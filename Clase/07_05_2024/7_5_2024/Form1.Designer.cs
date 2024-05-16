namespace _7_5_2024
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
            gbDetallesUsuario = new GroupBox();
            label1 = new Label();
            mtbCUIL = new MaskedTextBox();
            nEdad = new NumericUpDown();
            tbDireccion = new TextBox();
            tbNombre = new TextBox();
            lbEdad = new Label();
            lbDireccion = new Label();
            lbNombre = new Label();
            gbGenero = new GroupBox();
            rbNoBinario = new RadioButton();
            rbFemenino = new RadioButton();
            rbMasculino = new RadioButton();
            gbCursos = new GroupBox();
            lbCursos = new CheckedListBox();
            btnIngresar = new Button();
            lbPais = new ListBox();
            Pais = new Label();
            gbDetallesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nEdad).BeginInit();
            gbGenero.SuspendLayout();
            gbCursos.SuspendLayout();
            SuspendLayout();
            // 
            // gbDetallesUsuario
            // 
            gbDetallesUsuario.Controls.Add(label1);
            gbDetallesUsuario.Controls.Add(mtbCUIL);
            gbDetallesUsuario.Controls.Add(nEdad);
            gbDetallesUsuario.Controls.Add(tbDireccion);
            gbDetallesUsuario.Controls.Add(tbNombre);
            gbDetallesUsuario.Controls.Add(lbEdad);
            gbDetallesUsuario.Controls.Add(lbDireccion);
            gbDetallesUsuario.Controls.Add(lbNombre);
            gbDetallesUsuario.Location = new Point(20, 7);
            gbDetallesUsuario.Margin = new Padding(2);
            gbDetallesUsuario.Name = "gbDetallesUsuario";
            gbDetallesUsuario.Padding = new Padding(2);
            gbDetallesUsuario.Size = new Size(294, 192);
            gbDetallesUsuario.TabIndex = 0;
            gbDetallesUsuario.TabStop = false;
            gbDetallesUsuario.Text = "Detalles del usuario";
            gbDetallesUsuario.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 137);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 10;
            label1.Text = "CUIL/CUIT";
            label1.Click += label1_Click;
            // 
            // mtbCUIL
            // 
            mtbCUIL.Location = new Point(70, 134);
            mtbCUIL.Mask = "00-000000-0";
            mtbCUIL.Name = "mtbCUIL";
            mtbCUIL.Size = new Size(216, 23);
            mtbCUIL.TabIndex = 9;
            mtbCUIL.MaskInputRejected += mtbCUIL_MaskInputRejected;
            // 
            // nEdad
            // 
            nEdad.Location = new Point(69, 87);
            nEdad.Margin = new Padding(2);
            nEdad.Name = "nEdad";
            nEdad.Size = new Size(217, 23);
            nEdad.TabIndex = 8;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(69, 56);
            tbDireccion.Margin = new Padding(2);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(222, 23);
            tbDireccion.TabIndex = 7;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(69, 22);
            tbNombre.Margin = new Padding(2);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(222, 23);
            tbNombre.TabIndex = 6;
            // 
            // lbEdad
            // 
            lbEdad.AutoSize = true;
            lbEdad.Location = new Point(18, 88);
            lbEdad.Margin = new Padding(2, 0, 2, 0);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(33, 15);
            lbEdad.TabIndex = 5;
            lbEdad.Text = "Edad";
            // 
            // lbDireccion
            // 
            lbDireccion.AutoSize = true;
            lbDireccion.Location = new Point(10, 56);
            lbDireccion.Margin = new Padding(2, 0, 2, 0);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(57, 15);
            lbDireccion.TabIndex = 4;
            lbDireccion.Text = "Direccion";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(10, 22);
            lbNombre.Margin = new Padding(2, 0, 2, 0);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(51, 15);
            lbNombre.TabIndex = 3;
            lbNombre.Text = "Nombre";
            // 
            // gbGenero
            // 
            gbGenero.Controls.Add(rbNoBinario);
            gbGenero.Controls.Add(rbFemenino);
            gbGenero.Controls.Add(rbMasculino);
            gbGenero.Location = new Point(363, 15);
            gbGenero.Margin = new Padding(2);
            gbGenero.Name = "gbGenero";
            gbGenero.Padding = new Padding(2);
            gbGenero.Size = new Size(169, 83);
            gbGenero.TabIndex = 1;
            gbGenero.TabStop = false;
            gbGenero.Text = "Género";
            // 
            // rbNoBinario
            // 
            rbNoBinario.AutoSize = true;
            rbNoBinario.Location = new Point(14, 54);
            rbNoBinario.Margin = new Padding(2);
            rbNoBinario.Name = "rbNoBinario";
            rbNoBinario.Size = new Size(81, 19);
            rbNoBinario.TabIndex = 2;
            rbNoBinario.TabStop = true;
            rbNoBinario.Text = "No Binario";
            rbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            rbFemenino.AutoSize = true;
            rbFemenino.Location = new Point(14, 33);
            rbFemenino.Margin = new Padding(2);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new Size(78, 19);
            rbFemenino.TabIndex = 1;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "Femenino";
            rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(14, 13);
            rbMasculino.Margin = new Padding(2);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(80, 19);
            rbMasculino.TabIndex = 0;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // gbCursos
            // 
            gbCursos.Controls.Add(lbCursos);
            gbCursos.Location = new Point(363, 110);
            gbCursos.Margin = new Padding(2);
            gbCursos.Name = "gbCursos";
            gbCursos.Padding = new Padding(2);
            gbCursos.Size = new Size(169, 89);
            gbCursos.TabIndex = 2;
            gbCursos.TabStop = false;
            gbCursos.Text = "Cursos";
            // 
            // lbCursos
            // 
            lbCursos.FormattingEnabled = true;
            lbCursos.Items.AddRange(new object[] { "C#", "C++", "Javascript" });
            lbCursos.Location = new Point(29, 23);
            lbCursos.Margin = new Padding(2);
            lbCursos.Name = "lbCursos";
            lbCursos.Size = new Size(114, 58);
            lbCursos.TabIndex = 0;
            lbCursos.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(393, 223);
            btnIngresar.Margin = new Padding(2);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(113, 20);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += button1_Click;
            // 
            // lbPais
            // 
            lbPais.FormattingEnabled = true;
            lbPais.ItemHeight = 15;
            lbPais.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            lbPais.Location = new Point(20, 245);
            lbPais.Margin = new Padding(2);
            lbPais.Name = "lbPais";
            lbPais.Size = new Size(318, 94);
            lbPais.TabIndex = 3;
            // 
            // Pais
            // 
            Pais.AutoSize = true;
            Pais.Location = new Point(20, 228);
            Pais.Margin = new Padding(2, 0, 2, 0);
            Pais.Name = "Pais";
            Pais.Size = new Size(28, 15);
            Pais.TabIndex = 4;
            Pais.Text = "Pais";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 466);
            Controls.Add(Pais);
            Controls.Add(lbPais);
            Controls.Add(btnIngresar);
            Controls.Add(gbCursos);
            Controls.Add(gbGenero);
            Controls.Add(gbDetallesUsuario);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbDetallesUsuario.ResumeLayout(false);
            gbDetallesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nEdad).EndInit();
            gbGenero.ResumeLayout(false);
            gbGenero.PerformLayout();
            gbCursos.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbDetallesUsuario;
        private GroupBox gbGenero;
        private GroupBox gbCursos;
        private Button btnIngresar;
        private CheckedListBox lbCursos;
        private Label lbNombre;
        private TextBox tbDireccion;
        private TextBox tbNombre;
        private Label lbEdad;
        private Label lbDireccion;
        private RadioButton rbNoBinario;
        private RadioButton rbFemenino;
        private RadioButton rbMasculino;
        private NumericUpDown nEdad;
        private ListBox lbPais;
        private Label Pais;
        private MaskedTextBox mtbCUIL;
        private Label label1;
    }
}
