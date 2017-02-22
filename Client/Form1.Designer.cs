namespace Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtDependentes = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lsbResult = new System.Windows.Forms.ListBox();
            this.btnFecharRelatorio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "QTDE de Dependentes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salário Bruto:";
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(99, 14);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(211, 29);
            this.txtCPF.TabIndex = 3;
            this.txtCPF.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDependentes
            // 
            this.txtDependentes.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDependentes.Location = new System.Drawing.Point(193, 52);
            this.txtDependentes.MaxLength = 2;
            this.txtDependentes.Name = "txtDependentes";
            this.txtDependentes.Size = new System.Drawing.Size(117, 29);
            this.txtDependentes.TabIndex = 4;
            this.txtDependentes.TextChanged += new System.EventHandler(this.txtDependentes_TextChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(125, 89);
            this.txtSalario.MaxLength = 11;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(185, 29);
            this.txtSalario.TabIndex = 5;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarRelatorio.Location = new System.Drawing.Point(16, 134);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(294, 26);
            this.btnGerarRelatorio.TabIndex = 6;
            this.btnGerarRelatorio.Text = "Gerar Hollerit";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descrição do Hollerit";
            // 
            // lsbResult
            // 
            this.lsbResult.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbResult.FormattingEnabled = true;
            this.lsbResult.ItemHeight = 22;
            this.lsbResult.Location = new System.Drawing.Point(16, 204);
            this.lsbResult.Name = "lsbResult";
            this.lsbResult.Size = new System.Drawing.Size(294, 114);
            this.lsbResult.TabIndex = 8;
            // 
            // btnFecharRelatorio
            // 
            this.btnFecharRelatorio.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharRelatorio.Location = new System.Drawing.Point(16, 333);
            this.btnFecharRelatorio.Name = "btnFecharRelatorio";
            this.btnFecharRelatorio.Size = new System.Drawing.Size(294, 26);
            this.btnFecharRelatorio.TabIndex = 9;
            this.btnFecharRelatorio.Text = "Fechar Relatório";
            this.btnFecharRelatorio.UseVisualStyleBackColor = true;
            this.btnFecharRelatorio.Click += new System.EventHandler(this.btnFecharRelatorio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 368);
            this.Controls.Add(this.btnFecharRelatorio);
            this.Controls.Add(this.lsbResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtDependentes);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtDependentes;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lsbResult;
        private System.Windows.Forms.Button btnFecharRelatorio;
    }
}

