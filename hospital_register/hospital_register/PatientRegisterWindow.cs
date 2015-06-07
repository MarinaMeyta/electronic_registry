using System;

namespace hospital_register
{
	public partial class PatientRegisterWindow : Gtk.Window
	{
		public PatientRegisterWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

