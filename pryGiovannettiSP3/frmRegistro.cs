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
        //Static para que no se modifiquen las variables
        //New es instanciar en la memoria     
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

        struct datoRepuesto
        {
            public string Marca;
            public string Origen;
            public int Numero;
            public string Descripcion;
            public int Precio;
        }

        //indice PARA FILAS (primero se nombran las filas, luego las columnas)
        //otro indice o la posición por defecto para COLUMNAS

        string[,] matRespuesto = new string[100, 5];

        int indiceGrabar = 0;


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
                txtDescripcion.Enabled = true;
            }
            else
            {
                txtDescripcion.Enabled = false;
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (txtDescripcion.Text != "")
            {
                btnIngresar.Enabled = true;
                txtPrecio.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
                txtPrecio.Enabled = false;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Otorgamos valor a las variables 
            Marca = cmbMarca.Text;
            Origen = cmbOrigen.Text;
            Numero = Convert.ToInt32(mtbNumeroRespuesto.Text.Trim());
            Descripcion = txtDescripcion.Text;
            Precio = Convert.ToInt32(txtPrecio.Text.Trim());

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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cmbMarca.SelectedIndex = -1;
            cmbOrigen.SelectedIndex = -1;
            mtbNumeroRespuesto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
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

        private void mtbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //se utilizara para acumular los valores y mostrarlos
        string Resultado = "";
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Resultado = ""; //Limpio las variables
            MarcaSeleccionada = cmbMarca.Text;

         
            if (!chkNacional.Checked && !chkImportado.Checked)
            {
                MessageBox.Show("Debe seleccionar un origen (Nacional o Importado).", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int contadorCoincidencias = 0;

            // Recorre el array de datos cargados (hasta el índice actual)
            // El 'indice' global indica cuántos elementos válidos hay cargados en los arrays.
            for (int i = 0; i < indice; i++)
            {
                // Aplica los criterios de filtro
                // Verifica si la Marca y el Origen coinciden con los arrays de datos.
                if (vecMarca[i] == MarcaSeleccionada && vecOrigen[i] == OrigenSeleccionado)
                {
                    //  Concatenar la información del repuesto que coincide
                    Resultado += $"Marca: {vecMarca[i]}, Origen: {vecOrigen[i]}, Número: {vecNumero[i]}, Descripción: {vecDescripcion[i]}, Precio: {vecPrecio[i]:C}\r\n";
                    contadorCoincidencias++;
                }
            }

            // Mostrar el resultado
            if (contadorCoincidencias > 0)
            {
               
                MessageBox.Show(Resultado, $"Resultados de la consulta ({contadorCoincidencias})",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontraron repuestos con los criterios seleccionados.", "Sin resultados",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

            //Cargar datos en grilla desde la matriz
            CargadorDatos();
            MessageBox.Show("Datos Cargados");

            List<string> Origenes = new List<string>();

            for (int filas = 0; filas < matRespuesto.GetLength(0); filas++)
            {
                dgvDatos.Rows.Add(matRespuesto[filas, 0],
                    matRespuesto[filas, 1],
                    matRespuesto[filas, 2],
                    matRespuesto[filas, 3],
                    matRespuesto[filas, 4]);

                if (!Origenes.Contains(matRespuesto[filas, 1]))
                {
                    Origenes.Add(matRespuesto[filas, 1]);
                }

            }
        }
  private void CargadorDatos()
        {
            // Fila 0
            matRespuesto[0, 0] = "TechNova";
            matRespuesto[0, 1] = "Japón";
            matRespuesto[0, 2] = "54321";
            matRespuesto[0, 3] = "499.99";
            matRespuesto[0, 4] = "Smartphone de alta gama con cámara triple.";

            // Fila 1
            matRespuesto[1, 0] = "EcoWear";
            matRespuesto[1, 1] = "Vietnam";
            matRespuesto[1, 2] = "98765";
            matRespuesto[1, 3] = "29.50";
            matRespuesto[1, 4] = "Camiseta de algodón orgánico, talla M.";

            // Fila 2
            matRespuesto[2, 0] = "AeroWheels";
            matRespuesto[2, 1] = "EE. UU.";
            matRespuesto[2, 2] = "11223";
            matRespuesto[2, 3] = "1250.00";
            matRespuesto[2, 4] = "Bicicleta de montaña con suspensión completa.";

            // Fila 3
            matRespuesto[3, 0] = "GourmetChef";
            matRespuesto[3, 1] = "Francia";
            matRespuesto[3, 2] = "67890";
            matRespuesto[3, 3] = "45.99";
            matRespuesto[3, 4] = "Set de cuchillos de chef de acero inoxidable.";

            // Fila 4
            matRespuesto[4, 0] = "PowerUp";
            matRespuesto[4, 1] = "China";
            matRespuesto[4, 2] = "33445";
            matRespuesto[4, 3] = "19.95";
            matRespuesto[4, 4] = "Batería portátil de 10000mAh.";

            // Fila 5
            matRespuesto[5, 0] = "AquaFlow";
            matRespuesto[5, 1] = "México";
            matRespuesto[5, 2] = "20210";
            matRespuesto[5, 3] = "15.00";
            matRespuesto[5, 4] = "Filtro de agua de repuesto, pack de 3.";

            // Fila 6
            matRespuesto[6, 0] = "StyleFit";
            matRespuesto[6, 1] = "Italia";
            matRespuesto[6, 2] = "76543";
            matRespuesto[6, 3] = "89.00";
            matRespuesto[6, 4] = "Zapatos deportivos de cuero, color negro.";

            // Fila 7
            matRespuesto[7, 0] = "HomeLux";
            matRespuesto[7, 1] = "Alemania";
            matRespuesto[7, 2] = "88990";
            matRespuesto[7, 3] = "249.99";
            matRespuesto[7, 4] = "Aspiradora robótica con mapeo láser.";

            // Fila 8
            matRespuesto[8, 0] = "SweetTreats";
            matRespuesto[8, 1] = "Argentina";
            matRespuesto[8, 2] = "41414";
            matRespuesto[8, 3] = "5.50";
            matRespuesto[8, 4] = "Caja de alfajores artesanales (6 unidades).";

            // Fila 9
            matRespuesto[9, 0] = "OfficePro";
            matRespuesto[9, 1] = "Canadá";
            matRespuesto[9, 2] = "10010";
            matRespuesto[9, 3] = "120.75";
            matRespuesto[9, 4] = "Silla ergonómica de escritorio, color gris.";

            // Fila 10
            matRespuesto[10, 0] = "MediCare";
            matRespuesto[10, 1] = "India";
            matRespuesto[10, 2] = "90001";
            matRespuesto[10, 3] = "8.25";
            matRespuesto[10, 4] = "Termómetro digital de precisión.";

            // Fila 11
            matRespuesto[11, 0] = "UrbanArt";
            matRespuesto[11, 1] = "Brasil";
            matRespuesto[11, 2] = "25813";
            matRespuesto[11, 3] = "35.00";
            matRespuesto[11, 4] = "Lienzo para pintar, 50x70 cm.";

            // Fila 12
            matRespuesto[12, 0] = "SoundBliss";
            matRespuesto[12, 1] = "Corea del Sur";
            matRespuesto[12, 2] = "60606";
            matRespuesto[12, 3] = "189.99";
            matRespuesto[12, 4] = "Auriculares inalámbricos con cancelación de ruido.";

            // Fila 13
            matRespuesto[13, 0] = "AgriGrow";
            matRespuesto[13, 1] = "España";
            matRespuesto[13, 2] = "71717";
            matRespuesto[13, 3] = "12.90";
            matRespuesto[13, 4] = "Semillas orgánicas de tomate cherry.";

            // Fila 14
            matRespuesto[14, 0] = "FlexiPly";
            matRespuesto[14, 1] = "Suecia";
            matRespuesto[14, 2] = "82828";
            matRespuesto[14, 3] = "55.00";
            matRespuesto[14, 4] = "Juego de bloques de construcción de madera.";

            // Fila 15
            matRespuesto[15, 0] = "DataVault";
            matRespuesto[15, 1] = "Taiwán";
            matRespuesto[15, 2] = "93939";
            matRespuesto[15, 3] = "79.99";
            matRespuesto[15, 4] = "Disco duro externo de 1TB.";

            // Fila 16
            matRespuesto[16, 0] = "PuraVida";
            matRespuesto[16, 1] = "Costa Rica";
            matRespuesto[16, 2] = "10101";
            matRespuesto[16, 3] = "6.50";
            matRespuesto[16, 4] = "Café molido de origen, 250g.";

            // Fila 17
            matRespuesto[17, 0] = "ProGears";
            matRespuesto[17, 1] = "Reino Unido";
            matRespuesto[17, 2] = "12121";
            matRespuesto[17, 3] = "450.00";
            matRespuesto[17, 4] = "Taladro percutor profesional.";

            // Fila 18
            matRespuesto[18, 0] = "SoftDream";
            matRespuesto[18, 1] = "Portugal";
            matRespuesto[18, 2] = "13131";
            matRespuesto[18, 3] = "39.99";
            matRespuesto[18, 4] = "Almohada viscoelástica.";

            // Fila 19
            matRespuesto[19, 0] = "AutoShine";
            matRespuesto[19, 1] = "EE. UU.";
            matRespuesto[19, 2] = "14141";
            matRespuesto[19, 3] = "18.75";
            matRespuesto[19, 4] = "Cera protectora para carrocería.";

            // Fila 20
            matRespuesto[20, 0] = "TechNova";
            matRespuesto[20, 1] = "Japón";
            matRespuesto[20, 2] = "54322";
            matRespuesto[20, 3] = "699.99";
            matRespuesto[20, 4] = "Laptop ultradelgada 13 pulgadas.";

            // Fila 21
            matRespuesto[21, 0] = "EcoWear";
            matRespuesto[21, 1] = "Vietnam";
            matRespuesto[21, 2] = "98766";
            matRespuesto[21, 3] = "45.00";
            matRespuesto[21, 4] = "Pantalón deportivo transpirable, talla L.";

            // Fila 22
            matRespuesto[22, 0] = "AeroWheels";
            matRespuesto[22, 1] = "EE. UU.";
            matRespuesto[22, 2] = "11224";
            matRespuesto[22, 3] = "850.50";
            matRespuesto[22, 4] = "Casco de bicicleta aerodinámico.";

            // Fila 23
            matRespuesto[23, 0] = "GourmetChef";
            matRespuesto[23, 1] = "Francia";
            matRespuesto[23, 2] = "67891";
            matRespuesto[23, 3] = "15.90";
            matRespuesto[23, 4] = "Molde de silicona para repostería.";

            // Fila 24
            matRespuesto[24, 0] = "PowerUp";
            matRespuesto[24, 1] = "China";
            matRespuesto[24, 2] = "33446";
            matRespuesto[24, 3] = "9.99";
            matRespuesto[24, 4] = "Cable USB-C de carga rápida, 2 metros.";
        }
    }

}

