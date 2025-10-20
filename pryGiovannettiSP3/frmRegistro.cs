using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pryGiovannettiSP3
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        //Definicion de variables globales
        float Precio = 0;
        public static string[] vecRespuesto = new string[100];
        string Marca;
        string Origen;
        int Numero;
        string Descripcion;
        int indice = 0;

        //Declaración arrays
        public static string[] vecRepuesto = new string[100];
        public static string[] vecMarca = new string[100];
        public static string[] vecOrigen = new string[100];
        public static int[] vecNumero = new int[100];
        public static string[] vecDescripcion = new string[100];
        public static float[] vecPrecio = new float[100];

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarca.SelectedIndex != -1)
            {
                cmbOrigen.Enabled = true;
            }
            else
            {
                cmbOrigen.Enabled = false;
            }
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrigen.SelectedIndex != -1)
            {
                mtbNumeroRespuesto.Enabled = true;
            }
            else
            {
                mtbNumeroRespuesto.Enabled = false;
            }
        }

        private void mtbNumeroRespuesto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbNumeroRespuesto.Text != "")
            {
                btnIngresar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
            {
                btnIngresar.Enabled = true;
                lblPrecio.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
                lblPrecio.Enabled = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Otorgamos valor a las variables 
            Marca = cmbMarca.Text;
            Origen = cmbOrigen.Text;
            Numero = Convert.ToInt32(mtbNumeroRespuesto.Text.Trim());
            Descripcion = txtDescripcion.Text;
            Precio = Convert.ToInt32(lblPrecio.Text.Trim());

            //Validamos que el array no este lleno
            if (indice >= vecNumero.Length)
            {
                MessageBox.Show("El array se encuentra lleno, no se puede grabar más datos.", "Array lleno",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnIngresar.Enabled = false; //Deshabilitamos el btnIngresar para no agregar ningún dato nuevo
                return; //detiene el el procedimiento para que no grabe ningún dato
            }

            //Validar que no haya un número repetido en el array
            int i = 0;
            bool existe = false;

            while (i < indice && existe == false)   // recorre solo hasta la cantidad cargada y existe sea falso
            {
                if (vecNumero[i] == Numero)
                {
                    existe = true;
                }
                i++;
            }
            if (existe == true) //Validamos si sale del while por repetir número o no 
            {
                MessageBox.Show("Ya existe un repuesto con ese número.", "Número repetido",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Grabamos los datos
                vecMarca[indice] = Marca;
                vecOrigen[indice] = Origen;
                vecNumero[indice] = Numero;
                vecDescripcion[indice] = Descripcion;
                vecPrecio[indice] = Precio;

                indice++;
            }

            vecRespuesto[indice] = "untexto";
            indice++;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbMarca.SelectedIndex = -1;
            cmbOrigen.SelectedIndex = -1;
            mtbNumeroRespuesto.Text = "";
            txtDescripcion.Text = "";
            lblPrecio.Text = "";
            cmbMarca.Focus();



        }

        //Declaración variables consultas
        int Indice = 0;
        string MarcaSeleccionada = "";
        string OrigenSeleccionado = "";

        private void cmbMarcaCta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarcaCta.SelectedIndex != -1)
            {
                chkNacional.Enabled = true;
                chkImportado.Enabled = true;
            }

        }

        private void chkNacional_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNacional.Checked == true)
            {
                OrigenSeleccionado = "(N) Nacional"; //Otorgamos valor a la variable OrigenSeleccionado
                btnConsultar.Enabled = true;
            }
            else
            {
                btnConsultar.Enabled = false;
            }
        }

        private void chkImportado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkImportado.Checked == true)
            {
                btnConsultar.Enabled = true;
                OrigenSeleccionado = "(I) Importado";
            }
            else
            {
                btnConsultar.Enabled = false;
            }
        }
        //se utilizara para acumular los valores y mostrarlos
        string Resultado = "";
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Resultado = ""; //Limpio las variables
            MarcaSeleccionada = cmbMarca.Text;

        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            cmbMarca.Items.Add("(P) Peugeot");
            cmbMarca.Items.Add("(F) Fiat");
            cmbMarca.Items.Add("(R) Renault");
            cmbOrigen.Items.Add("(N) Nacional");
            cmbOrigen.Items.Add("(I) Importado");
            cmbMarcaCta.Items.Add("(P) Peugeot");
            cmbMarcaCta.Items.Add("(F) Fiat");
            cmbMarcaCta.Items.Add("(R) Renault");
        }
    }
}

