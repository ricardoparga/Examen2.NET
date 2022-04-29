//Programa de conversion de monedas: MXN, USD, CAD, EUR, JPY
namespace Introduccion;

public partial class Form1 : Form
{
    //Primero agregamos las etiquetas con sus respectivos campos de texto de cada moneda a convertir
    Label? lblMXM;
    Label? lblUSD;
    Label? lblCAD;
    Label? lblEUR;
    Label? lblJPY;
    TextBox? txtMXM;
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


    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
    }

    public void InicializarComponentes(){
        
    }
}
