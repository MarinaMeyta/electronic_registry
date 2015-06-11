using System;
using Gtk;

using Mono.Data.Sqlite;
using MonoDevelop.Database.ConnectionManager;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Collections.Generic;

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

		protected void OnEnrollButtonClicked (object sender, EventArgs e)
		{
			string passport = entrySeries.Text + entryNumber.Text;

			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				string search_patient = "SELECT patient_id FROM patient WHERE passport_series = '" + passport + "';";

				using (SqliteCommand search_patient_cmd = new SqliteCommand (search_patient, dbConnection)) {

					object reader = search_patient_cmd.ExecuteScalar ();

					if (reader != null) {
						hospital_register.TalonWindow talon_win = new TalonWindow ();
						talon_win.Show ();
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
	}
}

