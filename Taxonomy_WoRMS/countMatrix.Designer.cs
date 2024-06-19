namespace Taxonomy_WoRMS
{
    partial class countMatrix
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSamples = new System.Windows.Forms.ComboBox();
            this.cboSpecies = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoColumn = new System.Windows.Forms.RadioButton();
            this.rdoRow = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSplit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCombine = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.rdoIndexMatch = new System.Windows.Forms.RadioButton();
            this.rdoNameMatch = new System.Windows.Forms.RadioButton();
            this.btnCombine = new System.Windows.Forms.Button();
            this.cboFields = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelectBlast = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbCombine.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cboSamples);
            this.groupBox1.Controls.Add(this.cboSpecies);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rdoColumn);
            this.groupBox1.Controls.Add(this.rdoRow);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSplit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matrix format and index column selection";
            // 
            // cboSamples
            // 
            this.cboSamples.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSamples.FormattingEnabled = true;
            this.cboSamples.Location = new System.Drawing.Point(136, 171);
            this.cboSamples.Name = "cboSamples";
            this.cboSamples.Size = new System.Drawing.Size(449, 21);
            this.cboSamples.TabIndex = 11;
            // 
            // cboSpecies
            // 
            this.cboSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpecies.FormattingEnabled = true;
            this.cboSpecies.Location = new System.Drawing.Point(136, 144);
            this.cboSpecies.Name = "cboSpecies";
            this.cboSpecies.Size = new System.Drawing.Size(449, 21);
            this.cboSpecies.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "First 4 sample names";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "First 4 species sequence";
            // 
            // rdoColumn
            // 
            this.rdoColumn.AutoSize = true;
            this.rdoColumn.Location = new System.Drawing.Point(9, 86);
            this.rdoColumn.Name = "rdoColumn";
            this.rdoColumn.Size = new System.Drawing.Size(502, 17);
            this.rdoColumn.TabIndex = 7;
            this.rdoColumn.TabStop = true;
            this.rdoColumn.Text = "The sample\'s data is written on one column and the counts for each sequence are w" +
    "ritten on one row";
            this.rdoColumn.UseVisualStyleBackColor = true;
            this.rdoColumn.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdoRow
            // 
            this.rdoRow.AutoSize = true;
            this.rdoRow.Location = new System.Drawing.Point(9, 63);
            this.rdoRow.Name = "rdoRow";
            this.rdoRow.Size = new System.Drawing.Size(481, 17);
            this.rdoRow.TabIndex = 6;
            this.rdoRow.TabStop = true;
            this.rdoRow.Text = "The sample\'s data is written on one line and the counts for each sequence are wri" +
    "ttne in columns";
            this.rdoRow.UseVisualStyleBackColor = true;
            this.rdoRow.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select the option which describes how the data is organised in the file:";
            // 
            // txtSplit
            // 
            this.txtSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSplit.Location = new System.Drawing.Point(510, 19);
            this.txtSplit.Name = "txtSplit";
            this.txtSplit.Size = new System.Drawing.Size(75, 20);
            this.txtSplit.TabIndex = 4;
            this.txtSplit.TextChanged += new System.EventHandler(this.txtSplit_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter the character used to split the data fields on each line";
            // 
            // btnFile
            // 
            this.btnFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFile.Enabled = false;
            this.btnFile.Location = new System.Drawing.Point(510, 115);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(75, 23);
            this.btnFile.TabIndex = 1;
            this.btnFile.Text = "File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the count matrix file by pressing the File button";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbCombine
            // 
            this.gbCombine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCombine.Controls.Add(this.label8);
            this.gbCombine.Controls.Add(this.btnNext);
            this.gbCombine.Controls.Add(this.btnPrevious);
            this.gbCombine.Controls.Add(this.rdoIndexMatch);
            this.gbCombine.Controls.Add(this.rdoNameMatch);
            this.gbCombine.Controls.Add(this.btnCombine);
            this.gbCombine.Controls.Add(this.cboFields);
            this.gbCombine.Controls.Add(this.label7);
            this.gbCombine.Controls.Add(this.btnSelectBlast);
            this.gbCombine.Controls.Add(this.label6);
            this.gbCombine.Enabled = false;
            this.gbCombine.Location = new System.Drawing.Point(12, 223);
            this.gbCombine.Name = "gbCombine";
            this.gbCombine.Size = new System.Drawing.Size(591, 186);
            this.gbCombine.TabIndex = 1;
            this.gbCombine.TabStop = false;
            this.gbCombine.Text = "Annotation file selection";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Press the \'Combine\' button to merge the two files";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(510, 48);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(429, 48);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // rdoIndexMatch
            // 
            this.rdoIndexMatch.Location = new System.Drawing.Point(9, 119);
            this.rdoIndexMatch.Name = "rdoIndexMatch";
            this.rdoIndexMatch.Size = new System.Drawing.Size(348, 32);
            this.rdoIndexMatch.TabIndex = 6;
            this.rdoIndexMatch.TabStop = true;
            this.rdoIndexMatch.Text = "The selected field references the samples position in the counts file. (i.e. a va" +
    "lue of \'4\' references the 4th sample in the file)";
            this.rdoIndexMatch.UseVisualStyleBackColor = true;
            this.rdoIndexMatch.CheckedChanged += new System.EventHandler(this.rdoIndexMatch_CheckedChanged);
            // 
            // rdoNameMatch
            // 
            this.rdoNameMatch.AutoSize = true;
            this.rdoNameMatch.Location = new System.Drawing.Point(9, 96);
            this.rdoNameMatch.Name = "rdoNameMatch";
            this.rdoNameMatch.Size = new System.Drawing.Size(256, 17);
            this.rdoNameMatch.TabIndex = 5;
            this.rdoNameMatch.TabStop = true;
            this.rdoNameMatch.Text = "The selected field matches the sequence\'s name";
            this.rdoNameMatch.UseVisualStyleBackColor = true;
            this.rdoNameMatch.CheckedChanged += new System.EventHandler(this.rdoNameMatch_CheckedChanged);
            // 
            // btnCombine
            // 
            this.btnCombine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCombine.Enabled = false;
            this.btnCombine.Location = new System.Drawing.Point(510, 157);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(75, 23);
            this.btnCombine.TabIndex = 4;
            this.btnCombine.Text = "Combine";
            this.btnCombine.UseVisualStyleBackColor = true;
            this.btnCombine.Click += new System.EventHandler(this.btnCombine_Click);
            // 
            // cboFields
            // 
            this.cboFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFields.FormattingEnabled = true;
            this.cboFields.Location = new System.Drawing.Point(429, 77);
            this.cboFields.Name = "cboFields";
            this.cboFields.Size = new System.Drawing.Size(156, 21);
            this.cboFields.TabIndex = 3;
            this.cboFields.SelectedIndexChanged += new System.EventHandler(this.cboFields_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(409, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Select the column containing the sequences name/index used in the read counts fil" +
    "e ";
            // 
            // btnSelectBlast
            // 
            this.btnSelectBlast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectBlast.Location = new System.Drawing.Point(510, 19);
            this.btnSelectBlast.Name = "btnSelectBlast";
            this.btnSelectBlast.Size = new System.Drawing.Size(75, 23);
            this.btnSelectBlast.TabIndex = 1;
            this.btnSelectBlast.Text = "Select";
            this.btnSelectBlast.UseVisualStyleBackColor = true;
            this.btnSelectBlast.Click += new System.EventHandler(this.btnSelectBlast_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Select the file that links each sequence to a species/blast hit";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(21, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // countMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbCombine);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(631, 489);
            this.Name = "countMatrix";
            this.Text = "Combine files";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCombine.ResumeLayout(false);
            this.gbCombine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSplit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoColumn;
        private System.Windows.Forms.RadioButton rdoRow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboSamples;
        private System.Windows.Forms.ComboBox cboSpecies;
        private System.Windows.Forms.GroupBox gbCombine;
        private System.Windows.Forms.Button btnCombine;
        private System.Windows.Forms.ComboBox cboFields;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSelectBlast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rdoIndexMatch;
        private System.Windows.Forms.RadioButton rdoNameMatch;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label8;
    }
}