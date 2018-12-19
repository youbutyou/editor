namespace Editor
{
    partial class FindAndReplaceWnd
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
            this.查找 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Find_cbCycle = new System.Windows.Forms.CheckBox();
            this.Find_cbMatchWord = new System.Windows.Forms.CheckBox();
            this.Find_cbMatchCase = new System.Windows.Forms.CheckBox();
            this.Find_btFind = new System.Windows.Forms.Button();
            this.Find_tbFind = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.替换 = new System.Windows.Forms.TabPage();
            this.查找选项 = new System.Windows.Forms.GroupBox();
            this.Replace_cbCycle = new System.Windows.Forms.CheckBox();
            this.Replace_cbMatchWord = new System.Windows.Forms.CheckBox();
            this.Replace_cbMatchCase = new System.Windows.Forms.CheckBox();
            this.Replace_btReplace = new System.Windows.Forms.Button();
            this.Replace_tbReplace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Replace_tbFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Replace_btReplaceAll = new System.Windows.Forms.Button();
            this.Replace_btFind = new System.Windows.Forms.Button();
            this.查找.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.替换.SuspendLayout();
            this.查找选项.SuspendLayout();
            this.SuspendLayout();
            // 
            // 查找
            // 
            this.查找.Controls.Add(this.tabPage1);
            this.查找.Controls.Add(this.替换);
            this.查找.Location = new System.Drawing.Point(0, 3);
            this.查找.Name = "查找";
            this.查找.SelectedIndex = 0;
            this.查找.Size = new System.Drawing.Size(425, 319);
            this.查找.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.Find_btFind);
            this.tabPage1.Controls.Add(this.Find_tbFind);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "查找";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Find_cbCycle);
            this.groupBox1.Controls.Add(this.Find_cbMatchWord);
            this.groupBox1.Controls.Add(this.Find_cbMatchCase);
            this.groupBox1.Location = new System.Drawing.Point(59, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 117);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找选项";
            // 
            // Find_cbCycle
            // 
            this.Find_cbCycle.AutoSize = true;
            this.Find_cbCycle.Location = new System.Drawing.Point(7, 83);
            this.Find_cbCycle.Name = "Find_cbCycle";
            this.Find_cbCycle.Size = new System.Drawing.Size(72, 16);
            this.Find_cbCycle.TabIndex = 3;
            this.Find_cbCycle.Text = "循环查找";
            this.Find_cbCycle.UseVisualStyleBackColor = true;
            // 
            // Find_cbMatchWord
            // 
            this.Find_cbMatchWord.AutoSize = true;
            this.Find_cbMatchWord.Location = new System.Drawing.Point(7, 58);
            this.Find_cbMatchWord.Name = "Find_cbMatchWord";
            this.Find_cbMatchWord.Size = new System.Drawing.Size(72, 16);
            this.Find_cbMatchWord.TabIndex = 1;
            this.Find_cbMatchWord.Text = "全字匹配";
            this.Find_cbMatchWord.UseVisualStyleBackColor = true;
            // 
            // Find_cbMatchCase
            // 
            this.Find_cbMatchCase.AutoSize = true;
            this.Find_cbMatchCase.Location = new System.Drawing.Point(7, 33);
            this.Find_cbMatchCase.Name = "Find_cbMatchCase";
            this.Find_cbMatchCase.Size = new System.Drawing.Size(84, 16);
            this.Find_cbMatchCase.TabIndex = 0;
            this.Find_cbMatchCase.Text = "大小写匹配";
            this.Find_cbMatchCase.UseVisualStyleBackColor = true;
            // 
            // Find_btFind
            // 
            this.Find_btFind.Location = new System.Drawing.Point(281, 231);
            this.Find_btFind.Name = "Find_btFind";
            this.Find_btFind.Size = new System.Drawing.Size(78, 23);
            this.Find_btFind.TabIndex = 7;
            this.Find_btFind.Text = "查找";
            this.Find_btFind.UseVisualStyleBackColor = true;
            this.Find_btFind.Click += new System.EventHandler(this.Find_btFind_Click);
            // 
            // Find_tbFind
            // 
            this.Find_tbFind.Location = new System.Drawing.Point(59, 58);
            this.Find_tbFind.Name = "Find_tbFind";
            this.Find_tbFind.Size = new System.Drawing.Size(300, 21);
            this.Find_tbFind.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "查找内容";
            // 
            // 替换
            // 
            this.替换.BackColor = System.Drawing.SystemColors.Control;
            this.替换.Controls.Add(this.查找选项);
            this.替换.Controls.Add(this.Replace_btReplace);
            this.替换.Controls.Add(this.Replace_tbReplace);
            this.替换.Controls.Add(this.label2);
            this.替换.Controls.Add(this.Replace_tbFind);
            this.替换.Controls.Add(this.label1);
            this.替换.Controls.Add(this.Replace_btReplaceAll);
            this.替换.Controls.Add(this.Replace_btFind);
            this.替换.Location = new System.Drawing.Point(4, 22);
            this.替换.Name = "替换";
            this.替换.Padding = new System.Windows.Forms.Padding(3);
            this.替换.Size = new System.Drawing.Size(417, 293);
            this.替换.TabIndex = 1;
            this.替换.Text = "替换";
            // 
            // 查找选项
            // 
            this.查找选项.Controls.Add(this.Replace_cbCycle);
            this.查找选项.Controls.Add(this.Replace_cbMatchWord);
            this.查找选项.Controls.Add(this.Replace_cbMatchCase);
            this.查找选项.Location = new System.Drawing.Point(48, 118);
            this.查找选项.Name = "查找选项";
            this.查找选项.Size = new System.Drawing.Size(300, 116);
            this.查找选项.TabIndex = 13;
            this.查找选项.TabStop = false;
            this.查找选项.Text = "查找选项";
            // 
            // Replace_cbCycle
            // 
            this.Replace_cbCycle.AutoSize = true;
            this.Replace_cbCycle.Location = new System.Drawing.Point(7, 80);
            this.Replace_cbCycle.Name = "Replace_cbCycle";
            this.Replace_cbCycle.Size = new System.Drawing.Size(72, 16);
            this.Replace_cbCycle.TabIndex = 3;
            this.Replace_cbCycle.Text = "循环查找";
            this.Replace_cbCycle.UseVisualStyleBackColor = true;
            // 
            // Replace_cbMatchWord
            // 
            this.Replace_cbMatchWord.AutoSize = true;
            this.Replace_cbMatchWord.Location = new System.Drawing.Point(7, 55);
            this.Replace_cbMatchWord.Name = "Replace_cbMatchWord";
            this.Replace_cbMatchWord.Size = new System.Drawing.Size(72, 16);
            this.Replace_cbMatchWord.TabIndex = 1;
            this.Replace_cbMatchWord.Text = "全字匹配";
            this.Replace_cbMatchWord.UseVisualStyleBackColor = true;
            // 
            // Replace_cbMatchCase
            // 
            this.Replace_cbMatchCase.AutoSize = true;
            this.Replace_cbMatchCase.Location = new System.Drawing.Point(7, 30);
            this.Replace_cbMatchCase.Name = "Replace_cbMatchCase";
            this.Replace_cbMatchCase.Size = new System.Drawing.Size(84, 16);
            this.Replace_cbMatchCase.TabIndex = 0;
            this.Replace_cbMatchCase.Text = "大小写匹配";
            this.Replace_cbMatchCase.UseVisualStyleBackColor = true;
            // 
            // Replace_btReplace
            // 
            this.Replace_btReplace.Location = new System.Drawing.Point(212, 250);
            this.Replace_btReplace.Name = "Replace_btReplace";
            this.Replace_btReplace.Size = new System.Drawing.Size(75, 23);
            this.Replace_btReplace.TabIndex = 12;
            this.Replace_btReplace.Text = "替换";
            this.Replace_btReplace.UseVisualStyleBackColor = true;
            this.Replace_btReplace.Click += new System.EventHandler(this.Replace_btReplace_Click);
            // 
            // Replace_tbReplace
            // 
            this.Replace_tbReplace.Location = new System.Drawing.Point(49, 80);
            this.Replace_tbReplace.Name = "Replace_tbReplace";
            this.Replace_tbReplace.Size = new System.Drawing.Size(300, 21);
            this.Replace_tbReplace.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "替换为:";
            // 
            // Replace_tbFind
            // 
            this.Replace_tbFind.Location = new System.Drawing.Point(49, 31);
            this.Replace_tbFind.Name = "Replace_tbFind";
            this.Replace_tbFind.Size = new System.Drawing.Size(300, 21);
            this.Replace_tbFind.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "查找内容:";
            // 
            // Replace_btReplaceAll
            // 
            this.Replace_btReplaceAll.Location = new System.Drawing.Point(302, 250);
            this.Replace_btReplaceAll.Name = "Replace_btReplaceAll";
            this.Replace_btReplaceAll.Size = new System.Drawing.Size(75, 23);
            this.Replace_btReplaceAll.TabIndex = 15;
            this.Replace_btReplaceAll.Text = "全部替换";
            this.Replace_btReplaceAll.UseVisualStyleBackColor = true;
            this.Replace_btReplaceAll.Click += new System.EventHandler(this.Replace_btReplaceAll_Click);
            // 
            // Replace_btFind
            // 
            this.Replace_btFind.Location = new System.Drawing.Point(121, 250);
            this.Replace_btFind.Name = "Replace_btFind";
            this.Replace_btFind.Size = new System.Drawing.Size(75, 23);
            this.Replace_btFind.TabIndex = 14;
            this.Replace_btFind.Text = "查找";
            this.Replace_btFind.UseVisualStyleBackColor = true;
            this.Replace_btFind.Click += new System.EventHandler(this.Replace_btFind_Click);
            // 
            // FindAndReplaceWnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 320);
            this.Controls.Add(this.查找);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindAndReplaceWnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找和替换";
            this.TopMost = true;
            this.查找.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.替换.ResumeLayout(false);
            this.替换.PerformLayout();
            this.查找选项.ResumeLayout(false);
            this.查找选项.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl 查找;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage 替换;
        private System.Windows.Forms.GroupBox 查找选项;
        private System.Windows.Forms.CheckBox Replace_cbCycle;
        private System.Windows.Forms.CheckBox Replace_cbMatchWord;
        private System.Windows.Forms.CheckBox Replace_cbMatchCase;
        private System.Windows.Forms.Button Replace_btReplace;
        private System.Windows.Forms.TextBox Replace_tbReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Replace_tbFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Replace_btReplaceAll;
        private System.Windows.Forms.Button Replace_btFind;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Find_cbCycle;
        private System.Windows.Forms.CheckBox Find_cbMatchWord;
        private System.Windows.Forms.CheckBox Find_cbMatchCase;
        private System.Windows.Forms.Button Find_btFind;
        private System.Windows.Forms.TextBox Find_tbFind;
        private System.Windows.Forms.Label label3;

    }
}