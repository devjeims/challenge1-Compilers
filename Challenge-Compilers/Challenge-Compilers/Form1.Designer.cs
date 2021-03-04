
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
            this.grbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOptions
            // 
            this.grbOptions.Controls.Add(this.rdConsole);
            this.grbOptions.Controls.Add(this.rdArchive);
            this.grbOptions.Location = new System.Drawing.Point(12, 65);
            this.grbOptions.Name = "grbOptions";
            this.grbOptions.Size = new System.Drawing.Size(217, 92);
            this.grbOptions.TabIndex = 0;
            this.grbOptions.TabStop = false;
            this.grbOptions.Text = "Selecciona una opción:";
            this.grbOptions.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdConsole
            // 
            this.rdConsole.AutoSize = true;
            this.rdConsole.Location = new System.Drawing.Point(6, 55);
            this.rdConsole.Name = "rdConsole";
            this.rdConsole.Size = new System.Drawing.Size(89, 24);
            this.rdConsole.TabIndex = 1;
            this.rdConsole.Text = "consola";
            this.rdConsole.UseVisualStyleBackColor = true;
            this.rdConsole.CheckedChanged += new System.EventHandler(this.rdConsole_CheckedChanged);
            // 
            // rdArchive
            // 
            this.rdArchive.AutoSize = true;
            this.rdArchive.Checked = true;
            this.rdArchive.Location = new System.Drawing.Point(6, 25);
            this.rdArchive.Name = "rdArchive";
            this.rdArchive.Size = new System.Drawing.Size(84, 24);
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
            this.lblTitle.Location = new System.Drawing.Point(163, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(519, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "App propuesta como reto 1 para el curso de Compiladores";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOpenArchive
            // 
            this.btnOpenArchive.Location = new System.Drawing.Point(259, 75);
            this.btnOpenArchive.Name = "btnOpenArchive";
            this.btnOpenArchive.Size = new System.Drawing.Size(115, 39);
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
            this.lblRouteArchive.Location = new System.Drawing.Point(255, 122);
            this.lblRouteArchive.Name = "lblRouteArchive";
            this.lblRouteArchive.Size = new System.Drawing.Size(58, 20);
            this.lblRouteArchive.TabIndex = 2;
            this.lblRouteArchive.Text = "Ruta: ";
            this.lblRouteArchive.Visible = false;
            this.lblRouteArchive.Click += new System.EventHandler(this.lblRouteArchive_Click);
            // 
            // btnSendInput
            // 
            this.btnSendInput.Location = new System.Drawing.Point(380, 75);
            this.btnSendInput.Name = "btnSendInput";
            this.btnSendInput.Size = new System.Drawing.Size(115, 39);
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
            this.lblOutput.Location = new System.Drawing.Point(23, 207);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 20);
            this.lblOutput.TabIndex = 5;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoEllipsis = true;
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(27, 164);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(72, 22);
            this.labelOutput.TabIndex = 6;
            this.labelOutput.Text = "Salida:";
            this.labelOutput.Visible = false;
            this.labelOutput.Click += new System.EventHandler(this.labelOutput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(511, 75);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(277, 82);
            this.txtInput.TabIndex = 7;
            this.txtInput.Visible = false;
            // 
            // formCompiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnSendInput);
            this.Controls.Add(this.lblRouteArchive);
            this.Controls.Add(this.btnOpenArchive);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grbOptions);
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
    }
}

