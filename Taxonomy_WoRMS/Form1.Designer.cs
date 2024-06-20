namespace Taxonomy_WoRMS
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
            this.btnGetNodes = new System.Windows.Forms.Button();
            this.btnGetNames = new System.Windows.Forms.Button();
            this.btnTaxoIDSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnNameSearch = new System.Windows.Forms.Button();
            this.btnAnnotate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCombine = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFolder = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetNodes
            // 
            this.btnGetNodes.Location = new System.Drawing.Point(220, 23);
            this.btnGetNodes.Name = "btnGetNodes";
            this.btnGetNodes.Size = new System.Drawing.Size(75, 23);
            this.btnGetNodes.TabIndex = 0;
            this.btnGetNodes.Text = "Taxon";
            this.btnGetNodes.UseVisualStyleBackColor = true;
            this.btnGetNodes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGetNames
            // 
            this.btnGetNames.Enabled = false;
            this.btnGetNames.Location = new System.Drawing.Point(301, 23);
            this.btnGetNames.Name = "btnGetNames";
            this.btnGetNames.Size = new System.Drawing.Size(75, 23);
            this.btnGetNames.TabIndex = 1;
            this.btnGetNames.Text = "Names";
            this.btnGetNames.UseVisualStyleBackColor = true;
            this.btnGetNames.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTaxoIDSearch
            // 
            this.btnTaxoIDSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaxoIDSearch.Enabled = false;
            this.btnTaxoIDSearch.Location = new System.Drawing.Point(648, 17);
            this.btnTaxoIDSearch.Name = "btnTaxoIDSearch";
            this.btnTaxoIDSearch.Size = new System.Drawing.Size(75, 23);
            this.btnTaxoIDSearch.TabIndex = 2;
            this.btnTaxoIDSearch.Text = "Taxo ID";
            this.btnTaxoIDSearch.UseVisualStyleBackColor = true;
            this.btnTaxoIDSearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(6, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(161, 372);
            this.textBox1.TabIndex = 3;
            this.textBox1.WordWrap = false;
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.Location = new System.Drawing.Point(173, 46);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtData.Size = new System.Drawing.Size(626, 372);
            this.txtData.TabIndex = 4;
            this.txtData.WordWrap = false;
            // 
            // btnNameSearch
            // 
            this.btnNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNameSearch.Enabled = false;
            this.btnNameSearch.Location = new System.Drawing.Point(729, 17);
            this.btnNameSearch.Name = "btnNameSearch";
            this.btnNameSearch.Size = new System.Drawing.Size(75, 23);
            this.btnNameSearch.TabIndex = 5;
            this.btnNameSearch.Text = "Name";
            this.btnNameSearch.UseVisualStyleBackColor = true;
            this.btnNameSearch.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnAnnotate
            // 
            this.btnAnnotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnotate.Enabled = false;
            this.btnAnnotate.Location = new System.Drawing.Point(720, 16);
            this.btnAnnotate.Name = "btnAnnotate";
            this.btnAnnotate.Size = new System.Drawing.Size(75, 23);
            this.btnAnnotate.TabIndex = 6;
            this.btnAnnotate.Text = "Annotate";
            this.btnAnnotate.UseVisualStyleBackColor = true;
            this.btnAnnotate.Click += new System.EventHandler(this.btnNamesFile_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Import taxonomy data from WoRMS data files:";
            // 
            // btnCombine
            // 
            this.btnCombine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCombine.Location = new System.Drawing.Point(720, 14);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(75, 23);
            this.btnCombine.TabIndex = 10;
            this.btnCombine.Text = "Combine";
            this.btnCombine.UseVisualStyleBackColor = true;
            this.btnCombine.Click += new System.EventHandler(this.btnCombine_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.btnTaxoIDSearch);
            this.groupBox1.Controls.Add(this.btnNameSearch);
            this.groupBox1.Location = new System.Drawing.Point(17, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(810, 424);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manual search";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(636, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter speices name or WoRMS taxonomic ID in first text box and then press the rele" +
    "vant button on the right to search for the speices tree";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chkFolder);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAnnotate);
            this.groupBox2.Location = new System.Drawing.Point(17, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 50);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Automated analysis";
            // 
            // chkFolder
            // 
            this.chkFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFolder.AutoSize = true;
            this.chkFolder.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFolder.Location = new System.Drawing.Point(559, 20);
            this.chkFolder.Name = "chkFolder";
            this.chkFolder.Size = new System.Drawing.Size(155, 17);
            this.chkFolder.TabIndex = 12;
            this.chkFolder.Text = "Process a folder of text files";
            this.chkFolder.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Press the Annotate button to identify the species name in the blast hit file.";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnGetNodes);
            this.groupBox3.Controls.Add(this.btnGetNames);
            this.groupBox3.Location = new System.Drawing.Point(17, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(804, 57);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Import taxomoic data";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnCombine);
            this.groupBox4.Location = new System.Drawing.Point(17, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(804, 44);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Combine annotation file with read count matrix";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "To combine annotations with counts matrix press the Combine button.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "To combine and annotate a series of blast result files in the same folder tick th" +
    "e box";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 617);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(855, 656);
            this.Name = "Form1";
            this.Text = "WoRMS Taxonomic data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetNodes;
        private System.Windows.Forms.Button btnGetNames;
        private System.Windows.Forms.Button btnTaxoIDSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnNameSearch;
        private System.Windows.Forms.Button btnAnnotate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCombine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkFolder;
        private System.Windows.Forms.Label label4;
    }
}



