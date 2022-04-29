using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduccion;

public partial class Form2 : Form {
    public Label lblMensaje;
    public CheckBox MXN;
    public CheckBox USD;
    public CheckBox CAD;
    public CheckBox EUR;
    public CheckBox JPY;
    public Boolean MXNestatus = false;
    public Boolean USDestatus = false;
    public Boolean CADestatus = false;
    public Boolean EURestatus = false;
    public Boolean JPYestatus = false;
    public string _monedaEscogida;
    private Button btnCerrar;

    public Form2(string monedaEscogida) {
        this._monedaEscogida = monedaEscogida;
        lblMensaje = new Label();
        btnCerrar = new Button();
        InitializeComponent();
        inicializarComponentes();  
    }

    private void inicializarComponentes() {
        this.Size = new Size(300, 230);
        lblMensaje.Text = "";
        lblMensaje.AutoSize = true;
        lblMensaje.Location = new Point(80, 80);

        //Boton Cerrar
        btnCerrar.Text = "Cerrar";
        btnCerrar.AutoSize = true;
        btnCerrar.Location = new Point(100, 160);
        btnCerrar.Click += new EventHandler(btnCerrarVentana_Click);

        //Peso MXN
        MXN = new CheckBox();
        MXN.AutoSize = true;
        MXN.Location = new Point(10, 10);
        MXN.Text = ("Peso mexicano");
        if (_monedaEscogida != "MXN") {
            this.Controls.Add(MXN);
        }

        //Dolar USD
        USD = new CheckBox();
        USD.AutoSize = true;
        USD.Location = new Point(10, 40);
        USD.Text = ("Dolar estadounidense");
        if (_monedaEscogida != "USD") {
            this.Controls.Add(USD);
        }

        //Dolar CAD
        CAD = new CheckBox();
        CAD.AutoSize = true;
        CAD.Location = new Point(10, 70);
        CAD.Text = ("Dolar canadiense");
        if (_monedaEscogida != "CAD") {
            this.Controls.Add(CAD);
        }

        //Euro EUR
        EUR = new CheckBox();
        EUR.AutoSize = true;
        EUR.Location = new Point(10, 100);
        EUR.Text = ("Euro");
        if (_monedaEscogida != "EUR") {
            this.Controls.Add(EUR);
        }

        //Yen JPY
        JPY = new CheckBox();
        JPY.AutoSize = true;
        JPY.Location = new Point(10, 130);
        JPY.Text = ("Yen japones");
        if (_monedaEscogida != "JPY") {
            this.Controls.Add(JPY);
        }
        this.Controls.Add(lblMensaje);
        this.Controls.Add(btnCerrar);
    }

    private void btnCerrarVentana_Click(Object sender, EventArgs e) {
        this.DialogResult = DialogResult.OK;
        this.Close();
    }
}