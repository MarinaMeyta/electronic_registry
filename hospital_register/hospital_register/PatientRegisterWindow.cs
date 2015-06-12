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


		protected bool CheckNumericStringFormat (string num_str) 
		{
			try {
				long temp = Convert.ToInt64 (num_str);	
				return true;
			} catch (Exception e) {
				return false;
			}
		}

		protected void Register () {


/*			string insert_patient_cmd = "INSERT INTO ";

			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();



				dbConnection.Close ();
			}
*/
		}

		protected bool CheckDayFormat (string day) 
		{
			try {
				int temp = Convert.ToInt32 (day);
				if (temp < 32) {
					return true;
				} else {
					return false;
				}
			} catch (Exception e) {
				return false;
			}
		}

		protected string GetMonth (string month)
		{
			List<string> months = new List<string> ();
			months.Add ("января");
			months.Add ("февраля");
			months.Add ("марта");
			months.Add ("апреля");
			months.Add ("мая");
			months.Add ("июня");
			months.Add ("июля");
			months.Add ("августа");
			months.Add ("сентября");
			months.Add ("октября");
			months.Add ("ноября");
			months.Add ("декабря");

			string month_number = "";

			for (int i = 0; i < months.Count; i++) {
				if (month == months [i]) {
					month_number = (i + 1).ToString ();
					if (month_number.Length == 1) {
						month_number = "0" + month_number;
					}
				}
			}
			return month_number;
		}

		protected void OnRegisterButtonClicked (object sender, EventArgs e)
		{
			string patient_name = entry1.Text.Trim ();
			string sex = combobox1.ActiveText;
			string passport = entry3.Text + entry4.Text;
			string subdivision_code = entry5.Text;
			string address = entry7.Text.Trim ();
			string policy = entry8.Text + entry9.Text;
			string insurance_company = entry10.Text.Trim ();

			// форматирование даты рождения
			string birth_day = entry6.Text.Trim ();
			if (birth_day.Length == 1) {
				birth_day = "0" + birth_day;
			}
			string birth_month = GetMonth (combobox11.ActiveText);
			string birth_year = entry11.Text.Trim ();

			// форматирование даты получения паспорта
			string issue_day = entry12.Text.Trim ();
			if (birth_day.Length == 1) {
				birth_day = "0" + birth_day;
			}
			string issue_month = GetMonth (combobox13.ActiveText);
			string issue_year = entry13.Text.Trim ();


			string birth_date = birth_day + birth_month + birth_year;
			string date_of_issue = issue_day + issue_month + issue_year;



			if (patient_name != "" &&
			    birth_date != "" &&
			    sex != null &&
			    passport != "" &&
			    subdivision_code != "" &&
			    date_of_issue != "" &&
			    address != "" &&
			    policy != "" &&
			    insurance_company != "" &&
			    CheckNumericStringFormat (passport) == true &&
			    CheckNumericStringFormat (policy) == true &&
			    CheckNumericStringFormat (date_of_issue) == true &&
			    CheckDayFormat (issue_day) == true &&
			    CheckDayFormat (birth_day) == true &&
			    subdivision_code.Length == 6 &&
			    passport.Length == 10 &&
			    policy.Length == 11 &&
			    Convert.ToInt32 (birth_year) > 1900 &&
			    Convert.ToInt32 (issue_year) > 1900
			    ) {

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

