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
	}
}

