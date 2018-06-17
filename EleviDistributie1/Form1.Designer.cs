namespace EleviDistributie1
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
            this.buttonImport = new System.Windows.Forms.Button();
            this.listBoxElevi = new System.Windows.Forms.ListBox();
            this.listBoxEleviA = new System.Windows.Forms.ListBox();
            this.listBoxEleviB = new System.Windows.Forms.ListBox();
            this.listBoxEleviC = new System.Windows.Forms.ListBox();
            this.buttonDistributie = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxEleviA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEleviB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEleviC = new System.Windows.Forms.TextBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.textBoxNumeA = new System.Windows.Forms.TextBox();
            this.textBoxNumeB = new System.Windows.Forms.TextBox();
            this.textBoxNumeC = new System.Windows.Forms.TextBox();
            this.textBoxNumeD = new System.Windows.Forms.TextBox();
            this.textBoxEleviD = new System.Windows.Forms.TextBox();
            this.listBoxEleviD = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxMedie = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonImport
            // 
            this.buttonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImport.Location = new System.Drawing.Point(12, 26);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(91, 43);
            this.buttonImport.TabIndex = 0;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.ButtonImport_Click);
            // 
            // listBoxElevi
            // 
            this.listBoxElevi.FormattingEnabled = true;
            this.listBoxElevi.Location = new System.Drawing.Point(109, 26);
            this.listBoxElevi.Name = "listBoxElevi";
            this.listBoxElevi.Size = new System.Drawing.Size(120, 407);
            this.listBoxElevi.TabIndex = 1;
            // 
            // listBoxEleviA
            // 
            this.listBoxEleviA.FormattingEnabled = true;
            this.listBoxEleviA.Location = new System.Drawing.Point(298, 53);
            this.listBoxEleviA.Name = "listBoxEleviA";
            this.listBoxEleviA.Size = new System.Drawing.Size(120, 290);
            this.listBoxEleviA.TabIndex = 2;
            // 
            // listBoxEleviB
            // 
            this.listBoxEleviB.FormattingEnabled = true;
            this.listBoxEleviB.Location = new System.Drawing.Point(428, 53);
            this.listBoxEleviB.Name = "listBoxEleviB";
            this.listBoxEleviB.Size = new System.Drawing.Size(120, 290);
            this.listBoxEleviB.TabIndex = 3;
            // 
            // listBoxEleviC
            // 
            this.listBoxEleviC.FormattingEnabled = true;
            this.listBoxEleviC.Location = new System.Drawing.Point(554, 53);
            this.listBoxEleviC.Name = "listBoxEleviC";
            this.listBoxEleviC.Size = new System.Drawing.Size(120, 290);
            this.listBoxEleviC.TabIndex = 4;
            // 
            // buttonDistributie
            // 
            this.buttonDistributie.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonDistributie.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDistributie.Location = new System.Drawing.Point(298, 386);
            this.buttonDistributie.Name = "buttonDistributie";
            this.buttonDistributie.Size = new System.Drawing.Size(372, 47);
            this.buttonDistributie.TabIndex = 8;
            this.buttonDistributie.Text = "Distribuie";
            this.buttonDistributie.UseVisualStyleBackColor = true;
            this.buttonDistributie.Click += new System.EventHandler(this.ButtonDistributie_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxEleviA
            // 
            this.textBoxEleviA.Location = new System.Drawing.Point(378, 352);
            this.textBoxEleviA.Name = "textBoxEleviA";
            this.textBoxEleviA.Size = new System.Drawing.Size(40, 20);
            this.textBoxEleviA.TabIndex = 11;
            this.textBoxEleviA.Click += new System.EventHandler(this.TextBoxEleviA_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nr. elevi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nr. elevi";
            // 
            // textBoxEleviB
            // 
            this.textBoxEleviB.Location = new System.Drawing.Point(508, 352);
            this.textBoxEleviB.Name = "textBoxEleviB";
            this.textBoxEleviB.Size = new System.Drawing.Size(40, 20);
            this.textBoxEleviB.TabIndex = 13;
            this.textBoxEleviB.Click += new System.EventHandler(this.TextBoxEleviB_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nr. elevi";
            // 
            // textBoxEleviC
            // 
            this.textBoxEleviC.Location = new System.Drawing.Point(630, 352);
            this.textBoxEleviC.Name = "textBoxEleviC";
            this.textBoxEleviC.Size = new System.Drawing.Size(40, 20);
            this.textBoxEleviC.TabIndex = 15;
            this.textBoxEleviC.Click += new System.EventHandler(this.TextBoxEleviC_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.Location = new System.Drawing.Point(806, 24);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(91, 43);
            this.buttonExport.TabIndex = 17;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.ButtonExport_Click);
            // 
            // textBoxNumeA
            // 
            this.textBoxNumeA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNumeA.Location = new System.Drawing.Point(298, 26);
            this.textBoxNumeA.Name = "textBoxNumeA";
            this.textBoxNumeA.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeA.TabIndex = 18;
            // 
            // textBoxNumeB
            // 
            this.textBoxNumeB.Location = new System.Drawing.Point(428, 26);
            this.textBoxNumeB.Name = "textBoxNumeB";
            this.textBoxNumeB.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeB.TabIndex = 19;
            // 
            // textBoxNumeC
            // 
            this.textBoxNumeC.Location = new System.Drawing.Point(554, 26);
            this.textBoxNumeC.Name = "textBoxNumeC";
            this.textBoxNumeC.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeC.TabIndex = 20;
            // 
            // textBoxNumeD
            // 
            this.textBoxNumeD.Location = new System.Drawing.Point(680, 26);
            this.textBoxNumeD.Name = "textBoxNumeD";
            this.textBoxNumeD.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumeD.TabIndex = 23;
            // 
            // textBoxEleviD
            // 
            this.textBoxEleviD.Location = new System.Drawing.Point(756, 352);
            this.textBoxEleviD.Name = "textBoxEleviD";
            this.textBoxEleviD.Size = new System.Drawing.Size(40, 20);
            this.textBoxEleviD.TabIndex = 22;
            this.textBoxEleviD.Click += new System.EventHandler(this.TextBoxEleviD_Click);
            // 
            // listBoxEleviD
            // 
            this.listBoxEleviD.FormattingEnabled = true;
            this.listBoxEleviD.Location = new System.Drawing.Point(680, 53);
            this.listBoxEleviD.Name = "listBoxEleviD";
            this.listBoxEleviD.Size = new System.Drawing.Size(120, 290);
            this.listBoxEleviD.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(704, 355);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nr. elevi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Clasa";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(847, 383);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // checkBoxMedie
            // 
            this.checkBoxMedie.AutoSize = true;
            this.checkBoxMedie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMedie.Location = new System.Drawing.Point(677, 386);
            this.checkBoxMedie.Name = "checkBoxMedie";
            this.checkBoxMedie.Size = new System.Drawing.Size(168, 21);
            this.checkBoxMedie.TabIndex = 27;
            this.checkBoxMedie.Text = "Distributie dupa medie";
            this.checkBoxMedie.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(806, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 29);
            this.button2.TabIndex = 28;
            this.button2.Text = "Sigla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 452);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBoxMedie);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumeD);
            this.Controls.Add(this.textBoxEleviD);
            this.Controls.Add(this.listBoxEleviD);
            this.Controls.Add(this.textBoxNumeC);
            this.Controls.Add(this.textBoxNumeB);
            this.Controls.Add(this.textBoxNumeA);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxEleviC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEleviB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEleviA);
            this.Controls.Add(this.buttonDistributie);
            this.Controls.Add(this.listBoxEleviC);
            this.Controls.Add(this.listBoxEleviB);
            this.Controls.Add(this.listBoxEleviA);
            this.Controls.Add(this.listBoxElevi);
            this.Controls.Add(this.buttonImport);
            this.Name = "Form1";
            this.Text = "Student distributor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.ListBox listBoxElevi;
        private System.Windows.Forms.ListBox listBoxEleviA;
        private System.Windows.Forms.ListBox listBoxEleviB;
        private System.Windows.Forms.ListBox listBoxEleviC;
        private System.Windows.Forms.Button buttonDistributie;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxEleviA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEleviB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxEleviC;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.TextBox textBoxNumeA;
        private System.Windows.Forms.TextBox textBoxNumeB;
        private System.Windows.Forms.TextBox textBoxNumeC;
        private System.Windows.Forms.TextBox textBoxNumeD;
        private System.Windows.Forms.TextBox textBoxEleviD;
        private System.Windows.Forms.ListBox listBoxEleviD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxMedie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

