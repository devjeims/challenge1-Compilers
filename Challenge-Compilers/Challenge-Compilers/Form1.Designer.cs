
namespace Challenge_Compilers
{
    partial class formCompiler
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
            this.grbOptions = new System.Windows.Forms.GroupBox();
            this.rdConsole = new System.Windows.Forms.RadioButton();
            this.rdArchive = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOpenArchive = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblRouteArchive = new System.Windows.Forms.Label();
            this.btnSendInput = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.grbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOptions
            // 
            this.grbOptions.Controls.Add(this.rdConsole);
            this.grbOptions.Controls.Add(this.rdArchive);
            this.grbOptions.Location = new System.Drawing.Point(8, 42);
            this.grbOptions.Margin = new System.Windows.Forms.Padding(2);
            this.grbOptions.Name = "grbOptions";
            this.grbOptions.Padding = new System.Windows.Forms.Padding(2);
            this.grbOptions.Size = new System.Drawing.Size(145, 60);
            this.grbOptions.TabIndex = 0;
            this.grbOptions.TabStop = false;
            this.grbOptions.Text = "Selecciona una opción:";
            this.grbOptions.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdConsole
            // 
            this.rdConsole.AutoSize = true;
            this.rdConsole.Location = new System.Drawing.Point(4, 36);
            this.rdConsole.Margin = new System.Windows.Forms.Padding(2);
            this.rdConsole.Name = "rdConsole";
            this.rdConsole.Size = new System.Drawing.Size(62, 17);
            this.rdConsole.TabIndex = 1;
            this.rdConsole.Text = "consola";
            this.rdConsole.UseVisualStyleBackColor = true;
            this.rdConsole.CheckedChanged += new System.EventHandler(this.rdConsole_CheckedChanged);
            // 
            // rdArchive
            // 
            this.rdArchive.AutoSize = true;
            this.rdArchive.Checked = true;
            this.rdArchive.Location = new System.Drawing.Point(4, 16);
            this.rdArchive.Margin = new System.Windows.Forms.Padding(2);
            this.rdArchive.Name = "rdArchive";
            this.rdArchive.Size = new System.Drawing.Size(60, 17);
            this.rdArchive.TabIndex = 0;
            this.rdArchive.TabStop = true;
            this.rdArchive.Text = "archivo";
            this.rdArchive.UseVisualStyleBackColor = true;
            this.rdArchive.CheckedChanged += new System.EventHandler(this.rdArchive_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(109, 6);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(338, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "App propuesta como reto 1 para el curso de Compiladores";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOpenArchive
            // 
            this.btnOpenArchive.Location = new System.Drawing.Point(173, 49);
            this.btnOpenArchive.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenArchive.Name = "btnOpenArchive";
            this.btnOpenArchive.Size = new System.Drawing.Size(77, 25);
            this.btnOpenArchive.TabIndex = 2;
            this.btnOpenArchive.Text = "Seleccionar";
            this.btnOpenArchive.UseVisualStyleBackColor = true;
            this.btnOpenArchive.Click += new System.EventHandler(this.btnOpenArchive_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archives TXT (\".txt\")|*.txt";
            // 
            // lblRouteArchive
            // 
            this.lblRouteArchive.AutoSize = true;
            this.lblRouteArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteArchive.Location = new System.Drawing.Point(170, 79);
            this.lblRouteArchive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRouteArchive.Name = "lblRouteArchive";
            this.lblRouteArchive.Size = new System.Drawing.Size(42, 13);
            this.lblRouteArchive.TabIndex = 2;
            this.lblRouteArchive.Text = "Ruta: ";
            this.lblRouteArchive.Visible = false;
            this.lblRouteArchive.Click += new System.EventHandler(this.lblRouteArchive_Click);
            // 
            // btnSendInput
            // 
            this.btnSendInput.Location = new System.Drawing.Point(253, 49);
            this.btnSendInput.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendInput.Name = "btnSendInput";
            this.btnSendInput.Size = new System.Drawing.Size(77, 25);
            this.btnSendInput.TabIndex = 4;
            this.btnSendInput.Text = "Enviar";
            this.btnSendInput.UseVisualStyleBackColor = true;
            this.btnSendInput.Visible = false;
            this.btnSendInput.Click += new System.EventHandler(this.btnSendInput_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(15, 135);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 5;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoEllipsis = true;
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(18, 107);
            this.labelOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(52, 15);
            this.labelOutput.TabIndex = 6;
            this.labelOutput.Text = "Salida:";
            this.labelOutput.Visible = false;
            this.labelOutput.Click += new System.EventHandler(this.labelOutput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(341, 49);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(186, 55);
            this.txtInput.TabIndex = 7;
            this.txtInput.Visible = false;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtSalida
            // 
            this.txtSalida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalida.Location = new System.Drawing.Point(12, 135);
            this.txtSalida.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ReadOnly = true;
            this.txtSalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSalida.Size = new System.Drawing.Size(186, 134);
            this.txtSalida.TabIndex = 8;
            this.txtSalida.Visible = false;
            this.txtSalida.TextChanged += new System.EventHandler(this.txtSalida_TextChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(341, 121);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 9;
            // 
            // formCompiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnSendInput);
            this.Controls.Add(this.lblRouteArchive);
            this.Controls.Add(this.btnOpenArchive);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grbOptions);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formCompiler";
            this.Text = "Challenge Compilers";
            this.Load += new System.EventHandler(this.formCompiler_Load);
            this.grbOptions.ResumeLayout(false);
            this.grbOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOptions;
        private System.Windows.Forms.RadioButton rdArchive;
        private System.Windows.Forms.RadioButton rdConsole;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnOpenArchive;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblRouteArchive;
        private System.Windows.Forms.Button btnSendInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Label lblError;
    }
}

