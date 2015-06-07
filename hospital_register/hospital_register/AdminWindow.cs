using System;

namespace hospital_register
{
	public partial class AdminWindow : Gtk.Window
	{
		public AdminWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

