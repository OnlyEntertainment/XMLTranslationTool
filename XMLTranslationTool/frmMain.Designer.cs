namespace XMLTranslationTool
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbTranslatedText1 = new System.Windows.Forms.TextBox();
            this.cbChoosenLanguage1 = new System.Windows.Forms.ComboBox();
            this.btnLanguagesNew = new System.Windows.Forms.Button();
            this.cbKeyWords = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKeyWordsNew = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbChoosenLanguage2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTranslatedText2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTranslation2 = new System.Windows.Forms.Label();
            this.lblTranslation1 = new System.Windows.Forms.Label();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnChange = new System.Windows.Forms.Button();
            this.tbTestResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTestKeyWord = new System.Windows.Forms.TextBox();
            this.tbTestLanguage = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTranslatedText1
            // 
            this.tbTranslatedText1.AcceptsReturn = true;
            this.tbTranslatedText1.AcceptsTab = true;
            this.tbTranslatedText1.Location = new System.Drawing.Point(12, 177);
            this.tbTranslatedText1.Multiline = true;
            this.tbTranslatedText1.Name = "tbTranslatedText1";
            this.tbTranslatedText1.Size = new System.Drawing.Size(300, 300);
            this.tbTranslatedText1.TabIndex = 0;
            this.tbTranslatedText1.TextChanged += new System.EventHandler(this.tbTranslatedText1_TextChanged);
            // 
            // cbChoosenLanguage1
            // 
            this.cbChoosenLanguage1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbChoosenLanguage1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbChoosenLanguage1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChoosenLanguage1.FormattingEnabled = true;
            this.cbChoosenLanguage1.Location = new System.Drawing.Point(73, 150);
            this.cbChoosenLanguage1.Name = "cbChoosenLanguage1";
            this.cbChoosenLanguage1.Size = new System.Drawing.Size(138, 21);
            this.cbChoosenLanguage1.TabIndex = 1;
            this.cbChoosenLanguage1.SelectedIndexChanged += new System.EventHandler(this.cbChoosenLanguage1_SelectedIndexChanged);
            // 
            // btnLanguagesNew
            // 
            this.btnLanguagesNew.Location = new System.Drawing.Point(217, 151);
            this.btnLanguagesNew.Name = "btnLanguagesNew";
            this.btnLanguagesNew.Size = new System.Drawing.Size(39, 20);
            this.btnLanguagesNew.TabIndex = 4;
            this.btnLanguagesNew.Text = "New";
            this.btnLanguagesNew.UseVisualStyleBackColor = true;
            this.btnLanguagesNew.Click += new System.EventHandler(this.btnLanguagesNew1_Click);
            // 
            // cbKeyWords
            // 
            this.cbKeyWords.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbKeyWords.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbKeyWords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKeyWords.FormattingEnabled = true;
            this.cbKeyWords.Location = new System.Drawing.Point(684, 150);
            this.cbKeyWords.Name = "cbKeyWords";
            this.cbKeyWords.Size = new System.Drawing.Size(150, 21);
            this.cbKeyWords.TabIndex = 5;
            this.cbKeyWords.SelectedIndexChanged += new System.EventHandler(this.cbKeyWords_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "KeyWord";
            // 
            // btnKeyWordsNew
            // 
            this.btnKeyWordsNew.Location = new System.Drawing.Point(684, 176);
            this.btnKeyWordsNew.Name = "btnKeyWordsNew";
            this.btnKeyWordsNew.Size = new System.Drawing.Size(70, 20);
            this.btnKeyWordsNew.TabIndex = 7;
            this.btnKeyWordsNew.Text = "New";
            this.btnKeyWordsNew.UseVisualStyleBackColor = true;
            this.btnKeyWordsNew.Click += new System.EventHandler(this.btnKeyWordsNew_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Language";
            // 
            // cbChoosenLanguage2
            // 
            this.cbChoosenLanguage2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbChoosenLanguage2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbChoosenLanguage2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChoosenLanguage2.FormattingEnabled = true;
            this.cbChoosenLanguage2.Location = new System.Drawing.Point(382, 150);
            this.cbChoosenLanguage2.Name = "cbChoosenLanguage2";
            this.cbChoosenLanguage2.Size = new System.Drawing.Size(138, 21);
            this.cbChoosenLanguage2.TabIndex = 9;
            this.cbChoosenLanguage2.SelectedIndexChanged += new System.EventHandler(this.cbChoosenLanguage2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Language";
            // 
            // tbTranslatedText2
            // 
            this.tbTranslatedText2.AcceptsReturn = true;
            this.tbTranslatedText2.AcceptsTab = true;
            this.tbTranslatedText2.Location = new System.Drawing.Point(321, 177);
            this.tbTranslatedText2.Multiline = true;
            this.tbTranslatedText2.Name = "tbTranslatedText2";
            this.tbTranslatedText2.Size = new System.Drawing.Size(300, 300);
            this.tbTranslatedText2.TabIndex = 11;
            this.tbTranslatedText2.TextChanged += new System.EventHandler(this.tbTranslatedText2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnLanguagesNew2_Click);
            // 
            // lblTranslation2
            // 
            this.lblTranslation2.AutoSize = true;
            this.lblTranslation2.Location = new System.Drawing.Point(318, 480);
            this.lblTranslation2.Name = "lblTranslation2";
            this.lblTranslation2.Size = new System.Drawing.Size(34, 13);
            this.lblTranslation2.TabIndex = 13;
            this.lblTranslation2.Text = ">-----<";
            // 
            // lblTranslation1
            // 
            this.lblTranslation1.AutoSize = true;
            this.lblTranslation1.Location = new System.Drawing.Point(12, 480);
            this.lblTranslation1.Name = "lblTranslation1";
            this.lblTranslation1.Size = new System.Drawing.Size(34, 13);
            this.lblTranslation1.TabIndex = 14;
            this.lblTranslation1.Text = ">-----<";
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(262, 151);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(50, 20);
            this.btnSave1.TabIndex = 15;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(571, 151);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(50, 20);
            this.btnSave2.TabIndex = 16;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.toolStripSeparator2,
            this.miOpen,
            this.miSave,
            this.miSaveAs,
            this.toolStripSeparator1,
            this.miExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // miNew
            // 
            this.miNew.Name = "miNew";
            this.miNew.Size = new System.Drawing.Size(112, 22);
            this.miNew.Text = "&New";
            this.miNew.Click += new System.EventHandler(this.miNew_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(109, 6);
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(112, 22);
            this.miOpen.Text = "&Open";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(112, 22);
            this.miSave.Text = "&Save";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // miSaveAs
            // 
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.Size = new System.Drawing.Size(112, 22);
            this.miSaveAs.Text = "S&ave as";
            this.miSaveAs.Click += new System.EventHandler(this.miSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(112, 22);
            this.miExit.Text = "E&xit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "XML Files|*.xml";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "XML Files|*.xml";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(764, 176);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(70, 20);
            this.btnChange.TabIndex = 18;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // tbTestResult
            // 
            this.tbTestResult.AcceptsReturn = true;
            this.tbTestResult.AcceptsTab = true;
            this.tbTestResult.Location = new System.Drawing.Point(630, 331);
            this.tbTestResult.Multiline = true;
            this.tbTestResult.Name = "tbTestResult";
            this.tbTestResult.Size = new System.Drawing.Size(300, 146);
            this.tbTestResult.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Language";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "KeyWord";
            // 
            // tbTestKeyWord
            // 
            this.tbTestKeyWord.Location = new System.Drawing.Point(690, 305);
            this.tbTestKeyWord.Name = "tbTestKeyWord";
            this.tbTestKeyWord.Size = new System.Drawing.Size(167, 20);
            this.tbTestKeyWord.TabIndex = 24;
            // 
            // tbTestLanguage
            // 
            this.tbTestLanguage.Location = new System.Drawing.Point(690, 279);
            this.tbTestLanguage.Name = "tbTestLanguage";
            this.tbTestLanguage.Size = new System.Drawing.Size(167, 20);
            this.tbTestLanguage.TabIndex = 25;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(863, 282);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(67, 42);
            this.btnTest.TabIndex = 26;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 677);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.tbTestLanguage);
            this.Controls.Add(this.tbTestKeyWord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTestResult);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.btnSave1);
            this.Controls.Add(this.lblTranslation1);
            this.Controls.Add(this.lblTranslation2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbTranslatedText2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbChoosenLanguage2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKeyWordsNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbKeyWords);
            this.Controls.Add(this.btnLanguagesNew);
            this.Controls.Add(this.cbChoosenLanguage1);
            this.Controls.Add(this.tbTranslatedText1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "XML Translation Tool";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTranslatedText1;
        private System.Windows.Forms.ComboBox cbChoosenLanguage1;
        private System.Windows.Forms.Button btnLanguagesNew;
        private System.Windows.Forms.ComboBox cbKeyWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKeyWordsNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbChoosenLanguage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTranslatedText2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTranslation2;
        private System.Windows.Forms.Label lblTranslation1;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem miNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripMenuItem miSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox tbTestResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTestKeyWord;
        private System.Windows.Forms.TextBox tbTestLanguage;
        private System.Windows.Forms.Button btnTest;
    }
}

