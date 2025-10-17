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
            lblMacaDeRespuesto.Location = new Point(11, 76);
            lblMacaDeRespuesto.Name = "lblMacaDeRespuesto";
            lblMacaDeRespuesto.Size = new Size(166, 23);
            lblMacaDeRespuesto.TabIndex = 0;
            lblMacaDeRespuesto.Text = "Marca De Respuesto";
            // 
            // lblOrigenDeRespuesto
            // 
            lblOrigenDeRespuesto.AutoSize = true;
            lblOrigenDeRespuesto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrigenDeRespuesto.Location = new Point(11, 128);
            lblOrigenDeRespuesto.Name = "lblOrigenDeRespuesto";
            lblOrigenDeRespuesto.Size = new Size(171, 23);
            lblOrigenDeRespuesto.TabIndex = 1;
            lblOrigenDeRespuesto.Text = "Origen De Respuesto";
            // 
            // lblNumeroDelRespuesto
            // 
            lblNumeroDelRespuesto.AutoSize = true;
            lblNumeroDelRespuesto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroDelRespuesto.Location = new Point(11, 187);
            lblNumeroDelRespuesto.Name = "lblNumeroDelRespuesto";
            lblNumeroDelRespuesto.Size = new Size(186, 23);
            lblNumeroDelRespuesto.TabIndex = 2;
            lblNumeroDelRespuesto.Text = "Numero Del Respuesto";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(11, 229);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(98, 23);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecioDelRespuesto
            // 
            lblPrecioDelRespuesto.AutoSize = true;
            lblPrecioDelRespuesto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioDelRespuesto.Location = new Point(14, 285);
            lblPrecioDelRespuesto.Name = "lblPrecioDelRespuesto";
            lblPrecioDelRespuesto.Size = new Size(57, 23);
            lblPrecioDelRespuesto.TabIndex = 4;
            lblPrecioDelRespuesto.Text = "Precio";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(181, 288);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(27, 20);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "---";
            // 
            // cmbMarca
            // 
            cmbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "(P) Peugeot", "(F) Fiat", "(R) Renault" });
            cmbMarca.Location = new Point(181, 68);
            cmbMarca.Margin = new Padding(3, 4, 3, 4);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(151, 28);
            cmbMarca.TabIndex = 6;
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // cmbOrigen
            // 
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigen.Enabled = false;
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "(N) Nacional", "(I) Importado" });
            cmbOrigen.Location = new Point(181, 120);
            cmbOrigen.Margin = new Padding(3, 4, 3, 4);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(151, 28);
            cmbOrigen.TabIndex = 7;
            cmbOrigen.SelectedIndexChanged += cmbOrigen_SelectedIndexChanged;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(205, 221);
            txtDescripcion.Margin = new Padding(3, 4, 3, 4);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(127, 27);
            txtDescripcion.TabIndex = 8;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // mtbNumeroRespuesto
            // 
            mtbNumeroRespuesto.Enabled = false;
            mtbNumeroRespuesto.Location = new Point(205, 179);
            mtbNumeroRespuesto.Margin = new Padding(3, 4, 3, 4);
            mtbNumeroRespuesto.Mask = "999999";
            mtbNumeroRespuesto.Name = "mtbNumeroRespuesto";
            mtbNumeroRespuesto.Size = new Size(127, 27);
            mtbNumeroRespuesto.TabIndex = 9;
            mtbNumeroRespuesto.ValidatingType = typeof(int);
            mtbNumeroRespuesto.MaskInputRejected += mtbNumeroRespuesto_MaskInputRejected;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(73, 352);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 44);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Enabled = false;
            btnIngresar.Location = new Point(197, 352);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(106, 44);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 432);
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
            Margin = new Padding(3, 4, 3, 4);
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
