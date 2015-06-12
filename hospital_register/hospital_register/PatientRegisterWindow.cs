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
	public partial class PatientRegisterWindow : Gtk.Window
	{
		public string connection = "Data Source = hospital_register_2; Version = 3;";

		public PatientRegisterWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}

		protected void Register () {
			string patient_name = entry1.Text;
			string birth_date = entry2.Text;
			string sex = combobox1.ActiveText;
			string passport = entry3.Text + entry4.Text;
			string subdivision_code = entry5.Text;
			string date_of_issue = entry6.Text;
			string address = entry7.Text;
			string policy = entry8.Text + entry9.Text;
			string insurance_company = entry10.Text;

/*			string insert_patient_cmd = "INSERT INTO ";

			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();



				dbConnection.Close ();
			}
*/
		}

		protected void OnRegisterButtonClicked (object sender, EventArgs e)
		{
			if (entry1.Text != "" &&
				entry2.Text != "" &&
				combobox1.ActiveText != null &&
				entry3.Text != "" &&
				entry4.Text != "" &&
				entry5.Text != "" &&
				entry6.Text != "" &&
				entry6.Text != "" &&
				entry7.Text != "" &&
				entry8.Text != "" &&
				entry9.Text != "" &&
				entry10.Text != "") {

				Register ();
				hospital_register.RegisterSuccessWindow success_win = new RegisterSuccessWindow ();
				success_win.Show ();
			} else {
				hospital_register.RegisterFailWindow fail_win = new RegisterFailWindow ();
				fail_win.Show ();
			}


		}
	}
}

