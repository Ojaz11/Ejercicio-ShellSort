namespace ShellSort
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtNombreCliente = new TextBox();
            cbCondolencias = new ComboBox();
            cbElegantes = new ComboBox();
            cbRamosRomanticos = new ComboBox();
            btnIngresar = new Button();
            btnAcomodar = new Button();
            dgvDatos = new DataGridView();
            dtpFecha = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Font = new Font("Trebuchet MS", 9F);
            txtNombreCliente.ForeColor = Color.FromArgb(208, 131, 49);
            txtNombreCliente.Location = new Point(276, 152);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(193, 25);
            txtNombreCliente.TabIndex = 0;
            // 
            // cbCondolencias
            // 
            cbCondolencias.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCondolencias.Font = new Font("Trebuchet MS", 9F);
            cbCondolencias.ForeColor = Color.FromArgb(208, 131, 49);
            cbCondolencias.FormattingEnabled = true;
            cbCondolencias.Items.AddRange(new object[] { "", "Paz y Recuerdo", "Serenidad Blanca", "Abrazo Floral" });
            cbCondolencias.Location = new Point(245, 315);
            cbCondolencias.Name = "cbCondolencias";
            cbCondolencias.Size = new Size(212, 28);
            cbCondolencias.TabIndex = 1;
            // 
            // cbElegantes
            // 
            cbElegantes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbElegantes.Font = new Font("Trebuchet MS", 9F);
            cbElegantes.ForeColor = Color.FromArgb(208, 131, 49);
            cbElegantes.FormattingEnabled = true;
            cbElegantes.Items.AddRange(new object[] { "", "Toque de Distinción", "Armonía Floral", "Elegancia Natural" });
            cbElegantes.Location = new Point(214, 225);
            cbElegantes.Name = "cbElegantes";
            cbElegantes.Size = new Size(219, 28);
            cbElegantes.TabIndex = 2;
            // 
            // cbRamosRomanticos
            // 
            cbRamosRomanticos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRamosRomanticos.Font = new Font("Trebuchet MS", 9F);
            cbRamosRomanticos.ForeColor = Color.FromArgb(208, 131, 49);
            cbRamosRomanticos.FormattingEnabled = true;
            cbRamosRomanticos.Items.AddRange(new object[] { "", "Amor Eterno", "Susurros de Rosas", "Te Amo Hoy y Siempre" });
            cbRamosRomanticos.Location = new Point(231, 265);
            cbRamosRomanticos.Name = "cbRamosRomanticos";
            cbRamosRomanticos.Size = new Size(236, 28);
            cbRamosRomanticos.TabIndex = 3;
            cbRamosRomanticos.SelectedIndexChanged += cbRamosRomanticos_SelectedIndexChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Transparent;
            btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(251, 207, 132);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Location = new Point(136, 420);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(127, 33);
            btnIngresar.TabIndex = 5;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnAcomodar
            // 
            btnAcomodar.BackColor = Color.Transparent;
            btnAcomodar.FlatAppearance.BorderColor = Color.FromArgb(247, 175, 136);
            btnAcomodar.FlatAppearance.BorderSize = 0;
            btnAcomodar.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnAcomodar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAcomodar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAcomodar.FlatStyle = FlatStyle.Flat;
            btnAcomodar.Location = new Point(310, 420);
            btnAcomodar.Name = "btnAcomodar";
            btnAcomodar.Size = new Size(137, 31);
            btnAcomodar.TabIndex = 6;
            btnAcomodar.TextAlign = ContentAlignment.TopCenter;
            btnAcomodar.UseVisualStyleBackColor = false;
            btnAcomodar.Click += btnAcomodar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.BackgroundColor = Color.FromArgb(255, 245, 224);
            dgvDatos.BorderStyle = BorderStyle.None;
            dgvDatos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 245, 224);
            dataGridViewCellStyle1.Font = new Font("Trebuchet MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(163, 119, 69);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(247, 175, 136);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(163, 119, 69);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 245, 224);
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(163, 119, 69);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(247, 175, 136);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(163, 119, 69);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDatos.EnableHeadersVisualStyles = false;
            dgvDatos.GridColor = Color.FromArgb(163, 119, 69);
            dgvDatos.Location = new Point(525, 154);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(425, 254);
            dgvDatos.TabIndex = 7;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Trebuchet MS", 9F);
            dtpFecha.Location = new Point(266, 367);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(217, 25);
            dtpFecha.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1061, 550);
            Controls.Add(dtpFecha);
            Controls.Add(dgvDatos);
            Controls.Add(btnAcomodar);
            Controls.Add(btnIngresar);
            Controls.Add(cbRamosRomanticos);
            Controls.Add(cbElegantes);
            Controls.Add(cbCondolencias);
            Controls.Add(txtNombreCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreCliente;
        private ComboBox cbCondolencias;
        private ComboBox cbElegantes;
        private ComboBox cbRamosRomanticos;
        private MaskedTextBox mskFecha;
        private Button btnIngresar;
        private Button btnAcomodar;
        private DataGridView dgvDatos;
        private DateTimePicker dtpFecha;
    }
}
