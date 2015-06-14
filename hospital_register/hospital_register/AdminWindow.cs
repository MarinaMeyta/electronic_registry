using System;
using Gtk;

using Mono.Data.Sqlite;
using MonoDevelop.Database.ConnectionManager;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Collections.Generic;
using System.Collections;
using hospital_register;
using System.Data.SqlClient;

namespace hospital_register
{
	public partial class AdminWindow : Gtk.Window
	{
		// connection string - строка соединения с БД
		public string connection = "Data Source = hospital_register_2; Version = 3;";

		public AdminWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		// проверить входной формат строки - является ли числовым
		protected bool CheckNumericStringFormat (string num_str) 
		{
			try {
				long temp = Convert.ToInt64 (num_str);	
				return true;
			} catch (Exception e) {
				return false;
			}
		}

		// формирует новый employee_id
		protected string GetEmployeeId ()
		{
			string max_id = "SELECT MAX(employee_id) FROM 'employee';";
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

		// формирует новый timetable_id
		protected string GetTimetableId ()
		{
			string max_id = "SELECT MAX(timetable_id) FROM 'timetable';";
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


		// найти сотрудников
		protected void SelectEmployees ()
		{
			string select_doctors = "SELECT * FROM 'employee'";

			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				using (SqliteCommand select_doctors_cmd = new SqliteCommand (select_doctors, dbConnection)) {

					Gtk.TreeViewColumn employee_id_column = new Gtk.TreeViewColumn ();
					employee_id_column.Title = "employee id";

					Gtk.TreeViewColumn employee_name_column = new Gtk.TreeViewColumn ();
					employee_name_column.Title = "employee name";

					Gtk.TreeViewColumn speciality_column = new Gtk.TreeViewColumn ();
					speciality_column.Title = "speciality";

					Gtk.TreeViewColumn office_number_column = new Gtk.TreeViewColumn ();
					office_number_column.Title = "office number";

					treeview1.AppendColumn (employee_id_column);
					treeview1.AppendColumn (employee_name_column);
					treeview1.AppendColumn (speciality_column);
					treeview1.AppendColumn (office_number_column);

					Gtk.ListStore employee_store = new Gtk.ListStore (typeof(string), typeof(string), typeof(string), typeof(string));
					treeview1.Model = employee_store;

					SqliteDataReader reader = select_doctors_cmd.ExecuteReader ();

					while (reader.Read ()) {
						employee_store.AppendValues (reader.GetString (0), reader.GetString (1), reader.GetString (2), reader.GetString (3));
					}

					Gtk.CellRendererText cell_1 = new Gtk.CellRendererText ();
					employee_id_column.PackStart (cell_1, true);

					Gtk.CellRendererText cell_2 = new Gtk.CellRendererText ();
					employee_name_column.PackStart (cell_2, true);

					Gtk.CellRendererText cell_3 = new Gtk.CellRendererText ();
					speciality_column.PackStart (cell_3, true);

					Gtk.CellRendererText cell_4 = new Gtk.CellRendererText ();
					office_number_column.PackStart (cell_4, true);

					employee_id_column.AddAttribute (cell_1, "text", 0);
					employee_name_column.AddAttribute (cell_2, "text", 1);
					speciality_column.AddAttribute (cell_3, "text", 2);
					office_number_column.AddAttribute (cell_4, "text", 3);
				}
				dbConnection.Close ();
			}
		}

		// найти расписание врачей
		protected void SelectTimetables ()
		{
			string select_timetables = "select timetable_id, week_day, shift_begining, shift_ending, employee_name " +
				"from timetable, employee " +
					"where timetable.employee_id = employee.employee_id;";

			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				using (SqliteCommand select_doctors_cmd = new SqliteCommand (select_timetables, dbConnection)) {

					Gtk.TreeViewColumn timetable_id_column = new Gtk.TreeViewColumn ();
					timetable_id_column.Title = "timetable id";

					Gtk.TreeViewColumn week_day_column = new Gtk.TreeViewColumn ();
					week_day_column.Title = "week day";

					Gtk.TreeViewColumn shift_begining_column = new Gtk.TreeViewColumn ();
					shift_begining_column.Title = "shift begining";

					Gtk.TreeViewColumn shift_ending_column = new Gtk.TreeViewColumn ();
					shift_ending_column.Title = "shift ending";

					Gtk.TreeViewColumn employee_name_column = new Gtk.TreeViewColumn ();
					employee_name_column.Title = "employee name";

					treeview1.AppendColumn (timetable_id_column);
					treeview1.AppendColumn (week_day_column);
					treeview1.AppendColumn (shift_begining_column);
					treeview1.AppendColumn (shift_ending_column);
					treeview1.AppendColumn (employee_name_column);

					Gtk.ListStore timetable_store = new Gtk.ListStore (typeof(string), typeof(string), typeof(string), typeof(string), typeof(string));
					treeview1.Model = timetable_store;

					SqliteDataReader reader = select_doctors_cmd.ExecuteReader ();

					while (reader.Read ()) {
						timetable_store.AppendValues (reader.GetString (0), reader.GetString (1), reader.GetString (2), reader.GetString (3), reader.GetString (4));
					}

					Gtk.CellRendererText cell_1 = new Gtk.CellRendererText ();
					timetable_id_column.PackStart (cell_1, true);

					Gtk.CellRendererText cell_2 = new Gtk.CellRendererText ();
					week_day_column.PackStart (cell_2, true);

					Gtk.CellRendererText cell_3 = new Gtk.CellRendererText ();
					shift_begining_column.PackStart (cell_3, true);

					Gtk.CellRendererText cell_4 = new Gtk.CellRendererText ();
					shift_ending_column.PackStart (cell_4, true);

					Gtk.CellRendererText cell_5 = new Gtk.CellRendererText ();
					employee_name_column.PackStart (cell_5, true);

					timetable_id_column.AddAttribute (cell_1, "text", 0);
					week_day_column.AddAttribute (cell_2, "text", 1);
					shift_begining_column.AddAttribute (cell_3, "text", 2);
					shift_ending_column.AddAttribute (cell_4, "text", 3);
					employee_name_column.AddAttribute (cell_5, "text", 4);
				}
				dbConnection.Close ();
			}
		}

