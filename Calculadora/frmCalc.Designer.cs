namespace Calculadora
{
    partial class frmCalculator
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculator));
            this.label4 = new System.Windows.Forms.Label();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNum2 = new System.Windows.Forms.TextBox();
            this.txbNum1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(65, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Resultado da operação";
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(210, 136);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(143, 20);
            this.txbResult.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(90, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 33);
            this.label3.TabIndex = 31;
            this.label3.Text = "Calculadora Simples";
            // 
            // btnClean
            // 
            this.btnClean.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClean.BackColor = System.Drawing.Color.Transparent;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(177, 300);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(110, 34);
            this.btnClean.TabIndex = 30;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // btnDiv
            // 
            this.btnDiv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDiv.BackColor = System.Drawing.Color.Transparent;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(239, 248);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(96, 35);
            this.btnDiv.TabIndex = 29;
            this.btnDiv.Text = "Divisão";
            this.btnDiv.UseVisualStyleBackColor = false;
            // 
            // btnMult
            // 
            this.btnMult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMult.BackColor = System.Drawing.Color.Transparent;
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(131, 248);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(96, 35);
            this.btnMult.TabIndex = 28;
            this.btnMult.Text = "Multiplicação";
            this.btnMult.UseVisualStyleBackColor = false;
            // 
            // btnSub
            // 
            this.btnSub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSub.BackColor = System.Drawing.Color.Transparent;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(239, 202);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(96, 35);
            this.btnSub.TabIndex = 27;
            this.btnSub.Text = "Subtração";
            this.btnSub.UseVisualStyleBackColor = false;
            // 
            // btnSum
            // 
            this.btnSum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSum.BackColor = System.Drawing.Color.Transparent;
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(131, 202);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(96, 35);
            this.btnSum.TabIndex = 26;
            this.btnSum.Text = "Soma";
            this.btnSum.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(107, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Segundo número";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(107, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Primeiro número";
            // 
            // txbNum2
            // 
            this.txbNum2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbNum2.Location = new System.Drawing.Point(210, 86);
            this.txbNum2.Name = "txbNum2";
            this.txbNum2.Size = new System.Drawing.Size(143, 20);
            this.txbNum2.TabIndex = 23;
            // 
            // txbNum1
            // 
            this.txbNum1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbNum1.Location = new System.Drawing.Point(210, 59);
            this.txbNum1.Name = "txbNum1";
            this.txbNum1.Size = new System.Drawing.Size(143, 20);
            this.txbNum1.TabIndex = 22;
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(439, 341);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNum2);
            this.Controls.Add(this.txbNum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculator";
            this.Text = "Calculadora Simples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNum2;
        private System.Windows.Forms.TextBox txbNum1;
    }
}

