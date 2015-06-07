using System;

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
		public EnrollWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void OnEnrollButtonClicked (object sender, EventArgs e)
		{
			string passport = entrySeries.Text + entryNumber.Text;
			string connection = "Data Source = hospital_register_2; Version = 3;";

			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				string search_patient = "SELECT patient_id FROM patient WHERE passport_series = '" + passport + "';";

				using (SqliteCommand search_patient_comm = new SqliteCommand (search_patient, dbConnection)) {

					object reader = search_patient_comm.ExecuteScalar ();

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
	}
}

