namespace Atividade1_Repeticao
{
    partial class frm_Home
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
            this.btn_Exe2 = new System.Windows.Forms.Button();
            this.btn_Exe1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Exe2
            // 
            this.btn_Exe2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exe2.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exe2.Location = new System.Drawing.Point(47, 158);
            this.btn_Exe2.Name = "btn_Exe2";
            this.btn_Exe2.Size = new System.Drawing.Size(285, 77);
            this.btn_Exe2.TabIndex = 3;
            this.btn_Exe2.Text = "Exercicio 2";
            this.btn_Exe2.UseVisualStyleBackColor = true;
            this.btn_Exe2.Click += new System.EventHandler(this.Btn_Exe2_Click);
            // 
            // btn_Exe1
            // 
            this.btn_Exe1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exe1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exe1.Location = new System.Drawing.Point(47, 41);
            this.btn_Exe1.Name = "btn_Exe1";
            this.btn_Exe1.Size = new System.Drawing.Size(285, 77);
            this.btn_Exe1.TabIndex = 2;
            this.btn_Exe1.Text = "Exercicio 1";
            this.btn_Exe1.UseVisualStyleBackColor = true;
            this.btn_Exe1.Click += new System.EventHandler(this.Btn_Exe1_Click);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 278);
            this.Controls.Add(this.btn_Exe2);
            this.Controls.Add(this.btn_Exe1);
            this.Name = "frm_Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Exe2;
        private System.Windows.Forms.Button btn_Exe1;
    }
}

