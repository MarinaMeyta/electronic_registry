using System;

namespace hospital_register
{
	public partial class SuccessWindow : Gtk.Window
	{
		public SuccessWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

