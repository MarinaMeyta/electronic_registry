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

/*		public class EmployeeNode : Gtk.TreeNode
		{
			public EmployeeNode (string employee_id, string employee_name, string speciality, string office_number)
			{
				Employee = employee_id;
				Name = employee_name;
				Speciality = speciality;
				Office = office_number;
			}

			[Gtk.TreeNodeValue (Column = 0)]
			public string Employee;

			[Gtk.TreeNodeValue (Column = 1)]
			public string Name;

			[Gtk.TreeNodeValue (Column = 2)]
			public string Speciality;

			[Gtk.TreeNodeValue (Column = 3)]
			public string Office;

		}

		Gtk.NodeStore store;
		Gtk.NodeStore Store { 
			get {
				if (store == null) {
					store = new Gtk.NodeStore (typeof (EmployeeNode));
					store.AddNode (new EmployeeNode ("01", "test name", "test speciality", "123"));
				}
				return store;
			}
		}
*/

		ListStore SetupModel( TreeView tv ){
			var m = new ListStore(typeof(string),typeof(string));

			var nameCol = new TreeViewColumn( "Name", 
			                                 new CellRendererText(), "text", 0 );
			tv.AppendColumn( nameCol );

			var colourCol = new TreeViewColumn( "Colour", 
			                                   new CellRendererText(), "text", 1 );
			tv.AppendColumn( colourCol );

			tv.Model = m;
			return m;
		}

		void PopulateData( ListStore model ) {
			model.AppendValues( "Fred", "Blue" );
			model.AppendValues( "Bob", "Green" );
			model.AppendValues( "Mary", "Yellow" );
			model.AppendValues( "Alice", "Red" );
		}


		protected void OnButton1Clicked (object sender, EventArgs e)
		{
			string select_doctors = "SELECT * FROM 'employee'";



			using (SqliteConnection dbConnection = new SqliteConnection (connection)) {
				dbConnection.Open ();

				using (SqliteCommand select_doctors_cmd = new SqliteCommand (select_doctors, dbConnection)) {



//					object reader = select_doctors_cmd.ExecuteScalar ();

/*					if (reader != null) {
						return true;
					} else {
						return false;
					}
*/	
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


		protected void OnButton3Clicked (object sender, EventArgs e)
		{
			string employee_name = entry1.Text;
			string speciality = entry2.Text;
			string office_number = entry3.Text;
			string employee_id = GetEmployeeId ();

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
			}
		}

		protected void OnButton2Clicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}
	}
}

