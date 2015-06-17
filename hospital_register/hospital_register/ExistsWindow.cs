using System;

namespace hospital_register
{
	public partial class ExistsWindow : Gtk.Window
	{
		public ExistsWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

