
namespace Rekenmachine
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
            this.VraagSom = new System.Windows.Forms.Button();
            this.VraagVerschil = new System.Windows.Forms.Button();
            this.VraagProduct = new System.Windows.Forms.Button();
            this.VraagDeling = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VraagSom
            // 
            this.VraagSom.Location = new System.Drawing.Point(2, 38);
            this.VraagSom.Name = "VraagSom";
            this.VraagSom.Size = new System.Drawing.Size(75, 23);
            this.VraagSom.TabIndex = 0;
            this.VraagSom.Text = "som";
            this.VraagSom.UseVisualStyleBackColor = true;
            this.VraagSom.Click += new System.EventHandler(this.button1_Click);
            // 
            // VraagVerschil
            // 
            this.VraagVerschil.Location = new System.Drawing.Point(83, 38);
            this.VraagVerschil.Name = "VraagVerschil";
            this.VraagVerschil.Size = new System.Drawing.Size(75, 23);
            this.VraagVerschil.TabIndex = 1;
            this.VraagVerschil.Text = "verschil";
            this.VraagVerschil.UseVisualStyleBackColor = true;
            this.VraagVerschil.Click += new System.EventHandler(this.VraagVerschil_Click);
            // 
            // VraagProduct
            // 
            this.VraagProduct.Location = new System.Drawing.Point(164, 38);
            this.VraagProduct.Name = "VraagProduct";
            this.VraagProduct.Size = new System.Drawing.Size(107, 23);
            this.VraagProduct.TabIndex = 2;
            this.VraagProduct.Text = "vermeningvuldiging";
            this.VraagProduct.UseVisualStyleBackColor = true;
            this.VraagProduct.Click += new System.EventHandler(this.button3_Click);
            // 
            // VraagDeling
            // 
            this.VraagDeling.Location = new System.Drawing.Point(277, 38);
            this.VraagDeling.Name = "VraagDeling";
            this.VraagDeling.Size = new System.Drawing.Size(75, 23);
            this.VraagDeling.TabIndex = 3;
            this.VraagDeling.Text = "deling";
            this.VraagDeling.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(239, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(2, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(350, 20);
            this.textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 100);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.VraagDeling);
            this.Controls.Add(this.VraagProduct);
            this.Controls.Add(this.VraagVerschil);
            this.Controls.Add(this.VraagSom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VraagSom;
        private System.Windows.Forms.Button VraagVerschil;
        private System.Windows.Forms.Button VraagProduct;
        private System.Windows.Forms.Button VraagDeling;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

