namespace PredvidanjeRastaIPadaDionica
{
    partial class PocetniZaslon
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
            this.txtPodaciZaUcenje = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudBrojIteracijaTreniranja = new System.Windows.Forms.NumericUpDown();
            this.btnZapocniTrening = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPredvidaj = new System.Windows.Forms.Button();
            this.txtIzlaznaPredvidanja = new System.Windows.Forms.TextBox();
            this.lblPostotakZavrsenostiUcenja = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojIteracijaTreniranja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPodaciZaUcenje
            // 
            this.txtPodaciZaUcenje.Location = new System.Drawing.Point(34, 35);
            this.txtPodaciZaUcenje.Multiline = true;
            this.txtPodaciZaUcenje.Name = "txtPodaciZaUcenje";
            this.txtPodaciZaUcenje.Size = new System.Drawing.Size(175, 251);
            this.txtPodaciZaUcenje.TabIndex = 0;
            this.txtPodaciZaUcenje.Text = "0;\r\n0.247403959;\r\n0.379425539;\r\n0.28163876;\r\n0.241470985;\r\n0.148984619;\r\n0.297494" +
    "987;\r\n0.283985947;\r\n0.309297427;\r\n0.278073197;\r\n0.398472144;\r\n0.381660992;\r\n0.19" +
    "8472144";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudBrojIteracijaTreniranja);
            this.groupBox1.Controls.Add(this.btnZapocniTrening);
            this.groupBox1.Controls.Add(this.txtPodaciZaUcenje);
            this.groupBox1.Location = new System.Drawing.Point(60, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 383);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Učenje mreže";
            // 
            // nudBrojIteracijaTreniranja
            // 
            this.nudBrojIteracijaTreniranja.Location = new System.Drawing.Point(34, 293);
            this.nudBrojIteracijaTreniranja.Margin = new System.Windows.Forms.Padding(4);
            this.nudBrojIteracijaTreniranja.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudBrojIteracijaTreniranja.Name = "nudBrojIteracijaTreniranja";
            this.nudBrojIteracijaTreniranja.Size = new System.Drawing.Size(175, 22);
            this.nudBrojIteracijaTreniranja.TabIndex = 12;
            this.nudBrojIteracijaTreniranja.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // btnZapocniTrening
            // 
            this.btnZapocniTrening.Location = new System.Drawing.Point(34, 331);
            this.btnZapocniTrening.Name = "btnZapocniTrening";
            this.btnZapocniTrening.Size = new System.Drawing.Size(175, 36);
            this.btnZapocniTrening.TabIndex = 2;
            this.btnZapocniTrening.Text = "Započni učenje";
            this.btnZapocniTrening.UseVisualStyleBackColor = true;
            this.btnZapocniTrening.Click += new System.EventHandler(this.BtnZapocniTrening_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPredvidaj);
            this.groupBox2.Controls.Add(this.txtIzlaznaPredvidanja);
            this.groupBox2.Location = new System.Drawing.Point(358, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 383);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Predviđeni podaci 3 mjeseca";
            // 
            // btnPredvidaj
            // 
            this.btnPredvidaj.Location = new System.Drawing.Point(34, 331);
            this.btnPredvidaj.Name = "btnPredvidaj";
            this.btnPredvidaj.Size = new System.Drawing.Size(175, 36);
            this.btnPredvidaj.TabIndex = 2;
            this.btnPredvidaj.Text = "Predviđaj";
            this.btnPredvidaj.UseVisualStyleBackColor = true;
            this.btnPredvidaj.Click += new System.EventHandler(this.BtnPredvidaj_Click);
            // 
            // txtIzlaznaPredvidanja
            // 
            this.txtIzlaznaPredvidanja.Location = new System.Drawing.Point(34, 35);
            this.txtIzlaznaPredvidanja.Multiline = true;
            this.txtIzlaznaPredvidanja.Name = "txtIzlaznaPredvidanja";
            this.txtIzlaznaPredvidanja.Size = new System.Drawing.Size(175, 251);
            this.txtIzlaznaPredvidanja.TabIndex = 0;
            // 
            // lblPostotakZavrsenostiUcenja
            // 
            this.lblPostotakZavrsenostiUcenja.AutoSize = true;
            this.lblPostotakZavrsenostiUcenja.Location = new System.Drawing.Point(60, 441);
            this.lblPostotakZavrsenostiUcenja.Name = "lblPostotakZavrsenostiUcenja";
            this.lblPostotakZavrsenostiUcenja.Size = new System.Drawing.Size(0, 17);
            this.lblPostotakZavrsenostiUcenja.TabIndex = 3;
            // 
            // PocetniZaslon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 482);
            this.Controls.Add(this.lblPostotakZavrsenostiUcenja);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PocetniZaslon";
            this.Text = "Predviđanje rasta i pada dionica";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojIteracijaTreniranja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPodaciZaUcenje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudBrojIteracijaTreniranja;
        private System.Windows.Forms.Button btnZapocniTrening;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPredvidaj;
        private System.Windows.Forms.TextBox txtIzlaznaPredvidanja;
        private System.Windows.Forms.Label lblPostotakZavrsenostiUcenja;
    }
}

