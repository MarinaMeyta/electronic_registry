using System;

namespace hospital_register
{
	public partial class TalonWindow : Gtk.Window
	{
		public TalonWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

