namespace TodoCode_Ejercicio_2
{
    partial class FormComidas
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
            label1 = new Label();
            tbComidasNombre = new TextBox();
            tbComidasPrecio = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnComidasGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 54);
            label1.Name = "label1";
            label1.Size = new Size(105, 30);
            label1.TabIndex = 0;
            label1.Text = "COMIDAS";
            // 
            // tbComidasNombre
            // 
            tbComidasNombre.Location = new Point(274, 134);
            tbComidasNombre.Name = "tbComidasNombre";
            tbComidasNombre.Size = new Size(230, 23);
            tbComidasNombre.TabIndex = 1;
            // 
            // tbComidasPrecio
            // 
            tbComidasPrecio.Location = new Point(274, 230);
            tbComidasPrecio.Name = "tbComidasPrecio";
            tbComidasPrecio.Size = new Size(230, 23);
            tbComidasPrecio.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 106);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 212);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 4;
            label3.Text = "Precio";
            // 
            // btnComidasGuardar
            // 
            btnComidasGuardar.Location = new Point(274, 327);
            btnComidasGuardar.Name = "btnComidasGuardar";
            btnComidasGuardar.Size = new Size(230, 32);
            btnComidasGuardar.TabIndex = 5;
            btnComidasGuardar.Text = "GUARDAR";
            btnComidasGuardar.UseVisualStyleBackColor = true;
            btnComidasGuardar.Click += btnComidasGuardar_Click;
            // 
            // FormComidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnComidasGuardar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbComidasPrecio);
            Controls.Add(tbComidasNombre);
            Controls.Add(label1);
            Name = "FormComidas";
            Text = "FormComidas";
            Load += FormComidas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbComidasNombre;
        private TextBox tbComidasPrecio;
        private Label label2;
        private Label label3;
        private Button btnComidasGuardar;
    }
}