namespace TodoCode_Ejercicio_2
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
            btnCliente = new Button();
            btnPedido = new Button();
            btnComida = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCliente
            // 
            btnCliente.Location = new Point(123, 124);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(110, 64);
            btnCliente.TabIndex = 1;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnPedido
            // 
            btnPedido.Location = new Point(362, 124);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(101, 64);
            btnPedido.TabIndex = 2;
            btnPedido.Text = "Pedido";
            btnPedido.UseVisualStyleBackColor = true;
            btnPedido.Click += btnPedido_Click;
            // 
            // btnComida
            // 
            btnComida.Location = new Point(602, 124);
            btnComida.Name = "btnComida";
            btnComida.Size = new Size(127, 64);
            btnComida.TabIndex = 3;
            btnComida.Text = "Comida";
            btnComida.UseVisualStyleBackColor = true;
            btnComida.Click += btnComida_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(397, 88);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 4;
            label1.Text = "ALTA";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnComida);
            Controls.Add(btnPedido);
            Controls.Add(btnCliente);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCliente;
        private Button btnPedido;
        private Button btnComida;
        private Label label1;
    }
}
