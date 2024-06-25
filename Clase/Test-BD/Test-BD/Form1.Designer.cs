namespace Test_BD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConex1 = new System.Windows.Forms.Button();
            this.btnConex2 = new System.Windows.Forms.Button();
            this.cbActividad = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConex1
            // 
            this.btnConex1.Location = new System.Drawing.Point(150, 330);
            this.btnConex1.Name = "btnConex1";
            this.btnConex1.Size = new System.Drawing.Size(117, 39);
            this.btnConex1.TabIndex = 0;
            this.btnConex1.Text = "Conexión 1";
            this.btnConex1.UseVisualStyleBackColor = true;
            this.btnConex1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConex2
            // 
            this.btnConex2.Location = new System.Drawing.Point(507, 330);
            this.btnConex2.Name = "btnConex2";
            this.btnConex2.Size = new System.Drawing.Size(141, 39);
            this.btnConex2.TabIndex = 1;
            this.btnConex2.Text = "Conexión 2";
            this.btnConex2.UseVisualStyleBackColor = true;
            this.btnConex2.Click += new System.EventHandler(this.btnConex2_Click);
            // 
            // cbActividad
            // 
            this.cbActividad.FormattingEnabled = true;
            this.cbActividad.Location = new System.Drawing.Point(73, 72);
            this.cbActividad.Name = "cbActividad";
            this.cbActividad.Size = new System.Drawing.Size(296, 28);
            this.cbActividad.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(441, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(294, 252);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbActividad);
            this.Controls.Add(this.btnConex2);
            this.Controls.Add(this.btnConex1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConex1;
        private System.Windows.Forms.Button btnConex2;
        private System.Windows.Forms.ComboBox cbActividad;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

