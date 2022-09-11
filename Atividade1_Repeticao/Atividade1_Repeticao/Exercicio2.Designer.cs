namespace Atividade1_Repeticao
{
    partial class frm_Exe2
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
            this.grp_Resultado = new System.Windows.Forms.GroupBox();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.btn_Executar = new System.Windows.Forms.Button();
            this.txt_VntInicial = new System.Windows.Forms.TextBox();
            this.lbl_Valor_Inicial = new System.Windows.Forms.Label();
            this.grp_Resultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Resultado
            // 
            this.grp_Resultado.Controls.Add(this.lbl_Resultado);
            this.grp_Resultado.Location = new System.Drawing.Point(122, 206);
            this.grp_Resultado.Margin = new System.Windows.Forms.Padding(6);
            this.grp_Resultado.Name = "grp_Resultado";
            this.grp_Resultado.Padding = new System.Windows.Forms.Padding(6);
            this.grp_Resultado.Size = new System.Drawing.Size(263, 368);
            this.grp_Resultado.TabIndex = 19;
            this.grp_Resultado.TabStop = false;
            this.grp_Resultado.Text = "Resultado de repetições";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(44, 43);
            this.lbl_Resultado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(0, 13);
            this.lbl_Resultado.TabIndex = 0;
            // 
            // btn_Executar
            // 
            this.btn_Executar.Location = new System.Drawing.Point(297, 98);
            this.btn_Executar.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Executar.Name = "btn_Executar";
            this.btn_Executar.Size = new System.Drawing.Size(150, 42);
            this.btn_Executar.TabIndex = 18;
            this.btn_Executar.Text = "Mostrar";
            this.btn_Executar.UseVisualStyleBackColor = true;
            // 
            // txt_VntInicial
            // 
            this.txt_VntInicial.Location = new System.Drawing.Point(273, 53);
            this.txt_VntInicial.Margin = new System.Windows.Forms.Padding(6);
            this.txt_VntInicial.Name = "txt_VntInicial";
            this.txt_VntInicial.Size = new System.Drawing.Size(196, 20);
            this.txt_VntInicial.TabIndex = 17;
            // 
            // lbl_Valor_Inicial
            // 
            this.lbl_Valor_Inicial.AutoSize = true;
            this.lbl_Valor_Inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Valor_Inicial.Location = new System.Drawing.Point(58, 53);
            this.lbl_Valor_Inicial.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Valor_Inicial.Name = "lbl_Valor_Inicial";
            this.lbl_Valor_Inicial.Size = new System.Drawing.Size(166, 24);
            this.lbl_Valor_Inicial.TabIndex = 16;
            this.lbl_Valor_Inicial.Text = "Informe um valor";
            // 
            // frm_Exe2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 614);
            this.Controls.Add(this.grp_Resultado);
            this.Controls.Add(this.btn_Executar);
            this.Controls.Add(this.txt_VntInicial);
            this.Controls.Add(this.lbl_Valor_Inicial);
            this.Name = "frm_Exe2";
            this.Text = "Exercio 2";
            this.grp_Resultado.ResumeLayout(false);
            this.grp_Resultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grp_Resultado;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Button btn_Executar;
        private System.Windows.Forms.TextBox txt_VntInicial;
        private System.Windows.Forms.Label lbl_Valor_Inicial;
    }
}