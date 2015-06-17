using System;

namespace hospital_register
{
	public partial class TalonErrorWindow : Gtk.Window
	{
		public TalonErrorWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

