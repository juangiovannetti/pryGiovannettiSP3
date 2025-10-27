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
            TabPage tpDatos;
            TabPage Consultas;
            lblMacaDeRespuesto = new Label();
            btnIngresar = new Button();
            lblOrigenDeRespuesto = new Label();
            btnCancelar = new Button();
            lblNumeroDelRespuesto = new Label();
            mtbNumeroRespuesto = new MaskedTextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblPrecioDelRespuesto = new Label();
            cmbOrigen = new ComboBox();
            lblPrecio = new Label();
            cmbMarca = new ComboBox();
            btnConsultar = new Button();
            lblMarcaDeRepuesto = new Label();
            lstDatos = new ListBox();
            lblOrigenDeRepuesto = new Label();
            chkImportado = new RadioButton();
            cmbMarcaCta = new ComboBox();
            chkNacional = new RadioButton();
            tpConsultar = new TabControl();
            tpGrilla = new TabPage();
            dgvDatos = new DataGridView();
            colMarcas = new DataGridViewTextBoxColumn();
            colOrigenes = new DataGridViewTextBoxColumn();
            colNumeros = new DataGridViewTextBoxColumn();
            colDescripciones = new DataGridViewTextBoxColumn();
            colPrecios = new DataGridViewTextBoxColumn();
            tpDatos = new TabPage();
            Consultas = new TabPage();
            tpDatos.SuspendLayout();
            Consultas.SuspendLayout();
            tpConsultar.SuspendLayout();
            tpGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // tpDatos
            // 
            tpDatos.Controls.Add(lblMacaDeRespuesto);
            tpDatos.Controls.Add(btnIngresar);
            tpDatos.Controls.Add(lblOrigenDeRespuesto);
            tpDatos.Controls.Add(btnCancelar);
            tpDatos.Controls.Add(lblNumeroDelRespuesto);
            tpDatos.Controls.Add(mtbNumeroRespuesto);
            tpDatos.Controls.Add(lblDescripcion);
            tpDatos.Controls.Add(txtDescripcion);
            tpDatos.Controls.Add(lblPrecioDelRespuesto);
            tpDatos.Controls.Add(cmbOrigen);
            tpDatos.Controls.Add(lblPrecio);
            tpDatos.Controls.Add(cmbMarca);
            tpDatos.Location = new Point(4, 24);
            tpDatos.Margin = new Padding(3, 2, 3, 2);
            tpDatos.Name = "tpDatos";
            tpDatos.Padding = new Padding(3, 2, 3, 2);
            tpDatos.Size = new Size(679, 296);
            tpDatos.TabIndex = 0;
            tpDatos.Text = "Datos";
            tpDatos.UseVisualStyleBackColor = true;
            // 
            // lblMacaDeRespuesto
            // 
            lblMacaDeRespuesto.AutoSize = true;
            lblMacaDeRespuesto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMacaDeRespuesto.Location = new Point(18, 18);
            lblMacaDeRespuesto.Name = "lblMacaDeRespuesto";
            lblMacaDeRespuesto.Size = new Size(130, 17);
            lblMacaDeRespuesto.TabIndex = 0;
            lblMacaDeRespuesto.Text = "Marca De Respuesto";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Gray;
            btnIngresar.Enabled = false;
            btnIngresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = SystemColors.ControlLightLight;
            btnIngresar.Location = new Point(180, 225);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(93, 33);
            btnIngresar.TabIndex = 11;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblOrigenDeRespuesto
            // 
            lblOrigenDeRespuesto.AutoSize = true;
            lblOrigenDeRespuesto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrigenDeRespuesto.Location = new Point(18, 57);
            lblOrigenDeRespuesto.Name = "lblOrigenDeRespuesto";
            lblOrigenDeRespuesto.Size = new Size(133, 17);
            lblOrigenDeRespuesto.TabIndex = 1;
            lblOrigenDeRespuesto.Text = "Origen De Respuesto";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Gray;
            btnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(72, 225);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 33);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNumeroDelRespuesto
            // 
            lblNumeroDelRespuesto.AutoSize = true;
            lblNumeroDelRespuesto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumeroDelRespuesto.Location = new Point(18, 101);
            lblNumeroDelRespuesto.Name = "lblNumeroDelRespuesto";
            lblNumeroDelRespuesto.Size = new Size(144, 17);
            lblNumeroDelRespuesto.TabIndex = 2;
            lblNumeroDelRespuesto.Text = "Numero Del Respuesto";
            // 
            // mtbNumeroRespuesto
            // 
            mtbNumeroRespuesto.Enabled = false;
            mtbNumeroRespuesto.Location = new Point(187, 95);
            mtbNumeroRespuesto.Mask = "999999";
            mtbNumeroRespuesto.Name = "mtbNumeroRespuesto";
            mtbNumeroRespuesto.Size = new Size(112, 23);
            mtbNumeroRespuesto.TabIndex = 9;
            mtbNumeroRespuesto.ValidatingType = typeof(int);
            mtbNumeroRespuesto.MaskInputRejected += mtbNumeroRespuesto_MaskInputRejected;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(18, 133);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(76, 17);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(187, 127);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(112, 23);
            txtDescripcion.TabIndex = 8;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // lblPrecioDelRespuesto
            // 
            lblPrecioDelRespuesto.AutoSize = true;
            lblPrecioDelRespuesto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioDelRespuesto.Location = new Point(18, 177);
            lblPrecioDelRespuesto.Name = "lblPrecioDelRespuesto";
            lblPrecioDelRespuesto.Size = new Size(44, 17);
            lblPrecioDelRespuesto.TabIndex = 4;
            lblPrecioDelRespuesto.Text = "Precio";
            // 
            // cmbOrigen
            // 
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigen.Enabled = false;
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "(N) Nacional", "(I) Importado" });
            cmbOrigen.Location = new Point(166, 51);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(133, 23);
            cmbOrigen.TabIndex = 7;
            cmbOrigen.SelectedIndexChanged += cmbOrigen_SelectedIndexChanged;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(166, 177);
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
            cmbMarca.Location = new Point(166, 12);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(133, 23);
            cmbMarca.TabIndex = 6;
            cmbMarca.SelectedIndexChanged += cmbMarca_SelectedIndexChanged;
            // 
            // Consultas
            // 
            Consultas.Controls.Add(btnConsultar);
            Consultas.Controls.Add(lblMarcaDeRepuesto);
            Consultas.Controls.Add(lstDatos);
            Consultas.Controls.Add(lblOrigenDeRepuesto);
            Consultas.Controls.Add(chkImportado);
            Consultas.Controls.Add(cmbMarcaCta);
            Consultas.Controls.Add(chkNacional);
            Consultas.Location = new Point(4, 24);
            Consultas.Margin = new Padding(3, 2, 3, 2);
            Consultas.Name = "Consultas";
            Consultas.Padding = new Padding(3, 2, 3, 2);
            Consultas.Size = new Size(679, 296);
            Consultas.TabIndex = 1;
            Consultas.Text = "consultas";
            Consultas.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Gray;
            btnConsultar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsultar.ForeColor = SystemColors.ControlLightLight;
            btnConsultar.Location = new Point(134, 222);
            btnConsultar.Margin = new Padding(3, 2, 3, 2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(101, 28);
            btnConsultar.TabIndex = 19;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblMarcaDeRepuesto
            // 
            lblMarcaDeRepuesto.AutoSize = true;
            lblMarcaDeRepuesto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarcaDeRepuesto.Location = new Point(16, 17);
            lblMarcaDeRepuesto.Name = "lblMarcaDeRepuesto";
            lblMarcaDeRepuesto.Size = new Size(47, 19);
            lblMarcaDeRepuesto.TabIndex = 13;
            lblMarcaDeRepuesto.Text = "Marca";
            // 
            // lstDatos
            // 
            lstDatos.FormattingEnabled = true;
            lstDatos.ItemHeight = 15;
            lstDatos.Location = new Point(16, 124);
            lstDatos.Margin = new Padding(3, 2, 3, 2);
            lstDatos.Name = "lstDatos";
            lstDatos.Size = new Size(219, 79);
            lstDatos.TabIndex = 18;
            // 
            // lblOrigenDeRepuesto
            // 
            lblOrigenDeRepuesto.AutoSize = true;
            lblOrigenDeRepuesto.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrigenDeRepuesto.Location = new Point(16, 56);
            lblOrigenDeRepuesto.Name = "lblOrigenDeRepuesto";
            lblOrigenDeRepuesto.Size = new Size(51, 19);
            lblOrigenDeRepuesto.TabIndex = 14;
            lblOrigenDeRepuesto.Text = "Origen";
            // 
            // chkImportado
            // 
            chkImportado.AutoSize = true;
            chkImportado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkImportado.Location = new Point(102, 78);
            chkImportado.Margin = new Padding(3, 2, 3, 2);
            chkImportado.Name = "chkImportado";
            chkImportado.Size = new Size(92, 23);
            chkImportado.TabIndex = 17;
            chkImportado.TabStop = true;
            chkImportado.Text = "Importado";
            chkImportado.UseVisualStyleBackColor = true;
            chkImportado.CheckedChanged += chkImportado_CheckedChanged;
            // 
            // cmbMarcaCta
            // 
            cmbMarcaCta.FormattingEnabled = true;
            cmbMarcaCta.Items.AddRange(new object[] { "Fiat (F)", "Peugeot (P)", "Renault (R)" });
            cmbMarcaCta.Location = new Point(102, 11);
            cmbMarcaCta.Margin = new Padding(3, 2, 3, 2);
            cmbMarcaCta.Name = "cmbMarcaCta";
            cmbMarcaCta.Size = new Size(133, 23);
            cmbMarcaCta.TabIndex = 15;
            cmbMarcaCta.SelectedIndexChanged += cmbMarcaCta_SelectedIndexChanged;
            // 
            // chkNacional
            // 
            chkNacional.AutoSize = true;
            chkNacional.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkNacional.Location = new Point(102, 48);
            chkNacional.Margin = new Padding(3, 2, 3, 2);
            chkNacional.Name = "chkNacional";
            chkNacional.Size = new Size(79, 23);
            chkNacional.TabIndex = 16;
            chkNacional.TabStop = true;
            chkNacional.Text = "Nacional";
            chkNacional.UseVisualStyleBackColor = true;
            chkNacional.CheckedChanged += chkNacional_CheckedChanged;
            // 
            // tpConsultar
            // 
            tpConsultar.Controls.Add(tpDatos);
            tpConsultar.Controls.Add(Consultas);
            tpConsultar.Controls.Add(tpGrilla);
            tpConsultar.Location = new Point(10, 9);
            tpConsultar.Margin = new Padding(3, 2, 3, 2);
            tpConsultar.Name = "tpConsultar";
            tpConsultar.SelectedIndex = 0;
            tpConsultar.Size = new Size(687, 324);
            tpConsultar.TabIndex = 12;
            // 
            // tpGrilla
            // 
            tpGrilla.Controls.Add(dgvDatos);
            tpGrilla.Location = new Point(4, 24);
            tpGrilla.Margin = new Padding(3, 2, 3, 2);
            tpGrilla.Name = "tpGrilla";
            tpGrilla.Padding = new Padding(3, 2, 3, 2);
            tpGrilla.Size = new Size(679, 296);
            tpGrilla.TabIndex = 2;
            tpGrilla.Text = "Grilla";
            tpGrilla.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colMarcas, colOrigenes, colNumeros, colDescripciones, colPrecios });
            dgvDatos.Location = new Point(5, 4);
            dgvDatos.Margin = new Padding(3, 2, 3, 2);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(592, 141);
            dgvDatos.TabIndex = 13;
            // 
            // colMarcas
            // 
            colMarcas.HeaderText = "Marca";
            colMarcas.MinimumWidth = 6;
            colMarcas.Name = "colMarcas";
            colMarcas.Width = 125;
            // 
            // colOrigenes
            // 
            colOrigenes.HeaderText = "Origen";
            colOrigenes.MinimumWidth = 6;
            colOrigenes.Name = "colOrigenes";
            colOrigenes.Width = 125;
            // 
            // colNumeros
            // 
            colNumeros.HeaderText = "Numero";
            colNumeros.MinimumWidth = 6;
            colNumeros.Name = "colNumeros";
            colNumeros.Width = 125;
            // 
            // colDescripciones
            // 
            colDescripciones.HeaderText = "Descripción";
            colDescripciones.MinimumWidth = 6;
            colDescripciones.Name = "colDescripciones";
            colDescripciones.Width = 125;
            // 
            // colPrecios
            // 
            colPrecios.HeaderText = "Precio";
            colPrecios.MinimumWidth = 6;
            colPrecios.Name = "colPrecios";
            colPrecios.Width = 125;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 351);
            Controls.Add(tpConsultar);
            Name = "frmRegistro";
            Text = "Venta De Respuestos";
            Load += frmRegistro_Load;
            tpDatos.ResumeLayout(false);
            tpDatos.PerformLayout();
            Consultas.ResumeLayout(false);
            Consultas.PerformLayout();
            tpConsultar.ResumeLayout(false);
            tpGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
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
        private TabControl tpConsultar;
        private TabPage Consultas;
        private Label lblMarcaDeRepuesto;
        private Label lblOrigenDeRepuesto;
        private ComboBox cmbMarcaCta;
        private RadioButton chkNacional;
        private RadioButton chkImportado;
        private ListBox lstDatos;
        private Button btnConsultar;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colMarcas;
        private DataGridViewTextBoxColumn colOrigenes;
        private DataGridViewTextBoxColumn colNumeros;
        private DataGridViewTextBoxColumn colDescripciones;
        private DataGridViewTextBoxColumn colPrecios;
        private TabPage tpGrilla;
    }
}
