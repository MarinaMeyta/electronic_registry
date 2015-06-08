using System;

namespace hospital_register
{
	public partial class TimetableWindow : Gtk.Window
	{
		public TimetableWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

