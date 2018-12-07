namespace Editor
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.file_create = new System.Windows.Forms.ToolStripMenuItem();
            this.file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.file_save_as = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_check_all = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_search = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_format = new System.Windows.Forms.ToolStripMenuItem();
            this.format_align = new System.Windows.Forms.ToolStripMenuItem();
            this.format_align_left = new System.Windows.Forms.ToolStripMenuItem();
            this.format_align_right = new System.Windows.Forms.ToolStripMenuItem();
            this.format_align_center = new System.Windows.Forms.ToolStripMenuItem();
            this.format_font = new System.Windows.Forms.ToolStripMenuItem();
            this.format_font_bold = new System.Windows.Forms.ToolStripMenuItem();
            this.format_font_italic = new System.Windows.Forms.ToolStripMenuItem();
            this.format_font_underline = new System.Windows.Forms.ToolStripMenuItem();
            this.format_color = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.open = new System.Windows.Forms.ToolStripButton();
            this.save = new System.Windows.Forms.ToolStripButton();
            this.sep_File = new System.Windows.Forms.ToolStripSeparator();
            this.undo = new System.Windows.Forms.ToolStripButton();
            this.redo = new System.Windows.Forms.ToolStripButton();
            this.sep_edit = new System.Windows.Forms.ToolStripSeparator();
            this.bold = new System.Windows.Forms.ToolStripButton();
            this.italic = new System.Windows.Forms.ToolStripButton();
            this.underline = new System.Windows.Forms.ToolStripButton();
            this.deleteline = new System.Windows.Forms.ToolStripButton();
            this.sep_line = new System.Windows.Forms.ToolStripSeparator();
            this.fontSize = new System.Windows.Forms.ToolStripButton();
            this.fontColor = new System.Windows.Forms.ToolStripButton();
            this.fontBackground = new System.Windows.Forms.ToolStripButton();
            this.sep_font = new System.Windows.Forms.ToolStripSeparator();
            this.alignLeft = new System.Windows.Forms.ToolStripButton();
            this.alignRight = new System.Windows.Forms.ToolStripButton();
            this.alignCenter = new System.Windows.Forms.ToolStripButton();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.status_ready = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.help_about = new System.Windows.Forms.ToolStripMenuItem();
            this.status_detail = new System.Windows.Forms.ToolStripStatusLabel();
            this.edit_replace = new System.Windows.Forms.ToolStripMenuItem();
            this.format_font_deleteline = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.menu_edit,
            this.menu_format,
            this.menu_help});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1312, 25);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_create,
            this.file_open,
            this.file_save,
            this.file_save_as,
            this.toolStripSeparator1,
            this.file_exit});
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(58, 21);
            this.menu_file.Text = "文件(&F)";
            // 
            // file_create
            // 
            this.file_create.Name = "file_create";
            this.file_create.Size = new System.Drawing.Size(152, 22);
            this.file_create.Text = "新建";
            // 
            // file_open
            // 
            this.file_open.Name = "file_open";
            this.file_open.Size = new System.Drawing.Size(152, 22);
            this.file_open.Text = "打开";
            // 
            // file_save
            // 
            this.file_save.Name = "file_save";
            this.file_save.Size = new System.Drawing.Size(152, 22);
            this.file_save.Text = "保存";
            // 
            // file_save_as
            // 
            this.file_save_as.Name = "file_save_as";
            this.file_save_as.Size = new System.Drawing.Size(152, 22);
            this.file_save_as.Text = "另存为";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // file_exit
            // 
            this.file_exit.Name = "file_exit";
            this.file_exit.Size = new System.Drawing.Size(152, 22);
            this.file_exit.Text = "退出";
            // 
            // menu_edit
            // 
            this.menu_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit_undo,
            this.edit_redo,
            this.toolStripSeparator2,
            this.edit_cut,
            this.edit_copy,
            this.edit_paste,
            this.toolStripSeparator3,
            this.edit_search,
            this.edit_replace,
            this.toolStripSeparator4,
            this.edit_check_all});
            this.menu_edit.Name = "menu_edit";
            this.menu_edit.Size = new System.Drawing.Size(59, 21);
            this.menu_edit.Text = "编辑(&E)";
            // 
            // edit_undo
            // 
            this.edit_undo.Name = "edit_undo";
            this.edit_undo.Size = new System.Drawing.Size(152, 22);
            this.edit_undo.Text = "撤销";
            // 
            // edit_redo
            // 
            this.edit_redo.Name = "edit_redo";
            this.edit_redo.Size = new System.Drawing.Size(152, 22);
            this.edit_redo.Text = "重做";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // edit_cut
            // 
            this.edit_cut.Name = "edit_cut";
            this.edit_cut.Size = new System.Drawing.Size(152, 22);
            this.edit_cut.Text = "剪切";
            // 
            // edit_copy
            // 
            this.edit_copy.Name = "edit_copy";
            this.edit_copy.Size = new System.Drawing.Size(152, 22);
            this.edit_copy.Text = "复制";
            // 
            // edit_paste
            // 
            this.edit_paste.Name = "edit_paste";
            this.edit_paste.Size = new System.Drawing.Size(152, 22);
            this.edit_paste.Text = "粘贴";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // edit_check_all
            // 
            this.edit_check_all.Name = "edit_check_all";
            this.edit_check_all.Size = new System.Drawing.Size(152, 22);
            this.edit_check_all.Text = "全选";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // edit_search
            // 
            this.edit_search.Name = "edit_search";
            this.edit_search.Size = new System.Drawing.Size(152, 22);
            this.edit_search.Text = "查找";
            // 
            // menu_format
            // 
            this.menu_format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.format_align,
            this.format_font,
            this.format_color});
            this.menu_format.Name = "menu_format";
            this.menu_format.Size = new System.Drawing.Size(62, 21);
            this.menu_format.Text = "格式(&O)";
            // 
            // format_align
            // 
            this.format_align.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.format_align_left,
            this.format_align_right,
            this.format_align_center});
            this.format_align.Name = "format_align";
            this.format_align.Size = new System.Drawing.Size(152, 22);
            this.format_align.Text = "对齐";
            // 
            // format_align_left
            // 
            this.format_align_left.Name = "format_align_left";
            this.format_align_left.Size = new System.Drawing.Size(152, 22);
            this.format_align_left.Text = "左对齐";
            // 
            // format_align_right
            // 
            this.format_align_right.Name = "format_align_right";
            this.format_align_right.Size = new System.Drawing.Size(152, 22);
            this.format_align_right.Text = "右对齐";
            // 
            // format_align_center
            // 
            this.format_align_center.Name = "format_align_center";
            this.format_align_center.Size = new System.Drawing.Size(152, 22);
            this.format_align_center.Text = "居中对齐";
            // 
            // format_font
            // 
            this.format_font.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.format_font_bold,
            this.format_font_italic,
            this.toolStripSeparator5,
            this.format_font_underline,
            this.format_font_deleteline});
            this.format_font.Name = "format_font";
            this.format_font.Size = new System.Drawing.Size(152, 22);
            this.format_font.Text = "字体";
            // 
            // format_font_bold
            // 
            this.format_font_bold.Name = "format_font_bold";
            this.format_font_bold.Size = new System.Drawing.Size(152, 22);
            this.format_font_bold.Text = "加粗";
            // 
            // format_font_italic
            // 
            this.format_font_italic.Name = "format_font_italic";
            this.format_font_italic.Size = new System.Drawing.Size(152, 22);
            this.format_font_italic.Text = "倾斜";
            // 
            // format_font_underline
            // 
            this.format_font_underline.Name = "format_font_underline";
            this.format_font_underline.Size = new System.Drawing.Size(152, 22);
            this.format_font_underline.Text = "下划线";
            // 
            // format_color
            // 
            this.format_color.Name = "format_color";
            this.format_color.Size = new System.Drawing.Size(152, 22);
            this.format_color.Text = "颜色";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1312, 577);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open,
            this.save,
            this.sep_File,
            this.undo,
            this.redo,
            this.sep_edit,
            this.bold,
            this.italic,
            this.underline,
            this.deleteline,
            this.sep_line,
            this.fontSize,
            this.fontColor,
            this.fontBackground,
            this.sep_font,
            this.alignLeft,
            this.alignRight,
            this.alignCenter});
            this.toolStripMain.Location = new System.Drawing.Point(0, 25);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1312, 25);
            this.toolStripMain.TabIndex = 2;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // open
            // 
            this.open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.open.Image = ((System.Drawing.Image)(resources.GetObject("open.Image")));
            this.open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(23, 22);
            this.open.Text = "打开文件";
            // 
            // save
            // 
            this.save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(23, 22);
            this.save.Text = "保存";
            // 
            // sep_File
            // 
            this.sep_File.Name = "sep_File";
            this.sep_File.Size = new System.Drawing.Size(6, 25);
            // 
            // undo
            // 
            this.undo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undo.Image = ((System.Drawing.Image)(resources.GetObject("undo.Image")));
            this.undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(23, 22);
            this.undo.Text = "撤销";
            // 
            // redo
            // 
            this.redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redo.Image = ((System.Drawing.Image)(resources.GetObject("redo.Image")));
            this.redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(23, 22);
            this.redo.Text = "重做";
            // 
            // sep_edit
            // 
            this.sep_edit.Name = "sep_edit";
            this.sep_edit.Size = new System.Drawing.Size(6, 25);
            // 
            // bold
            // 
            this.bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bold.Image = ((System.Drawing.Image)(resources.GetObject("bold.Image")));
            this.bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(23, 22);
            this.bold.Text = "toolStripButton1";
            this.bold.ToolTipText = "加粗";
            // 
            // italic
            // 
            this.italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italic.Image = ((System.Drawing.Image)(resources.GetObject("italic.Image")));
            this.italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(23, 22);
            this.italic.Text = "toolStripButton2";
            this.italic.ToolTipText = "倾斜";
            // 
            // underline
            // 
            this.underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underline.Image = ((System.Drawing.Image)(resources.GetObject("underline.Image")));
            this.underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(23, 22);
            this.underline.Text = "toolStripButton3";
            this.underline.ToolTipText = "下划线";
            // 
            // deleteline
            // 
            this.deleteline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteline.Image = ((System.Drawing.Image)(resources.GetObject("deleteline.Image")));
            this.deleteline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteline.Name = "deleteline";
            this.deleteline.Size = new System.Drawing.Size(23, 22);
            this.deleteline.Text = "deleteline";
            this.deleteline.ToolTipText = "删除线";
            // 
            // sep_line
            // 
            this.sep_line.Name = "sep_line";
            this.sep_line.Size = new System.Drawing.Size(6, 25);
            // 
            // fontSize
            // 
            this.fontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontSize.Image = ((System.Drawing.Image)(resources.GetObject("fontSize.Image")));
            this.fontSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(23, 22);
            this.fontSize.Text = "toolStripButton4";
            this.fontSize.ToolTipText = "字体大小";
            // 
            // fontColor
            // 
            this.fontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontColor.Image = ((System.Drawing.Image)(resources.GetObject("fontColor.Image")));
            this.fontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontColor.Name = "fontColor";
            this.fontColor.Size = new System.Drawing.Size(23, 22);
            this.fontColor.Text = "toolStripButton5";
            this.fontColor.ToolTipText = "字体颜色";
            // 
            // fontBackground
            // 
            this.fontBackground.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontBackground.Image = ((System.Drawing.Image)(resources.GetObject("fontBackground.Image")));
            this.fontBackground.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontBackground.Name = "fontBackground";
            this.fontBackground.Size = new System.Drawing.Size(23, 22);
            this.fontBackground.Text = "字体底纹";
            // 
            // sep_font
            // 
            this.sep_font.Name = "sep_font";
            this.sep_font.Size = new System.Drawing.Size(6, 25);
            // 
            // alignLeft
            // 
            this.alignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignLeft.Image = ((System.Drawing.Image)(resources.GetObject("alignLeft.Image")));
            this.alignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignLeft.Name = "alignLeft";
            this.alignLeft.Size = new System.Drawing.Size(23, 22);
            this.alignLeft.Text = "左对齐";
            // 
            // alignRight
            // 
            this.alignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignRight.Image = ((System.Drawing.Image)(resources.GetObject("alignRight.Image")));
            this.alignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignRight.Name = "alignRight";
            this.alignRight.Size = new System.Drawing.Size(23, 22);
            this.alignRight.Text = "右对齐";
            // 
            // alignCenter
            // 
            this.alignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignCenter.Image = ((System.Drawing.Image)(resources.GetObject("alignCenter.Image")));
            this.alignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignCenter.Name = "alignCenter";
            this.alignCenter.Size = new System.Drawing.Size(23, 22);
            this.alignCenter.Text = "居中对齐";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_ready,
            this.status_detail});
            this.statusStripMain.Location = new System.Drawing.Point(0, 580);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1312, 22);
            this.statusStripMain.TabIndex = 3;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // status_ready
            // 
            this.status_ready.Name = "status_ready";
            this.status_ready.Size = new System.Drawing.Size(32, 17);
            this.status_ready.Text = "就绪";
            // 
            // menu_help
            // 
            this.menu_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.help_about});
            this.menu_help.Name = "menu_help";
            this.menu_help.Size = new System.Drawing.Size(61, 21);
            this.menu_help.Text = "帮助(&H)";
            // 
            // help_about
            // 
            this.help_about.Name = "help_about";
            this.help_about.Size = new System.Drawing.Size(152, 22);
            this.help_about.Text = "关于";
            // 
            // status_detail
            // 
            this.status_detail.Name = "status_detail";
            this.status_detail.Size = new System.Drawing.Size(82, 17);
            this.status_detail.Text = "第1行，第1列";
            // 
            // edit_replace
            // 
            this.edit_replace.Name = "edit_replace";
            this.edit_replace.Size = new System.Drawing.Size(152, 22);
            this.edit_replace.Text = "替换";
            // 
            // format_font_deleteline
            // 
            this.format_font_deleteline.Name = "format_font_deleteline";
            this.format_font_deleteline.Size = new System.Drawing.Size(152, 22);
            this.format_font_deleteline.Text = "删除线";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 602);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "Main";
            this.Text = "编辑器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menu_file;
        private System.Windows.Forms.ToolStripMenuItem file_create;
        private System.Windows.Forms.ToolStripMenuItem file_open;
        private System.Windows.Forms.ToolStripMenuItem file_save;
        private System.Windows.Forms.ToolStripMenuItem file_save_as;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem file_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_edit;
        private System.Windows.Forms.ToolStripMenuItem edit_undo;
        private System.Windows.Forms.ToolStripMenuItem edit_redo;
        private System.Windows.Forms.ToolStripMenuItem edit_cut;
        private System.Windows.Forms.ToolStripMenuItem edit_copy;
        private System.Windows.Forms.ToolStripMenuItem edit_paste;
        private System.Windows.Forms.ToolStripMenuItem edit_check_all;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem edit_search;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menu_format;
        private System.Windows.Forms.ToolStripMenuItem format_align;
        private System.Windows.Forms.ToolStripMenuItem format_align_left;
        private System.Windows.Forms.ToolStripMenuItem format_align_right;
        private System.Windows.Forms.ToolStripMenuItem format_align_center;
        private System.Windows.Forms.ToolStripMenuItem format_font;
        private System.Windows.Forms.ToolStripMenuItem format_color;
        private System.Windows.Forms.ToolStripMenuItem format_font_bold;
        private System.Windows.Forms.ToolStripMenuItem format_font_italic;
        private System.Windows.Forms.ToolStripMenuItem format_font_underline;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton bold;
        private System.Windows.Forms.ToolStripButton italic;
        private System.Windows.Forms.ToolStripButton underline;
        private System.Windows.Forms.ToolStripButton deleteline;
        private System.Windows.Forms.ToolStripButton fontSize;
        private System.Windows.Forms.ToolStripButton fontColor;
        private System.Windows.Forms.ToolStripButton fontBackground;
        private System.Windows.Forms.ToolStripButton open;
        private System.Windows.Forms.ToolStripButton save;
        private System.Windows.Forms.ToolStripSeparator sep_File;
        private System.Windows.Forms.ToolStripSeparator sep_line;
        private System.Windows.Forms.ToolStripSeparator sep_font;
        private System.Windows.Forms.ToolStripButton undo;
        private System.Windows.Forms.ToolStripButton redo;
        private System.Windows.Forms.ToolStripSeparator sep_edit;
        private System.Windows.Forms.ToolStripButton alignLeft;
        private System.Windows.Forms.ToolStripButton alignRight;
        private System.Windows.Forms.ToolStripButton alignCenter;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel status_ready;
        private System.Windows.Forms.ToolStripMenuItem menu_help;
        private System.Windows.Forms.ToolStripMenuItem help_about;
        private System.Windows.Forms.ToolStripStatusLabel status_detail;
        private System.Windows.Forms.ToolStripMenuItem edit_replace;
        private System.Windows.Forms.ToolStripMenuItem format_font_deleteline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

