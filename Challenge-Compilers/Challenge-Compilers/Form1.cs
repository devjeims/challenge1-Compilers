using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge_Compilers
{
    public partial class formCompiler : Form
    {
        
        public formCompiler()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void formCompiler_Load(object sender, EventArgs e)
        {

        }

        private void rdArchive_CheckedChanged(object sender, EventArgs e)
        {
            if (rdArchive.Checked)
            {
                btnOpenArchive.Visible = true;
                lblRouteArchive.Visible = true;
                txtSalida.Visible = true;
            }
            else
            {
                lblRouteArchive.Text = "";
                btnOpenArchive.Visible = false;
                lblRouteArchive.Visible = false;
            }
        }

        private void rdConsole_CheckedChanged(object sender, EventArgs e)
        {
            if (rdConsole.Checked)
            {
                btnSendInput.Visible = true;
                txtInput.Visible = true;
                txtSalida.Visible = true;
            }
            else
            {
                btnSendInput.Visible = false;
                txtInput.Visible = false;
            }
        }

        private void btnOpenArchive_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    lblRouteArchive.Text = openFileDialog1.FileName.ToLower() + "\n";
                    string[] lines = System.IO.File.ReadAllLines(@openFileDialog1.FileName);
                    txtSalida.Text += openFileDialog1.SafeFileName.ToLower() + "\r\n";
                    for (int i = 0; i < lines.Length; i++)
                    {
                        txtSalida.Text += ((i + 1) + "-> " + lines[i] + "\r\n");
                    }
                    lblRouteArchive.Visible = true;
                    labelOutput.Visible = true;
                    txtSalida.Visible = true;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Farid el mejor");
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private String archiveName() {

            return null;
        }
        private void btnSendInput_Click(object sender, EventArgs e)
        {
            try
            {
                string aLine;
                int lineNumber = 1;
                StringReader strReader = new StringReader(txtInput.Text);
                while (true)
                {
                    aLine = strReader.ReadLine();
                    if (aLine != null)
                    {
                        txtSalida.Text += lineNumber + "-> " + aLine + "\r\n";
                        labelOutput.Visible = true;
                        txtSalida.Visible = true;
                        lineNumber++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Farid el mejor");
            }
        }

        private void lblRouteArchive_Click(object sender, EventArgs e)
        {

        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalida_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
