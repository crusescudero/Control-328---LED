using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_328___LED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                btnApagar1.Enabled = false;
                btnApagar2.Enabled = false;
                serialPort1.PortName = "COM13";
                serialPort1.Open();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void bntApagar1_Click(object sender, EventArgs e)
        {
            try
            {
                //enviar codigo al arduino
                serialPort1.WriteLine("$rele1off");
                labelRele1.BackColor = Color.Red;
                labelRele1.Text = "OFF";
                btnApagar1.Enabled = false;
                btnEncender1.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnEncender1_Click(object sender, EventArgs e)
        {
            try
            {
                //enviar codigo al arduino
                serialPort1.WriteLine("$rele1on");
                labelRele1.BackColor = Color.LimeGreen;
                labelRele1.Text = "ON";
                btnApagar1.Enabled = true;
                btnEncender1.Enabled = false;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void btnEncender2_Click(object sender, EventArgs e)
        {
            try
            {
                //enviar codigo al arduino
                serialPort1.WriteLine("$rele2on");
                labelRele2.BackColor = Color.LimeGreen;
                labelRele2.Text = "ON";
                btnApagar2.Enabled = true;
                btnEncender2.Enabled = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnApagar2_Click(object sender, EventArgs e)
        {

            try
            {
                //enviar codigo al arduino
                serialPort1.WriteLine("$rele2off");
                labelRele2.BackColor = Color.Red;
                labelRele2.Text = "OFF";
                btnApagar2.Enabled = false;
                btnEncender2.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