		// найти пациентов
		protected void SelectPatients ()
		{
			string select_patients = "SELECT patient_id, name, passport_series, policy_series " +
				"FROM patient;";

			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				using (SqliteCommand select_patients_cmd = new SqliteCommand (select_patients, dbConnection)) {

					Gtk.TreeViewColumn patient_id_column = new Gtk.TreeViewColumn ();
					patient_id_column.Title = "patient id";

					Gtk.TreeViewColumn name_column = new Gtk.TreeViewColumn ();
					name_column.Title = "name";

					Gtk.TreeViewColumn passport_series_column = new Gtk.TreeViewColumn ();
					passport_series_column.Title = "passport series";

					Gtk.TreeViewColumn policy_series_column = new Gtk.TreeViewColumn ();
					policy_series_column.Title = "policy series";

					treeview1.AppendColumn (patient_id_column);
					treeview1.AppendColumn (name_column);
					treeview1.AppendColumn (passport_series_column);
					treeview1.AppendColumn (policy_series_column);

					Gtk.ListStore patient_store = new Gtk.ListStore (typeof(string), typeof(string), typeof(string), typeof(string));
					treeview1.Model = patient_store;

					SqliteDataReader reader = select_patients_cmd.ExecuteReader ();

					while (reader.Read ()) {
						patient_store.AppendValues (reader.GetString (0), reader.GetString (1), reader.GetString (2), reader.GetString (3));
					}

					Gtk.CellRendererText cell_1 = new Gtk.CellRendererText ();
					patient_id_column.PackStart (cell_1, true);

					Gtk.CellRendererText cell_2 = new Gtk.CellRendererText ();
					name_column.PackStart (cell_2, true);

					Gtk.CellRendererText cell_3 = new Gtk.CellRendererText ();
					passport_series_column.PackStart (cell_3, true);

					Gtk.CellRendererText cell_4 = new Gtk.CellRendererText ();
					policy_series_column.PackStart (cell_4, true);

					patient_id_column.AddAttribute (cell_1, "text", 0);
					name_column.AddAttribute (cell_2, "text", 1);
					passport_series_column.AddAttribute (cell_3, "text", 2);
					policy_series_column.AddAttribute (cell_4, "text", 3);
				}
				dbConnection.Close ();
			}
		}


		protected void OnButtonSelectClicked (object sender, EventArgs e)
		{
			try 
			{
				if (radiobutton1.Active == true) {
					SelectEmployees ();
				}

				if (radiobutton2.Active == true) {
					SelectPatients ();
				}

				if (radiobutton3.Active == true) {
					SelectTimetables ();
				}
			}catch (Exception e3) {
				hospital_register.DatabaseErrorWindow err_win = new DatabaseErrorWindow ();
				err_win.Show ();
			}
		}


		protected void OnButtonClearClicked (object sender, EventArgs e)
		{
			TreeViewColumn[] collumns = treeview1.Columns;
			for (int i = 0; i < collumns.Length; i++) {
				treeview1.RemoveColumn (collumns [i]);
			}
		}

