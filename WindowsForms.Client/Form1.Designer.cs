namespace WindowsForms.Client
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.XmlToJsonRslt = new System.Windows.Forms.TextBox();
            this.XmlToJsonTxt = new System.Windows.Forms.TextBox();
            this.FibonacciRslt = new System.Windows.Forms.TextBox();
            this.FibonacciTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FibonacciBtn = new System.Windows.Forms.Button();
            this.XmlToJsonBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrer format xml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Résultat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entrer un entier entre 1 et 100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Résultat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lemon Way Test";
            // 
            // XmlToJsonRslt
            // 
            this.XmlToJsonRslt.Location = new System.Drawing.Point(21, 125);
            this.XmlToJsonRslt.Multiline = true;
            this.XmlToJsonRslt.Name = "XmlToJsonRslt";
            this.XmlToJsonRslt.Size = new System.Drawing.Size(351, 110);
            this.XmlToJsonRslt.TabIndex = 5;
            // 
            // XmlToJsonTxt
            // 
            this.XmlToJsonTxt.Location = new System.Drawing.Point(21, 34);
            this.XmlToJsonTxt.Multiline = true;
            this.XmlToJsonTxt.Name = "XmlToJsonTxt";
            this.XmlToJsonTxt.Size = new System.Drawing.Size(256, 56);
            this.XmlToJsonTxt.TabIndex = 6;
            // 
            // FibonacciRslt
            // 
            this.FibonacciRslt.Location = new System.Drawing.Point(16, 105);
            this.FibonacciRslt.Name = "FibonacciRslt";
            this.FibonacciRslt.Size = new System.Drawing.Size(320, 20);
            this.FibonacciRslt.TabIndex = 7;
            // 
            // FibonacciTxt
            // 
            this.FibonacciTxt.Location = new System.Drawing.Point(16, 36);
            this.FibonacciTxt.Name = "FibonacciTxt";
            this.FibonacciTxt.Size = new System.Drawing.Size(100, 20);
            this.FibonacciTxt.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FibonacciBtn);
            this.panel1.Controls.Add(this.FibonacciTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FibonacciRslt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 257);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.XmlToJsonBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.XmlToJsonRslt);
            this.panel2.Controls.Add(this.XmlToJsonTxt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(404, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 257);
            this.panel2.TabIndex = 0;
            // 
            // FibonacciBtn
            // 
            this.FibonacciBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FibonacciBtn.Location = new System.Drawing.Point(122, 34);
            this.FibonacciBtn.Name = "FibonacciBtn";
            this.FibonacciBtn.Size = new System.Drawing.Size(87, 23);
            this.FibonacciBtn.TabIndex = 0;
            this.FibonacciBtn.Text = "Fibonacci";
            this.FibonacciBtn.UseVisualStyleBackColor = true;
            this.FibonacciBtn.Click += new System.EventHandler(this.FibonacciBtn_Click);
            // 
            // XmlToJsonBtn
            // 
            this.XmlToJsonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XmlToJsonBtn.Location = new System.Drawing.Point(283, 31);
            this.XmlToJsonBtn.Name = "XmlToJsonBtn";
            this.XmlToJsonBtn.Size = new System.Drawing.Size(89, 23);
            this.XmlToJsonBtn.TabIndex = 1;
            this.XmlToJsonBtn.Text = "XmlToJson";
            this.XmlToJsonBtn.UseVisualStyleBackColor = true;
            this.XmlToJsonBtn.Click += new System.EventHandler(this.XmlToJsonBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox XmlToJsonRslt;
        private System.Windows.Forms.TextBox XmlToJsonTxt;
        private System.Windows.Forms.TextBox FibonacciRslt;
        private System.Windows.Forms.TextBox FibonacciTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FibonacciBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button XmlToJsonBtn;
    }
}

