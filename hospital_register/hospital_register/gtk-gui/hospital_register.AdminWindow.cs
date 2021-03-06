
// This file has been generated by the GUI designer. Do not modify.
namespace hospital_register
{
	public partial class AdminWindow
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.Fixed fixed2;
		private global::Gtk.Image image2;
		private global::Gtk.Label label9;
		private global::Gtk.Image image1;
		private global::Gtk.Notebook notebook1;
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox13;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView treeview1;
		private global::Gtk.Fixed fixed5;
		private global::Gtk.RadioButton radiobutton2;
		private global::Gtk.RadioButton radiobutton1;
		private global::Gtk.RadioButton radiobutton3;
		private global::Gtk.Button buttonClear;
		private global::Gtk.Button buttonSelect;
		private global::Gtk.RadioButton radiobutton4;
		private global::Gtk.Label label2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Label label10;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Label label1;
		private global::Gtk.Entry entry1;
		private global::Gtk.HBox hbox4;
		private global::Gtk.Label label5;
		private global::Gtk.Entry entry2;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Label label6;
		private global::Gtk.Entry entry3;
		private global::Gtk.Button buttonInsertEmployee;
		private global::Gtk.VBox vbox4;
		private global::Gtk.Label label11;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Label label4;
		private global::Gtk.Entry entry9;
		private global::Gtk.HBox hbox6;
		private global::Gtk.Label label7;
		private global::Gtk.ComboBox combobox1;
		private global::Gtk.HBox hbox7;
		private global::Gtk.Label label8;
		private global::Gtk.Entry entry4;
		private global::Gtk.HBox hbox8;
		private global::Gtk.Label label12;
		private global::Gtk.Entry entry5;
		private global::Gtk.Button buttonInsertTimetable;
		private global::Gtk.Label label3;
		private global::Gtk.Fixed fixed4;
		private global::Gtk.Label label17;
		private global::Gtk.Entry entry6;
		private global::Gtk.Button buttonDeleteEmployee;
		private global::Gtk.Label label14;
		private global::Gtk.Label label18;
		private global::Gtk.Entry entry7;
		private global::Gtk.Label label15;
		private global::Gtk.Button buttonDeletePatient;
		private global::Gtk.Label label19;
		private global::Gtk.Entry entry8;
		private global::Gtk.Button buttonDeleteTimetable;
		private global::Gtk.Entry entry10;
		private global::Gtk.Label label21;
		private global::Gtk.Button buttonDeleteTalon;
		private global::Gtk.Label label20;
		private global::Gtk.Label label16;
		private global::Gtk.Label label13;
		private global::Gtk.Fixed fixed3;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget hospital_register.AdminWindow
			this.Name = "hospital_register.AdminWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("AdminWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child hospital_register.AdminWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.fixed2 = new global::Gtk.Fixed ();
			this.fixed2.HeightRequest = 124;
			this.fixed2.Name = "fixed2";
			this.fixed2.HasWindow = false;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.image2 = new global::Gtk.Image ();
			this.image2.Name = "image2";
			this.image2.Pixbuf = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./getClientLogoMini.png"));
			this.fixed2.Add (this.image2);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.image2]));
			w1.X = 456;
			w1.Y = 29;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("ОКНО УПРАВЛЕНИЯ БАЗОЙ ДАННЫХ");
			this.fixed2.Add (this.label9);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.label9]));
			w2.X = 191;
			w2.Y = 50;
			// Container child fixed2.Gtk.Fixed+FixedChild
			this.image1 = new global::Gtk.Image ();
			this.image1.WidthRequest = 30;
			this.image1.HeightRequest = 30;
			this.image1.Name = "image1";
			this.image1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "stock_file-properties", global::Gtk.IconSize.Menu);
			this.fixed2.Add (this.image1);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.image1]));
			w3.X = 148;
			w3.Y = 45;
			this.vbox1.Add (this.fixed2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.fixed2]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.HeightRequest = 0;
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 1;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox13 = new global::Gtk.HBox ();
			this.hbox13.Name = "hbox13";
			this.hbox13.Spacing = 6;
			// Container child hbox13.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeview1 = new global::Gtk.TreeView ();
			this.treeview1.CanFocus = true;
			this.treeview1.Name = "treeview1";
			this.GtkScrolledWindow.Add (this.treeview1);
			this.hbox13.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox13 [this.GtkScrolledWindow]));
			w6.Position = 0;
			this.vbox2.Add (this.hbox13);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox13]));
			w7.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.fixed5 = new global::Gtk.Fixed ();
			this.fixed5.HeightRequest = 104;
			this.fixed5.Name = "fixed5";
			this.fixed5.HasWindow = false;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.radiobutton2 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Пациенты"));
			this.radiobutton2.CanFocus = true;
			this.radiobutton2.Name = "radiobutton2";
			this.radiobutton2.DrawIndicator = true;
			this.radiobutton2.UseUnderline = true;
			this.radiobutton2.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.fixed5.Add (this.radiobutton2);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.radiobutton2]));
			w8.X = 16;
			w8.Y = 52;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.radiobutton1 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Сотрудники"));
			this.radiobutton1.CanFocus = true;
			this.radiobutton1.Name = "radiobutton1";
			this.radiobutton1.DrawIndicator = true;
			this.radiobutton1.UseUnderline = true;
			this.radiobutton1.Group = this.radiobutton2.Group;
			this.fixed5.Add (this.radiobutton1);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.radiobutton1]));
			w9.X = 16;
			w9.Y = 22;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.radiobutton3 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Расписание"));
			this.radiobutton3.CanFocus = true;
			this.radiobutton3.Name = "radiobutton3";
			this.radiobutton3.DrawIndicator = true;
			this.radiobutton3.UseUnderline = true;
			this.radiobutton3.Group = this.radiobutton2.Group;
			this.fixed5.Add (this.radiobutton3);
			global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.radiobutton3]));
			w10.X = 140;
			w10.Y = 21;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.buttonClear = new global::Gtk.Button ();
			this.buttonClear.CanFocus = true;
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.UseUnderline = true;
			this.buttonClear.Label = global::Mono.Unix.Catalog.GetString ("Очистить");
			this.fixed5.Add (this.buttonClear);
			global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.buttonClear]));
			w11.X = 282;
			w11.Y = 55;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.buttonSelect = new global::Gtk.Button ();
			this.buttonSelect.CanFocus = true;
			this.buttonSelect.Name = "buttonSelect";
			this.buttonSelect.UseUnderline = true;
			this.buttonSelect.Label = global::Mono.Unix.Catalog.GetString ("Найти");
			this.fixed5.Add (this.buttonSelect);
			global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.buttonSelect]));
			w12.X = 281;
			w12.Y = 20;
			// Container child fixed5.Gtk.Fixed+FixedChild
			this.radiobutton4 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Талоны"));
			this.radiobutton4.CanFocus = true;
			this.radiobutton4.Name = "radiobutton4";
			this.radiobutton4.DrawIndicator = true;
			this.radiobutton4.UseUnderline = true;
			this.radiobutton4.Group = this.radiobutton2.Group;
			this.fixed5.Add (this.radiobutton4);
			global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.radiobutton4]));
			w13.X = 140;
			w13.Y = 55;
			this.vbox2.Add (this.fixed5);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.fixed5]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.notebook1.Add (this.vbox2);
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Просмотр таблиц");
			this.notebook1.SetTabLabel (this.vbox2, this.label2);
			this.label2.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Добавить сотрудника");
			this.vbox3.Add (this.label10);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.label10]));
			w16.Position = 0;
			w16.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Ф.И.О.:");
			this.hbox3.Add (this.label1);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label1]));
			w17.Position = 0;
			w17.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entry1 = new global::Gtk.Entry ();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.MaxLength = 50;
			this.entry1.InvisibleChar = '•';
			this.hbox3.Add (this.entry1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.entry1]));
			w18.Position = 1;
			w18.Expand = false;
			this.vbox3.Add (this.hbox3);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox3]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Специальность:");
			this.hbox4.Add (this.label5);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.label5]));
			w20.Position = 0;
			w20.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.entry2 = new global::Gtk.Entry ();
			this.entry2.CanFocus = true;
			this.entry2.Name = "entry2";
			this.entry2.IsEditable = true;
			this.entry2.MaxLength = 50;
			this.entry2.InvisibleChar = '•';
			this.hbox4.Add (this.entry2);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.entry2]));
			w21.Position = 1;
			w21.Expand = false;
			this.vbox3.Add (this.hbox4);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox4]));
			w22.Position = 2;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Кабинет:");
			this.hbox5.Add (this.label6);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label6]));
			w23.Position = 0;
			w23.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.entry3 = new global::Gtk.Entry ();
			this.entry3.CanFocus = true;
			this.entry3.Name = "entry3";
			this.entry3.IsEditable = true;
			this.entry3.MaxLength = 3;
			this.entry3.InvisibleChar = '•';
			this.hbox5.Add (this.entry3);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.entry3]));
			w24.Position = 1;
			w24.Expand = false;
			this.vbox3.Add (this.hbox5);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox5]));
			w25.Position = 3;
			w25.Expand = false;
			w25.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.buttonInsertEmployee = new global::Gtk.Button ();
			this.buttonInsertEmployee.CanFocus = true;
			this.buttonInsertEmployee.Name = "buttonInsertEmployee";
			this.buttonInsertEmployee.UseUnderline = true;
			this.buttonInsertEmployee.Label = global::Mono.Unix.Catalog.GetString ("Добавить врача");
			this.vbox3.Add (this.buttonInsertEmployee);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.buttonInsertEmployee]));
			w26.Position = 4;
			w26.Fill = false;
			this.hbox1.Add (this.vbox3);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox3]));
			w27.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("Добавить расписание сотрудника");
			this.vbox4.Add (this.label11);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.label11]));
			w28.Position = 0;
			w28.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("ID сотрудника");
			this.hbox2.Add (this.label4);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label4]));
			w29.Position = 0;
			w29.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entry9 = new global::Gtk.Entry ();
			this.entry9.CanFocus = true;
			this.entry9.Name = "entry9";
			this.entry9.IsEditable = true;
			this.entry9.MaxLength = 10;
			this.entry9.InvisibleChar = '•';
			this.hbox2.Add (this.entry9);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.entry9]));
			w30.Position = 1;
			w30.Expand = false;
			this.vbox4.Add (this.hbox2);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox2]));
			w31.Position = 1;
			w31.Expand = false;
			w31.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox ();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("День недели:");
			this.hbox6.Add (this.label7);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.label7]));
			w32.Position = 0;
			w32.Expand = false;
			w32.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.combobox1 = global::Gtk.ComboBox.NewText ();
			this.combobox1.AppendText (global::Mono.Unix.Catalog.GetString ("Пн"));
			this.combobox1.AppendText (global::Mono.Unix.Catalog.GetString ("Вт"));
			this.combobox1.AppendText (global::Mono.Unix.Catalog.GetString ("Ср"));
			this.combobox1.AppendText (global::Mono.Unix.Catalog.GetString ("Чт"));
			this.combobox1.AppendText (global::Mono.Unix.Catalog.GetString ("Пт"));
			this.combobox1.AppendText (global::Mono.Unix.Catalog.GetString ("Сб"));
			this.combobox1.Name = "combobox1";
			this.hbox6.Add (this.combobox1);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox6 [this.combobox1]));
			w33.Position = 1;
			w33.Fill = false;
			this.vbox4.Add (this.hbox6);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox6]));
			w34.Position = 2;
			w34.Expand = false;
			w34.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox ();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Начало смены:");
			this.hbox7.Add (this.label8);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.label8]));
			w35.Position = 0;
			// Container child hbox7.Gtk.Box+BoxChild
			this.entry4 = new global::Gtk.Entry ();
			this.entry4.TooltipMarkup = "ЧЧ:ММ";
			this.entry4.CanFocus = true;
			this.entry4.Name = "entry4";
			this.entry4.IsEditable = true;
			this.entry4.MaxLength = 5;
			this.entry4.InvisibleChar = '•';
			this.hbox7.Add (this.entry4);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.entry4]));
			w36.Position = 1;
			w36.Expand = false;
			w36.Fill = false;
			this.vbox4.Add (this.hbox7);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox7]));
			w37.Position = 3;
			w37.Expand = false;
			w37.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label ();
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Конец смены:");
			this.hbox8.Add (this.label12);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.label12]));
			w38.Position = 0;
			// Container child hbox8.Gtk.Box+BoxChild
			this.entry5 = new global::Gtk.Entry ();
			this.entry5.TooltipMarkup = "ЧЧ:ММ";
			this.entry5.CanFocus = true;
			this.entry5.Name = "entry5";
			this.entry5.IsEditable = true;
			this.entry5.MaxLength = 5;
			this.entry5.InvisibleChar = '•';
			this.hbox8.Add (this.entry5);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.entry5]));
			w39.Position = 1;
			w39.Expand = false;
			this.vbox4.Add (this.hbox8);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox8]));
			w40.Position = 4;
			w40.Expand = false;
			w40.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.buttonInsertTimetable = new global::Gtk.Button ();
			this.buttonInsertTimetable.CanFocus = true;
			this.buttonInsertTimetable.Name = "buttonInsertTimetable";
			this.buttonInsertTimetable.UseUnderline = true;
			this.buttonInsertTimetable.Label = global::Mono.Unix.Catalog.GetString ("Добавить расписание");
			this.vbox4.Add (this.buttonInsertTimetable);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.buttonInsertTimetable]));
			w41.Position = 5;
			w41.Fill = false;
			this.hbox1.Add (this.vbox4);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox4]));
			w42.Position = 1;
			w42.Fill = false;
			this.notebook1.Add (this.hbox1);
			global::Gtk.Notebook.NotebookChild w43 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.hbox1]));
			w43.Position = 1;
			// Notebook tab
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Добавление данных");
			this.notebook1.SetTabLabel (this.hbox1, this.label3);
			this.label3.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.fixed4 = new global::Gtk.Fixed ();
			this.fixed4.Name = "fixed4";
			this.fixed4.HasWindow = false;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.label17 = new global::Gtk.Label ();
			this.label17.Name = "label17";
			this.label17.LabelProp = global::Mono.Unix.Catalog.GetString ("Удалить сотрудника");
			this.fixed4.Add (this.label17);
			global::Gtk.Fixed.FixedChild w44 = ((global::Gtk.Fixed.FixedChild)(this.fixed4 [this.label17]));
			w44.X = 249;
			w44.Y = 12;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.entry6 = new global::Gtk.Entry ();
			this.entry6.CanFocus = true;
			this.entry6.Name = "entry6";
			this.entry6.IsEditable = true;
			this.entry6.MaxLength = 10;
			this.entry6.InvisibleChar = '•';
			this.fixed4.Add (this.entry6);
			global::Gtk.Fixed.FixedChild w45 = ((global::Gtk.Fixed.FixedChild)(this.fixed4 [this.entry6]));
			w45.X = 240;
			w45.Y = 36;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.buttonDeleteEmployee = new global::Gtk.Button ();
			this.buttonDeleteEmployee.CanFocus = true;
			this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
			this.buttonDeleteEmployee.UseUnderline = true;
			this.buttonDeleteEmployee.Label = global::Mono.Unix.Catalog.GetString ("Удалить");
			this.fixed4.Add (this.buttonDeleteEmployee);
			global::Gtk.Fixed.FixedChild w46 = ((global::Gtk.Fixed.FixedChild)(this.fixed4 [this.buttonDeleteEmployee]));
			w46.X = 421;
			w46.Y = 34;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.label14 = new global::Gtk.Label ();
			this.label14.Name = "label14";
			this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("ID сотрудника:");
			this.fixed4.Add (this.label14);
			global::Gtk.Fixed.FixedChild w47 = ((global::Gtk.Fixed.FixedChild)(this.fixed4 [this.label14]));
			w47.X = 123;
			w47.Y = 37;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.label18 = new global::Gtk.Label ();
			this.label18.Name = "label18";
			this.label18.LabelProp = global::Mono.Unix.Catalog.GetString ("Удалить пациента");
			this.fixed4.Add (this.label18);
			global::Gtk.Fixed.FixedChild w48 = ((global::Gtk.Fixed.FixedChild)(this.fixed4 [this.label18]));
			w48.X = 253;
			w48.Y = 75;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.entry7 = new global::Gtk.Entry ();
			this.entry7.CanFocus = true;
			this.entry7.Name = "entry7";
			this.entry7.IsEditable = true;
			this.entry7.MaxLength = 10;
			this.entry7.InvisibleChar = '•';
			this.fixed4.Add (this.entry7);
			global::Gtk.Fixed.FixedChild w49 = ((global::Gtk.Fixed.FixedChild)(this.fixed4 [this.entry7]));
			w49.X = 240;
			w49.Y = 96;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.label15 = new global::Gtk.Label ();
			this.label15.Name = "label15";
			this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("ID пациента:");
			this.fixed4.Add (this.label15);
			global::Gtk.Fixed.FixedChild w50 = ((global::Gtk.Fixed.FixedChild)(this.fixed4 [this.label15]));
			w50.X = 135;
			w50.Y = 98;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.buttonDeletePatient = new global::Gtk.Button ();
			this.buttonDeletePatient.CanFocus = true;
			this.buttonDeletePatient.Name = "buttonDeletePatient";
			this.buttonDeletePatient.UseUnderline = true;
			this.buttonDeletePatient.Label = global::Mono.Unix.Catalog.GetString ("Удалить");
			this.fixed4.Add (this.buttonDeletePatient);
			global::Gtk.Fixed.FixedChild w51 = ((global::Gtk.Fixed.FixedChild)(this.fixed4 [this.buttonDeletePatient]));
			w51.X = 422;
			w51.Y = 97;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.label19 = new global::Gtk.Label ();
			this.label19.Name = "label19";
			this.label19.LabelProp = global::Mono.Unix.Catalog.GetString ("Удалить расписание сотрудника");
			this.fixed4.Add (this.label19);
			global::Gtk.Fixed.FixedChild w52 = ((global::Gtk.Fixed.FixedChild)(this.fixed4 [this.label19]));
			w52.X = 202;
			w52.Y = 136;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.entry8 = new global::Gtk.Entry ();
			this.entry8.CanFocus = true;
			this.entry8.Name = "entry8";
			this.entry8.IsEditable = true;
			this.entry8.MaxLength = 10;
			this.entry8.InvisibleChar = '•';
			this.fixed4.Add (this.entry8);
			global::Gtk.Fixed.FixedChild w53 = ((global::Gtk.Fixed.FixedChild)(this.fixed4 [this.entry8]));
			w53.X = 238;
			w53.Y = 165;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.buttonDeleteTimetable = new global::Gtk.Button ();
			this.buttonDeleteTimetable.CanFocus = true;
			this.buttonDeleteTimetable.Name = "buttonDeleteTimetable";
			this.buttonDeleteTimetable.UseUnderline = true;
			this.buttonDeleteTimetable.Label = global::Mono.Unix.Catalog.GetString ("Удалить");
			this.fixed4.Add (this.buttonDeleteTimetable);
			global::Gtk.Fixed.FixedChild w54 = ((global::Gtk.Fixed.FixedChild)(this.fixed4 [this.buttonDeleteTimetable]));
			w54.X = 421;
			w54.Y = 164;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.entry10 = new global::Gtk.Entry ();
			this.entry10.CanFocus = true;
			this.entry10.Name = "entry10";
			this.entry10.IsEditable = true;
			this.entry10.MaxLength = 10;
			this.entry10.InvisibleChar = '•';
			this.fixed4.Add (this.entry10);
			global::Gtk.Fixed.FixedChild w55 = ((global::Gtk.Fixed.FixedChild)(this.fixed4 [this.entry10]));
			w55.X = 239;
			w55.Y = 232;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.label21 = new global::Gtk.Label ();
			this.label21.Name = "label21";
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString ("Удалить талон");
			this.fixed4.Add (this.label21);
			global::Gtk.Fixed.FixedChild w56 = ((global::Gtk.Fixed.FixedChild)(this.fixed4 [this.label21]));
			w56.X = 269;
			w56.Y = 202;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.buttonDeleteTalon = new global::Gtk.Button ();
			this.buttonDeleteTalon.CanFocus = true;
			this.buttonDeleteTalon.Name = "buttonDeleteTalon";
			this.buttonDeleteTalon.UseUnderline = true;
			this.buttonDeleteTalon.Label = global::Mono.Unix.Catalog.GetString ("Удалить");
			this.fixed4.Add (this.buttonDeleteTalon);
			global::Gtk.Fixed.FixedChild w57 = ((global::Gtk.Fixed.FixedChild)(this.fixed4 [this.buttonDeleteTalon]));
			w57.X = 419;
			w57.Y = 228;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.label20 = new global::Gtk.Label ();
			this.label20.Name = "label20";
			this.label20.LabelProp = global::Mono.Unix.Catalog.GetString ("ID талона:");
			this.fixed4.Add (this.label20);
			global::Gtk.Fixed.FixedChild w58 = ((global::Gtk.Fixed.FixedChild)(this.fixed4 [this.label20]));
			w58.X = 153;
			w58.Y = 234;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.label16 = new global::Gtk.Label ();
			this.label16.Name = "label16";
			this.label16.LabelProp = global::Mono.Unix.Catalog.GetString ("ID расписания:");
			this.fixed4.Add (this.label16);
			global::Gtk.Fixed.FixedChild w59 = ((global::Gtk.Fixed.FixedChild)(this.fixed4 [this.label16]));
			w59.X = 123;
			w59.Y = 168;
			this.notebook1.Add (this.fixed4);
			global::Gtk.Notebook.NotebookChild w60 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.fixed4]));
			w60.Position = 2;
			// Notebook tab
			this.label13 = new global::Gtk.Label ();
			this.label13.Name = "label13";
			this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Удаление данных");
			this.notebook1.SetTabLabel (this.fixed4, this.label13);
			this.label13.ShowAll ();
			this.vbox1.Add (this.notebook1);
			global::Gtk.Box.BoxChild w61 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.notebook1]));
			w61.Position = 1;
			// Container child vbox1.Gtk.Box+BoxChild
			this.fixed3 = new global::Gtk.Fixed ();
			this.fixed3.HeightRequest = 91;
			this.fixed3.Name = "fixed3";
			this.fixed3.HasWindow = false;
			this.vbox1.Add (this.fixed3);
			global::Gtk.Box.BoxChild w62 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.fixed3]));
			w62.Position = 2;
			w62.Expand = false;
			w62.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 658;
			this.DefaultHeight = 542;
			this.Show ();
			this.buttonClear.Clicked += new global::System.EventHandler (this.OnButtonClearClicked);
			this.buttonSelect.Clicked += new global::System.EventHandler (this.OnButtonSelectClicked);
			this.buttonInsertEmployee.Clicked += new global::System.EventHandler (this.OnButtonInsertEmployeeClicked);
			this.buttonInsertTimetable.Clicked += new global::System.EventHandler (this.OnButtonInsertTimetableClicked);
			this.buttonDeleteEmployee.Clicked += new global::System.EventHandler (this.OnButtonDeleteEmployeeClicked);
			this.buttonDeletePatient.Clicked += new global::System.EventHandler (this.OnButtonDeletePatientClicked);
			this.buttonDeleteTimetable.Clicked += new global::System.EventHandler (this.OnButtonDeleteTimetableClicked);
			this.buttonDeleteTalon.Clicked += new global::System.EventHandler (this.OnButtonDeleteTalonClicked);
		}
	}
}
