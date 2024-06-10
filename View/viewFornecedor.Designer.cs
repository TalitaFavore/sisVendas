namespace SisVendas1.View
{
    partial class viewFornecedor
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
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboCidade_fornecedor = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Perpetua", 18F);
            this.button3.Location = new System.Drawing.Point(537, 523);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 44);
            this.button3.TabIndex = 55;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.cadastrarFornecedor);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Perpetua", 18F);
            this.button4.Location = new System.Drawing.Point(278, 523);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 44);
            this.button4.TabIndex = 54;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.fechaForm);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Perpetua", 18F);
            this.button5.Location = new System.Drawing.Point(36, 523);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 44);
            this.button5.TabIndex = 53;
            this.button5.Text = "Novo";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Font = new System.Drawing.Font("Perpetua", 18F);
            this.maskedTextBox3.Location = new System.Drawing.Point(136, 384);
            this.maskedTextBox3.Mask = "(00)00000-0000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(211, 42);
            this.maskedTextBox3.TabIndex = 52;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(503, 241);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(156, 35);
            this.linkLabel2.TabIndex = 51;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Nova Cidade";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.frmCidade);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Font = new System.Drawing.Font("Perpetua", 18F);
            this.maskedTextBox4.Location = new System.Drawing.Point(136, 103);
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(523, 42);
            this.maskedTextBox4.TabIndex = 50;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Perpetua", 18F);
            this.textBox4.Location = new System.Drawing.Point(136, 312);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(523, 42);
            this.textBox4.TabIndex = 49;
            // 
            // comboCidade_fornecedor
            // 
            this.comboCidade_fornecedor.Font = new System.Drawing.Font("Perpetua", 18F);
            this.comboCidade_fornecedor.FormattingEnabled = true;
            this.comboCidade_fornecedor.Location = new System.Drawing.Point(136, 238);
            this.comboCidade_fornecedor.Name = "comboCidade_fornecedor";
            this.comboCidade_fornecedor.Size = new System.Drawing.Size(361, 43);
            this.comboCidade_fornecedor.TabIndex = 48;
            this.comboCidade_fornecedor.Click += new System.EventHandler(this.atualizaComboboxCidade);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Perpetua", 18F);
            this.textBox5.Location = new System.Drawing.Point(136, 171);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(523, 42);
            this.textBox5.TabIndex = 47;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Perpetua", 18F);
            this.textBox6.Location = new System.Drawing.Point(136, 36);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(523, 42);
            this.textBox6.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 391);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 35);
            this.label13.TabIndex = 45;
            this.label13.Text = "Telefone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 35);
            this.label12.TabIndex = 44;
            this.label12.Text = "E-mail";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 35);
            this.label11.TabIndex = 43;
            this.label11.Text = "Cidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 35);
            this.label10.TabIndex = 42;
            this.label10.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 35);
            this.label8.TabIndex = 41;
            this.label8.Text = "Nome";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 35);
            this.label9.TabIndex = 40;
            this.label9.Text = "CNPJ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // viewFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(715, 638);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboCidade_fornecedor);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Name = "viewFornecedor";
            this.Text = "viewFornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboCidade_fornecedor;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}