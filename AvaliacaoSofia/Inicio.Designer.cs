
namespace AvaliacaoSofia
{
    partial class Inicio
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
            this.btCad = new System.Windows.Forms.Button();
            this.btList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCad
            // 
            this.btCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btCad.Location = new System.Drawing.Point(151, 171);
            this.btCad.Name = "btCad";
            this.btCad.Size = new System.Drawing.Size(199, 34);
            this.btCad.TabIndex = 0;
            this.btCad.Text = "Cadastro CPF";
            this.btCad.UseVisualStyleBackColor = true;
            this.btCad.Click += new System.EventHandler(this.btCad_Click);
            // 
            // btList
            // 
            this.btList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btList.Location = new System.Drawing.Point(151, 211);
            this.btList.Name = "btList";
            this.btList.Size = new System.Drawing.Size(199, 34);
            this.btList.TabIndex = 1;
            this.btList.Text = "Lista de Vendas";
            this.btList.UseVisualStyleBackColor = true;
            this.btList.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(151, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastro CNPJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 400);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btList);
            this.Controls.Add(this.btCad);
            this.Name = "Inicio";
            this.Text = "inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCad;
        private System.Windows.Forms.Button btList;
        private System.Windows.Forms.Button button1;
    }
}