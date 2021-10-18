
namespace AppPhotoTransfer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FolderOrigem = new System.Windows.Forms.FolderBrowserDialog();
            this.FolderDestino = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pesqCaminhoOrigem = new System.Windows.Forms.Button();
            this.btnOrigemPersonalizadas = new System.Windows.Forms.Button();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtOrigemPersonalizadas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.pesqCaminhoDestino = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mtbHoraFoto = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pesqCaminhoOrigem);
            this.groupBox1.Controls.Add(this.btnOrigemPersonalizadas);
            this.groupBox1.Controls.Add(this.txtOrigem);
            this.groupBox1.Controls.Add(this.txtOrigemPersonalizadas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkViolet;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caminho Pastas Origem:";
            // 
            // pesqCaminhoOrigem
            // 
            this.pesqCaminhoOrigem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pesqCaminhoOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesqCaminhoOrigem.ForeColor = System.Drawing.Color.DarkOrange;
            this.pesqCaminhoOrigem.Location = new System.Drawing.Point(403, 45);
            this.pesqCaminhoOrigem.Name = "pesqCaminhoOrigem";
            this.pesqCaminhoOrigem.Size = new System.Drawing.Size(75, 26);
            this.pesqCaminhoOrigem.TabIndex = 4;
            this.pesqCaminhoOrigem.Text = "Search";
            this.pesqCaminhoOrigem.UseVisualStyleBackColor = true;
            this.pesqCaminhoOrigem.Click += new System.EventHandler(this.pesqCaminhoOrigem_Click);
            // 
            // btnOrigemPersonalizadas
            // 
            this.btnOrigemPersonalizadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrigemPersonalizadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrigemPersonalizadas.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnOrigemPersonalizadas.Location = new System.Drawing.Point(403, 97);
            this.btnOrigemPersonalizadas.Name = "btnOrigemPersonalizadas";
            this.btnOrigemPersonalizadas.Size = new System.Drawing.Size(75, 26);
            this.btnOrigemPersonalizadas.TabIndex = 4;
            this.btnOrigemPersonalizadas.Text = "Search";
            this.btnOrigemPersonalizadas.UseVisualStyleBackColor = true;
            this.btnOrigemPersonalizadas.Click += new System.EventHandler(this.btnOrigemPersonalizadas_Click);
            // 
            // txtOrigem
            // 
            this.txtOrigem.BackColor = System.Drawing.Color.White;
            this.txtOrigem.Location = new System.Drawing.Point(16, 45);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.ReadOnly = true;
            this.txtOrigem.Size = new System.Drawing.Size(381, 26);
            this.txtOrigem.TabIndex = 1;
            // 
            // txtOrigemPersonalizadas
            // 
            this.txtOrigemPersonalizadas.BackColor = System.Drawing.Color.White;
            this.txtOrigemPersonalizadas.Location = new System.Drawing.Point(16, 97);
            this.txtOrigemPersonalizadas.Name = "txtOrigemPersonalizadas";
            this.txtOrigemPersonalizadas.ReadOnly = true;
            this.txtOrigemPersonalizadas.Size = new System.Drawing.Size(381, 26);
            this.txtOrigemPersonalizadas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caminho Origem Individuais:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Caminho Origem Personalizadas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Caminho Destino:";
            // 
            // txtDestino
            // 
            this.txtDestino.BackColor = System.Drawing.Color.White;
            this.txtDestino.Location = new System.Drawing.Point(16, 45);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ReadOnly = true;
            this.txtDestino.Size = new System.Drawing.Size(307, 26);
            this.txtDestino.TabIndex = 3;
            // 
            // pesqCaminhoDestino
            // 
            this.pesqCaminhoDestino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pesqCaminhoDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesqCaminhoDestino.ForeColor = System.Drawing.Color.DarkOrange;
            this.pesqCaminhoDestino.Location = new System.Drawing.Point(403, 45);
            this.pesqCaminhoDestino.Name = "pesqCaminhoDestino";
            this.pesqCaminhoDestino.Size = new System.Drawing.Size(75, 26);
            this.pesqCaminhoDestino.TabIndex = 5;
            this.pesqCaminhoDestino.Text = "Search";
            this.pesqCaminhoDestino.UseVisualStyleBackColor = true;
            this.pesqCaminhoDestino.Click += new System.EventHandler(this.pesqCaminhoDestino_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 406);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.btnCopiar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkViolet;
            this.groupBox2.Location = new System.Drawing.Point(0, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 70);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ações:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnLimpar.Location = new System.Drawing.Point(153, 25);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 26);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Clear";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopiar.Enabled = false;
            this.btnCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCopiar.Location = new System.Drawing.Point(16, 25);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(131, 26);
            this.btnCopiar.TabIndex = 6;
            this.btnCopiar.Text = "Photo Copy";
            this.btnCopiar.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.mtbHoraFoto);
            this.groupBox4.Controls.Add(this.pesqCaminhoDestino);
            this.groupBox4.Controls.Add(this.txtDestino);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DarkViolet;
            this.groupBox4.Location = new System.Drawing.Point(0, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(480, 81);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Caminho Pasta Destino:";
            // 
            // mtbHoraFoto
            // 
            this.mtbHoraFoto.Location = new System.Drawing.Point(329, 45);
            this.mtbHoraFoto.Mask = "00:00";
            this.mtbHoraFoto.Name = "mtbHoraFoto";
            this.mtbHoraFoto.Size = new System.Drawing.Size(68, 26);
            this.mtbHoraFoto.TabIndex = 8;
            this.mtbHoraFoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbHoraFoto.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DarkViolet;
            this.groupBox3.Location = new System.Drawing.Point(0, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 113);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log de Execução:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(3, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(474, 88);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 406);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(496, 445);
            this.MinimumSize = new System.Drawing.Size(496, 445);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Transfer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog FolderOrigem;
        private System.Windows.Forms.FolderBrowserDialog FolderDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button pesqCaminhoDestino;
        private System.Windows.Forms.Button pesqCaminhoOrigem;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnOrigemPersonalizadas;
        private System.Windows.Forms.TextBox txtOrigemPersonalizadas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbHoraFoto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

