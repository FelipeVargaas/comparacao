namespace comparacao
{
    partial class Form1
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
            this.txb_num1 = new System.Windows.Forms.TextBox();
            this.txb_num2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_comp = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_num1
            // 
            this.txb_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_num1.Location = new System.Drawing.Point(219, 19);
            this.txb_num1.Name = "txb_num1";
            this.txb_num1.Size = new System.Drawing.Size(125, 30);
            this.txb_num1.TabIndex = 0;
            this.txb_num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_num1_KeyPress);
            // 
            // txb_num2
            // 
            this.txb_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_num2.Location = new System.Drawing.Point(219, 55);
            this.txb_num2.Name = "txb_num2";
            this.txb_num2.Size = new System.Drawing.Size(125, 30);
            this.txb_num2.TabIndex = 1;
            this.txb_num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_num2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o primeiro numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite o segundo numero:";
            // 
            // btn_comp
            // 
            this.btn_comp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comp.Location = new System.Drawing.Point(219, 91);
            this.btn_comp.Name = "btn_comp";
            this.btn_comp.Size = new System.Drawing.Size(125, 46);
            this.btn_comp.TabIndex = 4;
            this.btn_comp.Text = "Comparar";
            this.btn_comp.UseVisualStyleBackColor = true;
            this.btn_comp.Click += new System.EventHandler(this.btn_comp_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(21, 91);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(125, 46);
            this.btn_limpar.TabIndex = 5;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 149);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_comp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_num2);
            this.Controls.Add(this.txb_num1);
            this.Name = "Form1";
            this.Text = "Comparação ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_num1;
        private System.Windows.Forms.TextBox txb_num2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_comp;
        private System.Windows.Forms.Button btn_limpar;
    }
}

