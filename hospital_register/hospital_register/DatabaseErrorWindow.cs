using System;

namespace hospital_register
{
	public partial class DatabaseErrorWindow : Gtk.Window
	{
		public DatabaseErrorWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

