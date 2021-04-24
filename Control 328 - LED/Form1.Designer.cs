
namespace Control_328___LED
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
            this.components = new System.ComponentModel.Container();
            this.labelRele1 = new System.Windows.Forms.Label();
            this.btnEncender1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApagar1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRele1
            // 
            this.labelRele1.AutoSize = true;
            this.labelRele1.BackColor = System.Drawing.Color.Red;
            this.labelRele1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRele1.Location = new System.Drawing.Point(35, 69);
            this.labelRele1.Name = "labelRele1";
            this.labelRele1.Size = new System.Drawing.Size(62, 29);
            this.labelRele1.TabIndex = 0;
            this.labelRele1.Text = "OFF";
            this.labelRele1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEncender1
            // 
            this.btnEncender1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncender1.Location = new System.Drawing.Point(140, 30);
            this.btnEncender1.Name = "btnEncender1";
            this.btnEncender1.Size = new System.Drawing.Size(127, 46);
            this.btnEncender1.TabIndex = 1;
            this.btnEncender1.Text = "Encender Relé 1";
            this.btnEncender1.UseVisualStyleBackColor = true;
            this.btnEncender1.Click += new System.EventHandler(this.btnEncender1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnApagar1);
            this.groupBox1.Controls.Add(this.labelRele1);
            this.groupBox1.Controls.Add(this.btnEncender1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reles";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnApagar1
            // 
            this.btnApagar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar1.Location = new System.Drawing.Point(140, 94);
            this.btnApagar1.Name = "btnApagar1";
            this.btnApagar1.Size = new System.Drawing.Size(127, 46);
            this.btnApagar1.TabIndex = 2;
            this.btnApagar1.Text = "Apagar Relé 1";
            this.btnApagar1.UseVisualStyleBackColor = true;
            this.btnApagar1.Click += new System.EventHandler(this.bntApagar1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM22";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 185);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "IOTA CONTROL 328";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelRele1;
        private System.Windows.Forms.Button btnEncender1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnApagar1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

