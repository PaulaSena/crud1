
namespace crud1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DgTb01 = new System.Windows.Forms.DataGridView();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnNomeDelete = new System.Windows.Forms.Button();
            this.TxtDeleteID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtUpdateID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnNomeUpdate = new System.Windows.Forms.Button();
            this.TxtNomeUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNomeInserir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNomeInserir = new System.Windows.Forms.Button();
            this.gridPessoa = new System.Windows.Forms.DataGridView();
            this.txtIdPessoa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblMsgErro = new System.Windows.Forms.Label();
            this.pctBoxMsgErro = new System.Windows.Forms.PictureBox();
            this.lblCPessoa = new System.Windows.Forms.Label();
            this.cbxEmailPromo = new System.Windows.Forms.CheckBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.lblInf3 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.dataTimeS = new System.Windows.Forms.DateTimePicker();
            this.maskDataN = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgTb01)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMsgErro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DgTb01);
            this.groupBox4.Controls.Add(this.BtnConsultar);
            this.groupBox4.Location = new System.Drawing.Point(394, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(409, 275);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consultar";
            // 
            // DgTb01
            // 
            this.DgTb01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgTb01.Location = new System.Drawing.Point(31, 82);
            this.DgTb01.Name = "DgTb01";
            this.DgTb01.Size = new System.Drawing.Size(355, 178);
            this.DgTb01.TabIndex = 1;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(149, 28);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultar.TabIndex = 0;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnNomeDelete);
            this.groupBox3.Controls.Add(this.TxtDeleteID);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(-3, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 97);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete";
            // 
            // BtnNomeDelete
            // 
            this.BtnNomeDelete.Location = new System.Drawing.Point(275, 28);
            this.BtnNomeDelete.Name = "BtnNomeDelete";
            this.BtnNomeDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnNomeDelete.TabIndex = 2;
            this.BtnNomeDelete.Text = "Delete";
            this.BtnNomeDelete.UseVisualStyleBackColor = true;
            // 
            // TxtDeleteID
            // 
            this.TxtDeleteID.Location = new System.Drawing.Point(88, 30);
            this.TxtDeleteID.Name = "TxtDeleteID";
            this.TxtDeleteID.Size = new System.Drawing.Size(155, 20);
            this.TxtDeleteID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtUpdateID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BtnNomeUpdate);
            this.groupBox2.Controls.Add(this.TxtNomeUpdate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(-3, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 97);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update";
            // 
            // TxtUpdateID
            // 
            this.TxtUpdateID.Location = new System.Drawing.Point(88, 59);
            this.TxtUpdateID.Name = "TxtUpdateID";
            this.TxtUpdateID.Size = new System.Drawing.Size(155, 20);
            this.TxtUpdateID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID";
            // 
            // BtnNomeUpdate
            // 
            this.BtnNomeUpdate.Location = new System.Drawing.Point(275, 28);
            this.BtnNomeUpdate.Name = "BtnNomeUpdate";
            this.BtnNomeUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnNomeUpdate.TabIndex = 2;
            this.BtnNomeUpdate.Text = "Update";
            this.BtnNomeUpdate.UseVisualStyleBackColor = true;
            // 
            // TxtNomeUpdate
            // 
            this.TxtNomeUpdate.Location = new System.Drawing.Point(88, 30);
            this.TxtNomeUpdate.Name = "TxtNomeUpdate";
            this.TxtNomeUpdate.Size = new System.Drawing.Size(155, 20);
            this.TxtNomeUpdate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtNomeInserir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-3, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert";
            // 
            // TxtNomeInserir
            // 
            this.TxtNomeInserir.Location = new System.Drawing.Point(88, 30);
            this.TxtNomeInserir.Name = "TxtNomeInserir";
            this.TxtNomeInserir.Size = new System.Drawing.Size(155, 20);
            this.TxtNomeInserir.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // BtnNomeInserir
            // 
            this.BtnNomeInserir.Location = new System.Drawing.Point(293, 518);
            this.BtnNomeInserir.Name = "BtnNomeInserir";
            this.BtnNomeInserir.Size = new System.Drawing.Size(75, 23);
            this.BtnNomeInserir.TabIndex = 2;
            this.BtnNomeInserir.Text = "Inserir";
            this.BtnNomeInserir.UseVisualStyleBackColor = true;
            this.BtnNomeInserir.Click += new System.EventHandler(this.BtnNomeInserir_Click);
            // 
            // gridPessoa
            // 
            this.gridPessoa.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon;
            this.gridPessoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPessoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPessoa.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridPessoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPessoa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridPessoa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPessoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPessoa.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridPessoa.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridPessoa.GridColor = System.Drawing.Color.Gainsboro;
            this.gridPessoa.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.gridPessoa.Location = new System.Drawing.Point(390, 339);
            this.gridPessoa.Name = "gridPessoa";
            this.gridPessoa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPessoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridPessoa.RowHeadersVisible = false;
            this.gridPessoa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.gridPessoa.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.gridPessoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPessoa.Size = new System.Drawing.Size(551, 58);
            this.gridPessoa.TabIndex = 264;
            // 
            // txtIdPessoa
            // 
            this.txtIdPessoa.BackColor = System.Drawing.Color.GhostWhite;
            this.txtIdPessoa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdPessoa.Enabled = false;
            this.txtIdPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPessoa.Location = new System.Drawing.Point(398, 423);
            this.txtIdPessoa.Multiline = true;
            this.txtIdPessoa.Name = "txtIdPessoa";
            this.txtIdPessoa.Size = new System.Drawing.Size(79, 27);
            this.txtIdPessoa.TabIndex = 263;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(398, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 262;
            this.label11.Text = "ID";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.GhostWhite;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(398, 471);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(225, 27);
            this.txtNome.TabIndex = 259;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(398, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 258;
            this.label9.Text = "NOME ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(613, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 257;
            this.label10.Text = "?";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblHora.Location = new System.Drawing.Point(399, 755);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(73, 25);
            this.lblHora.TabIndex = 256;
            this.lblHora.Text = "lblHora";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblData.Location = new System.Drawing.Point(740, 755);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(72, 25);
            this.lblData.TabIndex = 255;
            this.lblData.Text = "lblData";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(660, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 251;
            this.label7.Text = "PAÍS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(881, 610);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 250;
            this.label8.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(660, 562);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 249;
            this.label5.Text = "ESTADO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(881, 556);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 248;
            this.label6.Text = "?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(661, 614);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 247;
            this.label12.Text = "CIDADE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(881, 505);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 17);
            this.label13.TabIndex = 246;
            this.label13.Text = "?";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(398, 630);
            this.txtTelefone.Multiline = true;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(224, 27);
            this.txtTelefone.TabIndex = 244;
            // 
            // lblMsgErro
            // 
            this.lblMsgErro.AutoSize = true;
            this.lblMsgErro.Location = new System.Drawing.Point(416, 672);
            this.lblMsgErro.Name = "lblMsgErro";
            this.lblMsgErro.Size = new System.Drawing.Size(99, 13);
            this.lblMsgErro.TabIndex = 242;
            this.lblMsgErro.Text = "Mensagem de Erro ";
            this.lblMsgErro.Visible = false;
            // 
            // pctBoxMsgErro
            // 
            this.pctBoxMsgErro.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxMsgErro.Image")));
            this.pctBoxMsgErro.Location = new System.Drawing.Point(388, 669);
            this.pctBoxMsgErro.Name = "pctBoxMsgErro";
            this.pctBoxMsgErro.Size = new System.Drawing.Size(37, 19);
            this.pctBoxMsgErro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBoxMsgErro.TabIndex = 243;
            this.pctBoxMsgErro.TabStop = false;
            this.pctBoxMsgErro.Visible = false;
            // 
            // lblCPessoa
            // 
            this.lblCPessoa.AutoSize = true;
            this.lblCPessoa.BackColor = System.Drawing.Color.Transparent;
            this.lblCPessoa.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPessoa.ForeColor = System.Drawing.Color.White;
            this.lblCPessoa.Location = new System.Drawing.Point(80, 518);
            this.lblCPessoa.Name = "lblCPessoa";
            this.lblCPessoa.Size = new System.Drawing.Size(160, 30);
            this.lblCPessoa.TabIndex = 241;
            this.lblCPessoa.Text = "Dados Pessoais";
            // 
            // cbxEmailPromo
            // 
            this.cbxEmailPromo.AutoSize = true;
            this.cbxEmailPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxEmailPromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.cbxEmailPromo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbxEmailPromo.Location = new System.Drawing.Point(401, 701);
            this.cbxEmailPromo.Name = "cbxEmailPromo";
            this.cbxEmailPromo.Size = new System.Drawing.Size(231, 17);
            this.cbxEmailPromo.TabIndex = 240;
            this.cbxEmailPromo.Text = "A ceito receber e-mails promocionais";
            this.cbxEmailPromo.UseVisualStyleBackColor = true;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.BackColor = System.Drawing.Color.GhostWhite;
            this.txtSobrenome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(398, 518);
            this.txtSobrenome.Multiline = true;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(225, 27);
            this.txtSobrenome.TabIndex = 239;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(398, 558);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(39, 13);
            this.lblSenha.TabIndex = 238;
            this.lblSenha.Text = "EMAIL";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfo2.Location = new System.Drawing.Point(617, 552);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(16, 17);
            this.lblInfo2.TabIndex = 237;
            this.lblInfo2.Text = "?";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(398, 504);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 235;
            this.label15.Text = "SOBRENOME";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(398, 572);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 27);
            this.txtEmail.TabIndex = 236;
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.ForeColor = System.Drawing.Color.Maroon;
            this.lblInfo1.Location = new System.Drawing.Point(616, 498);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(16, 17);
            this.lblInfo1.TabIndex = 234;
            this.lblInfo1.Text = "?";
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblConfSenha.ForeColor = System.Drawing.Color.White;
            this.lblConfSenha.Location = new System.Drawing.Point(398, 616);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(63, 13);
            this.lblConfSenha.TabIndex = 233;
            this.lblConfSenha.Text = "TELEFONE";
            // 
            // lblInf3
            // 
            this.lblInf3.AutoSize = true;
            this.lblInf3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInf3.ForeColor = System.Drawing.Color.Maroon;
            this.lblInf3.Location = new System.Drawing.Point(616, 609);
            this.lblInf3.Name = "lblInf3";
            this.lblInf3.Size = new System.Drawing.Size(16, 17);
            this.lblInf3.TabIndex = 232;
            this.lblInf3.Text = "?";
            // 
            // txtPais
            // 
            this.txtPais.BackColor = System.Drawing.Color.GhostWhite;
            this.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.Location = new System.Drawing.Point(663, 529);
            this.txtPais.Multiline = true;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(225, 27);
            this.txtPais.TabIndex = 267;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.GhostWhite;
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(663, 576);
            this.txtEstado.Multiline = true;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(225, 27);
            this.txtEstado.TabIndex = 266;
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(663, 630);
            this.txtCidade.Multiline = true;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(225, 27);
            this.txtCidade.TabIndex = 265;
            // 
            // dataTimeS
            // 
            this.dataTimeS.CustomFormat = "dd-mm-yyyy";
            this.dataTimeS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTimeS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataTimeS.Location = new System.Drawing.Point(694, 484);
            this.dataTimeS.Name = "dataTimeS";
            this.dataTimeS.Size = new System.Drawing.Size(109, 24);
            this.dataTimeS.TabIndex = 270;
            // 
            // maskDataN
            // 
            this.maskDataN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.maskDataN.Location = new System.Drawing.Point(694, 442);
            this.maskDataN.Mask = "00/00/0000";
            this.maskDataN.Name = "maskDataN";
            this.maskDataN.Size = new System.Drawing.Size(109, 26);
            this.maskDataN.TabIndex = 269;
            this.maskDataN.ValidatingType = typeof(System.DateTime);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(691, 426);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 13);
            this.label14.TabIndex = 268;
            this.label14.Text = "DATA DE NASCIMENTO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(970, 1005);
            this.Controls.Add(this.dataTimeS);
            this.Controls.Add(this.maskDataN);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.BtnNomeInserir);
            this.Controls.Add(this.gridPessoa);
            this.Controls.Add(this.txtIdPessoa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblMsgErro);
            this.Controls.Add(this.pctBoxMsgErro);
            this.Controls.Add(this.lblCPessoa);
            this.Controls.Add(this.cbxEmailPromo);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.lblConfSenha);
            this.Controls.Add(this.lblInf3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgTb01)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxMsgErro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DgTb01;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnNomeDelete;
        private System.Windows.Forms.TextBox TxtDeleteID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtUpdateID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnNomeUpdate;
        private System.Windows.Forms.TextBox TxtNomeUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnNomeInserir;
        private System.Windows.Forms.TextBox TxtNomeInserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridPessoa;
        private System.Windows.Forms.TextBox txtIdPessoa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblMsgErro;
        private System.Windows.Forms.PictureBox pctBoxMsgErro;
        private System.Windows.Forms.Label lblCPessoa;
        private System.Windows.Forms.CheckBox cbxEmailPromo;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.Label lblInf3;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.DateTimePicker dataTimeS;
        private System.Windows.Forms.MaskedTextBox maskDataN;
        private System.Windows.Forms.Label label14;
    }
}

