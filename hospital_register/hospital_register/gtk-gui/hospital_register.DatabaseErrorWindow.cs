
// This file has been generated by the GUI designer. Do not modify.
namespace hospital_register
{
	public partial class DatabaseErrorWindow
	{
		private global::Gtk.Fixed fixed1;
		private global::Gtk.Image image1;
		private global::Gtk.Label label1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget hospital_register.DatabaseErrorWindow
			this.Name = "hospital_register.DatabaseErrorWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("DatabaseErrorWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child hospital_register.DatabaseErrorWindow.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.image1 = new global::Gtk.Image ();
			this.image1.WidthRequest = 30;
			this.image1.HeightRequest = 30;
			this.image1.Name = "image1";
			this.image1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			this.fixed1.Add (this.image1);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.image1]));
			w1.X = 72;
			w1.Y = 58;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("ОШИБКА БАЗЫ ДАННЫХ");
			this.fixed1.Add (this.label1);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label1]));
			w2.X = 113;
			w2.Y = 65;
			this.Add (this.fixed1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 370;
			this.DefaultHeight = 150;
			this.Show ();
		}
	}
}