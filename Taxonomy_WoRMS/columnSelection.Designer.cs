namespace Taxonomy_WoRMS
{
    partial class columnSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(columnSelection));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIgnoreNones = new System.Windows.Forms.CheckBox();
            this.chkReverseOrder = new System.Windows.Forms.CheckBox();
            this.chkCombinefields = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPervious = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSelected = new System.Windows.Forms.TextBox();
            this.chkSecondFromEnd = new System.Windows.Forms.CheckBox();
            this.chkFirstFromEnd = new System.Windows.Forms.CheckBox();
            this.nudSecondSecondColumn = new System.Windows.Forms.NumericUpDown();
            this.nudSecondFirstColumn = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudFirstSecondColumn = new System.Windows.Forms.NumericUpDown();
            this.nudFirstFirstColumn = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecondSplit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstSplit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondSecondColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondFirstColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstSecondColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstFirstColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkIgnoreNones);
            this.groupBox1.Controls.Add(this.chkReverseOrder);
            this.groupBox1.Controls.Add(this.chkCombinefields);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtLine);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnPervious);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSelected);
            this.groupBox1.Controls.Add(this.chkSecondFromEnd);
            this.groupBox1.Controls.Add(this.chkFirstFromEnd);
            this.groupBox1.Controls.Add(this.nudSecondSecondColumn);
            this.groupBox1.Controls.Add(this.nudSecondFirstColumn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudFirstSecondColumn);
            this.groupBox1.Controls.Add(this.nudFirstFirstColumn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSecondSplit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFirstSplit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 544);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name field select";
            // 
            // chkIgnoreNones
            // 
            this.chkIgnoreNones.AutoSize = true;
            this.chkIgnoreNones.Location = new System.Drawing.Point(9, 211);
            this.chkIgnoreNones.Name = "chkIgnoreNones";
            this.chkIgnoreNones.Size = new System.Drawing.Size(122, 17);
            this.chkIgnoreNones.TabIndex = 6;
            this.chkIgnoreNones.Text = "Ignore \"None\" items";
            this.chkIgnoreNones.UseVisualStyleBackColor = true;
            this.chkIgnoreNones.CheckedChanged += new System.EventHandler(this.chkIgnoreNones_CheckedChanged);
            // 
            // chkReverseOrder
            // 
            this.chkReverseOrder.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkReverseOrder.Location = new System.Drawing.Point(9, 273);
            this.chkReverseOrder.Name = "chkReverseOrder";
            this.chkReverseOrder.Size = new System.Drawing.Size(473, 17);
            this.chkReverseOrder.TabIndex = 11;
            this.chkReverseOrder.Text = "Reverse the order of the terms: terms at the start of the list are processed firs" +
    "t";
            this.chkReverseOrder.UseVisualStyleBackColor = true;
            this.chkReverseOrder.CheckedChanged += new System.EventHandler(this.chkReverseOrder_CheckedChanged);
            // 
            // chkCombinefields
            // 
            this.chkCombinefields.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCombinefields.Location = new System.Drawing.Point(9, 232);
            this.chkCombinefields.Name = "chkCombinefields";
            this.chkCombinefields.Size = new System.Drawing.Size(473, 35);
            this.chkCombinefields.TabIndex = 10;
            this.chkCombinefields.Text = "If a field is split on a space for example, it may split a name in two. Check thi" +
    "s option if you wish to combine two fields per search";
            this.chkCombinefields.UseVisualStyleBackColor = true;
            this.chkCombinefields.CheckedChanged += new System.EventHandler(this.chkCombinefields_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Selected indexes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Selected line";
            // 
            // txtLine
            // 
            this.txtLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLine.Location = new System.Drawing.Point(9, 359);
            this.txtLine.Multiline = true;
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(473, 65);
            this.txtLine.TabIndex = 14;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(407, 330);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPervious
            // 
            this.btnPervious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPervious.Location = new System.Drawing.Point(326, 330);
            this.btnPervious.Name = "btnPervious";
            this.btnPervious.Size = new System.Drawing.Size(75, 23);
            this.btnPervious.TabIndex = 12;
            this.btnPervious.Text = "Previous";
            this.btnPervious.UseVisualStyleBackColor = true;
            this.btnPervious.Click += new System.EventHandler(this.btnPervious_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(6, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(476, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "The selected column should appear below. Press the Next and Pervious buttons to c" +
    "ycle through the first twenty lines.";
            // 
            // txtSelected
            // 
            this.txtSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelected.Location = new System.Drawing.Point(9, 443);
            this.txtSelected.Multiline = true;
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.Size = new System.Drawing.Size(473, 95);
            this.txtSelected.TabIndex = 15;
            // 
            // chkSecondFromEnd
            // 
            this.chkSecondFromEnd.AutoSize = true;
            this.chkSecondFromEnd.Location = new System.Drawing.Point(155, 209);
            this.chkSecondFromEnd.Name = "chkSecondFromEnd";
            this.chkSecondFromEnd.Size = new System.Drawing.Size(165, 17);
            this.chkSecondFromEnd.TabIndex = 7;
            this.chkSecondFromEnd.Text = "Count from the end of the line";
            this.chkSecondFromEnd.UseVisualStyleBackColor = true;
            this.chkSecondFromEnd.CheckedChanged += new System.EventHandler(this.chkSecondFromEnd_CheckedChanged);
            // 
            // chkFirstFromEnd
            // 
            this.chkFirstFromEnd.AutoSize = true;
            this.chkFirstFromEnd.Location = new System.Drawing.Point(155, 162);
            this.chkFirstFromEnd.Name = "chkFirstFromEnd";
            this.chkFirstFromEnd.Size = new System.Drawing.Size(165, 17);
            this.chkFirstFromEnd.TabIndex = 3;
            this.chkFirstFromEnd.Text = "Count from the end of the line";
            this.chkFirstFromEnd.UseVisualStyleBackColor = true;
            this.chkFirstFromEnd.CheckedChanged += new System.EventHandler(this.chkFirstFromEnd_CheckedChanged);
            // 
            // nudSecondSecondColumn
            // 
            this.nudSecondSecondColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSecondSecondColumn.Location = new System.Drawing.Point(407, 208);
            this.nudSecondSecondColumn.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSecondSecondColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSecondSecondColumn.Name = "nudSecondSecondColumn";
            this.nudSecondSecondColumn.Size = new System.Drawing.Size(75, 20);
            this.nudSecondSecondColumn.TabIndex = 9;
            this.nudSecondSecondColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSecondSecondColumn.ValueChanged += new System.EventHandler(this.nudSecondSecondColumn_ValueChanged);
            // 
            // nudSecondFirstColumn
            // 
            this.nudSecondFirstColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSecondFirstColumn.Location = new System.Drawing.Point(326, 208);
            this.nudSecondFirstColumn.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSecondFirstColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSecondFirstColumn.Name = "nudSecondFirstColumn";
            this.nudSecondFirstColumn.Size = new System.Drawing.Size(75, 20);
            this.nudSecondFirstColumn.TabIndex = 8;
            this.nudSecondFirstColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSecondFirstColumn.ValueChanged += new System.EventHandler(this.nudSecondFirstColumn_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Select the range of the columns to be used.";
            // 
            // nudFirstSecondColumn
            // 
            this.nudFirstSecondColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudFirstSecondColumn.Location = new System.Drawing.Point(407, 161);
            this.nudFirstSecondColumn.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudFirstSecondColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFirstSecondColumn.Name = "nudFirstSecondColumn";
            this.nudFirstSecondColumn.Size = new System.Drawing.Size(75, 20);
            this.nudFirstSecondColumn.TabIndex = 5;
            this.nudFirstSecondColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFirstSecondColumn.ValueChanged += new System.EventHandler(this.nudFirstSecondColumn_ValueChanged);
            // 
            // nudFirstFirstColumn
            // 
            this.nudFirstFirstColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudFirstFirstColumn.Location = new System.Drawing.Point(326, 161);
            this.nudFirstFirstColumn.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudFirstFirstColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFirstFirstColumn.Name = "nudFirstFirstColumn";
            this.nudFirstFirstColumn.Size = new System.Drawing.Size(75, 20);
            this.nudFirstFirstColumn.TabIndex = 4;
            this.nudFirstFirstColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFirstFirstColumn.ValueChanged += new System.EventHandler(this.nudFirstFirstColumn_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(482, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select the range of the columns to be used, if selectect column is split only one" +
    " field can be selected)";
            // 
            // txtSecondSplit
            // 
            this.txtSecondSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecondSplit.Location = new System.Drawing.Point(407, 117);
            this.txtSecondSplit.Name = "txtSecondSplit";
            this.txtSecondSplit.Size = new System.Drawing.Size(75, 20);
            this.txtSecondSplit.TabIndex = 2;
            this.txtSecondSplit.TextChanged += new System.EventHandler(this.txtSecondSplit_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Split the selected column using this charater (if empty whole field used)";
            // 
            // txtFirstSplit
            // 
            this.txtFirstSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstSplit.Location = new System.Drawing.Point(407, 91);
            this.txtFirstSplit.Name = "txtFirstSplit";
            this.txtFirstSplit.Size = new System.Drawing.Size(75, 20);
            this.txtFirstSplit.TabIndex = 1;
            this.txtFirstSplit.TextChanged += new System.EventHandler(this.txtFirstSplit_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Split data line using this character (If empty whole line used)";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(338, 562);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 16;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(419, 563);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // columnSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 598);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(528, 637);
            this.Name = "columnSelection";
            this.Text = "Name location";
            this.Load += new System.EventHandler(this.columnSelection_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondSecondColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondFirstColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstSecondColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstFirstColumn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPervious;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSelected;
        private System.Windows.Forms.CheckBox chkSecondFromEnd;
        private System.Windows.Forms.CheckBox chkFirstFromEnd;
        private System.Windows.Forms.NumericUpDown nudSecondSecondColumn;
        private System.Windows.Forms.NumericUpDown nudSecondFirstColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudFirstSecondColumn;
        private System.Windows.Forms.NumericUpDown nudFirstFirstColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecondSplit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstSplit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.CheckBox chkCombinefields;
        private System.Windows.Forms.CheckBox chkReverseOrder;
        private System.Windows.Forms.CheckBox chkIgnoreNones;
    }
}