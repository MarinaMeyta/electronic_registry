using System;
using Gtk;

using PdfSharp;

using Mono.Data.Sqlite;
using MonoDevelop.Database.ConnectionManager;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Collections.Generic;
using System.Collections;

using hospital_register;

namespace hospital_register
{
	public partial class EnrollWindow2 : Gtk.Window
	{
		public string connection = "Data Source = hospital_register_2; Version = 3;";

		public EnrollWindow2 () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected bool CheckNumericStringFormat (string num_str) 
		{
			try {
				long temp = Convert.ToInt64 (num_str);	
				return true;
			} catch (Exception e) {
				return false;
			}
		}

		protected void OnCombobox2Changed (object sender, EventArgs e)
		{
			string speciality = combobox2.ActiveText;

			// очистить атрибуты (текст) комбобокса		
			ListStore ClearList = new ListStore (typeof (string));
			combobox1.Model = ClearList;

			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				string search_specialist = "SELECT employee_name FROM 'employee' WHERE speciality = '" + speciality + "';";

				using (SqliteCommand search_specialist_cmd = new SqliteCommand (search_specialist, dbConnection)) {

					SqliteDataReader reader = search_specialist_cmd.ExecuteReader ();

					while (reader.Read ()) {
						combobox1.AppendText (reader.GetString (0));
					}
				}
				dbConnection.Close ();
			}
		}


