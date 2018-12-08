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
            this.edit_search = new System.Windows.Forms.ToolStripMenuItem();
            this.edit_replace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.edit_check_all = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_format = new System.Windows.Forms.ToolStripMenuItem();
            this.format_align = new System.Windows.Forms.ToolStripMenuItem();
            this.format_align_left = new System.Windows.Forms.ToolStripMenuItem();
            this.format_align_right = new System.Windows.Forms.ToolStripMenuItem();
            this.format_align_center = new System.Windows.Forms.ToolStripMenuItem();
            this.format_color = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.help_about = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.open = new System.Windows.Forms.ToolStripButton();
            this.save = new System.Windows.Forms.ToolStripButton();
            this.sep_File = new System.Windows.Forms.ToolStripSeparator();
            this.undo = new System.Windows.Forms.ToolStripButton();
            this.redo = new System.Windows.Forms.ToolStripButton();
            this.cut = new System.Windows.Forms.ToolStripButton();
            this.copy = new System.Windows.Forms.ToolStripButton();
            this.paste = new System.Windows.Forms.ToolStripButton();
            this.sep_edit = new System.Windows.Forms.ToolStripSeparator();
            this.bold = new System.Windows.Forms.ToolStripButton();
            this.italic = new System.Windows.Forms.ToolStripButton();
            this.underline = new System.Windows.Forms.ToolStripButton();
            this.deleteline = new System.Windows.Forms.ToolStripButton();
            this.sep_line = new System.Windows.Forms.ToolStripSeparator();
            this.sep_font = new System.Windows.Forms.ToolStripSeparator();
            this.alignLeft = new System.Windows.Forms.ToolStripButton();
            this.alignCenter = new System.Windows.Forms.ToolStripButton();
            this.alignRight = new System.Windows.Forms.ToolStripButton();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.status_ready = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_detail = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.format_bold = new System.Windows.Forms.ToolStripMenuItem();
            this.format_italic = new System.Windows.Forms.ToolStripMenuItem();
            this.format_underline = new System.Windows.Forms.ToolStripMenuItem();
            this.format_deleteline = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.format_background = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.font_size = new System.Windows.Forms.ToolStripComboBox();
            this.font_type = new System.Windows.Forms.ToolStripComboBox();
            this.fontColor = new System.Windows.Forms.ToolStripSplitButton();
            this.fontBackgroundColor = new System.Windows.Forms.ToolStripSplitButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.menuStripMain.Size = new System.Drawing.Size(1040, 25);
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
            // edit_search
            // 
            this.edit_search.Name = "edit_search";
            this.edit_search.Size = new System.Drawing.Size(152, 22);
            this.edit_search.Text = "查找";
            // 
            // edit_replace
            // 
            this.edit_replace.Name = "edit_replace";
            this.edit_replace.Size = new System.Drawing.Size(152, 22);
            this.edit_replace.Text = "替换";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // edit_check_all
            // 
            this.edit_check_all.Name = "edit_check_all";
            this.edit_check_all.Size = new System.Drawing.Size(152, 22);
            this.edit_check_all.Text = "全选";
            // 
            // menu_format
            // 
            this.menu_format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.format_align,
            this.toolStripSeparator5,
            this.format_bold,
            this.format_italic,
            this.format_underline,
            this.format_deleteline,
            this.toolStripSeparator6,
            this.format_color,
            this.format_background});
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
            // format_color
            // 
            this.format_color.Name = "format_color";
            this.format_color.Size = new System.Drawing.Size(152, 22);
            this.format_color.Text = "字体颜色";
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
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open,
            this.save,
            this.sep_File,
            this.undo,
            this.redo,
            this.cut,
            this.copy,
            this.paste,
            this.sep_edit,
            this.bold,
            this.italic,
            this.underline,
            this.deleteline,
            this.sep_line,
            this.alignLeft,
            this.alignCenter,
            this.alignRight,
            this.sep_font,
            this.fontColor,
            this.fontBackgroundColor,
            this.toolStripLabel1,
            this.font_size,
            this.toolStripLabel2,
            this.font_type});
            this.toolStripMain.Location = new System.Drawing.Point(0, 25);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1040, 25);
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
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(23, 22);
            this.save.Text = "保存";
            this.save.Click += new System.EventHandler(this.save_Click);
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
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // redo
            // 
            this.redo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redo.Image = ((System.Drawing.Image)(resources.GetObject("redo.Image")));
            this.redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(23, 22);
            this.redo.Text = "重做";
            this.redo.Click += new System.EventHandler(this.redo_Click);
            // 
            // cut
            // 
            this.cut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cut.Image = ((System.Drawing.Image)(resources.GetObject("cut.Image")));
            this.cut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(23, 22);
            this.cut.Text = "cut";
            this.cut.ToolTipText = "剪切";
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // copy
            // 
            this.copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copy.Image = ((System.Drawing.Image)(resources.GetObject("copy.Image")));
            this.copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(23, 22);
            this.copy.Text = "copy";
            this.copy.ToolTipText = "复制";
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // paste
            // 
            this.paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paste.Image = ((System.Drawing.Image)(resources.GetObject("paste.Image")));
            this.paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(23, 22);
            this.paste.Text = "paste";
            this.paste.ToolTipText = "粘贴";
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // sep_edit
            // 
            this.sep_edit.Name = "sep_edit";
            this.sep_edit.Size = new System.Drawing.Size(6, 25);
            // 
            // bold
            // 
            this.bold.AutoSize = false;
            this.bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bold.Image = ((System.Drawing.Image)(resources.GetObject("bold.Image")));
            this.bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(23, 22);
            this.bold.Text = "toolStripButton1";
            this.bold.ToolTipText = "加粗";
            this.bold.Click += new System.EventHandler(this.bold_Click);
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
            this.italic.Click += new System.EventHandler(this.italic_Click);
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
            this.underline.Click += new System.EventHandler(this.underline_Click);
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
            this.deleteline.Click += new System.EventHandler(this.deleteline_Click);
            // 
            // sep_line
            // 
            this.sep_line.Name = "sep_line";
            this.sep_line.Size = new System.Drawing.Size(6, 25);
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
            this.alignLeft.Click += new System.EventHandler(this.alignLeft_Click);
            // 
            // alignCenter
            // 
            this.alignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignCenter.Image = ((System.Drawing.Image)(resources.GetObject("alignCenter.Image")));
            this.alignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignCenter.Name = "alignCenter";
            this.alignCenter.Size = new System.Drawing.Size(23, 22);
            this.alignCenter.Text = "居中对齐";
            this.alignCenter.Click += new System.EventHandler(this.alignCenter_Click);
            // 
            // alignRight
            // 
            this.alignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alignRight.Image = ((System.Drawing.Image)(resources.GetObject("alignRight.Image")));
            this.alignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alignRight.Name = "alignRight";
            this.alignRight.Size = new System.Drawing.Size(23, 22);
            this.alignRight.Text = "右对齐";
            this.alignRight.Click += new System.EventHandler(this.alignRight_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_ready,
            this.status_detail});
            this.statusStripMain.Location = new System.Drawing.Point(0, 702);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1040, 22);
            this.statusStripMain.TabIndex = 3;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // status_ready
            // 
            this.status_ready.Name = "status_ready";
            this.status_ready.Size = new System.Drawing.Size(32, 17);
            this.status_ready.Text = "就绪";
            // 
            // status_detail
            // 
            this.status_detail.Name = "status_detail";
            this.status_detail.Size = new System.Drawing.Size(82, 17);
            this.status_detail.Text = "第1行，第1列";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 652);
            this.panel1.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1040, 652);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // format_bold
            // 
            this.format_bold.Name = "format_bold";
            this.format_bold.Size = new System.Drawing.Size(152, 22);
            this.format_bold.Text = "加粗";
            // 
            // format_italic
            // 
            this.format_italic.Name = "format_italic";
            this.format_italic.Size = new System.Drawing.Size(152, 22);
            this.format_italic.Text = "倾斜";
            // 
            // format_underline
            // 
            this.format_underline.Name = "format_underline";
            this.format_underline.Size = new System.Drawing.Size(152, 22);
            this.format_underline.Text = "下划线";
            // 
            // format_deleteline
            // 
            this.format_deleteline.Name = "format_deleteline";
            this.format_deleteline.Size = new System.Drawing.Size(152, 22);
            this.format_deleteline.Text = "删除线";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(149, 6);
            // 
            // format_background
            // 
            this.format_background.Name = "format_background";
            this.format_background.Size = new System.Drawing.Size(152, 22);
            this.format_background.Text = "字体底纹";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "字号";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel2.Text = "字体";
            // 
            // font_size
            // 
            this.font_size.Name = "font_size";
            this.font_size.Size = new System.Drawing.Size(75, 25);
            // 
            // font_type
            // 
            this.font_type.Name = "font_type";
            this.font_type.Size = new System.Drawing.Size(121, 25);
            // 
            // fontColor
            // 
            this.fontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontColor.Image = ((System.Drawing.Image)(resources.GetObject("fontColor.Image")));
            this.fontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontColor.Name = "fontColor";
            this.fontColor.Size = new System.Drawing.Size(32, 22);
            this.fontColor.Text = "toolStripSplitButton1";
            this.fontColor.ToolTipText = "字体颜色";
            // 
            // fontBackgroundColor
            // 
            this.fontBackgroundColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontBackgroundColor.Image = ((System.Drawing.Image)(resources.GetObject("fontBackgroundColor.Image")));
            this.fontBackgroundColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontBackgroundColor.Name = "fontBackgroundColor";
            this.fontBackgroundColor.Size = new System.Drawing.Size(32, 22);
            this.fontBackgroundColor.Text = "toolStripSplitButton1";
            this.fontBackgroundColor.ToolTipText = "字体底纹";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 724);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.toolStripMain);
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
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem format_color;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton bold;
        private System.Windows.Forms.ToolStripButton italic;
        private System.Windows.Forms.ToolStripButton underline;
        private System.Windows.Forms.ToolStripButton deleteline;
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
        private System.Windows.Forms.ToolStripButton cut;
        private System.Windows.Forms.ToolStripButton copy;
        private System.Windows.Forms.ToolStripButton paste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem format_bold;
        private System.Windows.Forms.ToolStripMenuItem format_italic;
        private System.Windows.Forms.ToolStripMenuItem format_underline;
        private System.Windows.Forms.ToolStripMenuItem format_deleteline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem format_background;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox font_size;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox font_type;
        private System.Windows.Forms.ToolStripSplitButton fontColor;
        private System.Windows.Forms.ToolStripSplitButton fontBackgroundColor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

