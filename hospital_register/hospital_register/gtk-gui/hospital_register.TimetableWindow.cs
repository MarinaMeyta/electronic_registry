
// This file has been generated by the GUI designer. Do not modify.
namespace hospital_register
{
	public partial class TimetableWindow
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.Fixed fixed2;
		private global::Gtk.HBox hbox7;
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label label13;
		private global::Gtk.ComboBox combobox1;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label label14;
		private global::Gtk.ComboBox combobox2;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Notebook notebook3;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.NodeView nodeview1;
		private global::Gtk.Label label11;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.NodeView nodeview2;
		private global::Gtk.Label label12;
		private global::Gtk.VBox vbox3;
		private global::Gtk.VBox vbox5;
		private global::Gtk.Label label17;
		private global::Gtk.VBox vbox6;
		private global::Gtk.RadioButton radiobutton4;
		private global::Gtk.RadioButton radiobutton5;
		private global::Gtk.Button button2;
		private global::Gtk.VBox vbox4;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Calendar calendar5;
		private global::Gtk.Notebook notebook1;
		private global::Gtk.TextView textview8;
		private global::Gtk.Label label1;
		private global::Gtk.TextView textview2;
		private global::Gtk.Label label3;
		private global::Gtk.TextView textview3;
		private global::Gtk.Label label4;
		private global::Gtk.TextView textview4;
		private global::Gtk.Label label5;
		private global::Gtk.TextView textview5;
		private global::Gtk.Label label6;
		private global::Gtk.TextView textview6;
		private global::Gtk.Label label7;
		private global::Gtk.TextView textview7;
		private global::Gtk.Label label8;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget hospital_register.TimetableWindow
			this.Name = "hospital_register.TimetableWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("TimetableWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child hospital_register.TimetableWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.fixed2 = new global::Gtk.Fixed ();
			this.fixed2.HeightRequest = 102;
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			this.vbox1.Add (this.fixed2);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.fixed2]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.WidthRequest = 487;
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label13 = new global::Gtk.Label ();
			this.label13.WidthRequest = 180;
			this.label13.Name = "label13";
			this.label13.Xalign = 1F;
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Ф.И.О. врача:  ");
			this.hbox1.Add (this.label13);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label13]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.combobox1 = global::Gtk.ComboBox.NewText ();
			this.combobox1.WidthRequest = 191;
			this.combobox1.Name = "combobox1";
			this.hbox1.Add (this.combobox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.combobox1]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label14 = new global::Gtk.Label ();
			this.label14.WidthRequest = 180;
			this.label14.Name = "label14";
			this.label14.Xalign = 1F;
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("Специальность:  ");
			this.hbox2.Add (this.label14);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label14]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.combobox2 = global::Gtk.ComboBox.NewText ();
			this.combobox2.WidthRequest = 191;
			this.combobox2.Name = "combobox2";
			this.hbox2.Add (this.combobox2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.combobox2]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.notebook3 = new global::Gtk.Notebook ();
			this.notebook3.CanFocus = true;
			this.notebook3.Name = "notebook3";
			this.notebook3.CurrentPage = 0;
			// Container child notebook3.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.nodeview1 = new global::Gtk.NodeView ();
			this.nodeview1.CanFocus = true;
			this.nodeview1.Name = "nodeview1";
			this.GtkScrolledWindow.Add (this.nodeview1);
			this.notebook3.Add (this.GtkScrolledWindow);
			// Notebook tab
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Текущая неделя");
			this.notebook3.SetTabLabel (this.GtkScrolledWindow, this.label11);
			this.label11.ShowAll ();
			// Container child notebook3.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.nodeview2 = new global::Gtk.NodeView ();
			this.nodeview2.CanFocus = true;
			this.nodeview2.Name = "nodeview2";
			this.GtkScrolledWindow1.Add (this.nodeview2);
			this.notebook3.Add (this.GtkScrolledWindow1);
			global::Gtk.Notebook.NotebookChild w11 = ((global::Gtk.Notebook.NotebookChild)(this.notebook3 [this.GtkScrolledWindow1]));
			w11.Position = 1;
			// Notebook tab
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Следующая неделя");
			this.notebook3.SetTabLabel (this.GtkScrolledWindow1, this.label12);
			this.label12.ShowAll ();
			this.hbox3.Add (this.notebook3);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.notebook3]));
			w12.Position = 0;
			this.vbox2.Add (this.hbox3);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
			w13.Position = 2;
			this.hbox7.Add (this.vbox2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.vbox2]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label17 = new global::Gtk.Label ();
			this.label17.Name = "label17";
			this.label17.Xalign = 0F;
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString ("Искать:");
			this.vbox5.Add (this.label17);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label17]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.radiobutton4 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Только свободные записи"));
			this.radiobutton4.CanFocus = true;
			this.radiobutton4.Name = "radiobutton4";
			this.radiobutton4.Active = false;
			this.radiobutton4.DrawIndicator = true;
			this.radiobutton4.UseUnderline = true;
			this.radiobutton4.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.vbox6.Add (this.radiobutton4);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.radiobutton4]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.radiobutton5 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Все"));
			this.radiobutton5.CanFocus = true;
			this.radiobutton5.Name = "radiobutton5";
			this.radiobutton5.Active = false;
			this.radiobutton5.DrawIndicator = true;
			this.radiobutton5.UseUnderline = true;
			this.radiobutton5.Group = this.radiobutton4.Group;
			this.vbox6.Add (this.radiobutton5);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.radiobutton5]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.vbox5.Add (this.vbox6);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.vbox6]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.button2 = new global::Gtk.Button ();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString ("Найти");
			this.vbox5.Add (this.button2);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.button2]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			this.vbox3.Add (this.vbox5);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox5]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.calendar5 = new global::Gtk.Calendar ();
			this.calendar5.CanFocus = true;
			this.calendar5.Name = "calendar5";
			this.calendar5.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
			this.hbox5.Add (this.calendar5);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.calendar5]));
			w21.Position = 0;
			this.vbox4.Add (this.hbox5);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox5]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			this.vbox3.Add (this.vbox4);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox4]));
			w23.Position = 1;
			w23.Expand = false;
			w23.Fill = false;
			this.hbox7.Add (this.vbox3);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.vbox3]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			this.vbox1.Add (this.hbox7);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox7]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.textview8 = new global::Gtk.TextView ();
			this.textview8.CanFocus = true;
			this.textview8.Name = "textview8";
			this.notebook1.Add (this.textview8);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Пн");
			this.notebook1.SetTabLabel (this.textview8, this.label1);
			this.label1.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.textview2 = new global::Gtk.TextView ();
			this.textview2.CanFocus = true;
			this.textview2.Name = "textview2";
			this.notebook1.Add (this.textview2);
			global::Gtk.Notebook.NotebookChild w27 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.textview2]));
			w27.Position = 1;
			// Notebook tab
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Вт");
			this.notebook1.SetTabLabel (this.textview2, this.label3);
			this.label3.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.textview3 = new global::Gtk.TextView ();
			this.textview3.CanFocus = true;
			this.textview3.Name = "textview3";
			this.notebook1.Add (this.textview3);
			global::Gtk.Notebook.NotebookChild w28 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.textview3]));
			w28.Position = 2;
			// Notebook tab
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Ср");
			this.notebook1.SetTabLabel (this.textview3, this.label4);
			this.label4.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.textview4 = new global::Gtk.TextView ();
			this.textview4.CanFocus = true;
			this.textview4.Name = "textview4";
			this.notebook1.Add (this.textview4);
			global::Gtk.Notebook.NotebookChild w29 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.textview4]));
			w29.Position = 3;
			// Notebook tab
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Чт");
			this.notebook1.SetTabLabel (this.textview4, this.label5);
			this.label5.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.textview5 = new global::Gtk.TextView ();
			this.textview5.CanFocus = true;
			this.textview5.Name = "textview5";
			this.notebook1.Add (this.textview5);
			global::Gtk.Notebook.NotebookChild w30 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.textview5]));
			w30.Position = 4;
			// Notebook tab
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Пт");
			this.notebook1.SetTabLabel (this.textview5, this.label6);
			this.label6.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.textview6 = new global::Gtk.TextView ();
			this.textview6.CanFocus = true;
			this.textview6.Name = "textview6";
			this.notebook1.Add (this.textview6);
			global::Gtk.Notebook.NotebookChild w31 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.textview6]));
			w31.Position = 5;
			// Notebook tab
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Сб");
			this.notebook1.SetTabLabel (this.textview6, this.label7);
			this.label7.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.textview7 = new global::Gtk.TextView ();
			this.textview7.CanFocus = true;
			this.textview7.Name = "textview7";
			this.notebook1.Add (this.textview7);
			global::Gtk.Notebook.NotebookChild w32 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.textview7]));
			w32.Position = 6;
			// Notebook tab
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Вс");
			this.notebook1.SetTabLabel (this.textview7, this.label8);
			this.label8.ShowAll ();
			this.vbox1.Add (this.notebook1);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.notebook1]));
			w33.Position = 2;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 722;
			this.DefaultHeight = 633;
			this.Show ();
		}
	}
}