		protected void OnButtonInsertEmployeeClicked (object sender, EventArgs e)
		{
			string employee_name = entry1.Text;
			string speciality = entry2.Text;
			string office_number = entry3.Text;
			string employee_id = GetEmployeeId ();

			if (CheckNumericStringFormat (office_number) == true && 
			    office_number.Length == 3 &&
			    employee_name != "" &&
			    speciality != "") {

				string insert_employee = "INSERT INTO 'employee' (" +
					"employee_id, employee_name, speciality, office_number) " +
					"VALUES ('" + employee_id + "', '" + employee_name + "', '" + speciality + 
					"', '" + office_number + "');";

				using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
					dbConnection.Open ();

					try {

						using (SqliteCommand insert_employee_cmd = new SqliteCommand (insert_employee, dbConnection)) {
							insert_employee_cmd.ExecuteNonQuery ();
						}

					} catch (Exception e2) {
						hospital_register.DatabaseErrorWindow err_win = new DatabaseErrorWindow ();
						err_win.Show ();
					}

					dbConnection.Close ();
					hospital_register.SuccessWindow suc_win = new SuccessWindow ();
					suc_win.Show ();
				}
			} else {
				hospital_register.ErrorWindow err_win = new ErrorWindow ();
				err_win.Show ();
			}
		}

		protected void OnButtonInsertTimetableClicked (object sender, EventArgs e)
		{
			string week_day = combobox1.ActiveText;
			string begining = entry4.Text;
			string ending = entry5.Text;
			string employee_id = entry9.Text;

			if (week_day != "" &&
			    begining != "" &&
			    ending != "" &&
			    begining.Length == 5 &&
			    ending.Length == 5
			    ) {

				string timetable_id = GetTimetableId ();
				string insert_timetable = "INSERT INTO timetable " +
					"(timetable_id, employee_id, week_day, shift_begining, shift_ending)" +
						"VALUES ('" + timetable_id + "', '" +employee_id + "', '" + week_day + "', '" + begining + "', '" + ending + "') ";

				using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
					dbConnection.Open ();

					try {

						using (SqliteCommand insert_timetable_cmd = new SqliteCommand (insert_timetable, dbConnection)) {
							insert_timetable_cmd.ExecuteNonQuery ();
						}

					} catch (Exception e2) {
						hospital_register.DatabaseErrorWindow err_win = new DatabaseErrorWindow ();
						err_win.Show ();
					}

					dbConnection.Close ();
					hospital_register.SuccessWindow suc_win = new SuccessWindow ();
					suc_win.Show ();
				}
			} else {
				hospital_register.ErrorWindow err_win = new ErrorWindow ();
				err_win.Show ();
			}
		}

		protected void OnButtonDeleteEmployeeClicked (object sender, EventArgs e)
		{
			string employee_id = entry6.Text;
			string delete_employee = "DELETE FROM employee WHERE employee_id = '" + employee_id + "';";

			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				try {

					using (SqliteCommand delete_employee_cmd = new SqliteCommand (delete_employee, dbConnection)) {
						delete_employee_cmd.ExecuteNonQuery ();
					}

				} catch (Exception e2) {
					hospital_register.DatabaseErrorWindow err_win = new DatabaseErrorWindow ();
					err_win.Show ();
				}

				dbConnection.Close ();
				hospital_register.SuccessWindow suc_win = new SuccessWindow ();
				suc_win.Show ();
			}
		}

		protected void OnButtonDeletePatientClicked (object sender, EventArgs e)
		{
			string patient_id = entry7.Text;
			string delete_patient = "DELETE FROM patient WHERE patient_id = '" + patient_id + "';";

			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				try {

					using (SqliteCommand delete_patient_cmd = new SqliteCommand (delete_patient, dbConnection)) {
						delete_patient_cmd.ExecuteNonQuery ();
					}

				} catch (Exception e2) {
					hospital_register.DatabaseErrorWindow err_win = new DatabaseErrorWindow ();
					err_win.Show ();
				}

				dbConnection.Close ();
				hospital_register.SuccessWindow suc_win = new SuccessWindow ();
				suc_win.Show ();
			}
		}

		protected void OnButtonDeleteTimetableClicked (object sender, EventArgs e)
		{
			string timetable_id = entry8.Text;
			string delete_timetable = "DELETE FROM timetable WHERE timetable_id = '" + timetable_id + "';";

			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				try {

					using (SqliteCommand delete_timetable_cmd = new SqliteCommand (delete_timetable, dbConnection)) {
						delete_timetable_cmd.ExecuteNonQuery ();
					}

				} catch (Exception e2) {
					hospital_register.DatabaseErrorWindow err_win = new DatabaseErrorWindow ();
					err_win.Show ();
				}

				dbConnection.Close ();
				hospital_register.SuccessWindow suc_win = new SuccessWindow ();
				suc_win.Show ();
			}
		}
	}
}

