namespace ControlSearchEngine
{
    partial class SearchResultForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblEnterText = new System.Windows.Forms.Label();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.btnFocus = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSearchRes = new System.Windows.Forms.Label();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.searchTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ChkRadioButton = new System.Windows.Forms.CheckBox();
            this.ChkLabel = new System.Windows.Forms.CheckBox();
            this.chkCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lslUserCtrl = new System.Windows.Forms.CheckedListBox();
            this.searchTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(202, 165);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 24);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblEnterText
            // 
            this.lblEnterText.AutoSize = true;
            this.lblEnterText.Location = new System.Drawing.Point(7, 6);
            this.lblEnterText.Name = "lblEnterText";
            this.lblEnterText.Size = new System.Drawing.Size(56, 13);
            this.lblEnterText.TabIndex = 12;
            this.lblEnterText.Text = "Enter Text";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(9, 23);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(277, 20);
            this.txtSearchText.TabIndex = 8;
            // 
            // btnFocus
            // 
            this.btnFocus.Location = new System.Drawing.Point(9, 425);
            this.btnFocus.Name = "btnFocus";
            this.btnFocus.Size = new System.Drawing.Size(85, 24);
            this.btnFocus.TabIndex = 13;
            this.btnFocus.Text = "&Focus";
            this.btnFocus.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(201, 425);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 24);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSearchRes
            // 
            this.lblSearchRes.AutoSize = true;
            this.lblSearchRes.Location = new System.Drawing.Point(7, 176);
            this.lblSearchRes.Name = "lblSearchRes";
            this.lblSearchRes.Size = new System.Drawing.Size(86, 13);
            this.lblSearchRes.TabIndex = 10;
            this.lblSearchRes.Text = "Seach Result ....";
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(9, 194);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(277, 225);
            this.lstResult.TabIndex = 9;
            this.lstResult.SelectedIndexChanged += new System.EventHandler(this.lstResult_SelectedIndexChanged);
            // 
            // searchTab
            // 
            this.searchTab.Controls.Add(this.tabPage1);
            this.searchTab.Controls.Add(this.tabPage2);
            this.searchTab.Location = new System.Drawing.Point(9, 53);
            this.searchTab.Name = "searchTab";
            this.searchTab.SelectedIndex = 0;
            this.searchTab.Size = new System.Drawing.Size(281, 110);
            this.searchTab.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ChkRadioButton);
            this.tabPage1.Controls.Add(this.ChkLabel);
            this.tabPage1.Controls.Add(this.chkCheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(273, 84);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Standard Controls";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ChkRadioButton
            // 
            this.ChkRadioButton.AutoSize = true;
            this.ChkRadioButton.Location = new System.Drawing.Point(8, 33);
            this.ChkRadioButton.Name = "ChkRadioButton";
            this.ChkRadioButton.Size = new System.Drawing.Size(93, 17);
            this.ChkRadioButton.TabIndex = 7;
            this.ChkRadioButton.Text = "Radio Buttons";
            this.ChkRadioButton.UseVisualStyleBackColor = true;
            // 
            // ChkLabel
            // 
            this.ChkLabel.AutoSize = true;
            this.ChkLabel.Location = new System.Drawing.Point(8, 56);
            this.ChkLabel.Name = "ChkLabel";
            this.ChkLabel.Size = new System.Drawing.Size(57, 17);
            this.ChkLabel.TabIndex = 6;
            this.ChkLabel.Text = "Labels";
            this.ChkLabel.UseVisualStyleBackColor = true;
            // 
            // chkCheckBox
            // 
            this.chkCheckBox.AutoSize = true;
            this.chkCheckBox.Location = new System.Drawing.Point(8, 10);
            this.chkCheckBox.Name = "chkCheckBox";
            this.chkCheckBox.Size = new System.Drawing.Size(75, 17);
            this.chkCheckBox.TabIndex = 5;
            this.chkCheckBox.Text = "CheckBox";
            this.chkCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lslUserCtrl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(273, 84);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Defined";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lslUserCtrl
            // 
            this.lslUserCtrl.FormattingEnabled = true;
            this.lslUserCtrl.Location = new System.Drawing.Point(4, 3);
            this.lslUserCtrl.Name = "lslUserCtrl";
            this.lslUserCtrl.Size = new System.Drawing.Size(267, 79);
            this.lslUserCtrl.TabIndex = 0;
            // 
            // SearchResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 454);
            this.Controls.Add(this.searchTab);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblEnterText);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.btnFocus);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblSearchRes);
            this.Controls.Add(this.lstResult);
            this.Name = "SearchResultForm";
            this.Text = "ControlSearch";
            this.searchTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Label lblEnterText;
        internal System.Windows.Forms.TextBox txtSearchText;
        internal System.Windows.Forms.Button btnFocus;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Label lblSearchRes;
        internal System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.TabControl searchTab;
        private System.Windows.Forms.TabPage tabPage1;
        internal System.Windows.Forms.CheckBox ChkRadioButton;
        internal System.Windows.Forms.CheckBox ChkLabel;
        internal System.Windows.Forms.CheckBox chkCheckBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckedListBox lslUserCtrl;
    }
}