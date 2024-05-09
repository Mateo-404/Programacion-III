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
            gbGenero = new GroupBox();
            gbCursos = new GroupBox();
            lbCursos = new CheckedListBox();
            btnIngresar = new Button();
            lbNombre = new Label();
            rbMasculino = new RadioButton();
            rbFemenino = new RadioButton();
            rbNoBinario = new RadioButton();
            lbDireccion = new Label();
            lbEdad = new Label();
            tbNombre = new TextBox();
            tbDireccion = new TextBox();
            nEdad = new NumericUpDown();
            lbPais = new ListBox();
            Pais = new Label();
            gbDetallesUsuario.SuspendLayout();
            gbGenero.SuspendLayout();
            gbCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nEdad).BeginInit();
            SuspendLayout();
            // 
            // gbDetallesUsuario
            // 
            gbDetallesUsuario.Controls.Add(nEdad);
            gbDetallesUsuario.Controls.Add(tbDireccion);
            gbDetallesUsuario.Controls.Add(tbNombre);
            gbDetallesUsuario.Controls.Add(lbEdad);
            gbDetallesUsuario.Controls.Add(lbDireccion);
            gbDetallesUsuario.Controls.Add(lbNombre);
            gbDetallesUsuario.Location = new Point(29, 12);
            gbDetallesUsuario.Name = "gbDetallesUsuario";
            gbDetallesUsuario.Size = new Size(420, 233);
            gbDetallesUsuario.TabIndex = 0;
            gbDetallesUsuario.TabStop = false;
            gbDetallesUsuario.Text = "Detalles del usuario";
            gbDetallesUsuario.Enter += groupBox1_Enter;
            // 
            // gbGenero
            // 
            gbGenero.Controls.Add(rbNoBinario);
            gbGenero.Controls.Add(rbFemenino);
            gbGenero.Controls.Add(rbMasculino);
            gbGenero.Location = new Point(519, 25);
            gbGenero.Name = "gbGenero";
            gbGenero.Size = new Size(241, 138);
            gbGenero.TabIndex = 1;
            gbGenero.TabStop = false;
            gbGenero.Text = "Género";
            // 
            // gbCursos
            // 
            gbCursos.Controls.Add(lbCursos);
            gbCursos.Location = new Point(519, 184);
            gbCursos.Name = "gbCursos";
            gbCursos.Size = new Size(241, 149);
            gbCursos.TabIndex = 2;
            gbCursos.TabStop = false;
            gbCursos.Text = "Cursos";
            // 
            // lbCursos
            // 
            lbCursos.FormattingEnabled = true;
            lbCursos.Items.AddRange(new object[] { "C#", "C++", "Javascript" });
            lbCursos.Location = new Point(42, 39);
            lbCursos.Name = "lbCursos";
            lbCursos.Size = new Size(161, 88);
            lbCursos.TabIndex = 0;
            lbCursos.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(561, 371);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(161, 34);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += button1_Click;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(15, 36);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(78, 25);
            lbNombre.TabIndex = 3;
            lbNombre.Text = "Nombre";
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(20, 21);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(117, 29);
            rbMasculino.TabIndex = 0;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            rbFemenino.AutoSize = true;
            rbFemenino.Location = new Point(20, 55);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new Size(115, 29);
            rbFemenino.TabIndex = 1;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "Femenino";
            rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbNoBinario
            // 
            rbNoBinario.AutoSize = true;
            rbNoBinario.Location = new Point(20, 90);
            rbNoBinario.Name = "rbNoBinario";
            rbNoBinario.Size = new Size(120, 29);
            rbNoBinario.TabIndex = 2;
            rbNoBinario.TabStop = true;
            rbNoBinario.Text = "No Binario";
            rbNoBinario.UseVisualStyleBackColor = true;
            // 
            // lbDireccion
            // 
            lbDireccion.AutoSize = true;
            lbDireccion.Location = new Point(15, 94);
            lbDireccion.Name = "lbDireccion";
            lbDireccion.Size = new Size(85, 25);
            lbDireccion.TabIndex = 4;
            lbDireccion.Text = "Direccion";
            // 
            // lbEdad
            // 
            lbEdad.AutoSize = true;
            lbEdad.Location = new Point(25, 147);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(52, 25);
            lbEdad.TabIndex = 5;
            lbEdad.Text = "Edad";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(99, 36);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(315, 31);
            tbNombre.TabIndex = 6;
            // 
            // tbDireccion
            // 
            tbDireccion.Location = new Point(99, 94);
            tbDireccion.Name = "tbDireccion";
            tbDireccion.Size = new Size(315, 31);
            tbDireccion.TabIndex = 7;
            // 
            // nEdad
            // 
            nEdad.Location = new Point(99, 145);
            nEdad.Name = "nEdad";
            nEdad.Size = new Size(310, 31);
            nEdad.TabIndex = 8;
            // 
            // lbPais
            // 
            lbPais.FormattingEnabled = true;
            lbPais.ItemHeight = 25;
            lbPais.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            lbPais.Location = new Point(34, 279);
            lbPais.Name = "lbPais";
            lbPais.Size = new Size(452, 154);
            lbPais.TabIndex = 3;
            // 
            // Pais
            // 
            Pais.AutoSize = true;
            Pais.Location = new Point(34, 251);
            Pais.Name = "Pais";
            Pais.Size = new Size(42, 25);
            Pais.TabIndex = 4;
            Pais.Text = "Pais";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Pais);
            Controls.Add(lbPais);
            Controls.Add(btnIngresar);
            Controls.Add(gbCursos);
            Controls.Add(gbGenero);
            Controls.Add(gbDetallesUsuario);
            Name = "Form1";
            Text = "Form1";
            gbDetallesUsuario.ResumeLayout(false);
            gbDetallesUsuario.PerformLayout();
            gbGenero.ResumeLayout(false);
            gbGenero.PerformLayout();
            gbCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nEdad).EndInit();
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
    }
}
