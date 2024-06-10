namespace SisVendas1.View
{
    partial class viewMarca
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 18F);
            this.label1.Location = new System.Drawing.Point(57, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Perpetua", 18F);
            this.textBox1.Location = new System.Drawing.Point(183, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 42);
            this.textBox1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Perpetua", 18F);
            this.button3.Location = new System.Drawing.Point(426, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 44);
            this.button3.TabIndex = 58;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.novaMarca);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Perpetua", 18F);
            this.button4.Location = new System.Drawing.Point(218, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 44);
            this.button4.TabIndex = 57;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.fechaForm);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Perpetua", 18F);
            this.button5.Location = new System.Drawing.Point(45, 195);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 44);
            this.button5.TabIndex = 56;
            this.button5.Text = "Novo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.limparFormMarca);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // viewMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(566, 290);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "viewMarca";
            this.Text = "viewMarca";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}