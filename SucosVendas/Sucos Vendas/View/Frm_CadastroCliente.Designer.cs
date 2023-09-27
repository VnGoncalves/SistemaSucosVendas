namespace Sucos_Vendas.View
{
    partial class Frm_CadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroCliente));
            this.tbc_Aplicacoes = new System.Windows.Forms.TabControl();
            this.iml_Imagens = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_Aplicacoes
            // 
            this.tbc_Aplicacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbc_Aplicacoes.ImageList = this.iml_Imagens;
            this.tbc_Aplicacoes.Location = new System.Drawing.Point(1, 0);
            this.tbc_Aplicacoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbc_Aplicacoes.Name = "tbc_Aplicacoes";
            this.tbc_Aplicacoes.SelectedIndex = 0;
            this.tbc_Aplicacoes.Size = new System.Drawing.Size(1356, 705);
            this.tbc_Aplicacoes.TabIndex = 0;
            // 
            // iml_Imagens
            // 
            this.iml_Imagens.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iml_Imagens.ImageStream")));
            this.iml_Imagens.TransparentColor = System.Drawing.Color.Transparent;
            this.iml_Imagens.Images.SetKeyName(0, "user.png");
            this.iml_Imagens.Images.SetKeyName(1, "cadastro.png");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(85, 28);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(84, 24);
            this.toolStripMenuItem2.Text = ";;";
            // 
            // Frm_CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 708);
            this.Controls.Add(this.tbc_Aplicacoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_CadastroCliente";
            this.Text = "Cadastro de Clientes";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tbc_Aplicacoes;
        private System.Windows.Forms.ImageList iml_Imagens;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}