		// формирует новый talon_id
		protected string GetTalonId ()
		{
			string max_id = "SELECT MAX(talon_id) FROM 'talon';";
			string new_id = "";
			long id = 0;

			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				try {
					using (SqliteCommand max_id_cmd = new SqliteCommand (max_id, dbConnection)) {

						object reader = max_id_cmd.ExecuteScalar ();
						new_id = reader.ToString ();

						if (new_id == "") {
							new_id = "0";
						}

						id = Convert.ToInt64 (new_id) + 1;
						new_id = id.ToString ();

						while (new_id.Length < 10) {
							new_id = "0" + new_id;
						}
					}
				} catch (Exception e) {
					hospital_register.DatabaseErrorWindow err_win = new DatabaseErrorWindow ();
					err_win.Show ();
				}
				dbConnection.Close ();
			}
			return new_id;
		}

		// ТАЛООООООООН!!!!!!!!!
		protected void GetTalon (string doctor_name, string speciality, string week_day, string passport)
		{
			List<string> result = new List<string> ();

			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				try {

					using (SqliteTransaction tr = dbConnection.BeginTransaction ()) {

						using (SqliteCommand cmd = dbConnection.CreateCommand ()) {

							cmd.Transaction = tr;
							string talon_id = GetTalonId ();

							// найти имя пациента в БД
							cmd.CommandText = "SELECT name FROM patient WHERE passport_series = '" + passport + "';";
							cmd.ExecuteScalar ();

							// найти часы приема специалиста
							cmd.CommandText = "SELECT shift_begining, shift_ending FROM timetable " +
								"WHERE week_day = '" + week_day + "' AND employee_id = '" +
									"(SELECT employee_id FROM employee WHERE employee_name = '" + doctor_name + "');";
							SqliteDataReader reader = cmd.ExecuteReader ();

							while (reader.Read ()) {
								result.Add (reader.GetString (0));
								result.Add (reader.GetString (1));
							}

							// добавить новый талон в таблицу
							cmd.CommandText = "INSERT INTO talon ('talon_id', " +
								"'patient_id', 'timetable_id', 'date' ) " +
									"VALUES ( '" + talon_id + "', '(SELECT patient_id FROM patient WHERE passport_series = '" + passport + "')', '" + 
									"(SELECT timetable_id FROM timetable WHERE week_day = '" + week_day + "' AND employee_id = " +
									"'(SELECT employee_id FROM employee WHERE employee_name = '" + doctor_name + "')')" + "', " +
									"(select date('now', '+7 days')));";
							cmd.ExecuteNonQuery ();
						}

						tr.Commit ();
					}
				dbConnection.Close ();
				} catch (Exception e2) {
					hospital_register.DatabaseErrorWindow err_win = new DatabaseErrorWindow ();
					err_win.Show ();
				}
			}
		}

		protected void OnButtonEnrollClicked (object sender, EventArgs e)
		{
			string passport = entry1.Text + entry2.Text;
			string doctor_name = combobox1.ActiveText;
			string speciality = combobox2.ActiveText;
			string week_day = combobox3.ActiveText;

			if (passport != "" &&
			    doctor_name != "" &&
			    speciality != "" &&
			    CheckNumericStringFormat (passport) == true &&
			    passport.Length == 10 &&
			    combobox1.ActiveText != null &&
			    combobox2.ActiveText != null &&
			    combobox3.ActiveText != null) 
			{
				using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
					dbConnection.Open ();

					string search_patient = "SELECT patient_id FROM patient WHERE passport_series = '" + passport + "';";

					using (SqliteCommand search_patient_cmd = new SqliteCommand (search_patient, dbConnection)) {

						object reader = search_patient_cmd.ExecuteScalar ();

						if (reader != null) {
							GetTalon (doctor_name, speciality, week_day, passport);
						} else {
							hospital_register.PatientRegisterWindow reg_win = new PatientRegisterWindow ();
							reg_win.Show ();
						}

					}
					dbConnection.Close ();
				}
			} else {
				hospital_register.EnrollFailWindow err = new EnrollFailWindow ();
				err.Show ();
			}
		}

		protected void OnButtonSearchClicked (object sender, EventArgs e)
		{
			string employee_name = combobox1.ActiveText;
			string week_day = combobox3.ActiveText;

			string search_timetable = "SELECT week_day, shift_begining, shift_ending " +
				"FROM timetable WHERE employee_id = " +
					"(SELECT employee_id FROM employee " +
					"WHERE employee_name = '" + employee_name + "');";

			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				using (SqliteCommand search_timetable_cmd = new SqliteCommand (search_timetable, dbConnection)) {

					Gtk.TreeViewColumn day_column = new Gtk.TreeViewColumn ();
					day_column.Title = "День";

					Gtk.TreeViewColumn begining_column = new Gtk.TreeViewColumn ();
					begining_column.Title = "Начало приема";

					Gtk.TreeViewColumn ending_column = new Gtk.TreeViewColumn ();
					ending_column.Title = "Конец приема";

					treeview1.AppendColumn (day_column);
					treeview1.AppendColumn (begining_column);
					treeview1.AppendColumn (ending_column);

					Gtk.ListStore timetable_store = new Gtk.ListStore (typeof(string), typeof(string), typeof(string));
					treeview1.Model = timetable_store;

					SqliteDataReader reader = search_timetable_cmd.ExecuteReader ();

					while (reader.Read ()) {
						timetable_store.AppendValues (reader.GetString (0), reader.GetString (1), reader.GetString (2));
					}

					Gtk.CellRendererText cell_1 = new Gtk.CellRendererText ();
					day_column.PackStart (cell_1, true);

					Gtk.CellRendererText cell_2 = new Gtk.CellRendererText ();
					begining_column.PackStart (cell_2, true);

					Gtk.CellRendererText cell_3 = new Gtk.CellRendererText ();
					ending_column.PackStart (cell_3, true);

					day_column.AddAttribute (cell_1, "text", 0);
					begining_column.AddAttribute (cell_2, "text", 1);
					ending_column.AddAttribute (cell_3, "text", 2);

				}
				dbConnection.Close ();
			}
		}

		protected void OnButtonClearClicked (object sender, EventArgs e)
		{
			TreeViewColumn[] collumns = treeview1.Columns;
			for (int i = 0; i < collumns.Length; i++) {
				treeview1.RemoveColumn (collumns [i]);
			}
		}
	}
}

