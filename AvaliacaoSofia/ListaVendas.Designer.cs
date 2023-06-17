
namespace AvaliacaoSofia
{
    partial class ListaVendas
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
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lbCod = new System.Windows.Forms.Label();
            this.btCan = new System.Windows.Forms.Button();
            this.ListaVenda = new System.Windows.Forms.ListBox();
            this.comboCli = new System.Windows.Forms.ComboBox();
            this.lbCli = new System.Windows.Forms.Label();
            this.lbPro = new System.Windows.Forms.Label();
            this.lbQt = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.comboProd = new System.Windows.Forms.ComboBox();
            this.btAlt = new System.Windows.Forms.Button();
            this.btInc = new System.Windows.Forms.Button();
            this.btSel = new System.Windows.Forms.Button();
            this.btEx = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btVolt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCod.Location = new System.Drawing.Point(114, 75);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(305, 23);
            this.txtCod.TabIndex = 0;
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCod.Location = new System.Drawing.Point(45, 74);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(63, 20);
            this.lbCod.TabIndex = 1;
            this.lbCod.Text = "Código:";
            // 
            // btCan
            // 
            this.btCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btCan.Location = new System.Drawing.Point(114, 245);
            this.btCan.Name = "btCan";
            this.btCan.Size = new System.Drawing.Size(76, 26);
            this.btCan.TabIndex = 2;
            this.btCan.Text = "Cancelar";
            this.btCan.UseVisualStyleBackColor = true;
            this.btCan.Click += new System.EventHandler(this.BtCan_Click);
            // 
            // ListaVenda
            // 
            this.ListaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ListaVenda.FormattingEnabled = true;
            this.ListaVenda.ItemHeight = 16;
            this.ListaVenda.Location = new System.Drawing.Point(498, 79);
            this.ListaVenda.Name = "ListaVenda";
            this.ListaVenda.Size = new System.Drawing.Size(236, 132);
            this.ListaVenda.TabIndex = 3;
            // 
            // comboCli
            // 
            this.comboCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboCli.FormattingEnabled = true;
            this.comboCli.Location = new System.Drawing.Point(114, 119);
            this.comboCli.Name = "comboCli";
            this.comboCli.Size = new System.Drawing.Size(305, 24);
            this.comboCli.TabIndex = 4;
            // 
            // lbCli
            // 
            this.lbCli.AutoSize = true;
            this.lbCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCli.Location = new System.Drawing.Point(47, 120);
            this.lbCli.Name = "lbCli";
            this.lbCli.Size = new System.Drawing.Size(62, 20);
            this.lbCli.TabIndex = 5;
            this.lbCli.Text = "Cliente:";
            // 
            // lbPro
            // 
            this.lbPro.AutoSize = true;
            this.lbPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbPro.Location = new System.Drawing.Point(40, 165);
            this.lbPro.Name = "lbPro";
            this.lbPro.Size = new System.Drawing.Size(69, 20);
            this.lbPro.TabIndex = 6;
            this.lbPro.Text = "Produto:";
            // 
            // lbQt
            // 
            this.lbQt.AutoSize = true;
            this.lbQt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbQt.Location = new System.Drawing.Point(48, 204);
            this.lbQt.Name = "lbQt";
            this.lbQt.Size = new System.Drawing.Size(61, 20);
            this.lbQt.TabIndex = 7;
            this.lbQt.Text = "Quant.:";
            // 
            // txtQtd
            // 
            this.txtQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtQtd.Location = new System.Drawing.Point(114, 205);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(305, 23);
            this.txtQtd.TabIndex = 8;
            // 
            // comboProd
            // 
            this.comboProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboProd.FormattingEnabled = true;
            this.comboProd.Location = new System.Drawing.Point(114, 164);
            this.comboProd.Name = "comboProd";
            this.comboProd.Size = new System.Drawing.Size(305, 24);
            this.comboProd.TabIndex = 9;
            // 
            // btAlt
            // 
            this.btAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btAlt.Location = new System.Drawing.Point(318, 245);
            this.btAlt.Name = "btAlt";
            this.btAlt.Size = new System.Drawing.Size(76, 26);
            this.btAlt.TabIndex = 10;
            this.btAlt.Text = "Alterar";
            this.btAlt.UseVisualStyleBackColor = true;
            this.btAlt.Click += new System.EventHandler(this.BtAlt_Click);
            // 
            // btInc
            // 
            this.btInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btInc.Location = new System.Drawing.Point(216, 245);
            this.btInc.Name = "btInc";
            this.btInc.Size = new System.Drawing.Size(76, 26);
            this.btInc.TabIndex = 11;
            this.btInc.Text = "Incluir";
            this.btInc.UseVisualStyleBackColor = true;
            this.btInc.Click += new System.EventHandler(this.BtInc_Click);
            // 
            // btSel
            // 
            this.btSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btSel.Location = new System.Drawing.Point(523, 238);
            this.btSel.Name = "btSel";
            this.btSel.Size = new System.Drawing.Size(87, 26);
            this.btSel.TabIndex = 12;
            this.btSel.Text = "Selecionar";
            this.btSel.UseVisualStyleBackColor = true;
            this.btSel.Click += new System.EventHandler(this.BtSel_Click);
            // 
            // btEx
            // 
            this.btEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btEx.Location = new System.Drawing.Point(630, 238);
            this.btEx.Name = "btEx";
            this.btEx.Size = new System.Drawing.Size(76, 26);
            this.btEx.TabIndex = 13;
            this.btEx.Text = "Excluir";
            this.btEx.UseVisualStyleBackColor = true;
            this.btEx.Click += new System.EventHandler(this.BtEx_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(553, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lista de Vendas";
            // 
            // btVolt
            // 
            this.btVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btVolt.Location = new System.Drawing.Point(12, 12);
            this.btVolt.Name = "btVolt";
            this.btVolt.Size = new System.Drawing.Size(76, 26);
            this.btVolt.TabIndex = 15;
            this.btVolt.Text = "Voltar";
            this.btVolt.UseVisualStyleBackColor = true;
            this.btVolt.Click += new System.EventHandler(this.BtVolt_Click);
            // 
            // ListaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 318);
            this.Controls.Add(this.btVolt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btEx);
            this.Controls.Add(this.btSel);
            this.Controls.Add(this.btInc);
            this.Controls.Add(this.btAlt);
            this.Controls.Add(this.comboProd);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.lbQt);
            this.Controls.Add(this.lbPro);
            this.Controls.Add(this.lbCli);
            this.Controls.Add(this.comboCli);
            this.Controls.Add(this.ListaVenda);
            this.Controls.Add(this.btCan);
            this.Controls.Add(this.lbCod);
            this.Controls.Add(this.txtCod);
            this.Name = "ListaVendas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lbCod;
        private System.Windows.Forms.Button btCan;
        private System.Windows.Forms.ListBox ListaVenda;
        private System.Windows.Forms.ComboBox comboCli;
        private System.Windows.Forms.Label lbCli;
        private System.Windows.Forms.Label lbPro;
        private System.Windows.Forms.Label lbQt;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.ComboBox comboProd;
        private System.Windows.Forms.Button btAlt;
        private System.Windows.Forms.Button btInc;
        private System.Windows.Forms.Button btSel;
        private System.Windows.Forms.Button btEx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btVolt;
    }
}

