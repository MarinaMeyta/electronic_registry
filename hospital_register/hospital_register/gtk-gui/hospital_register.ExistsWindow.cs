
// This file has been generated by the GUI designer. Do not modify.
namespace hospital_register
{
	public partial class ExistsWindow
	{
		private global::Gtk.Fixed fixed1;
		private global::Gtk.Image image1;
		private global::Gtk.Label label3;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget hospital_register.ExistsWindow
			this.Name = "hospital_register.ExistsWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("ExistsWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child hospital_register.ExistsWindow.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.image1 = new global::Gtk.Image ();
			this.image1.WidthRequest = 30;
			this.image1.HeightRequest = 30;
			this.image1.Name = "image1";
			this.image1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-dialog-warning", global::Gtk.IconSize.Menu);
			this.fixed1.Add (this.image1);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.image1]));
			w1.X = 74;
			w1.Y = 79;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("УЖЕ ДОБАВЛЕНО!");
			this.fixed1.Add (this.label3);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label3]));
			w2.X = 115;
			w2.Y = 86;
			this.Add (this.fixed1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 353;
			this.DefaultHeight = 188;
			this.Show ();
		}
	}
}
