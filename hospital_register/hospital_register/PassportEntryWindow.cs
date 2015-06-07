using System;

namespace hospital_register
{
	public partial class PassportEntryWindow : Gtk.Window
	{
		public PassportEntryWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

