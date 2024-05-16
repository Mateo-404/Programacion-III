namespace TodoCode_Ejercicio_2
{
    partial class FormPedidos
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
            tbPedidoNombre = new TextBox();
            tbPedidoComida = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbPedidoApellido = new TextBox();
            btnPedidoGuardarPedido = new Button();
            btnPedidoAgregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 39);
            label1.Name = "label1";
            label1.Size = new Size(99, 30);
            label1.TabIndex = 0;
            label1.Text = "PEDIDOS";
            label1.Click += label1_Click;
            // 
            // tbPedidoNombre
            // 
            tbPedidoNombre.Location = new Point(246, 142);
            tbPedidoNombre.Name = "tbPedidoNombre";
            tbPedidoNombre.Size = new Size(123, 23);
            tbPedidoNombre.TabIndex = 1;
            tbPedidoNombre.TextChanged += tbPedidoNombre_TextChanged;
            // 
            // tbPedidoComida
            // 
            tbPedidoComida.Location = new Point(246, 238);
            tbPedidoComida.Name = "tbPedidoComida";
            tbPedidoComida.Size = new Size(262, 23);
            tbPedidoComida.TabIndex = 2;
            tbPedidoComida.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 111);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 220);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Comida";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 111);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Apellido";
            // 
            // tbPedidoApellido
            // 
            tbPedidoApellido.Location = new Point(385, 142);
            tbPedidoApellido.Name = "tbPedidoApellido";
            tbPedidoApellido.Size = new Size(123, 23);
            tbPedidoApellido.TabIndex = 5;
            tbPedidoApellido.TextChanged += tbPedidoApellido_TextChanged;
            // 
            // btnPedidoGuardarPedido
            // 
            btnPedidoGuardarPedido.Location = new Point(246, 322);
            btnPedidoGuardarPedido.Name = "btnPedidoGuardarPedido";
            btnPedidoGuardarPedido.Size = new Size(262, 45);
            btnPedidoGuardarPedido.TabIndex = 7;
            btnPedidoGuardarPedido.Text = "GUARDAR PEDIDO";
            btnPedidoGuardarPedido.UseVisualStyleBackColor = true;
            btnPedidoGuardarPedido.Click += btnPedidoGuardarPedido_Click;
            // 
            // btnPedidoAgregar
            // 
            btnPedidoAgregar.Location = new Point(536, 220);
            btnPedidoAgregar.Name = "btnPedidoAgregar";
            btnPedidoAgregar.Size = new Size(49, 41);
            btnPedidoAgregar.TabIndex = 8;
            btnPedidoAgregar.Text = "+";
            btnPedidoAgregar.UseVisualStyleBackColor = true;
            btnPedidoAgregar.Click += btnPedidoAgregar_Click;
            // 
            // FormPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPedidoAgregar);
            Controls.Add(btnPedidoGuardarPedido);
            Controls.Add(label4);
            Controls.Add(tbPedidoApellido);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbPedidoComida);
            Controls.Add(tbPedidoNombre);
            Controls.Add(label1);
            Name = "FormPedidos";
            Text = "FormPedidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbPedidoNombre;
        private TextBox tbPedidoComida;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbPedidoApellido;
        private Button btnPedidoGuardarPedido;
        private Button btnPedidoAgregar;
    }
}