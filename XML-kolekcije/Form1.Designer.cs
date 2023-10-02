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
            this.txtIspis = new System.Windows.Forms.TextBox();
            this.btnObrada = new System.Windows.Forms.Button();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(303, 70);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(208, 31);
            this.txtModel.TabIndex = 0;
            // 
            // txtGod
            // 
            this.txtGod.Location = new System.Drawing.Point(303, 162);
            this.txtGod.Name = "txtGod";
            this.txtGod.Size = new System.Drawing.Size(208, 31);
            this.txtGod.TabIndex = 1;
            this.txtGod.TextChanged += new System.EventHandler(this.txtGod_TextChanged);
            // 
            // txtKotac
            // 
            this.txtKotac.Location = new System.Drawing.Point(303, 270);
            this.txtKotac.Name = "txtKotac";
            this.txtKotac.Size = new System.Drawing.Size(208, 31);
            this.txtKotac.TabIndex = 2;
            this.txtKotac.TextChanged += new System.EventHandler(this.txtKotac_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Godina proizvodnje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broj kotaca";
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(130, 553);
            this.txtIspis.Multiline = true;
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(536, 299);
            this.txtIspis.TabIndex = 6;
            // 
            // btnObrada
            // 
            this.btnObrada.Location = new System.Drawing.Point(130, 366);
            this.btnObrada.Name = "btnObrada";
            this.btnObrada.Size = new System.Drawing.Size(130, 121);
            this.btnObrada.TabIndex = 7;
            this.btnObrada.Text = "Obradi";
            this.btnObrada.UseVisualStyleBackColor = true;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(333, 366);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(130, 121);
            this.btnUnos.TabIndex = 8;
            this.btnUnos.Text = "Unesi";
            this.btnUnos.UseVisualStyleBackColor = true;
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(536, 366);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(130, 121);
            this.btnIspis.TabIndex = 9;
            this.btnIspis.Text = "Ispisi";
            this.btnIspis.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 894);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox txtIspis;
        private System.Windows.Forms.Button btnObrada;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnIspis;
    }
}

