//Programa de conversion de monedas: MXN, USD, CAD, EUR, JPY
namespace Introduccion;

public partial class Form1 : Form
{
    //Primero agregamos las etiquetas con sus respectivos campos de texto de cada moneda a convertir
    Label? lblMXN;
    Label? lblUSD;
    Label? lblCAD;
    Label? lblEUR;
    Label? lblJPY;
    TextBox? txtMXN;
    TextBox? txtUSD;
    TextBox? txtCAD;
    TextBox? txtEUR;
    TextBox? txtJPY;
    //ComboBox para elegir la moneda y un TextBox para especificar el monto a convertir
    Label? lblMoneda;
    ComboBox? cmbMoneda;
    Label? lblMonto;
    TextBox? txtMonto;
    //String para guardar la moneda que el usuario haya escogido
    public string monedaEscogida = "";
    public Boolean MXNestatus;
    public Boolean USDestatus;
    public Boolean CADestatus;
    public Boolean EURestatus;
    public Boolean JPYestatus;
    //Declaamos el boton calcular que sera el respnsable de accionar el evento para la conversion
    Button? btnCalcular;
    Label? lblConversion;



    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
    }

    public void InicializarComponentes(){
        this.Size = new Size(300, 350);
        //Moneda MXN
        lblMXN = new Label();
        lblMXN.Text = "Peso mexicano";
        lblMXN.AutoSize = true;
        lblMXN.Location = new Point(10, 100);
        lblMXN.Visible = false;
        txtMXN = new TextBox();
        txtMXN.Size = new Size(100, 20);
        txtMXN.Location = new Point(150, 120);
        txtMXN.Visible = false;
        //Dolar USD
        lblUSD = new Label();
        lblUSD.Text = "Dolar estadounidense";
        lblUSD.AutoSize = true;
        lblUSD.Location = new Point(10, 120);
        lblUSD.Visible = false;
        txtUSD = new TextBox();
        txtUSD.Size = new Size(100, 20);
        txtUSD.Location = new Point(150, 135);
        txtUSD.Visible = false;
        //Dolar CAD
        lblCAD = new Label();
        lblCAD.Text = "Dolar canadiense";
        lblCAD.AutoSize = true;
        lblCAD.Location = new Point(10, 140);
        lblCAD.Visible = false;
        txtCAD = new TextBox();
        txtCAD.Size = new Size(100, 20);
        txtCAD.Location = new Point(150, 150);
        txtCAD.Visible = false;
        //Euro EUR
        lblEUR = new Label();
        lblEUR.Text = "Euro";
        lblEUR.AutoSize = true;
        lblEUR.Location = new Point(10, 160);
        lblEUR.Visible = false;
        txtEUR = new TextBox();
        txtEUR.Size = new Size(100, 20);
        txtEUR.Location = new Point(150, 175);
        txtEUR.Visible = false;
        //Yen JPY
        lblJPY = new Label();
        lblJPY.Text = "Yen japones";
        lblJPY.AutoSize = true;
        lblJPY.Location = new Point(10, 180);
        lblJPY.Visible = false;
        txtJPY = new TextBox();
        txtJPY.Size = new Size(100, 20);
        txtJPY.Location = new Point(150, 200);
        txtJPY.Visible = false;
        //Etiqueta Moneda
        lblMoneda = new Label();
        lblMoneda.Text = "Moneda";
        lblMoneda.AutoSize = true;
        lblMoneda.Location = new Point(10, 10);
        //Combobox donde agregamos los tipos de monedas que estan disponibles
        cmbMoneda = new ComboBox();
        cmbMoneda.Size = new Size(160, 20);
        cmbMoneda.Items.Add("Peso mexicano");
        cmbMoneda.Items.Add("Dolar estadounidense");
        cmbMoneda.Items.Add("Dolar canadiense");
        cmbMoneda.Items.Add("Euro");
        cmbMoneda.Items.Add("Yen japones");
        cmbMoneda.SelectedValueChanged += new EventHandler(cmbMoneda_ValueChanged);
        cmbMoneda.Location = new Point(10, 40);
        //Etiqueta Monto
        lblMonto = new Label();
        lblMonto.Text = "Monto";
        lblMonto.AutoSize = true;
        lblMonto.Location = new Point(175, 10);
        //TextBox Monto
        txtMonto = new TextBox();
        txtMonto.Text = "";
        txtMonto.Size = new Size(100, 20);
        txtMonto.Location = new Point(175, 30);
        //Boton Calcular al que le pasamos el evento para accionar
        btnCalcular = new Button();
        btnCalcular.Text = "Calcular";
        btnCalcular.Size = new Size(100, 25);
        btnCalcular.Location = new Point(175, 77);
        btnCalcular.Click += new EventHandler(btnVentana_Click);
        //Etiqueta Conversion
        lblConversion = new Label();
        lblConversion.Text = "Conversion";
        lblConversion.AutoSize = true;
        lblConversion.Location = new Point(10, 110);

        this.Controls.Add(lblMXN);
        this.Controls.Add(lblUSD);
        this.Controls.Add(lblCAD);
        this.Controls.Add(lblEUR);
        this.Controls.Add(lblJPY);
        this.Controls.Add(txtMXN);
        this.Controls.Add(txtUSD);
        this.Controls.Add(txtCAD);
        this.Controls.Add(txtEUR);
        this.Controls.Add(txtJPY);
        this.Controls.Add(lblMoneda);
        this.Controls.Add(cmbMoneda);
        this.Controls.Add(lblMonto);
        this.Controls.Add(txtMonto);
        this.Controls.Add(btnCalcular);
        this.Controls.Add(lblConversion);
    }

    private void btnVentana_Click(Object sender, EventArgs e) {
        Form2 formVentana = new Form2(monedaEscogida);

        if (formVentana.ShowDialog() == DialogResult.OK) {
            txtMXN.Visible = false;
            lblMXN.Visible = false;
            txtUSD.Visible = false;
            lblUSD.Visible = false;
            txtCAD.Visible = false;
            lblCAD.Visible = false;
            txtEUR.Visible = false;
            lblEUR.Visible = false;
            txtJPY.Visible = false;
            lblJPY.Visible = false;

            Label lblAgregado = new Label();
            lblAgregado.Text = formVentana.lblMensaje.Text;
            lblAgregado.AutoSize = true;
            lblAgregado.Location = new Point(10, 20);
            lblAgregado.Visible = false;

            if (txtMonto.Text != null && double.Parse(txtMonto.Text) > 0) {
                if (formVentana.MXN.Checked == true) {
                    txtMXN.Visible = true;
                    lblMXN.Visible = true;
                    if (monedaEscogida == "USD") {
                        txtMXN.Text = "$" + (double.Parse(txtMonto.Text) * 21.23).ToString();
                    }
                    if (monedaEscogida == "CAD") {
                        txtMXN.Text = "$" + (double.Parse(txtMonto.Text) * 16.55).ToString();
                    }
                    if (monedaEscogida == "EUR") {
                        txtMXN.Text = "$" + (double.Parse(txtMonto.Text) * 23.96).ToString();
                    }
                    if (monedaEscogida == "JPY") {
                        txtMXN.Text = "$" + (double.Parse(txtMonto.Text) * 0.1878).ToString();
                    }
                }

                if (formVentana.USD.Checked == true) {
                    txtUSD.Visible = true;
                    lblUSD.Visible = true;
                    if (monedaEscogida == "MXN") {
                        txtUSD.Text = "$" + (double.Parse(txtMonto.Text) * 0.05).ToString();
                    }
                    if (monedaEscogida == "CAD") {
                        txtUSD.Text = "$" + (double.Parse(txtMonto.Text) * 0.78).ToString();
                    }
                    if (monedaEscogida == "EUR") {
                        txtUSD.Text = "$" + (double.Parse(txtMonto.Text) * 1.13).ToString();
                    }
                    if (monedaEscogida == "JPY") {
                        txtUSD.Text = "$" + (double.Parse(txtMonto.Text) * 0.0088).ToString();
                    }
                }

                if (formVentana.CAD.Checked == true) {
                    txtCAD.Visible = true;
                    lblCAD.Visible = true;
                    if (monedaEscogida == "USD") {
                        txtCAD.Text = "$" + (double.Parse(txtMonto.Text) * 1.28).ToString();
                    }
                    if (monedaEscogida == "MXN") {
                        txtCAD.Text = "$" + (double.Parse(txtMonto.Text) * 0.06).ToString();
                    }
                    if (monedaEscogida == "EUR") {
                        txtCAD.Text = "$" + (double.Parse(txtMonto.Text) * 1.45).ToString();
                    }
                    if (monedaEscogida == "JPY") {
                        txtCAD.Text = "$" + (double.Parse(txtMonto.Text) * 0.0113).ToString();
                    }
                }

                if (formVentana.EUR.Checked == true) {
                    txtEUR.Visible = true;
                    lblEUR.Visible = true;
                    if (monedaEscogida == "USD") {
                        txtEUR.Text = "€" + (double.Parse(txtMonto.Text) * 0.89).ToString();
                    }
                    if (monedaEscogida == "CAD") {
                        txtEUR.Text = "€" + (double.Parse(txtMonto.Text) * 0.69).ToString();
                    }
                    if (monedaEscogida == "MXN") {
                        txtEUR.Text = "€" + (double.Parse(txtMonto.Text) * 0.04).ToString();
                    }
                    if (monedaEscogida == "JPY") {
                        txtEUR.Text = "€" + (double.Parse(txtMonto.Text) * 0.0078).ToString();
                    }
                }

                if (formVentana.JPY.Checked == true) {
                    txtJPY.Visible = true;
                    lblJPY.Visible = true;
                    if (monedaEscogida == "USD") {
                        txtJPY.Text = "¥" + (double.Parse(txtMonto.Text) * 113.05).ToString();
                    }
                    if (monedaEscogida == "CAD") {
                        txtJPY.Text = "¥" + (double.Parse(txtMonto.Text) * 88.12).ToString();
                    }
                    if (monedaEscogida == "EUR") {
                        txtJPY.Text = "¥" + (double.Parse(txtMonto.Text) * 127.56).ToString();
                    }
                    if (monedaEscogida == "MXN") {
                        txtJPY.Text = "¥" + (double.Parse(txtMonto.Text) * 5.32).ToString();
                    }
                }
            }
            this.Controls.Add(lblAgregado);
        }
    }

    private void cmbMoneda_ValueChanged(object sender, EventArgs e) {
        if (cmbMoneda.SelectedItem != null && txtMonto != null) {
            
            if (cmbMoneda.SelectedItem.ToString() == "Peso mexicano") {
                btnCalcular.Visible = true;
                monedaEscogida = "MXN";
            }
            else if (cmbMoneda.SelectedItem.ToString() == "Dolar estadounidense") {
                btnCalcular.Visible = true;
                monedaEscogida = "USD";
            }
            else if (cmbMoneda.SelectedItem.ToString() == "Dolar canadiense") {
                btnCalcular.Visible = true;
                monedaEscogida = "CAD";
            }
            else if (cmbMoneda.SelectedItem.ToString() == "Euro") {
                btnCalcular.Visible = true;
                monedaEscogida = "EUR";
            }
            else if (cmbMoneda.SelectedItem.ToString() == "Yen japones") {
                btnCalcular.Visible = true;
                monedaEscogida = "JPY";
            }
        }
    }
}