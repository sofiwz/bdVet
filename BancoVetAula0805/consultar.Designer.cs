
namespace BancoVetAula0805
{
    partial class consultar
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
            this.btBusc = new System.Windows.Forms.Button();
            this.txtConsCrv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtConsForm = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBusc
            // 
            this.btBusc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btBusc.Location = new System.Drawing.Point(425, 86);
            this.btBusc.Name = "btBusc";
            this.btBusc.Size = new System.Drawing.Size(92, 31);
            this.btBusc.TabIndex = 18;
            this.btBusc.Text = "Buscar";
            this.btBusc.UseVisualStyleBackColor = true;
            this.btBusc.Click += new System.EventHandler(this.btBusc_Click);
            // 
            // txtConsCrv
            // 
            this.txtConsCrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtConsCrv.Location = new System.Drawing.Point(167, 88);
            this.txtConsCrv.Name = "txtConsCrv";
            this.txtConsCrv.Size = new System.Drawing.Size(239, 26);
            this.txtConsCrv.TabIndex = 17;
            this.txtConsCrv.TextChanged += new System.EventHandler(this.txtConsCrv_TextChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(58, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Insira o CRV:";
            // 
            // txtConsNome
            // 
            this.txtConsNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtConsNome.Location = new System.Drawing.Point(96, 0);
            this.txtConsNome.Name = "txtConsNome";
            this.txtConsNome.Size = new System.Drawing.Size(239, 26);
            this.txtConsNome.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Consultar Cadastro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(323, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // txtConsForm
            // 
            this.txtConsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtConsForm.Location = new System.Drawing.Point(96, 44);
            this.txtConsForm.Name = "txtConsForm";
            this.txtConsForm.Size = new System.Drawing.Size(239, 26);
            this.txtConsForm.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtConsNome);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.txtConsForm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(71, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 260);
            this.panel1.TabIndex = 22;
            this.panel1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(425, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btBusc);
            this.Controls.Add(this.txtConsCrv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "consultar";
            this.Text = "consultar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btBusc;
        private System.Windows.Forms.TextBox txtConsCrv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtConsForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}