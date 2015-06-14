using System;

namespace hospital_register
{
	public partial class ErrorWindow : Gtk.Window
	{
		public ErrorWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

