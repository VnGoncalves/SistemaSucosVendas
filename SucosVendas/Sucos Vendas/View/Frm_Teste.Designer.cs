namespace Sucos_Vendas.View
{
    partial class Frm_Teste
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Teste));
            this.tbc_Aplicacoes = new System.Windows.Forms.TabControl();
            this.iml_Imagens = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tbc_Aplicacoes
            // 
            this.tbc_Aplicacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_Aplicacoes.ImageList = this.iml_Imagens;
            this.tbc_Aplicacoes.Location = new System.Drawing.Point(1, 1);
            this.tbc_Aplicacoes.Name = "tbc_Aplicacoes";
            this.tbc_Aplicacoes.SelectedIndex = 0;
            this.tbc_Aplicacoes.Size = new System.Drawing.Size(1155, 635);
            this.tbc_Aplicacoes.TabIndex = 0;
            // 
            // iml_Imagens
            // 
            this.iml_Imagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iml_Imagens.ImageStream")));
            this.iml_Imagens.TransparentColor = System.Drawing.Color.Transparent;
            this.iml_Imagens.Images.SetKeyName(0, "user.png");
            // 
            // Frm_Teste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 639);
            this.Controls.Add(this.tbc_Aplicacoes);
            this.Name = "Frm_Teste";
            this.Text = "Frm_Teste";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tbc_Aplicacoes;
        private System.Windows.Forms.ImageList iml_Imagens;
    }
}