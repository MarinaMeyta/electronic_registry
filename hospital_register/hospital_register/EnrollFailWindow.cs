using System;

namespace hospital_register
{
	public partial class EnrollFailWindow : Gtk.Window
	{
		public EnrollFailWindow () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

