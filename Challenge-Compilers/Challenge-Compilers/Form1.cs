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
            }
            else
            {
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
            }
            else
            {
                btnSendInput.Visible = false;
                txtInput.Visible = false;
            }
        }

        private void btnOpenArchive_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                lblRouteArchive.Text += openFileDialog1.FileName.ToLower() + "\n";
                string[] lines = System.IO.File.ReadAllLines(@openFileDialog1.FileName);
                for (int i = 0; i < lines.Length; i++) {
                    lblOutput.Text += ((i + 1) + "-> " + lines[i] + "\n");
                }
                lblRouteArchive.Visible = true;
                labelOutput.Visible = true;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void btnSendInput_Click(object sender, EventArgs e)
        {
            string aLine;
            Boolean aParagraph = true;
            int lineNumber = 1;
            StringReader strReader = new StringReader(txtInput.Text);
            while (aParagraph)
            {
                aLine = strReader.ReadLine();
                if (aLine != null) {
                    lblOutput.Text += lineNumber + "-> " +  aLine + "\n";
                    labelOutput.Visible = true;
                    lineNumber++;
                }
                else {
                    MessageBox.Show("Debes escribir algo en el campo de texto.");
                    aParagraph = false;
                }
            }
        }

        private void lblRouteArchive_Click(object sender, EventArgs e)
        {

        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
