namespace XML_kolekcije
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
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtGod = new System.Windows.Forms.TextBox();
            this.txtKotac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIspis = new System.Windows.Forms.RichTextBox();
            this.btnObrada = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(152, 36);
            this.txtModel.Margin = new System.Windows.Forms.Padding(2);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(106, 20);
            this.txtModel.TabIndex = 0;
            // 
            // txtGod
            // 
            this.txtGod.Location = new System.Drawing.Point(152, 84);
            this.txtGod.Margin = new System.Windows.Forms.Padding(2);
            this.txtGod.Name = "txtGod";
            this.txtGod.Size = new System.Drawing.Size(106, 20);
            this.txtGod.TabIndex = 1;
            this.txtGod.TextChanged += new System.EventHandler(this.txtGod_TextChanged);
            // 
            // txtKotac
            // 
            this.txtKotac.Location = new System.Drawing.Point(152, 140);
            this.txtKotac.Margin = new System.Windows.Forms.Padding(2);
            this.txtKotac.Name = "txtKotac";
            this.txtKotac.Size = new System.Drawing.Size(106, 20);
            this.txtKotac.TabIndex = 2;
            this.txtKotac.TextChanged += new System.EventHandler(this.txtKotac_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Godina proizvodnje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broj kotaca";
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(65, 288);
            this.txtIspis.Margin = new System.Windows.Forms.Padding(2);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(270, 157);
            this.txtIspis.TabIndex = 6;
            this.txtIspis.Click += new System.EventHandler(this.txtIspisClicked);
            // 
            // btnObrada
            // 
            this.btnObrada.Location = new System.Drawing.Point(65, 190);
            this.btnObrada.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrada.Name = "btnObrada";
            this.btnObrada.Size = new System.Drawing.Size(65, 63);
            this.btnObrada.TabIndex = 7;
            this.btnObrada.Text = "Obradi";
            this.btnObrada.UseVisualStyleBackColor = true;
            this.btnObrada.Click += new System.EventHandler(this.btnObrada_Click);
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(166, 190);
            this.btnUnos.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(65, 63);
            this.btnUnos.TabIndex = 8;
            this.btnUnos.Text = "Unesi";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(268, 190);
            this.btnIspis.Margin = new System.Windows.Forms.Padding(2);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(65, 63);
            this.btnIspis.TabIndex = 9;
            this.btnIspis.Text = "Ispisi";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 465);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.btnObrada);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKotac);
            this.Controls.Add(this.txtGod);
            this.Controls.Add(this.txtModel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Vozila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtGod;
        private System.Windows.Forms.TextBox txtKotac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtIspis;
        private System.Windows.Forms.Button btnObrada;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnIspis;
    }
}

