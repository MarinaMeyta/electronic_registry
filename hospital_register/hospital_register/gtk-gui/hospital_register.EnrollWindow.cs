
// This file has been generated by the GUI designer. Do not modify.
namespace hospital_register
{
	public partial class EnrollWindow
	{
		private global::Gtk.Fixed fixed8;
		private global::Gtk.ComboBoxEntry comboboxentry6;
		private global::Gtk.ComboBoxEntry comboboxentry4;
		private global::Gtk.Label label24;
		private global::Gtk.Label label25;
		private global::Gtk.Label label22;
		private global::Gtk.Label label23;
		private global::Gtk.Label label21;
		private global::Gtk.Image image6;
		private global::Gtk.Button button3;
		private global::Gtk.Label label26;
		private global::Gtk.Entry entrySeries;
		private global::Gtk.Entry entryNumber;
		private global::Gtk.Label label27;
		private global::Gtk.Label label28;
		private global::Gtk.Button button4;
		private global::Gtk.ComboBox combobox2;
		private global::Gtk.ComboBox combobox3;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget hospital_register.EnrollWindow
			this.Name = "hospital_register.EnrollWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("EnrollWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child hospital_register.EnrollWindow.Gtk.Container+ContainerChild
			this.fixed8 = new global::Gtk.Fixed ();
			this.fixed8.Name = "fixed8";
			this.fixed8.HasWindow = false;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.comboboxentry6 = global::Gtk.ComboBoxEntry.NewText ();
			this.comboboxentry6.Name = "comboboxentry6";
			this.fixed8.Add (this.comboboxentry6);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.comboboxentry6]));
			w1.X = 491;
			w1.Y = 116;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.comboboxentry4 = global::Gtk.ComboBoxEntry.NewText ();
			this.comboboxentry4.Name = "comboboxentry4";
			this.fixed8.Add (this.comboboxentry4);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.comboboxentry4]));
			w2.X = 490;
			w2.Y = 70;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.label24 = new global::Gtk.Label ();
			this.label24.Name = "label24";
			this.label24.LabelProp = global::Mono.Unix.Catalog.GetString ("Дата приема:");
			this.fixed8.Add (this.label24);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.label24]));
			w3.X = 387;
			w3.Y = 74;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.label25 = new global::Gtk.Label ();
			this.label25.Name = "label25";
			this.label25.LabelProp = global::Mono.Unix.Catalog.GetString ("Время приема:");
			this.fixed8.Add (this.label25);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.label25]));
			w4.X = 377;
			w4.Y = 119;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.label22 = new global::Gtk.Label ();
			this.label22.Name = "label22";
			this.label22.LabelProp = global::Mono.Unix.Catalog.GetString ("Ф.И.О. врача:");
			this.fixed8.Add (this.label22);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.label22]));
			w5.X = 47;
			w5.Y = 70;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.label23 = new global::Gtk.Label ();
			this.label23.Name = "label23";
			this.label23.LabelProp = global::Mono.Unix.Catalog.GetString ("Специальность:");
			this.fixed8.Add (this.label23);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.label23]));
			w6.X = 31;
			w6.Y = 116;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.label21 = new global::Gtk.Label ();
			this.label21.Name = "label21";
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString ("ЗАПИСЬ НА ПРИЕМ");
			this.fixed8.Add (this.label21);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.label21]));
			w7.X = 302;
			w7.Y = 27;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.image6 = new global::Gtk.Image ();
			this.image6.WidthRequest = 43;
			this.image6.HeightRequest = 43;
			this.image6.Name = "image6";
			this.image6.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "stock_task", global::Gtk.IconSize.Menu);
			this.fixed8.Add (this.image6);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.image6]));
			w8.X = 257;
			w8.Y = 13;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.button3 = new global::Gtk.Button ();
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			this.button3.Label = global::Mono.Unix.Catalog.GetString ("Посмотреть расписание");
			this.fixed8.Add (this.button3);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.button3]));
			w9.X = 271;
			w9.Y = 165;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.label26 = new global::Gtk.Label ();
			this.label26.Name = "label26";
			this.label26.LabelProp = global::Mono.Unix.Catalog.GetString ("ПАССПОРТНЫЕ ДАННЫЕ");
			this.fixed8.Add (this.label26);
			global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.label26]));
			w10.X = 281;
			w10.Y = 216;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.entrySeries = new global::Gtk.Entry ();
			this.entrySeries.CanFocus = true;
			this.entrySeries.Name = "entrySeries";
			this.entrySeries.IsEditable = true;
			this.entrySeries.MaxLength = 4;
			this.entrySeries.InvisibleChar = '•';
			this.fixed8.Add (this.entrySeries);
			global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.entrySeries]));
			w11.X = 367;
			w11.Y = 252;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.entryNumber = new global::Gtk.Entry ();
			this.entryNumber.CanFocus = true;
			this.entryNumber.Name = "entryNumber";
			this.entryNumber.IsEditable = true;
			this.entryNumber.MaxLength = 6;
			this.entryNumber.InvisibleChar = '•';
			this.fixed8.Add (this.entryNumber);
			global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.entryNumber]));
			w12.X = 367;
			w12.Y = 297;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.label27 = new global::Gtk.Label ();
			this.label27.Name = "label27";
			this.label27.LabelProp = global::Mono.Unix.Catalog.GetString ("Серия пасспорта:");
			this.fixed8.Add (this.label27);
			global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.label27]));
			w13.X = 238;
			w13.Y = 252;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.label28 = new global::Gtk.Label ();
			this.label28.Name = "label28";
			this.label28.LabelProp = global::Mono.Unix.Catalog.GetString ("Номер пасспорта:");
			this.fixed8.Add (this.label28);
			global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.label28]));
			w14.X = 233;
			w14.Y = 298;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.button4 = new global::Gtk.Button ();
			this.button4.WidthRequest = 180;
			this.button4.HeightRequest = 39;
			this.button4.CanFocus = true;
			this.button4.Name = "button4";
			this.button4.UseUnderline = true;
			this.button4.Label = global::Mono.Unix.Catalog.GetString ("ЗАПИСАТЬСЯ");
			this.fixed8.Add (this.button4);
			global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.button4]));
			w15.X = 270;
			w15.Y = 345;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.combobox2 = global::Gtk.ComboBox.NewText ();
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("хирург"));
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("офтальмолог"));
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("терапевт"));
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("гинеколог"));
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("отолоринголог"));
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("кадиолог"));
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("эндокринолог"));
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("аллерголог"));
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("венеролог"));
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("невролог"));
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("рентгенолог"));
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("уролог"));
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("физиотерапевт"));
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("травматолог"));
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("ревматолог"));
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("околог"));
			this.combobox2.AppendText (global::Mono.Unix.Catalog.GetString ("гастероэнтеролог"));
			this.combobox2.WidthRequest = 191;
			this.combobox2.Name = "combobox2";
			this.fixed8.Add (this.combobox2);
			global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.combobox2]));
			w16.X = 150;
			w16.Y = 111;
			// Container child fixed8.Gtk.Fixed+FixedChild
			this.combobox3 = global::Gtk.ComboBox.NewText ();
			this.combobox3.WidthRequest = 191;
			this.combobox3.Name = "combobox3";
			this.fixed8.Add (this.combobox3);
			global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.fixed8 [this.combobox3]));
			w17.X = 151;
			w17.Y = 63;
			this.Add (this.fixed8);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 729;
			this.DefaultHeight = 422;
			this.Show ();
			this.button4.Clicked += new global::System.EventHandler (this.OnEnrollButtonClicked);
			this.combobox2.Changed += new global::System.EventHandler (this.OnCombobox2Changed);
		}
	}
}