using System;

namespace hospital_register
{
	public partial class RegisterSuccessWindow : Gtk.Window
	{
		public RegisterSuccessWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

