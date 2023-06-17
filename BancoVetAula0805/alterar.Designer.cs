
namespace BancoVetAula0805
{
    partial class alterar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtForm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btBscCad = new System.Windows.Forms.Button();
            this.txtCrv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAltCad = new System.Windows.Forms.Button();
            this.btCanc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.txtForm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(78, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 256);
            this.panel1.TabIndex = 29;
            this.panel1.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(96, 0);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(239, 26);
            this.txtNome.TabIndex = 13;
            // 
            // txtForm
            // 
            this.txtForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtForm.Location = new System.Drawing.Point(96, 44);
            this.txtForm.Name = "txtForm";
            this.txtForm.Size = new System.Drawing.Size(239, 26);
            this.txtForm.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(9, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Formação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(35, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nome:";
            // 
            // btBscCad
            // 
            this.btBscCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btBscCad.Location = new System.Drawing.Point(432, 96);
            this.btBscCad.Name = "btBscCad";
            this.btBscCad.Size = new System.Drawing.Size(92, 31);
            this.btBscCad.TabIndex = 27;
            this.btBscCad.Text = "Buscar";
            this.btBscCad.UseVisualStyleBackColor = true;
            this.btBscCad.Click += new System.EventHandler(this.btBscCad_Click);
            // 
            // txtCrv
            // 
            this.txtCrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCrv.Location = new System.Drawing.Point(174, 98);
            this.txtCrv.Name = "txtCrv";
            this.txtCrv.Size = new System.Drawing.Size(239, 26);
            this.txtCrv.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(65, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Insira o CRV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Alterar Cadastro";
            // 
            // btAltCad
            // 
            this.btAltCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btAltCad.Location = new System.Drawing.Point(432, 139);
            this.btAltCad.Name = "btAltCad";
            this.btAltCad.Size = new System.Drawing.Size(92, 31);
            this.btAltCad.TabIndex = 28;
            this.btAltCad.Text = "Alterar";
            this.btAltCad.UseVisualStyleBackColor = true;
            this.btAltCad.Click += new System.EventHandler(this.btAltCad_Click);
            // 
            // btCanc
            // 
            this.btCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btCanc.Location = new System.Drawing.Point(432, 185);
            this.btCanc.Name = "btCanc";
            this.btCanc.Size = new System.Drawing.Size(92, 34);
            this.btCanc.TabIndex = 30;
            this.btCanc.Text = "Cancelar";
            this.btCanc.UseVisualStyleBackColor = true;
            this.btCanc.Click += new System.EventHandler(this.btCanc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(306, 119);
            this.dataGridView1.TabIndex = 31;
            // 
            // alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.btAltCad);
            this.Controls.Add(this.btCanc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btBscCad);
            this.Controls.Add(this.txtCrv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "alterar";
            this.Text = "alterar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btBscCad;
        private System.Windows.Forms.TextBox txtCrv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAltCad;
        private System.Windows.Forms.Button btCanc;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}