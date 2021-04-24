
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnApagar2 = new System.Windows.Forms.Button();
            this.labelRele2 = new System.Windows.Forms.Label();
            this.btnEncender2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRele1
            // 
            this.labelRele1.AutoSize = true;
            this.labelRele1.BackColor = System.Drawing.Color.Red;
            this.labelRele1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRele1.Location = new System.Drawing.Point(47, 85);
            this.labelRele1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRele1.Name = "labelRele1";
            this.labelRele1.Size = new System.Drawing.Size(73, 36);
            this.labelRele1.TabIndex = 0;
            this.labelRele1.Text = "OFF";
            // 
            // btnEncender1
            // 
            this.btnEncender1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncender1.Location = new System.Drawing.Point(187, 37);
            this.btnEncender1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEncender1.Name = "btnEncender1";
            this.btnEncender1.Size = new System.Drawing.Size(169, 57);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(389, 198);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relé 1 (D7)";
            // 
            // btnApagar1
            // 
            this.btnApagar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar1.Location = new System.Drawing.Point(187, 116);
            this.btnApagar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApagar1.Name = "btnApagar1";
            this.btnApagar1.Size = new System.Drawing.Size(169, 57);
            this.btnApagar1.TabIndex = 2;
            this.btnApagar1.Text = "Apagar Relé 1";
            this.btnApagar1.UseVisualStyleBackColor = true;
            this.btnApagar1.Click += new System.EventHandler(this.bntApagar1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM22";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnApagar2);
            this.groupBox2.Controls.Add(this.labelRele2);
            this.groupBox2.Controls.Add(this.btnEncender2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(420, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(389, 198);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relé 2 (D8)";
            // 
            // btnApagar2
            // 
            this.btnApagar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar2.Location = new System.Drawing.Point(187, 116);
            this.btnApagar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApagar2.Name = "btnApagar2";
            this.btnApagar2.Size = new System.Drawing.Size(169, 57);
            this.btnApagar2.TabIndex = 2;
            this.btnApagar2.Text = "Apagar Relé 2";
            this.btnApagar2.UseVisualStyleBackColor = true;
            this.btnApagar2.Click += new System.EventHandler(this.btnApagar2_Click);
            // 
            // labelRele2
            // 
            this.labelRele2.AutoSize = true;
            this.labelRele2.BackColor = System.Drawing.Color.Red;
            this.labelRele2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRele2.Location = new System.Drawing.Point(47, 85);
            this.labelRele2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRele2.Name = "labelRele2";
            this.labelRele2.Size = new System.Drawing.Size(73, 36);
            this.labelRele2.TabIndex = 0;
            this.labelRele2.Text = "OFF";
            // 
            // btnEncender2
            // 
            this.btnEncender2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncender2.Location = new System.Drawing.Point(187, 37);
            this.btnEncender2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEncender2.Name = "btnEncender2";
            this.btnEncender2.Size = new System.Drawing.Size(169, 57);
            this.btnEncender2.TabIndex = 1;
            this.btnEncender2.Text = "Encender Relé 2";
            this.btnEncender2.UseVisualStyleBackColor = true;
            this.btnEncender2.Click += new System.EventHandler(this.btnEncender2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 228);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "IOTA CONTROL 328";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelRele1;
        private System.Windows.Forms.Button btnEncender1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnApagar1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnApagar2;
        private System.Windows.Forms.Label labelRele2;
        private System.Windows.Forms.Button btnEncender2;
    }
}

