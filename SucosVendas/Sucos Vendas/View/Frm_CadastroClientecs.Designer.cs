namespace Sucos_Vendas.View
{
    partial class Frm_CadastroClientecs
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
            this.tbc_Aplicacoes = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tbc_Aplicacoes
            // 
            this.tbc_Aplicacoes.Location = new System.Drawing.Point(-3, 1);
            this.tbc_Aplicacoes.Name = "tbc_Aplicacoes";
            this.tbc_Aplicacoes.SelectedIndex = 0;
            this.tbc_Aplicacoes.Size = new System.Drawing.Size(1108, 654);
            this.tbc_Aplicacoes.TabIndex = 0;
            // 
            // Frm__CadastroClientecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 655);
            this.Controls.Add(this.tbc_Aplicacoes);
            this.Name = "Frm__CadastroClientecs";
            this.Text = "Frm__CadastroClientecs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_Aplicacoes;
    }
}