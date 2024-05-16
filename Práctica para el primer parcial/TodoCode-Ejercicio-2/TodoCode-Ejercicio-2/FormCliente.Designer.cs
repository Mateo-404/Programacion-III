namespace TodoCode_Ejercicio_2
{
    partial class FormCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbClienteNombre = new TextBox();
            tbClienteApellido = new TextBox();
            mtbClienteTelefono = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnClienteGuardar = new Button();
            SuspendLayout();
            // 
            // tbClienteNombre
            // 
            tbClienteNombre.Location = new Point(291, 113);
            tbClienteNombre.Name = "tbClienteNombre";
            tbClienteNombre.Size = new Size(206, 23);
            tbClienteNombre.TabIndex = 0;
            // 
            // tbClienteApellido
            // 
            tbClienteApellido.Location = new Point(292, 162);
            tbClienteApellido.Name = "tbClienteApellido";
            tbClienteApellido.Size = new Size(206, 23);
            tbClienteApellido.TabIndex = 1;
            // 
            // mtbClienteTelefono
            // 
            mtbClienteTelefono.Location = new Point(292, 230);
            mtbClienteTelefono.Mask = "(999)000-0000";
            mtbClienteTelefono.Name = "mtbClienteTelefono";
            mtbClienteTelefono.Size = new Size(206, 23);
            mtbClienteTelefono.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 95);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 144);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 212);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 5;
            label3.Text = "Teléfono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(355, 43);
            label4.Name = "label4";
            label4.Size = new Size(91, 30);
            label4.TabIndex = 6;
            label4.Text = "CLIENTE";
            label4.Click += label4_Click;
            // 
            // btnClienteGuardar
            // 
            btnClienteGuardar.Location = new Point(291, 301);
            btnClienteGuardar.Name = "btnClienteGuardar";
            btnClienteGuardar.Size = new Size(194, 39);
            btnClienteGuardar.TabIndex = 7;
            btnClienteGuardar.Text = "GUARDAR";
            btnClienteGuardar.UseVisualStyleBackColor = true;
            btnClienteGuardar.Click += btnClienteGuardar_Click;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClienteGuardar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(mtbClienteTelefono);
            Controls.Add(tbClienteApellido);
            Controls.Add(tbClienteNombre);
            Name = "FormCliente";
            Text = "FormCliente";
            Load += FormCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbClienteNombre;
        private TextBox tbClienteApellido;
        private MaskedTextBox mtbClienteTelefono;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnClienteGuardar;
    }
}