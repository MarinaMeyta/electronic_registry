
// This file has been generated by the GUI designer. Do not modify.
public partial class MainWindow
{
	private global::Gtk.Fixed fixed7;
	private global::Gtk.Image image5;
	private global::Gtk.Button button2;
	private global::Gtk.Label label20;
	private global::Gtk.Entry entryPassword;
	private global::Gtk.Label label19;
	private global::Gtk.Image image4;
	private global::Gtk.RadioButton radiobutton1;
	private global::Gtk.RadioButton radiobutton2;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed7 = new global::Gtk.Fixed ();
		this.fixed7.Name = "fixed7";
		this.fixed7.HasWindow = false;
		// Container child fixed7.Gtk.Fixed+FixedChild
		this.image5 = new global::Gtk.Image ();
		this.image5.Name = "image5";
		this.image5.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./getClientLogo.png"));
		this.fixed7.Add (this.image5);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed7 [this.image5]));
		w1.X = 261;
		w1.Y = 3;
		// Container child fixed7.Gtk.Fixed+FixedChild
		this.button2 = new global::Gtk.Button ();
		this.button2.WidthRequest = 141;
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString ("Войти");
		this.fixed7.Add (this.button2);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed7 [this.button2]));
		w2.X = 147;
		w2.Y = 223;
		// Container child fixed7.Gtk.Fixed+FixedChild
		this.label20 = new global::Gtk.Label ();
		this.label20.Name = "label20";
		this.label20.Xalign = 1F;
		this.label20.LabelProp = global::Mono.Unix.Catalog.GetString ("Пароль  \nадминистратора:");
		this.fixed7.Add (this.label20);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed7 [this.label20]));
		w3.X = 39;
		w3.Y = 166;
		// Container child fixed7.Gtk.Fixed+FixedChild
		this.entryPassword = new global::Gtk.Entry ();
		this.entryPassword.Sensitive = false;
		this.entryPassword.CanFocus = true;
		this.entryPassword.Name = "entryPassword";
		this.entryPassword.IsEditable = true;
		this.entryPassword.Visibility = false;
		this.entryPassword.InvisibleChar = '•';
		this.fixed7.Add (this.entryPassword);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed7 [this.entryPassword]));
		w4.X = 173;
		w4.Y = 179;
		// Container child fixed7.Gtk.Fixed+FixedChild
		this.label19 = new global::Gtk.Label ();
		this.label19.Name = "label19";
		this.label19.LabelProp = global::Mono.Unix.Catalog.GetString ("ВХОД");
		this.fixed7.Add (this.label19);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed7 [this.label19]));
		w5.X = 198;
		w5.Y = 22;
		// Container child fixed7.Gtk.Fixed+FixedChild
		this.image4 = new global::Gtk.Image ();
		this.image4.Name = "image4";
		this.image4.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-dialog-authentication", global::Gtk.IconSize.Menu);
		this.fixed7.Add (this.image4);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed7 [this.image4]));
		w6.X = 169;
		w6.Y = 22;
		// Container child fixed7.Gtk.Fixed+FixedChild
		this.radiobutton1 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Я пациент"));
		this.radiobutton1.CanFocus = true;
		this.radiobutton1.Name = "radiobutton1";
		this.radiobutton1.DrawIndicator = true;
		this.radiobutton1.UseUnderline = true;
		this.radiobutton1.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.fixed7.Add (this.radiobutton1);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed7 [this.radiobutton1]));
		w7.X = 37;
		w7.Y = 66;
		// Container child fixed7.Gtk.Fixed+FixedChild
		this.radiobutton2 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Я админ"));
		this.radiobutton2.CanFocus = true;
		this.radiobutton2.Name = "radiobutton2";
		this.radiobutton2.DrawIndicator = true;
		this.radiobutton2.UseUnderline = true;
		this.radiobutton2.Group = this.radiobutton1.Group;
		this.fixed7.Add (this.radiobutton2);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed7 [this.radiobutton2]));
		w8.X = 37;
		w8.Y = 114;
		this.Add (this.fixed7);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 443;
		this.DefaultHeight = 284;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button2.Clicked += new global::System.EventHandler (this.OnEnterButtonClicked);
		this.radiobutton1.Toggled += new global::System.EventHandler (this.OnRadiobutton1Toggled);
		this.radiobutton2.Toggled += new global::System.EventHandler (this.OnRadiobutton2Toggled);
	}
}
