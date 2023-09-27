namespace Sucos_Vendas.View
{
    partial class Frm_CadastroCliente_UC
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroCliente_UC));
            this.lbl_DataNascimento = new System.Windows.Forms.Label();
            this.msk_DataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Idade = new System.Windows.Forms.Label();
            this.txt_Idade = new System.Windows.Forms.TextBox();
            this.msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_CPF = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.grp_Genero = new System.Windows.Forms.GroupBox();
            this.rb_Feminino = new System.Windows.Forms.RadioButton();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.rb_Masculino = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Endereco2 = new System.Windows.Forms.Label();
            this.lbl_Endereco1 = new System.Windows.Forms.Label();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.lbl_Cep = new System.Windows.Forms.Label();
            this.txt_Endereco1 = new System.Windows.Forms.TextBox();
            this.txt_Endereco2 = new System.Windows.Forms.TextBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.msk_CEP = new System.Windows.Forms.MaskedTextBox();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_PrimeiraCompra = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cbo_PrimeiraCompra = new System.Windows.Forms.Label();
            this.lbl_VolumeDeCompra = new System.Windows.Forms.Label();
            this.lbl_LimiteDeCredito = new System.Windows.Forms.Label();
            this.txt_LimiteCredito = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.imprimirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.recortarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copiarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.grp_Genero.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_DataNascimento
            // 
            this.lbl_DataNascimento.AutoSize = true;
            this.lbl_DataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataNascimento.Location = new System.Drawing.Point(11, 144);
            this.lbl_DataNascimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DataNascimento.Name = "lbl_DataNascimento";
            this.lbl_DataNascimento.Size = new System.Drawing.Size(136, 17);
            this.lbl_DataNascimento.TabIndex = 5;
            this.lbl_DataNascimento.Text = "Data de Nascimento";
            // 
            // msk_DataNascimento
            // 
            this.msk_DataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_DataNascimento.Location = new System.Drawing.Point(14, 162);
            this.msk_DataNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.msk_DataNascimento.Mask = "00/00/0000";
            this.msk_DataNascimento.Name = "msk_DataNascimento";
            this.msk_DataNascimento.Size = new System.Drawing.Size(170, 23);
            this.msk_DataNascimento.TabIndex = 4;
            this.msk_DataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_Idade
            // 
            this.lbl_Idade.AutoSize = true;
            this.lbl_Idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idade.Location = new System.Drawing.Point(202, 144);
            this.lbl_Idade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Idade.Name = "lbl_Idade";
            this.lbl_Idade.Size = new System.Drawing.Size(43, 17);
            this.lbl_Idade.TabIndex = 6;
            this.lbl_Idade.Text = "Idade";
            // 
            // txt_Idade
            // 
            this.txt_Idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Idade.Location = new System.Drawing.Point(202, 162);
            this.txt_Idade.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Idade.Name = "txt_Idade";
            this.txt_Idade.Size = new System.Drawing.Size(80, 23);
            this.txt_Idade.TabIndex = 5;
            // 
            // msk_CPF
            // 
            this.msk_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_CPF.Location = new System.Drawing.Point(14, 51);
            this.msk_CPF.Margin = new System.Windows.Forms.Padding(2);
            this.msk_CPF.Mask = "000.000.000-00";
            this.msk_CPF.Name = "msk_CPF";
            this.msk_CPF.Size = new System.Drawing.Size(170, 23);
            this.msk_CPF.TabIndex = 1;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(11, 83);
            this.lbl_Nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(45, 17);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "Nome";
            // 
            // lbl_CPF
            // 
            this.lbl_CPF.AutoSize = true;
            this.lbl_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CPF.Location = new System.Drawing.Point(10, 32);
            this.lbl_CPF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CPF.Name = "lbl_CPF";
            this.lbl_CPF.Size = new System.Drawing.Size(34, 17);
            this.lbl_CPF.TabIndex = 0;
            this.lbl_CPF.Text = "CPF";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(14, 102);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(1530, 23);
            this.txt_Nome.TabIndex = 2;
            // 
            // grp_Genero
            // 
            this.grp_Genero.Controls.Add(this.rb_Feminino);
            this.grp_Genero.Controls.Add(this.lbl_Sexo);
            this.grp_Genero.Controls.Add(this.rb_Masculino);
            this.grp_Genero.Location = new System.Drawing.Point(304, 128);
            this.grp_Genero.Margin = new System.Windows.Forms.Padding(2);
            this.grp_Genero.Name = "grp_Genero";
            this.grp_Genero.Padding = new System.Windows.Forms.Padding(2);
            this.grp_Genero.Size = new System.Drawing.Size(211, 64);
            this.grp_Genero.TabIndex = 10;
            this.grp_Genero.TabStop = false;
            // 
            // rb_Feminino
            // 
            this.rb_Feminino.AutoSize = true;
            this.rb_Feminino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Feminino.Location = new System.Drawing.Point(103, 35);
            this.rb_Feminino.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Feminino.Name = "rb_Feminino";
            this.rb_Feminino.Size = new System.Drawing.Size(83, 21);
            this.rb_Feminino.TabIndex = 9;
            this.rb_Feminino.TabStop = true;
            this.rb_Feminino.Text = "Feminino";
            this.rb_Feminino.UseVisualStyleBackColor = true;
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sexo.Location = new System.Drawing.Point(7, 15);
            this.lbl_Sexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(56, 17);
            this.lbl_Sexo.TabIndex = 7;
            this.lbl_Sexo.Text = "Gênero";
            // 
            // rb_Masculino
            // 
            this.rb_Masculino.AutoSize = true;
            this.rb_Masculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Masculino.Location = new System.Drawing.Point(10, 34);
            this.rb_Masculino.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Masculino.Name = "rb_Masculino";
            this.rb_Masculino.Size = new System.Drawing.Size(89, 21);
            this.rb_Masculino.TabIndex = 8;
            this.rb_Masculino.TabStop = true;
            this.rb_Masculino.Text = "Masculino";
            this.rb_Masculino.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grp_Genero);
            this.groupBox1.Controls.Add(this.txt_Nome);
            this.groupBox1.Controls.Add(this.lbl_CPF);
            this.groupBox1.Controls.Add(this.lbl_Nome);
            this.groupBox1.Controls.Add(this.msk_CPF);
            this.groupBox1.Controls.Add(this.txt_Idade);
            this.groupBox1.Controls.Add(this.lbl_Idade);
            this.groupBox1.Controls.Add(this.msk_DataNascimento);
            this.groupBox1.Controls.Add(this.lbl_DataNascimento);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1558, 219);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // lbl_Endereco2
            // 
            this.lbl_Endereco2.AutoSize = true;
            this.lbl_Endereco2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Endereco2.Location = new System.Drawing.Point(10, 84);
            this.lbl_Endereco2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Endereco2.Name = "lbl_Endereco2";
            this.lbl_Endereco2.Size = new System.Drawing.Size(81, 17);
            this.lbl_Endereco2.TabIndex = 21;
            this.lbl_Endereco2.Text = "Endereco 2";
            // 
            // lbl_Endereco1
            // 
            this.lbl_Endereco1.AutoSize = true;
            this.lbl_Endereco1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Endereco1.Location = new System.Drawing.Point(10, 32);
            this.lbl_Endereco1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Endereco1.Name = "lbl_Endereco1";
            this.lbl_Endereco1.Size = new System.Drawing.Size(81, 17);
            this.lbl_Endereco1.TabIndex = 20;
            this.lbl_Endereco1.Text = "Endereco 1";
            // 
            // lbl_Bairro
            // 
            this.lbl_Bairro.AutoSize = true;
            this.lbl_Bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bairro.Location = new System.Drawing.Point(11, 140);
            this.lbl_Bairro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Bairro.Name = "lbl_Bairro";
            this.lbl_Bairro.Size = new System.Drawing.Size(46, 17);
            this.lbl_Bairro.TabIndex = 24;
            this.lbl_Bairro.Text = "Bairro";
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bairro.Location = new System.Drawing.Point(12, 158);
            this.txt_Bairro.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(1532, 23);
            this.txt_Bairro.TabIndex = 8;
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cidade.Location = new System.Drawing.Point(12, 210);
            this.txt_Cidade.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(1532, 23);
            this.txt_Cidade.TabIndex = 9;
            // 
            // lbl_Cep
            // 
            this.lbl_Cep.AutoSize = true;
            this.lbl_Cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cep.Location = new System.Drawing.Point(456, 252);
            this.lbl_Cep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Cep.Name = "lbl_Cep";
            this.lbl_Cep.Size = new System.Drawing.Size(35, 17);
            this.lbl_Cep.TabIndex = 4;
            this.lbl_Cep.Text = "CEP";
            // 
            // txt_Endereco1
            // 
            this.txt_Endereco1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Endereco1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Endereco1.Location = new System.Drawing.Point(13, 50);
            this.txt_Endereco1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Endereco1.Name = "txt_Endereco1";
            this.txt_Endereco1.Size = new System.Drawing.Size(1532, 23);
            this.txt_Endereco1.TabIndex = 6;
            // 
            // txt_Endereco2
            // 
            this.txt_Endereco2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Endereco2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Endereco2.Location = new System.Drawing.Point(14, 103);
            this.txt_Endereco2.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Endereco2.Name = "txt_Endereco2";
            this.txt_Endereco2.Size = new System.Drawing.Size(1531, 23);
            this.txt_Endereco2.TabIndex = 7;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.Location = new System.Drawing.Point(11, 245);
            this.lbl_Estado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(52, 17);
            this.lbl_Estado.TabIndex = 3;
            this.lbl_Estado.Text = "Estado";
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cidade.Location = new System.Drawing.Point(10, 191);
            this.lbl_Cidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(52, 17);
            this.lbl_Cidade.TabIndex = 2;
            this.lbl_Cidade.Text = "Cidade";
            // 
            // msk_CEP
            // 
            this.msk_CEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_CEP.Location = new System.Drawing.Point(458, 271);
            this.msk_CEP.Margin = new System.Windows.Forms.Padding(2);
            this.msk_CEP.Mask = "00000-000";
            this.msk_CEP.Name = "msk_CEP";
            this.msk_CEP.Size = new System.Drawing.Size(103, 23);
            this.msk_CEP.TabIndex = 11;
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Location = new System.Drawing.Point(12, 271);
            this.cmb_Estado.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(432, 25);
            this.cmb_Estado.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_Estado);
            this.groupBox2.Controls.Add(this.msk_CEP);
            this.groupBox2.Controls.Add(this.lbl_Cidade);
            this.groupBox2.Controls.Add(this.lbl_Estado);
            this.groupBox2.Controls.Add(this.txt_Endereco2);
            this.groupBox2.Controls.Add(this.txt_Endereco1);
            this.groupBox2.Controls.Add(this.lbl_Cep);
            this.groupBox2.Controls.Add(this.txt_Cidade);
            this.groupBox2.Controls.Add(this.txt_Bairro);
            this.groupBox2.Controls.Add(this.lbl_Bairro);
            this.groupBox2.Controls.Add(this.lbl_Endereco1);
            this.groupBox2.Controls.Add(this.lbl_Endereco2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 307);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1558, 326);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações de Endereço";
            // 
            // cmb_PrimeiraCompra
            // 
            this.cmb_PrimeiraCompra.FormattingEnabled = true;
            this.cmb_PrimeiraCompra.Location = new System.Drawing.Point(416, 63);
            this.cmb_PrimeiraCompra.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_PrimeiraCompra.Name = "cmb_PrimeiraCompra";
            this.cmb_PrimeiraCompra.Size = new System.Drawing.Size(92, 28);
            this.cmb_PrimeiraCompra.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(16, 122);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(357, 23);
            this.textBox6.TabIndex = 14;
            // 
            // cbo_PrimeiraCompra
            // 
            this.cbo_PrimeiraCompra.AutoSize = true;
            this.cbo_PrimeiraCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_PrimeiraCompra.Location = new System.Drawing.Point(412, 40);
            this.cbo_PrimeiraCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cbo_PrimeiraCompra.Name = "cbo_PrimeiraCompra";
            this.cbo_PrimeiraCompra.Size = new System.Drawing.Size(113, 17);
            this.cbo_PrimeiraCompra.TabIndex = 27;
            this.cbo_PrimeiraCompra.Text = "Primeira Compra";
            // 
            // lbl_VolumeDeCompra
            // 
            this.lbl_VolumeDeCompra.AutoSize = true;
            this.lbl_VolumeDeCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VolumeDeCompra.Location = new System.Drawing.Point(10, 99);
            this.lbl_VolumeDeCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_VolumeDeCompra.Name = "lbl_VolumeDeCompra";
            this.lbl_VolumeDeCompra.Size = new System.Drawing.Size(128, 17);
            this.lbl_VolumeDeCompra.TabIndex = 9;
            this.lbl_VolumeDeCompra.Text = "Volume de Compra";
            // 
            // lbl_LimiteDeCredito
            // 
            this.lbl_LimiteDeCredito.AutoSize = true;
            this.lbl_LimiteDeCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LimiteDeCredito.Location = new System.Drawing.Point(10, 40);
            this.lbl_LimiteDeCredito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LimiteDeCredito.Name = "lbl_LimiteDeCredito";
            this.lbl_LimiteDeCredito.Size = new System.Drawing.Size(114, 17);
            this.lbl_LimiteDeCredito.TabIndex = 8;
            this.lbl_LimiteDeCredito.Text = "Limite de Credito";
            // 
            // txt_LimiteCredito
            // 
            this.txt_LimiteCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LimiteCredito.Location = new System.Drawing.Point(13, 63);
            this.txt_LimiteCredito.Margin = new System.Windows.Forms.Padding(2);
            this.txt_LimiteCredito.Name = "txt_LimiteCredito";
            this.txt_LimiteCredito.Size = new System.Drawing.Size(360, 23);
            this.txt_LimiteCredito.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_LimiteCredito);
            this.groupBox3.Controls.Add(this.lbl_LimiteDeCredito);
            this.groupBox3.Controls.Add(this.lbl_VolumeDeCompra);
            this.groupBox3.Controls.Add(this.cbo_PrimeiraCompra);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.cmb_PrimeiraCompra);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 659);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(1558, 185);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações de Vendas";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripButton,
            this.abrirToolStripButton,
            this.salvarToolStripButton,
            this.imprimirToolStripButton,
            this.toolStripSeparator,
            this.recortarToolStripButton,
            this.copiarToolStripButton,
            this.colarToolStripButton,
            this.toolStripSeparator1,
            this.ajudaToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1706, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // novoToolStripButton
            // 
            this.novoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.novoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton.Image")));
            this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton.Name = "novoToolStripButton";
            this.novoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.novoToolStripButton.Text = "&Novo";
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton.Image")));
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.abrirToolStripButton.Text = "&Abrir";
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton.Text = "&Salvar";
            // 
            // imprimirToolStripButton
            // 
            this.imprimirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripButton.Image")));
            this.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripButton.Name = "imprimirToolStripButton";
            this.imprimirToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.imprimirToolStripButton.Text = "&Imprimir";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // recortarToolStripButton
            // 
            this.recortarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.recortarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("recortarToolStripButton.Image")));
            this.recortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.recortarToolStripButton.Name = "recortarToolStripButton";
            this.recortarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.recortarToolStripButton.Text = "Recor&tar";
            // 
            // copiarToolStripButton
            // 
            this.copiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton.Image")));
            this.copiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton.Name = "copiarToolStripButton";
            this.copiarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copiarToolStripButton.Text = "&Copiar";
            // 
            // colarToolStripButton
            // 
            this.colarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("colarToolStripButton.Image")));
            this.colarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colarToolStripButton.Name = "colarToolStripButton";
            this.colarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.colarToolStripButton.Text = "C&olar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ajudaToolStripButton
            // 
            this.ajudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ajudaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripButton.Image")));
            this.ajudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ajudaToolStripButton.Name = "ajudaToolStripButton";
            this.ajudaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ajudaToolStripButton.Text = "&Ajuda";
            // 
            // Frm_CadastroCliente_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_CadastroCliente_UC";
            this.Size = new System.Drawing.Size(1706, 904);
            this.grp_Genero.ResumeLayout(false);
            this.grp_Genero.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DataNascimento;
        private System.Windows.Forms.MaskedTextBox msk_DataNascimento;
        private System.Windows.Forms.Label lbl_Idade;
        private System.Windows.Forms.TextBox txt_Idade;
        private System.Windows.Forms.MaskedTextBox msk_CPF;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_CPF;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.GroupBox grp_Genero;
        private System.Windows.Forms.RadioButton rb_Feminino;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.RadioButton rb_Masculino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Endereco2;
        private System.Windows.Forms.Label lbl_Endereco1;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.Label lbl_Cep;
        private System.Windows.Forms.TextBox txt_Endereco1;
        private System.Windows.Forms.TextBox txt_Endereco2;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.MaskedTextBox msk_CEP;
        private System.Windows.Forms.ComboBox cmb_Estado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_PrimeiraCompra;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label cbo_PrimeiraCompra;
        private System.Windows.Forms.Label lbl_VolumeDeCompra;
        private System.Windows.Forms.Label lbl_LimiteDeCredito;
        private System.Windows.Forms.TextBox txt_LimiteCredito;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton novoToolStripButton;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripButton imprimirToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton recortarToolStripButton;
        private System.Windows.Forms.ToolStripButton copiarToolStripButton;
        private System.Windows.Forms.ToolStripButton colarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ajudaToolStripButton;
    }
}
