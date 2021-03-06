
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox MainBox;

	private global::Gtk.Entry EntryBox;

	private global::Gtk.Table ControlPanel;

	private global::Gtk.Button _0Button;

	private global::Gtk.Button _1Button;

	private global::Gtk.Button _2Button;

	private global::Gtk.Button _3Button;

	private global::Gtk.Button _4Button;

	private global::Gtk.Button _5Button;

	private global::Gtk.Button _6Button;

	private global::Gtk.Button _7Button;

	private global::Gtk.Button _8Button;

	private global::Gtk.Button _9Button;

	private global::Gtk.Button AdditionButton;

	private global::Gtk.Button BackspaceButton;

	private global::Gtk.Button ClearButton;

	private global::Gtk.Button CloseBracketButton;

	private global::Gtk.Button DivisionButton;

	private global::Gtk.Button EvaluateButton;

	private global::Gtk.Button MultiplicationButton;

	private global::Gtk.Button OpenBracketButton;

	private global::Gtk.Button PointButton;

	private global::Gtk.Button SubtractionButton;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.MainBox = new global::Gtk.VBox();
		this.MainBox.Name = "MainBox";
		this.MainBox.Spacing = 5;
		this.MainBox.BorderWidth = ((uint)(5));
		// Container child MainBox.Gtk.Box+BoxChild
		this.EntryBox = new global::Gtk.Entry();
		this.EntryBox.CanFocus = true;
		this.EntryBox.Name = "EntryBox";
		this.EntryBox.IsEditable = true;
		this.EntryBox.InvisibleChar = '●';
		this.EntryBox.Xalign = 1F;
		this.MainBox.Add(this.EntryBox);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.MainBox[this.EntryBox]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child MainBox.Gtk.Box+BoxChild
		this.ControlPanel = new global::Gtk.Table(((uint)(5)), ((uint)(4)), false);
		this.ControlPanel.Name = "ControlPanel";
		this.ControlPanel.RowSpacing = ((uint)(6));
		this.ControlPanel.ColumnSpacing = ((uint)(6));
		// Container child ControlPanel.Gtk.Table+TableChild
		this._0Button = new global::Gtk.Button();
		this._0Button.WidthRequest = 30;
		this._0Button.HeightRequest = 30;
		this._0Button.CanFocus = true;
		this._0Button.Name = "_0Button";
		this._0Button.UseUnderline = true;
		this._0Button.Label = global::Mono.Unix.Catalog.GetString("0");
		this.ControlPanel.Add(this._0Button);
		global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this._0Button]));
		w2.TopAttach = ((uint)(4));
		w2.BottomAttach = ((uint)(5));
		w2.XOptions = ((global::Gtk.AttachOptions)(4));
		// Container child ControlPanel.Gtk.Table+TableChild
		this._1Button = new global::Gtk.Button();
		this._1Button.WidthRequest = 30;
		this._1Button.HeightRequest = 30;
		this._1Button.CanFocus = true;
		this._1Button.Name = "_1Button";
		this._1Button.UseUnderline = true;
		this._1Button.Label = global::Mono.Unix.Catalog.GetString("1");
		this.ControlPanel.Add(this._1Button);
		global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this._1Button]));
		w3.TopAttach = ((uint)(3));
		w3.BottomAttach = ((uint)(4));
		w3.XOptions = ((global::Gtk.AttachOptions)(4));
		// Container child ControlPanel.Gtk.Table+TableChild
		this._2Button = new global::Gtk.Button();
		this._2Button.WidthRequest = 30;
		this._2Button.HeightRequest = 30;
		this._2Button.CanFocus = true;
		this._2Button.Name = "_2Button";
		this._2Button.UseUnderline = true;
		this._2Button.Label = global::Mono.Unix.Catalog.GetString("2");
		this.ControlPanel.Add(this._2Button);
		global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this._2Button]));
		w4.TopAttach = ((uint)(3));
		w4.BottomAttach = ((uint)(4));
		w4.LeftAttach = ((uint)(1));
		w4.RightAttach = ((uint)(2));
		w4.XOptions = ((global::Gtk.AttachOptions)(4));
		w4.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child ControlPanel.Gtk.Table+TableChild
		this._3Button = new global::Gtk.Button();
		this._3Button.WidthRequest = 30;
		this._3Button.HeightRequest = 30;
		this._3Button.CanFocus = true;
		this._3Button.Name = "_3Button";
		this._3Button.UseUnderline = true;
		this._3Button.Label = global::Mono.Unix.Catalog.GetString("3");
		this.ControlPanel.Add(this._3Button);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this._3Button]));
		w5.TopAttach = ((uint)(3));
		w5.BottomAttach = ((uint)(4));
		w5.LeftAttach = ((uint)(2));
		w5.RightAttach = ((uint)(3));
		w5.XOptions = ((global::Gtk.AttachOptions)(4));
		w5.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child ControlPanel.Gtk.Table+TableChild
		this._4Button = new global::Gtk.Button();
		this._4Button.WidthRequest = 30;
		this._4Button.HeightRequest = 30;
		this._4Button.CanFocus = true;
		this._4Button.Name = "_4Button";
		this._4Button.UseUnderline = true;
		this._4Button.Label = global::Mono.Unix.Catalog.GetString("4");
		this.ControlPanel.Add(this._4Button);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this._4Button]));
		w6.TopAttach = ((uint)(2));
		w6.BottomAttach = ((uint)(3));
		w6.XOptions = ((global::Gtk.AttachOptions)(4));
		// Container child ControlPanel.Gtk.Table+TableChild
		this._5Button = new global::Gtk.Button();
		this._5Button.WidthRequest = 30;
		this._5Button.HeightRequest = 30;
		this._5Button.CanFocus = true;
		this._5Button.Name = "_5Button";
		this._5Button.UseUnderline = true;
		this._5Button.Label = global::Mono.Unix.Catalog.GetString("5");
		this.ControlPanel.Add(this._5Button);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this._5Button]));
		w7.TopAttach = ((uint)(2));
		w7.BottomAttach = ((uint)(3));
		w7.LeftAttach = ((uint)(1));
		w7.RightAttach = ((uint)(2));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child ControlPanel.Gtk.Table+TableChild
		this._6Button = new global::Gtk.Button();
		this._6Button.WidthRequest = 30;
		this._6Button.HeightRequest = 30;
		this._6Button.CanFocus = true;
		this._6Button.Name = "_6Button";
		this._6Button.UseUnderline = true;
		this._6Button.Label = global::Mono.Unix.Catalog.GetString("6");
		this.ControlPanel.Add(this._6Button);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this._6Button]));
		w8.TopAttach = ((uint)(2));
		w8.BottomAttach = ((uint)(3));
		w8.LeftAttach = ((uint)(2));
		w8.RightAttach = ((uint)(3));
		w8.XOptions = ((global::Gtk.AttachOptions)(4));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child ControlPanel.Gtk.Table+TableChild
		this._7Button = new global::Gtk.Button();
		this._7Button.WidthRequest = 30;
		this._7Button.HeightRequest = 30;
		this._7Button.CanFocus = true;
		this._7Button.Name = "_7Button";
		this._7Button.UseUnderline = true;
		this._7Button.Label = global::Mono.Unix.Catalog.GetString("7");
		this.ControlPanel.Add(this._7Button);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this._7Button]));
		w9.TopAttach = ((uint)(1));
		w9.BottomAttach = ((uint)(2));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		// Container child ControlPanel.Gtk.Table+TableChild
		this._8Button = new global::Gtk.Button();
		this._8Button.WidthRequest = 30;
		this._8Button.HeightRequest = 30;
		this._8Button.CanFocus = true;
		this._8Button.Name = "_8Button";
		this._8Button.UseUnderline = true;
		this._8Button.Label = global::Mono.Unix.Catalog.GetString("8");
		this.ControlPanel.Add(this._8Button);
		global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this._8Button]));
		w10.TopAttach = ((uint)(1));
		w10.BottomAttach = ((uint)(2));
		w10.LeftAttach = ((uint)(1));
		w10.RightAttach = ((uint)(2));
		w10.XOptions = ((global::Gtk.AttachOptions)(4));
		w10.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child ControlPanel.Gtk.Table+TableChild
		this._9Button = new global::Gtk.Button();
		this._9Button.WidthRequest = 30;
		this._9Button.HeightRequest = 30;
		this._9Button.CanFocus = true;
		this._9Button.Name = "_9Button";
		this._9Button.UseUnderline = true;
		this._9Button.Label = global::Mono.Unix.Catalog.GetString("9");
		this.ControlPanel.Add(this._9Button);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this._9Button]));
		w11.TopAttach = ((uint)(1));
		w11.BottomAttach = ((uint)(2));
		w11.LeftAttach = ((uint)(2));
		w11.RightAttach = ((uint)(3));
		w11.XOptions = ((global::Gtk.AttachOptions)(4));
		w11.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child ControlPanel.Gtk.Table+TableChild
		this.AdditionButton = new global::Gtk.Button();
		this.AdditionButton.WidthRequest = 30;
		this.AdditionButton.HeightRequest = 30;
		this.AdditionButton.CanFocus = true;
		this.AdditionButton.Name = "AdditionButton";
		this.AdditionButton.UseUnderline = true;
		this.AdditionButton.Label = global::Mono.Unix.Catalog.GetString("+");
		this.ControlPanel.Add(this.AdditionButton);
		global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this.AdditionButton]));
		w12.TopAttach = ((uint)(4));
		w12.BottomAttach = ((uint)(5));
		w12.LeftAttach = ((uint)(3));
		w12.RightAttach = ((uint)(4));
		w12.XOptions = ((global::Gtk.AttachOptions)(4));
		w12.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child ControlPanel.Gtk.Table+TableChild
		this.BackspaceButton = new global::Gtk.Button();
		this.BackspaceButton.WidthRequest = 30;
		this.BackspaceButton.HeightRequest = 30;
		this.BackspaceButton.CanFocus = true;
		this.BackspaceButton.Name = "BackspaceButton";
		this.BackspaceButton.UseUnderline = true;
		this.BackspaceButton.Label = global::Mono.Unix.Catalog.GetString("<<");
		this.ControlPanel.Add(this.BackspaceButton);
		global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this.BackspaceButton]));
		w13.LeftAttach = ((uint)(3));
		w13.RightAttach = ((uint)(4));
		// Container child ControlPanel.Gtk.Table+TableChild
		this.ClearButton = new global::Gtk.Button();
		this.ClearButton.WidthRequest = 30;
		this.ClearButton.HeightRequest = 30;
		this.ClearButton.CanFocus = true;
		this.ClearButton.Name = "ClearButton";
		this.ClearButton.UseUnderline = true;
		this.ClearButton.Label = global::Mono.Unix.Catalog.GetString("C");
		this.ControlPanel.Add(this.ClearButton);
		// Container child ControlPanel.Gtk.Table+TableChild
		this.CloseBracketButton = new global::Gtk.Button();
		this.CloseBracketButton.WidthRequest = 30;
		this.CloseBracketButton.HeightRequest = 30;
		this.CloseBracketButton.CanFocus = true;
		this.CloseBracketButton.Name = "CloseBracketButton";
		this.CloseBracketButton.UseUnderline = true;
		this.CloseBracketButton.Label = global::Mono.Unix.Catalog.GetString(")");
		this.ControlPanel.Add(this.CloseBracketButton);
		global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this.CloseBracketButton]));
		w15.LeftAttach = ((uint)(2));
		w15.RightAttach = ((uint)(3));
		w15.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child ControlPanel.Gtk.Table+TableChild
		this.DivisionButton = new global::Gtk.Button();
		this.DivisionButton.WidthRequest = 30;
		this.DivisionButton.HeightRequest = 30;
		this.DivisionButton.CanFocus = true;
		this.DivisionButton.Name = "DivisionButton";
		this.DivisionButton.UseUnderline = true;
		this.DivisionButton.Label = global::Mono.Unix.Catalog.GetString("/");
		this.ControlPanel.Add(this.DivisionButton);
		global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this.DivisionButton]));
		w16.TopAttach = ((uint)(1));
		w16.BottomAttach = ((uint)(2));
		w16.LeftAttach = ((uint)(3));
		w16.RightAttach = ((uint)(4));
		w16.XOptions = ((global::Gtk.AttachOptions)(4));
		w16.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child ControlPanel.Gtk.Table+TableChild
		this.EvaluateButton = new global::Gtk.Button();
		this.EvaluateButton.WidthRequest = 30;
		this.EvaluateButton.HeightRequest = 30;
		this.EvaluateButton.CanFocus = true;
		this.EvaluateButton.Name = "EvaluateButton";
		this.EvaluateButton.UseUnderline = true;
		this.EvaluateButton.Label = global::Mono.Unix.Catalog.GetString("=");
		this.ControlPanel.Add(this.EvaluateButton);
		global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this.EvaluateButton]));
		w17.TopAttach = ((uint)(4));
		w17.BottomAttach = ((uint)(5));
		w17.LeftAttach = ((uint)(2));
		w17.RightAttach = ((uint)(3));
		w17.XOptions = ((global::Gtk.AttachOptions)(4));
		w17.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child ControlPanel.Gtk.Table+TableChild
		this.MultiplicationButton = new global::Gtk.Button();
		this.MultiplicationButton.WidthRequest = 30;
		this.MultiplicationButton.HeightRequest = 30;
		this.MultiplicationButton.CanFocus = true;
		this.MultiplicationButton.Name = "MultiplicationButton";
		this.MultiplicationButton.UseUnderline = true;
		this.MultiplicationButton.Label = global::Mono.Unix.Catalog.GetString("*");
		this.ControlPanel.Add(this.MultiplicationButton);
		global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this.MultiplicationButton]));
		w18.TopAttach = ((uint)(2));
		w18.BottomAttach = ((uint)(3));
		w18.LeftAttach = ((uint)(3));
		w18.RightAttach = ((uint)(4));
		w18.XOptions = ((global::Gtk.AttachOptions)(4));
		w18.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child ControlPanel.Gtk.Table+TableChild
		this.OpenBracketButton = new global::Gtk.Button();
		this.OpenBracketButton.WidthRequest = 30;
		this.OpenBracketButton.HeightRequest = 30;
		this.OpenBracketButton.CanFocus = true;
		this.OpenBracketButton.Name = "OpenBracketButton";
		this.OpenBracketButton.UseUnderline = true;
		this.OpenBracketButton.Label = global::Mono.Unix.Catalog.GetString("(");
		this.ControlPanel.Add(this.OpenBracketButton);
		global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this.OpenBracketButton]));
		w19.LeftAttach = ((uint)(1));
		w19.RightAttach = ((uint)(2));
		w19.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child ControlPanel.Gtk.Table+TableChild
		this.PointButton = new global::Gtk.Button();
		this.PointButton.WidthRequest = 30;
		this.PointButton.HeightRequest = 30;
		this.PointButton.CanFocus = true;
		this.PointButton.Name = "PointButton";
		this.PointButton.UseUnderline = true;
		this.PointButton.Label = global::Mono.Unix.Catalog.GetString(".");
		this.ControlPanel.Add(this.PointButton);
		global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this.PointButton]));
		w20.TopAttach = ((uint)(4));
		w20.BottomAttach = ((uint)(5));
		w20.LeftAttach = ((uint)(1));
		w20.RightAttach = ((uint)(2));
		w20.XOptions = ((global::Gtk.AttachOptions)(4));
		w20.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child ControlPanel.Gtk.Table+TableChild
		this.SubtractionButton = new global::Gtk.Button();
		this.SubtractionButton.WidthRequest = 30;
		this.SubtractionButton.HeightRequest = 30;
		this.SubtractionButton.CanFocus = true;
		this.SubtractionButton.Name = "SubtractionButton";
		this.SubtractionButton.UseUnderline = true;
		this.SubtractionButton.Label = global::Mono.Unix.Catalog.GetString("-");
		this.ControlPanel.Add(this.SubtractionButton);
		global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.ControlPanel[this.SubtractionButton]));
		w21.TopAttach = ((uint)(3));
		w21.BottomAttach = ((uint)(4));
		w21.LeftAttach = ((uint)(3));
		w21.RightAttach = ((uint)(4));
		w21.XOptions = ((global::Gtk.AttachOptions)(4));
		w21.YOptions = ((global::Gtk.AttachOptions)(4));
		this.MainBox.Add(this.ControlPanel);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.MainBox[this.ControlPanel]));
		w22.Position = 1;
		this.Add(this.MainBox);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 226;
		this.DefaultHeight = 280;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.KeyPressEvent += new global::Gtk.KeyPressEventHandler(this.OnEnterClicked);
		this.SubtractionButton.Clicked += new global::System.EventHandler(this.OnNumButtonClicked);
		this.OpenBracketButton.Clicked += new global::System.EventHandler(this.OnNumButtonClicked);
		this.MultiplicationButton.Clicked += new global::System.EventHandler(this.OnNumButtonClicked);
		this.EvaluateButton.Clicked += new global::System.EventHandler(this.OnEvaluateButtonClicked);
		this.DivisionButton.Clicked += new global::System.EventHandler(this.OnNumButtonClicked);
		this.CloseBracketButton.Clicked += new global::System.EventHandler(this.OnNumButtonClicked);
		this.ClearButton.Clicked += new global::System.EventHandler(this.OnClearButtonClicked);
		this.BackspaceButton.Clicked += new global::System.EventHandler(this.OnBackspaceButtonClicked);
		this.AdditionButton.Clicked += new global::System.EventHandler(this.OnNumButtonClicked);
		this._9Button.Clicked += new global::System.EventHandler(this.OnNumButtonClicked);
		this._8Button.Clicked += new global::System.EventHandler(this.OnNumButtonClicked);
		this._7Button.Clicked += new global::System.EventHandler(this.OnNumButtonClicked);
		this._6Button.Clicked += new global::System.EventHandler(this.OnNumButtonClicked);
		this._5Button.Clicked += new global::System.EventHandler(this.OnNumButtonClicked);
		this._4Button.Clicked += new global::System.EventHandler(this.OnNumButtonClicked);
		this._3Button.Clicked += new global::System.EventHandler(this.OnNumButtonClicked);
		this._2Button.Clicked += new global::System.EventHandler(this.OnNumButtonClicked);
		this._1Button.Clicked += new global::System.EventHandler(this.OnNumButtonClicked);
		this._0Button.Clicked += new global::System.EventHandler(this.OnNumButtonClicked);
	}
}
