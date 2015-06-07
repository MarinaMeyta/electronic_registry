//login window

using System;
using Gtk;


using hospital_register;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnEnterButtonClicked (object sender, EventArgs e)
	{
		// adminLOL12345
		int admin_hash = 1548824313;

		string entered_password = entryPassword.Text;

		if (radiobutton2.Active == true && entered_password.GetHashCode () == admin_hash) {
			hospital_register.AdminWindow admin_win = new AdminWindow ();
			admin_win.Show ();
		} else if (radiobutton2.Active == true && entered_password.GetHashCode () != admin_hash) {
			hospital_register.PasswordErrorWindow err_win = new PasswordErrorWindow ();
			err_win.Show ();
		} else {
			hospital_register.EnrollWindow enroll_win = new EnrollWindow ();
			enroll_win.Show ();
		}

//		hospital_register.PatientRegisterWindow reg_win = new PatientRegisterWindow ();
//		reg_win.Show ();



	}
	
}
