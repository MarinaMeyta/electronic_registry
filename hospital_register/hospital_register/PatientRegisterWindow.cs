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
	public partial class PatientRegisterWindow : Gtk.Window
	{
		// connection string - строка соединения с БД
		public string connection = "Data Source = hospital_register_2; Version = 3;";

		public PatientRegisterWindow () : 
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

		// проверить наличие паспорта в БД
		protected bool CheckPassportInDatabase (string passport) 
		{
			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				string search_passport = "SELECT patient_id FROM patient WHERE passport_series = '" + passport + "';";

				using (SqliteCommand search_passport_cmd = new SqliteCommand (search_passport, dbConnection)) {

					object reader = search_passport_cmd.ExecuteScalar ();

					if (reader != null) {
						return true;
					} else {
						return false;
					}
				}
				dbConnection.Close ();
			}
		}

		// проверить наличие полиса в БД
		protected bool CheckPolicyInDatabase (string policy) 
		{
			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				string search_policy = "SELECT patient_id FROM 'policy' " +
					"where policy_series = '" + policy + "';";

				using (SqliteCommand search_policy_cmd = new SqliteCommand (search_policy, dbConnection)) {

					object reader = search_policy_cmd.ExecuteScalar ();

					if (reader != null) {
						return true;
					} else {
						return false;
					}
				}
				dbConnection.Close ();
			}
		}

		// формирует новый patient_id
		protected string GetPatientId ()
		{
			string max_id = "SELECT MAX(patient_id) FROM 'patient';";
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

		// зарегистрировать пациента
		protected void Register (string passport, string policy, string patient_name, string sex, 
		                         string birth_date, string subdivision_code, string date_of_issue,
		                         string address, string insurance_company) {

			if (CheckPassportInDatabase (passport) == true || CheckPolicyInDatabase (policy) == true) {
				hospital_register.RegisterFailWindow fail_win = new RegisterFailWindow ();
				fail_win.Show ();
			} else {

				using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
					dbConnection.Open ();

					try {

						using (SqliteTransaction tr = dbConnection.BeginTransaction ()) {

							using (SqliteCommand cmd = dbConnection.CreateCommand ()) {

								cmd.Transaction = tr;
								string patient_id = GetPatientId ();

								// добавить пациента в таблицу 'patient'
								cmd.CommandText = "INSERT INTO 'patient' (patient_id, " +
									"name, passport_series, policy_series) " +
									"VALUES ('" + patient_id + "', '" + patient_name + "','" + passport + "', '" + policy + "');";
								cmd.ExecuteNonQuery ();

								// добавить его паспорт в таблицу 'pasport' 
								cmd.CommandText = "INSERT INTO 'passport' (passport_series, " +
									"patient_id, birth_date, sex, address, subdivision_code, date_of_issue) " +
										"VALUES ('" + passport + "', '" + patient_id + "', '" + birth_date + "', '" + sex + "', '" + 
										address + "', " + "'" + subdivision_code + "','" + date_of_issue + "');";
								cmd.ExecuteNonQuery ();

								// добавить полис в таблицу 'policy'
								cmd.CommandText = "INSERT INTO 'policy' (policy_series, " +
									"patient_id, insurance_agency) VALUES ('" + policy + "', " +
										"'" + patient_id + "', '" + insurance_company + "');";
								cmd.ExecuteNonQuery ();
							}

							tr.Commit ();
						}

						hospital_register.RegisterSuccessWindow success_win = new RegisterSuccessWindow ();
						success_win.Show ();

					} catch (Exception e) {
						hospital_register.RegisterFailWindow fail_win = new RegisterFailWindow ();
						fail_win.Show ();
					}

					dbConnection.Close ();
				}
			} 
		}

		// проверить формат дня
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

		// возвращает номер месяца
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
			string sex = combobox1.ActiveText.ToLower ();
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


			string birth_date = birth_year + "-" + birth_month + "-" + birth_day;
			string date_of_issue = issue_year + "-" + issue_month + "-" + issue_day;


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
			    CheckNumericStringFormat (issue_year + issue_month + issue_day) == true &&
			    CheckNumericStringFormat (birth_year + birth_month + birth_day) == true &&
			    CheckDayFormat (issue_day) == true &&
			    CheckDayFormat (birth_day) == true &&
			    subdivision_code.Length == 6 &&
			    passport.Length == 10 &&
			    policy.Length == 11 &&
			    Convert.ToInt32 (birth_year) > 1900 &&
			    Convert.ToInt32 (issue_year) > 1900 &&
			    Convert.ToInt32 (birth_year) < 2020 &&
			    Convert.ToInt32 (issue_year) < 2020
			    ) {

				Register (passport, policy, patient_name, sex, birth_date, subdivision_code, date_of_issue,
				          address, insurance_company);

			} else {
				hospital_register.RegisterFailWindow fail_win = new RegisterFailWindow ();
				fail_win.Show ();
			}


		}
	}
}

