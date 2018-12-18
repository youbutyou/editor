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
            this.menu_file_create = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_save_as = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit_redo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_edit_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_edit_search = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit_replace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_edit_check_all = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_format = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_format_align = new System.Windows.Forms.ToolStripMenuItem();
            this.format_align_left = new System.Windows.Forms.ToolStripMenuItem();
            this.format_align_right = new System.Windows.Forms.ToolStripMenuItem();
            this.format_align_center = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_format_bold = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_format_italic = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_format_underline = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_format_deleteline = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_format_color = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_format_background = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help_about = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.open = new System.Windows.Forms.ToolStripButton();
            this.create = new System.Windows.Forms.ToolStripButton();
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
            this.alignLeft = new System.Windows.Forms.ToolStripButton();
            this.alignCenter = new System.Windows.Forms.ToolStripButton();
            this.alignRight = new System.Windows.Forms.ToolStripButton();
            this.sep_font = new System.Windows.Forms.ToolStripSeparator();
            this.colorFont = new System.Windows.Forms.ToolStripTextBox();
            this.fontColor = new System.Windows.Forms.ToolStripSplitButton();
            this.colorBackground = new System.Windows.Forms.ToolStripTextBox();
            this.fontBackgroundColor = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.fontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.fontType = new System.Windows.Forms.ToolStripComboBox();
            this.picture = new System.Windows.Forms.ToolStripButton();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.status_ready = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_detail = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
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
            this.menu_file_create,
            this.menu_file_open,
            this.menu_file_save,
            this.menu_file_save_as,
            this.toolStripSeparator1,
            this.menu_file_exit});
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(58, 21);
            this.menu_file.Text = "文件(&F)";
            // 
            // menu_file_create
            // 
            this.menu_file_create.Name = "menu_file_create";
            this.menu_file_create.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menu_file_create.Size = new System.Drawing.Size(147, 22);
            this.menu_file_create.Text = "新建";
            this.menu_file_create.Click += new System.EventHandler(this.menu_file_create_Click);
            // 
            // menu_file_open
            // 
            this.menu_file_open.Name = "menu_file_open";
            this.menu_file_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menu_file_open.Size = new System.Drawing.Size(147, 22);
            this.menu_file_open.Text = "打开";
            this.menu_file_open.Click += new System.EventHandler(this.menu_file_open_Click);
            // 
            // menu_file_save
            // 
            this.menu_file_save.Name = "menu_file_save";
            this.menu_file_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menu_file_save.Size = new System.Drawing.Size(147, 22);
            this.menu_file_save.Text = "保存";
            this.menu_file_save.Click += new System.EventHandler(this.menu_file_save_Click);
            // 
            // menu_file_save_as
            // 
            this.menu_file_save_as.Name = "menu_file_save_as";
            this.menu_file_save_as.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.menu_file_save_as.Size = new System.Drawing.Size(147, 22);
            this.menu_file_save_as.Text = "另存为";
            this.menu_file_save_as.Click += new System.EventHandler(this.menu_file_save_as_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // menu_file_exit
            // 
            this.menu_file_exit.Name = "menu_file_exit";
            this.menu_file_exit.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menu_file_exit.Size = new System.Drawing.Size(147, 22);
            this.menu_file_exit.Text = "退出";
            this.menu_file_exit.Click += new System.EventHandler(this.menu_file_exit_Click);
            // 
            // menu_edit
            // 
            this.menu_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_edit_undo,
            this.menu_edit_redo,
            this.toolStripSeparator2,
            this.menu_edit_cut,
            this.menu_edit_copy,
            this.menu_edit_paste,
            this.toolStripSeparator3,
            this.menu_edit_search,
            this.menu_edit_replace,
            this.toolStripSeparator4,
            this.menu_edit_check_all});
            this.menu_edit.Name = "menu_edit";
            this.menu_edit.Size = new System.Drawing.Size(59, 21);
            this.menu_edit.Text = "编辑(&E)";
            // 
            // menu_edit_undo
            // 
            this.menu_edit_undo.Name = "menu_edit_undo";
            this.menu_edit_undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menu_edit_undo.Size = new System.Drawing.Size(152, 22);
            this.menu_edit_undo.Text = "撤销";
            this.menu_edit_undo.Click += new System.EventHandler(this.menu_edit_undo_Click);
            // 
            // menu_edit_redo
            // 
            this.menu_edit_redo.Name = "menu_edit_redo";
            this.menu_edit_redo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.menu_edit_redo.Size = new System.Drawing.Size(152, 22);
            this.menu_edit_redo.Text = "重做";
            this.menu_edit_redo.Click += new System.EventHandler(this.menu_edit_redo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // menu_edit_cut
            // 
            this.menu_edit_cut.Name = "menu_edit_cut";
            this.menu_edit_cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menu_edit_cut.Size = new System.Drawing.Size(152, 22);
            this.menu_edit_cut.Text = "剪切";
            this.menu_edit_cut.Click += new System.EventHandler(this.menu_edit_cut_Click);
            // 
            // menu_edit_copy
            // 
            this.menu_edit_copy.Name = "menu_edit_copy";
            this.menu_edit_copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menu_edit_copy.Size = new System.Drawing.Size(152, 22);
            this.menu_edit_copy.Text = "复制";
            this.menu_edit_copy.Click += new System.EventHandler(this.menu_edit_copy_Click);
            // 
            // menu_edit_paste
            // 
            this.menu_edit_paste.Name = "menu_edit_paste";
            this.menu_edit_paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menu_edit_paste.Size = new System.Drawing.Size(152, 22);
            this.menu_edit_paste.Text = "粘贴";
            this.menu_edit_paste.Click += new System.EventHandler(this.menu_edit_paste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // menu_edit_search
            // 
            this.menu_edit_search.Name = "menu_edit_search";
            this.menu_edit_search.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menu_edit_search.Size = new System.Drawing.Size(152, 22);
            this.menu_edit_search.Text = "查找";
            this.menu_edit_search.Click += new System.EventHandler(this.menu_edit_search_Click);
            // 
            // menu_edit_replace
            // 
            this.menu_edit_replace.Name = "menu_edit_replace";
            this.menu_edit_replace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menu_edit_replace.Size = new System.Drawing.Size(152, 22);
            this.menu_edit_replace.Text = "替换";
            this.menu_edit_replace.Click += new System.EventHandler(this.menu_edit_replace_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // menu_edit_check_all
            // 
            this.menu_edit_check_all.Name = "menu_edit_check_all";
            this.menu_edit_check_all.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menu_edit_check_all.Size = new System.Drawing.Size(152, 22);
            this.menu_edit_check_all.Text = "全选";
            this.menu_edit_check_all.Click += new System.EventHandler(this.menu_edit_check_all_Click);
            // 
            // menu_format
            // 
            this.menu_format.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_format_align,
            this.toolStripSeparator5,
            this.menu_format_bold,
            this.menu_format_italic,
            this.menu_format_underline,
            this.menu_format_deleteline,
            this.toolStripSeparator6,
            this.menu_format_color,
            this.menu_format_background});
            this.menu_format.Name = "menu_format";
            this.menu_format.Size = new System.Drawing.Size(62, 21);
            this.menu_format.Text = "格式(&O)";
            // 
            // menu_format_align
            // 
            this.menu_format_align.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.format_align_left,
            this.format_align_right,
            this.format_align_center});
            this.menu_format_align.Name = "menu_format_align";
            this.menu_format_align.Size = new System.Drawing.Size(158, 22);
            this.menu_format_align.Text = "对齐";
            // 
            // format_align_left
            // 
            this.format_align_left.Name = "format_align_left";
            this.format_align_left.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.format_align_left.Size = new System.Drawing.Size(168, 22);
            this.format_align_left.Text = "左对齐";
            this.format_align_left.Click += new System.EventHandler(this.format_align_left_Click);
            // 
            // format_align_right
            // 
            this.format_align_right.Name = "format_align_right";
            this.format_align_right.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.format_align_right.Size = new System.Drawing.Size(168, 22);
            this.format_align_right.Text = "右对齐";
            this.format_align_right.Click += new System.EventHandler(this.format_align_right_Click);
            // 
            // format_align_center
            // 
            this.format_align_center.Name = "format_align_center";
            this.format_align_center.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.format_align_center.Size = new System.Drawing.Size(168, 22);
            this.format_align_center.Text = "居中对齐";
            this.format_align_center.Click += new System.EventHandler(this.format_align_center_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // menu_format_bold
            // 
            this.menu_format_bold.Name = "menu_format_bold";
            this.menu_format_bold.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menu_format_bold.Size = new System.Drawing.Size(158, 22);
            this.menu_format_bold.Text = "加粗";
            this.menu_format_bold.Click += new System.EventHandler(this.menu_format_bold_Click);
            // 
            // menu_format_italic
            // 
            this.menu_format_italic.Name = "menu_format_italic";
            this.menu_format_italic.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.menu_format_italic.Size = new System.Drawing.Size(158, 22);
            this.menu_format_italic.Text = "倾斜";
            this.menu_format_italic.Click += new System.EventHandler(this.menu_format_italic_Click);
            // 
            // menu_format_underline
            // 
            this.menu_format_underline.Name = "menu_format_underline";
            this.menu_format_underline.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.menu_format_underline.Size = new System.Drawing.Size(158, 22);
            this.menu_format_underline.Text = "下划线";
            this.menu_format_underline.Click += new System.EventHandler(this.menu_format_underline_Click);
            // 
            // menu_format_deleteline
            // 
            this.menu_format_deleteline.Name = "menu_format_deleteline";
            this.menu_format_deleteline.Size = new System.Drawing.Size(158, 22);
            this.menu_format_deleteline.Text = "删除线";
            this.menu_format_deleteline.Click += new System.EventHandler(this.menu_format_deleteline_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(155, 6);
            // 
            // menu_format_color
            // 
            this.menu_format_color.Name = "menu_format_color";
            this.menu_format_color.Size = new System.Drawing.Size(158, 22);
            this.menu_format_color.Text = "字体颜色";
            this.menu_format_color.Click += new System.EventHandler(this.menu_format_color_Click);
            // 
            // menu_format_background
            // 
            this.menu_format_background.Name = "menu_format_background";
            this.menu_format_background.Size = new System.Drawing.Size(158, 22);
            this.menu_format_background.Text = "字体底纹";
            this.menu_format_background.Click += new System.EventHandler(this.menu_format_background_Click);
            // 
            // menu_help
            // 
            this.menu_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_help_about});
            this.menu_help.Name = "menu_help";
            this.menu_help.Size = new System.Drawing.Size(61, 21);
            this.menu_help.Text = "帮助(&H)";
            // 
            // menu_help_about
            // 
            this.menu_help_about.Name = "menu_help_about";
            this.menu_help_about.Size = new System.Drawing.Size(100, 22);
            this.menu_help_about.Text = "关于";
            this.menu_help_about.Click += new System.EventHandler(this.menu_help_about_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open,
            this.create,
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
            this.colorFont,
            this.fontColor,
            this.colorBackground,
            this.fontBackgroundColor,
            this.toolStripLabel1,
            this.fontSize,
            this.toolStripLabel2,
            this.fontType,
            this.picture});
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
            // create
            // 
            this.create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.create.Image = ((System.Drawing.Image)(resources.GetObject("create.Image")));
            this.create.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(23, 22);
            this.create.Text = "new";
            this.create.ToolTipText = "新建";
            this.create.Click += new System.EventHandler(this.create_Click);
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
            // sep_font
            // 
            this.sep_font.Name = "sep_font";
            this.sep_font.Size = new System.Drawing.Size(6, 25);
            // 
            // colorFont
            // 
            this.colorFont.Name = "colorFont";
            this.colorFont.Size = new System.Drawing.Size(5, 25);
            // 
            // fontColor
            // 
            this.fontColor.BackColor = System.Drawing.Color.White;
            this.fontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontColor.Image = ((System.Drawing.Image)(resources.GetObject("fontColor.Image")));
            this.fontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontColor.Name = "fontColor";
            this.fontColor.Size = new System.Drawing.Size(32, 22);
            this.fontColor.Text = "toolStripSplitButton1";
            this.fontColor.ToolTipText = "字体颜色";
            this.fontColor.Click += new System.EventHandler(this.fontColor_Click);
            // 
            // colorBackground
            // 
            this.colorBackground.Name = "colorBackground";
            this.colorBackground.Size = new System.Drawing.Size(5, 25);
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
            this.fontBackgroundColor.Click += new System.EventHandler(this.fontBackgroundColor_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel1.Text = "字号";
            // 
            // fontSize
            // 
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(75, 25);
            this.fontSize.SelectedIndexChanged += new System.EventHandler(this.fontSize_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel2.Text = "字体";
            // 
            // fontType
            // 
            this.fontType.Name = "fontType";
            this.fontType.Size = new System.Drawing.Size(120, 25);
            this.fontType.SelectedIndexChanged += new System.EventHandler(this.fontType_SelectedIndexChanged);
            // 
            // picture
            // 
            this.picture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(23, 22);
            this.picture.Text = "toolStripButton1";
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
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem menu_file_create;
        private System.Windows.Forms.ToolStripMenuItem menu_file_open;
        private System.Windows.Forms.ToolStripMenuItem menu_file_save;
        private System.Windows.Forms.ToolStripMenuItem menu_file_save_as;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu_file_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_edit;
        private System.Windows.Forms.ToolStripMenuItem menu_edit_undo;
        private System.Windows.Forms.ToolStripMenuItem menu_edit_redo;
        private System.Windows.Forms.ToolStripMenuItem menu_edit_cut;
        private System.Windows.Forms.ToolStripMenuItem menu_edit_copy;
        private System.Windows.Forms.ToolStripMenuItem menu_edit_paste;
        private System.Windows.Forms.ToolStripMenuItem menu_edit_check_all;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menu_edit_search;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menu_format;
        private System.Windows.Forms.ToolStripMenuItem menu_format_align;
        private System.Windows.Forms.ToolStripMenuItem format_align_left;
        private System.Windows.Forms.ToolStripMenuItem format_align_right;
        private System.Windows.Forms.ToolStripMenuItem format_align_center;
        private System.Windows.Forms.ToolStripMenuItem menu_format_color;
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
        private System.Windows.Forms.ToolStripMenuItem menu_help_about;
        private System.Windows.Forms.ToolStripStatusLabel status_detail;
        private System.Windows.Forms.ToolStripMenuItem menu_edit_replace;
        private System.Windows.Forms.ToolStripButton cut;
        private System.Windows.Forms.ToolStripButton copy;
        private System.Windows.Forms.ToolStripButton paste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menu_format_bold;
        private System.Windows.Forms.ToolStripMenuItem menu_format_italic;
        private System.Windows.Forms.ToolStripMenuItem menu_format_underline;
        private System.Windows.Forms.ToolStripMenuItem menu_format_deleteline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem menu_format_background;
        private System.Windows.Forms.ToolStripComboBox fontSize;
        private System.Windows.Forms.ToolStripComboBox fontType;
        private System.Windows.Forms.ToolStripSplitButton fontColor;
        private System.Windows.Forms.ToolStripSplitButton fontBackgroundColor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton create;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripTextBox colorBackground;
        private System.Windows.Forms.ToolStripTextBox colorFont;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton picture;
    }
}

