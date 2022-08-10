namespace TP.Aula02
{
    partial class frmCalcIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalcIMC));
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSituacaoIMC = new System.Windows.Forms.Label();
            this.picTitulo = new System.Windows.Forms.PictureBox();
            this.mtbAltura = new System.Windows.Forms.MaskedTextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(101, 103);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(216, 23);
            this.txbPeso.TabIndex = 0;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(57, 106);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(35, 15);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(57, 151);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(42, 15);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(140, 55);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(94, 40);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Calculadora \r\nde IMC";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(113, 188);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(218, 188);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblSituacaoIMC
            // 
            this.lblSituacaoIMC.AutoSize = true;
            this.lblSituacaoIMC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSituacaoIMC.Location = new System.Drawing.Point(57, 216);
            this.lblSituacaoIMC.Name = "lblSituacaoIMC";
            this.lblSituacaoIMC.Size = new System.Drawing.Size(0, 19);
            this.lblSituacaoIMC.TabIndex = 7;
            this.lblSituacaoIMC.Click += new System.EventHandler(this.lblSituacaoIMC_Click);
            // 
            // picTitulo
            // 
            this.picTitulo.Image = ((System.Drawing.Image)(resources.GetObject("picTitulo.Image")));
            this.picTitulo.Location = new System.Drawing.Point(146, 12);
            this.picTitulo.Name = "picTitulo";
            this.picTitulo.Size = new System.Drawing.Size(82, 38);
            this.picTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitulo.TabIndex = 8;
            this.picTitulo.TabStop = false;
            // 
            // mtbAltura
            // 
            this.mtbAltura.Location = new System.Drawing.Point(101, 150);
            this.mtbAltura.Name = "mtbAltura";
            this.mtbAltura.PromptChar = '0';
            this.mtbAltura.Size = new System.Drawing.Size(216, 23);
            this.mtbAltura.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(159, 225);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmCalcIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(375, 260);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.mtbAltura);
            this.Controls.Add(this.picTitulo);
            this.Controls.Add(this.lblSituacaoIMC);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txbPeso);
            this.MaximizeBox = false;
            this.Name = "frmCalcIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de IMC";
            this.Load += new System.EventHandler(this.frmCalcIMC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbPeso;
        private Label lblPeso;
        private Label lblAltura;
        private Label lblTitulo;
        private Button btnCalcular;
        private Button btnLimpar;
        private Label lblSituacaoIMC;
        private PictureBox picTitulo;
        private MaskedTextBox mtbAltura;
        private Button btnFechar;
    }
}