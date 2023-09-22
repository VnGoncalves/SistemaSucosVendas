namespace Sucos_Vendas.View
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPÇÕESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSDOSISTEMAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPÇÕESToolStripMenuItem,
            this.cADASTROSToolStripMenuItem,
            this.vENDASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1263, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPÇÕESToolStripMenuItem
            // 
            this.oPÇÕESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOSDOSISTEMAToolStripMenuItem,
            this.sOBREToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.oPÇÕESToolStripMenuItem.Name = "oPÇÕESToolStripMenuItem";
            this.oPÇÕESToolStripMenuItem.Size = new System.Drawing.Size(92, 32);
            this.oPÇÕESToolStripMenuItem.Text = "Opções";
            // 
            // uSUARIOSDOSISTEMAToolStripMenuItem
            // 
            this.uSUARIOSDOSISTEMAToolStripMenuItem.Name = "uSUARIOSDOSISTEMAToolStripMenuItem";
            this.uSUARIOSDOSISTEMAToolStripMenuItem.Size = new System.Drawing.Size(275, 32);
            this.uSUARIOSDOSISTEMAToolStripMenuItem.Text = "Usuários do Sistema";
            // 
            // sOBREToolStripMenuItem
            // 
            this.sOBREToolStripMenuItem.Name = "sOBREToolStripMenuItem";
            this.sOBREToolStripMenuItem.Size = new System.Drawing.Size(275, 32);
            this.sOBREToolStripMenuItem.Text = "Sobre";
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(275, 32);
            this.sAIRToolStripMenuItem.Text = "Sair";
            // 
            // cADASTROSToolStripMenuItem
            // 
            this.cADASTROSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTEToolStripMenuItem,
            this.pRODUTOToolStripMenuItem});
            this.cADASTROSToolStripMenuItem.Name = "cADASTROSToolStripMenuItem";
            this.cADASTROSToolStripMenuItem.Size = new System.Drawing.Size(112, 32);
            this.cADASTROSToolStripMenuItem.Text = "Cadastros";
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(170, 32);
            this.cLIENTEToolStripMenuItem.Text = "Cliente";
            this.cLIENTEToolStripMenuItem.Click += new System.EventHandler(this.ClienteToolStripMenuItem_Click);
            // 
            // pRODUTOToolStripMenuItem
            // 
            this.pRODUTOToolStripMenuItem.Name = "pRODUTOToolStripMenuItem";
            this.pRODUTOToolStripMenuItem.Size = new System.Drawing.Size(170, 32);
            this.pRODUTOToolStripMenuItem.Text = "Produto";
            // 
            // vENDASToolStripMenuItem
            // 
            this.vENDASToolStripMenuItem.Name = "vENDASToolStripMenuItem";
            this.vENDASToolStripMenuItem.Size = new System.Drawing.Size(88, 32);
            this.vENDASToolStripMenuItem.Text = "Vendas";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 723);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPÇÕESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOSDOSISTEMAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOBREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENDASToolStripMenuItem;
    }
}