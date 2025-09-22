namespace pryGiovannettiSP3
{
    partial class frmRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMacaDeRespuesto = new Label();
            lblOrigenDeRespuesto = new Label();
            lblNumeroDelRespuesto = new Label();
            lblDescripcion = new Label();
            lblPrecioDelRespuesto = new Label();
            lblPrecio = new Label();
            cmbMarca = new ComboBox();
            cmbOrigen = new ComboBox();
            txtDescripcion = new TextBox();
            mtbNumeroRespuesto = new MaskedTextBox();
            btnCancelar = new Button();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // lblMacaDeRespuesto
            // 
            lblMacaDeRespuesto.AutoSize = true;
            lblMacaDeRespuesto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMacaDeRespuesto.Location = new Point(10, 57);
            lblMacaDeRespuesto.Name = "lblMacaDeRespuesto";
            lblMacaDeRespuesto.Size = new Size(130, 17);
            lblMacaDeRespuesto.TabIndex = 0;
            lblMacaDeRespuesto.Text = "Marca De Respuesto";
            // 
            // lblOrigenDeRespuesto
            // 
            lblOrigenDeRespuesto.AutoSize = true;
            lblOrigenDeRespuesto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrigenDeRespuesto.Location = new Point(10, 96);
            lblOrigenDeRespuesto.Name = "lblOrigenDeRespuesto";
            lblOrigenDeRespuesto.Size = new Size(133, 17);
            lblOrigenDeRespuesto.TabIndex = 1;
            lblOrigenDeRespuesto.Text = "Origen De Respuesto";
            // 
            // lblNumeroDelRespuesto
            // 
            lblNumeroDelRespuesto.AutoSize = true;
            lblNumeroDelRespuesto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroDelRespuesto.Location = new Point(10, 140);
            lblNumeroDelRespuesto.Name = "lblNumeroDelRespuesto";
            lblNumeroDelRespuesto.Size = new Size(144, 17);
            lblNumeroDelRespuesto.TabIndex = 2;
            lblNumeroDelRespuesto.Text = "Numero Del Respuesto";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(10, 172);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(76, 17);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecioDelRespuesto
            // 
            lblPrecioDelRespuesto.AutoSize = true;
            lblPrecioDelRespuesto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioDelRespuesto.Location = new Point(12, 214);
            lblPrecioDelRespuesto.Name = "lblPrecioDelRespuesto";
            lblPrecioDelRespuesto.Size = new Size(44, 17);
            lblPrecioDelRespuesto.TabIndex = 4;
            lblPrecioDelRespuesto.Text = "Precio";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(158, 216);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(22, 15);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "---";
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "(P) Peugeot", "(F) Fiat", "(R) Renault" });
            cmbMarca.Location = new Point(158, 51);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(133, 23);
            cmbMarca.TabIndex = 6;
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // cmbOrigen
            // 
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigen.Enabled = false;
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "(N) Nacional", "(I) Importado" });
            cmbOrigen.Location = new Point(158, 90);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(133, 23);
            cmbOrigen.TabIndex = 7;
            cmbOrigen.SelectedIndexChanged += cmbOrigen_SelectedIndexChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(179, 166);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(112, 23);
            txtDescripcion.TabIndex = 8;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // mtbNumeroRespuesto
            // 
            mtbNumeroRespuesto.Enabled = false;
            mtbNumeroRespuesto.Location = new Point(179, 134);
            mtbNumeroRespuesto.Mask = "999999";
            mtbNumeroRespuesto.Name = "mtbNumeroRespuesto";
            mtbNumeroRespuesto.Size = new Size(112, 23);
            mtbNumeroRespuesto.TabIndex = 9;
            mtbNumeroRespuesto.ValidatingType = typeof(int);
            mtbNumeroRespuesto.MaskInputRejected += mtbNumeroRespuesto_MaskInputRejected;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(64, 264);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 33);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Enabled = false;
            btnIngresar.Location = new Point(172, 264);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(93, 33);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 324);
            Controls.Add(btnIngresar);
            Controls.Add(btnCancelar);
            Controls.Add(mtbNumeroRespuesto);
            Controls.Add(txtDescripcion);
            Controls.Add(cmbOrigen);
            Controls.Add(cmbMarca);
            Controls.Add(lblPrecio);
            Controls.Add(lblPrecioDelRespuesto);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNumeroDelRespuesto);
            Controls.Add(lblOrigenDeRespuesto);
            Controls.Add(lblMacaDeRespuesto);
            Name = "frmRegistro";
            Text = "Venta De Respuestos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMacaDeRespuesto;
        private Label lblOrigenDeRespuesto;
        private Label lblNumeroDelRespuesto;
        private Label lblDescripcion;
        private Label lblPrecioDelRespuesto;
        private Label lblPrecio;
        private ComboBox cmbMarca;
        private ComboBox cmbOrigen;
        private TextBox txtDescripcion;
        private MaskedTextBox mtbNumeroRespuesto;
        private Button btnCancelar;
        private Button btnIngresar;
    }
}
