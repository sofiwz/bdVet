
namespace BancoVetAula0805
{
    partial class cadastro
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
            this.comboForm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCRV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btSav = new System.Windows.Forms.Button();
            this.btCanc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboForm
            // 
            this.comboForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboForm.FormattingEnabled = true;
            this.comboForm.Items.AddRange(new object[] {
            "Geral\t",
            "Especialista",
            "Estagiário"});
            this.comboForm.Location = new System.Drawing.Point(156, 272);
            this.comboForm.Name = "comboForm";
            this.comboForm.Size = new System.Drawing.Size(239, 28);
            this.comboForm.TabIndex = 2;
            this.comboForm.SelectedIndexChanged += new System.EventHandler(this.comboForm_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastrar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCRV
            // 
            this.txtCRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCRV.Location = new System.Drawing.Point(156, 215);
            this.txtCRV.Name = "txtCRV";
            this.txtCRV.Size = new System.Drawing.Size(239, 26);
            this.txtCRV.TabIndex = 4;
            this.txtCRV.TextChanged += new System.EventHandler(this.txtCRV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(152, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(152, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Formação";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(152, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "CRV";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(156, 158);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(239, 26);
            this.txtNome.TabIndex = 8;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btSav
            // 
            this.btSav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btSav.Location = new System.Drawing.Point(156, 333);
            this.btSav.Name = "btSav";
            this.btSav.Size = new System.Drawing.Size(92, 34);
            this.btSav.TabIndex = 9;
            this.btSav.Text = "Salvar";
            this.btSav.UseVisualStyleBackColor = true;
            this.btSav.Click += new System.EventHandler(this.btSav_Click);
            // 
            // btCanc
            // 
            this.btCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btCanc.Location = new System.Drawing.Point(303, 333);
            this.btCanc.Name = "btCanc";
            this.btCanc.Size = new System.Drawing.Size(92, 34);
            this.btCanc.TabIndex = 10;
            this.btCanc.Text = "Cancelar";
            this.btCanc.UseVisualStyleBackColor = true;
            this.btCanc.Click += new System.EventHandler(this.btCanc_Click);
            // 
            // cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.btCanc);
            this.Controls.Add(this.btSav);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCRV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboForm);
            this.Name = "cadastro";
            this.Text = "cadastro";
            this.Load += new System.EventHandler(this.cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCRV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btSav;
        private System.Windows.Forms.Button btCanc;
    }
}