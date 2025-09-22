namespace pryGiovannettiSP3
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        //Definicion de variables globales
        float precio = 0;
        public static string[] vecRespuesto = new string[100];
        string marca;
        string origen;
        int numero;
        string Descripcion;

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
            }
            else 
            {
                btnIngresar.Enabled = false;
            }
        }
    }
}
