using System;

namespace hospital_register
{
	public partial class PasswordErrorWindow : Gtk.Window
	{
		public PasswordErrorWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

