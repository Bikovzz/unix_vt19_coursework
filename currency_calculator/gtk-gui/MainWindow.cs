
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.ComboBox cmbFrom;

	private global::Gtk.ComboBox cmbTo;

	private global::Gtk.Entry entValue;

	private global::Gtk.Label lblResult;

	private global::Gtk.Button btnCalculate;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.cmbFrom = global::Gtk.ComboBox.NewText();
		this.cmbFrom.AppendText(global::Mono.Unix.Catalog.GetString("USD"));
		this.cmbFrom.AppendText(global::Mono.Unix.Catalog.GetString("RUB"));
		this.cmbFrom.AppendText(global::Mono.Unix.Catalog.GetString("UAH"));
		this.cmbFrom.AppendText(global::Mono.Unix.Catalog.GetString("EUR"));
		this.cmbFrom.WidthRequest = 150;
		this.cmbFrom.HeightRequest = 30;
		this.cmbFrom.Name = "cmbFrom";
		this.fixed1.Add(this.cmbFrom);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.cmbFrom]));
		w1.X = 70;
		w1.Y = 90;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.cmbTo = global::Gtk.ComboBox.NewText();
		this.cmbTo.AppendText(global::Mono.Unix.Catalog.GetString("USD"));
		this.cmbTo.AppendText(global::Mono.Unix.Catalog.GetString("RUB"));
		this.cmbTo.AppendText(global::Mono.Unix.Catalog.GetString("UAH"));
		this.cmbTo.AppendText(global::Mono.Unix.Catalog.GetString("EUR"));
		this.cmbTo.WidthRequest = 150;
		this.cmbTo.HeightRequest = 30;
		this.cmbTo.Name = "cmbTo";
		this.fixed1.Add(this.cmbTo);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.cmbTo]));
		w2.X = 426;
		w2.Y = 90;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entValue = new global::Gtk.Entry();
		this.entValue.WidthRequest = 150;
		this.entValue.HeightRequest = 30;
		this.entValue.CanFocus = true;
		this.entValue.Name = "entValue";
		this.entValue.IsEditable = true;
		this.entValue.InvisibleChar = '•';
		this.fixed1.Add(this.entValue);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entValue]));
		w3.X = 70;
		w3.Y = 148;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblResult = new global::Gtk.Label();
		this.lblResult.WidthRequest = 150;
		this.lblResult.HeightRequest = 30;
		this.lblResult.Name = "lblResult";
		this.fixed1.Add(this.lblResult);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblResult]));
		w4.X = 425;
		w4.Y = 148;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnCalculate = new global::Gtk.Button();
		this.btnCalculate.WidthRequest = 150;
		this.btnCalculate.HeightRequest = 30;
		this.btnCalculate.CanFocus = true;
		this.btnCalculate.Name = "btnCalculate";
		this.btnCalculate.UseUnderline = true;
		this.btnCalculate.Label = global::Mono.Unix.Catalog.GetString("Calculate");
		this.fixed1.Add(this.btnCalculate);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnCalculate]));
		w5.X = 251;
		w5.Y = 365;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 651;
		this.DefaultHeight = 452;
		this.Show();
		this.btnCalculate.Clicked += new global::System.EventHandler(this.OnBtnCalculateClicked);
	}
}