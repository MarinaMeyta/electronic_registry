using System;
using Gtk;

using Mono.Data.Sqlite;
using MonoDevelop.Database.ConnectionManager;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Collections.Generic;
using System.Collections;

using hospital_register;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

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
			string max_id = "SELECT MAX(talon_id) FROM talon;";
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

		// проверить, есть ли уже такая запись в базе (талон)
		protected bool CheckTalon (string passport, string week_day, string doctor_name)
		{
			string talon_id = "SELECT talon_id from talon " +
				"WHERE patient_id = (SELECT patient_id FROM patient WHERE passport_series = '" + passport + "') " +
					"AND timetable_id = (SELECT timetable_id FROM timetable WHERE week_day = '" + week_day + "' " +
					"AND employee_id = (SELECT employee_id FROM employee WHERE employee_name = '" + doctor_name + "')) " +
					"AND date = (SELECT date('now', '+7 days'));";

			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				try {
					using (SqliteCommand talon_id_cmd = new SqliteCommand (talon_id, dbConnection)) {
						SqliteDataReader reader = talon_id_cmd.ExecuteReader ();
						if (reader.Read () == false) {
							return false;
						} else {
							return true;
						}
					} 
				}catch (Exception e) {
					hospital_register.DatabaseErrorWindow err_win = new DatabaseErrorWindow ();
					err_win.Show ();
					return false;
				}
				dbConnection.Close ();
			}
		}


		// THIS IS ТАЛООООООООН!!!!!!!!!
		protected List<string> GetTalon (string doctor_name, string week_day, string passport)
		{
			List<string> result = new List<string> ();

			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				try {

					using (SqliteTransaction tr = dbConnection.BeginTransaction ()) {

						using (SqliteCommand cmd = dbConnection.CreateCommand ()) {

							cmd.Transaction = tr;
							string talon_id = GetTalonId ();

							if (CheckTalon (passport, week_day, doctor_name) == false) {
								// найти имя пациента в БД
								cmd.CommandText = "SELECT name FROM patient WHERE passport_series = '" + passport + "';";
								result.Add (cmd.ExecuteScalar ().ToString ());

								// найти полис пациента
								cmd.CommandText = "SELECT policy_series FROM patient " +
									"WHERE passport_series = '" + passport + "';";
								result.Add (cmd.ExecuteScalar ().ToString ());

								// найти номер кабинета врача
								cmd.CommandText = "SELECT office_number FROM employee " +
									"WHERE employee_name = '" + doctor_name + "';";
								result.Add (cmd.ExecuteScalar ().ToString ());

								// найти начало смены специалиста
								cmd.CommandText = "SELECT shift_begining FROM timetable " +
									"WHERE week_day = '" + week_day + "' AND employee_id = " +
										"(SELECT employee_id FROM employee WHERE employee_name = '" + doctor_name + "');";
								result.Add (cmd.ExecuteScalar ().ToString ());

								// найти конец смены специалиста
								cmd.CommandText = "SELECT shift_ending FROM timetable " +
									"WHERE week_day = '" + week_day + "' AND employee_id = " +
										"(SELECT employee_id FROM employee WHERE employee_name = '" + doctor_name + "');";
								result.Add (cmd.ExecuteScalar ().ToString ());

								// добавить новый талон в таблицу
								cmd.CommandText = "INSERT INTO talon (talon_id, " +
									"patient_id, timetable_id, 'date') " +
										"VALUES ( '" + talon_id + "', (SELECT patient_id FROM patient " +
										"WHERE passport_series = '" + passport + "'), (SELECT timetable_id FROM timetable " +
										"WHERE week_day = '" + week_day + "' AND employee_id = (SELECT employee_id FROM employee " +
										"WHERE employee_name = '" + doctor_name + "')), (SELECT date('now', '+7 days')));";
								cmd.ExecuteNonQuery ();

								hospital_register.TalonSuccessWindow suc_talon_win = new TalonSuccessWindow ();
								suc_talon_win.Show ();
							} else {
								hospital_register.TalonErrorWindow talon_err_win = new TalonErrorWindow ();
								talon_err_win.Show ();
							}
						}

						tr.Commit ();
					}
					return result;
				} catch (Exception e2) {
					hospital_register.DatabaseErrorWindow err_win = new DatabaseErrorWindow ();
					err_win.Show ();
					return result;
				}
				dbConnection.Close ();
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

					try 
					{
						string search_patient = "SELECT patient_id FROM patient WHERE passport_series = '" + passport + "';";

						using (SqliteCommand search_patient_cmd = new SqliteCommand (search_patient, dbConnection)) {

							object reader = search_patient_cmd.ExecuteScalar ();

							if (reader != null) {
								List<string> result = GetTalon (doctor_name, week_day, passport);
								PrintTalon (doctor_name, speciality, result [2], week_day, result [3], result [4], result [0], result [1]);
							} else {
								hospital_register.PatientRegisterWindow reg_win = new PatientRegisterWindow ();
								reg_win.Show ();
							}

						}
					} catch (Exception e2) {
						hospital_register.DatabaseErrorWindow err_win = new DatabaseErrorWindow ();
						err_win.Show ();
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

		// печать талона в pdf
		protected void PrintTalon (string doctor_name, string speciality, string office_number,
		                           string week_day, string shift_begining, string shift_ending,
		                           string patient_name, string policy)
		{

			Document document = new Document();     
			try      
			{              
				BaseFont baseFont = BaseFont.CreateFont("TIMES.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
				iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
				using (FileStream stream = new FileStream("talon.pdf", FileMode.Create))
				{
					PdfWriter.GetInstance(document, stream);
					document.Open();     
					String phrase = "ТАЛОН"; 
					document.Add(new Paragraph(phrase, font));
					phrase = "частная клиника \"Медстар\"";
					document.Add(new Paragraph(phrase, font));
					phrase = "Ф.И.О. врача:    " + doctor_name;
					document.Add(new Paragraph(phrase, font));
					phrase = "Специальность:    " + speciality;
					document.Add(new Paragraph(phrase, font));
					phrase = "Кабинет:    " + office_number;
					document.Add(new Paragraph(phrase, font));
					phrase = "Рабочие часы:    " + week_day + "    " + shift_begining + " - " + shift_ending;
					document.Add(new Paragraph(phrase, font));
					phrase = "Ф.И.О. пациента:    " + patient_name;
					document.Add(new Paragraph(phrase, font));
					phrase = "Страховой медицинский полис:    " + policy;
					document.Add(new Paragraph(phrase, font));
					document.Close();
				}
			}     
			catch (DocumentException ex)    
			{
				hospital_register.ErrorWindow err = new ErrorWindow ();
				err.Show ();
			}       
			catch (IOException ex)  
			{
				hospital_register.ErrorWindow err = new ErrorWindow ();
				err.Show ();
			} 
		}



	}
}

