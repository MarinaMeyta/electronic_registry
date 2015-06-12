using System;
using Gtk;

using Mono.Data.Sqlite;
using MonoDevelop.Database.ConnectionManager;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Collections.Generic;
using System.Collections;

using hospital_register;

namespace hospital_register
{
	public partial class EnrollWindow : Gtk.Window
	{
		public string connection = "Data Source = hospital_register_2; Version = 3;";
		 
		public EnrollWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void GetTalon (string doctor_name, string speciality, string date, string time)
		{
			hospital_register.TalonWindow talon_win = new TalonWindow ();
			talon_win.Show ();


		}

		protected void OnEnrollButtonClicked (object sender, EventArgs e)
		{
			string passport = entrySeries.Text + entryNumber.Text;
			string doctor_name = combobox3.ActiveText;
			string speciality = combobox2.ActiveText;
			string date = combobox4.ActiveText;
			string time = combobox5.ActiveText;


			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				string search_patient = "SELECT patient_id FROM patient WHERE passport_series = '" + passport + "';";

				using (SqliteCommand search_patient_cmd = new SqliteCommand (search_patient, dbConnection)) {

					object reader = search_patient_cmd.ExecuteScalar ();

					if (reader != null) {
						if (passport != null &&
						    doctor_name != null &&
						    speciality != null
						    // date != null &&
						    // time ! = null
						    ) {

							GetTalon (doctor_name, speciality, date, time);

						} else {
							hospital_register.EnrollFailWindow err = new EnrollFailWindow ();
							err.Show ();
						}
				
					} else {
						hospital_register.PatientRegisterWindow reg_win = new PatientRegisterWindow ();
						reg_win.Show ();
					}

				}
				dbConnection.Close ();
			}



		}

		protected void OnCombobox2Changed (object sender, EventArgs e)
		{
			string speciality = combobox2.ActiveText;


			 // очистить атрибуты (текст) комбобокса

//			while (IEnumerator.MoveNext ()) {
//				//combobox3.AllChildren.GetEnumerator ();
//				combobox3.RemoveText (0);
				



				using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
					dbConnection.Open ();

					string search_specialist = "SELECT employee_name FROM 'employee' WHERE speciality = '" + speciality + "';";

					using (SqliteCommand search_specialist_cmd = new SqliteCommand (search_specialist, dbConnection)) {



						SqliteDataReader reader = search_specialist_cmd.ExecuteReader ();

						while (reader.Read ()) {
							combobox3.AppendText (reader.GetString (0));
						}


					}
					dbConnection.Close ();
				}
		}

		protected void OnButtonCheckTimetableClicked (object sender, EventArgs e)
		{
			hospital_register.TimetableWindow timetable_win = new TimetableWindow ();
			timetable_win.Show ();
		}

		protected void OnCombobox3Changed (object sender, EventArgs e)
		{
			string doctor_name = combobox3.ActiveText;

			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				string search_date = "select distinct reception_day from 'timetables'" +
					"where employee_id = (select employee_id from 'employee'" +
					"where employee_name = '"+ doctor_name +"');";

				using (SqliteCommand search_date_cmd = new SqliteCommand (search_date, dbConnection)) {
				
					SqliteDataReader reader = search_date_cmd.ExecuteReader ();

					while (reader.Read ()) {
						combobox4.AppendText (reader.GetString (0));
					}
				}
				dbConnection.Close ();
			}
		}

		protected void OnCombobox4Changed (object sender, EventArgs e)
		{
			combobox5.AppendText ("some time");
		}
	}
}

