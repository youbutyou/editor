﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Editor.util;

namespace Editor
{
    public partial class Main : Form
    {
        // 新建或打开的文件路径
        private string g_filePath = "";
        // 是否编辑过
        private bool g_isChanged = false;
        // 查找开始坐标
        private int g_indexFind = 0;

        public Main()
        {
            InitializeComponent();
        }

        /**
         * 主窗口加载
         */
        private void Main_Load(object sender, EventArgs e)
        {
            initControl();
        }

        /**
         * 主窗口关闭
         */
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        /****************************************************************************
         **************************** 自定义方法 ************************************ 
         ****************************************************************************/

        /**
         *  初始化控件
         */
        public void initControl()
        {
            // 样式初始化
            statusStripMain.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            status_detail.Alignment = ToolStripItemAlignment.Right;

            // 默认左边
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            alignLeft.Checked = true;

            // 文件格式
            this.richTextBox1.Rtf = @"{\rtf1\ansi\ansicpg936\deff0\deflang1033\deflangfe2052"
            + @"{\fonttbl{\f0\fmodern\fprq6\fcharset134   \ 'cb\ 'ce\ 'cc\ 'e5;}{\f1\fnil\fcharset134   \ 'cb\ 'ce\ 'cc\ 'e5;}}"
            + @"{\colortbl;\red0\green0\blue0;}"
            + @"\viewkind4\uc1\pard\cf1\lang2052\f0\cf1  }";

            // 字体样式
            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            foreach (System.Drawing.FontFamily family in fonts.Families)
            {
                fontType.Items.Add(family.Name);
            }
            // 字体大小
            string[] sizes = Enum.GetNames(typeof(MyFontSize));
            foreach (string size in sizes)
            {
                fontSize.Items.Add(size);
            }
            fontType.Text = "宋体";
            fontSize.Text = "五号";
            richTextBox1.Font = new Font(new FontFamily(fontType.Text), FontSizeUtil.getSize(fontSize.Text));
        }

        /****************************************************************************
         **************************** 工具栏菜单 ************************************ 
         ****************************************************************************/

        /**
         *  工具栏菜单-打开文件
         */
        private void open_Click(object sender, EventArgs e)
        {
            // 创建打开文件对话框
            openFileDialog1 = new OpenFileDialog();
            // 对话框的初始目录
            openFileDialog1.InitialDirectory = "c:\\";
            // 对话框中显示的文件筛选器
            openFileDialog1.Filter = "rtf 文件(*.rtf)|*.rtf|txt 文件(*.txt)|*.txt|word 文件(*.doc)|*.doc|所有文件|*.*";
            // 控制对话框在关闭之前是否恢复当前目录
            openFileDialog1.RestoreDirectory = true;
            // 是否自动添加默认扩展名
            openFileDialog1.AddExtension = true;
            // 默认扩展名
            openFileDialog1.DefaultExt = ".txt";
            // 在对话框返回之前，检查指定路径是否存在
            openFileDialog1.CheckPathExists = true;
            // 对话框标题栏
            openFileDialog1.Title = "打开文件";
            // 在对话框中选择的文件筛选器的索引，如果选第一项就设为1
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // 点击对话框打开按钮事件
                g_filePath = openFileDialog1.FileName;
                if (StringUtil.isNotEmpty(g_filePath))
                {
                    // 清空当前控件后加载文件文件
                    //richTextBox1.Text = "";
                    try
                    {
                        // 加载文件内容
                        if ((System.IO.Path.GetExtension(g_filePath)).ToLower() == ".txt")
                        {
                            // 加载文本格式
                            richTextBox1.LoadFile(g_filePath, RichTextBoxStreamType.PlainText);
                        }
                        else
                        {
                            // 同时加载文本样式
                            richTextBox1.LoadFile(g_filePath);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                Console.WriteLine("【Editor】打开文件：" + g_filePath);
            }
            else
            {
                Console.WriteLine("【Editor】点击取消按钮");
            }
            fontType.Text = richTextBox1.Font.Name;
            fontSize.Text = richTextBox1.Font.Size.ToString();
        }

        /**
         * 工具栏菜单 - 新建
         */
        private void create_Click(object sender, EventArgs e)
        {
            // 清空文件路径
            g_filePath = "";
            // 清空控件
            richTextBox1.Text = "";
            fontType.Text = richTextBox1.Font.Name;
            fontSize.Text = richTextBox1.Font.Size.ToString();
        }

        /**
         * 工具栏菜单 - 保存
         */
        private void save_Click(object sender, EventArgs e)
        {
            // 判断是否为打开文件
            // 若g_filePath为空则调用保存文件对话框
            if (StringUtil.isEmpty(g_filePath))
            {
                saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "rtf 文件(*.rtf)|*.rtf|txt 文件(*.txt)|*.txt|word 文件(*.doc)|*.doc|所有文件|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    g_filePath = saveFileDialog1.FileName; 
                }
                if (StringUtil.isEmpty(g_filePath))
                {
                    // 没有创建文件,不做任何操作
                    return;
                }
            }
            try
            {
                // 保存文件
                if ((System.IO.Path.GetExtension(g_filePath)).ToLower() == ".txt")
                {
                    // 文本格式保存到txt文件
                    richTextBox1.SaveFile(g_filePath, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    // 同时保存文本样式
                    richTextBox1.SaveFile(g_filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**
         * 编辑文本事件
         */
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // 获取当前行第一个字符的索引
            int index = richTextBox1.GetFirstCharIndexOfCurrentLine();
            // 获取当前行号
            int row = richTextBox1.GetLineFromCharIndex(index) + 1;
            // 获取列号
            int col = richTextBox1.SelectionStart - index + 1;
            // 设置状态栏行列
            status_detail.Text = "第" + row + "行" + "，第" + col + "列";
            g_isChanged = true;
        }

        /**
         * 选中事件，根据选中内容修改工具栏状态
         */
        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            if (null == font)
            {
                return;
            }
            HorizontalAlignment alignment = richTextBox1.SelectionAlignment;
            // 设置字体状态
            bold.Checked = font.Bold ? true : false;
            italic.Checked = font.Italic ? true : false;
            underline.Checked = font.Underline ? true : false;
            deleteline.Checked = font.Strikeout ? true : false;
            // 设置对齐状态
            switch (alignment)
            {
                case HorizontalAlignment.Left:
                    alignLeft.Checked = true;
                    alignCenter.Checked = false;
                    alignRight.Checked = false;
                    break;
                case HorizontalAlignment.Center:
                    alignLeft.Checked = false;
                    alignCenter.Checked = true;
                    alignRight.Checked = false;
                    break;
                case HorizontalAlignment.Right:
                    alignLeft.Checked = false;
                    alignCenter.Checked = false;
                    alignRight.Checked = true;
                    break;
                default:
                    break;
            }
            // 设置字体
            fontType.Text = font.Name;
            fontSize.Text = FontSizeUtil.getName(font.Size.ToString());
            // 设置字体背景色
            if (null != richTextBox1.SelectionBackColor)
            {
                colorBackground.BackColor = richTextBox1.SelectionBackColor;
            }
            // 设置字体颜色
            if (null != richTextBox1.SelectionColor)
            {
                colorFont.BackColor = richTextBox1.SelectionColor;
            }
        }

        /**
         * 工具栏菜单 - 撤销
         */
        private void undo_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        /**
         * 工具栏菜单 - 重做
         */
        private void redo_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        /**
         * 工具栏菜单 - 剪切
         */
        private void cut_Click(object sender, EventArgs e)
        {
            // 获取选中的内容
            string selectionContent = richTextBox1.SelectedText;
            if (StringUtil.isEmpty(selectionContent))
            {
                // 没有选中文本
                return;
            }
            // 把选中的内容存入粘贴板
            Clipboard.SetText(selectionContent);
            // 删除选中的内容
            richTextBox1.SelectedText = "";
        }

        /**
         * 工具栏菜单 - 复制
         */
        private void copy_Click(object sender, EventArgs e)
        {
            // 获取选中的内容
            string selectionContent = richTextBox1.SelectedText;
            if (StringUtil.isNotEmpty(selectionContent))
            {
                // 把选中的内容存入粘贴板
                Clipboard.SetText(selectionContent);
            }
        }

        /**
         * 工具栏菜单 - 粘贴
         */
        private void paste_Click(object sender, EventArgs e)
        {
            string copyContent = Clipboard.GetText();
            if (StringUtil.isEmpty(copyContent))
            {
                // 粘贴板无内容
                return;
            }
            richTextBox1.SelectedText = copyContent;
        }

        /**
         * 工具栏菜单 - 字体加粗
         */
        private void bold_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            if (null == font)
            {
                return;
            }
            bold.Checked = bold.Checked ^ true;
            richTextBox1.SelectionFont = new Font(font, font.Style ^ FontStyle.Bold);
        }

        /**
         * 工具栏菜单 - 字体倾斜
         */
        private void italic_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            if (null == font)
            {
                return;
            }
            italic.Checked = italic.Checked ^ true;
            richTextBox1.SelectionFont = new Font(font, font.Style ^ FontStyle.Italic);
        }

        /**
         * 工具栏菜单 - 下划线
         */
        private void underline_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            if (null == font)
            {
                return;
            }
            underline.Checked = underline.Checked ^ true;
            richTextBox1.SelectionFont = new Font(font, font.Style ^ FontStyle.Underline);
        }
        /**
         * 工具栏菜单 - 删除线
         */
        private void deleteline_Click(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            if (null == font)
            {
                return;
            }
            deleteline.Checked = deleteline.Checked ^ true;
            richTextBox1.SelectionFont = new Font(font, font.Style ^ FontStyle.Strikeout);
        }
        /**
         * 工具栏菜单 - 左对齐
         */
        private void alignLeft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            alignLeft.Checked = true;
            alignCenter.Checked = false;
            alignRight.Checked = false;
        }
        /**
         * 工具栏菜单 - 居中对齐
         */
        private void alignCenter_Click(object sender, EventArgs e)
        {
            alignCenter.Checked = alignCenter.Checked ^ true;
            richTextBox1.SelectionAlignment =  HorizontalAlignment.Center;
            if (alignCenter.Checked)
            {
                alignLeft.Checked = false;
                alignRight.Checked = false;
            }
            else
            {
                alignLeft.Checked = true;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
        }
        /**
         * 工具栏菜单 - 右对齐
         */
        private void alignRight_Click(object sender, EventArgs e)
        {
            alignRight.Checked = alignRight.Checked ^ true;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            if (alignRight.Checked)
            {
                alignLeft.Checked = false;
                alignCenter.Checked = false;
            }
            else
            {
                alignLeft.Checked = true;
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        /**
         * 工具栏菜单 - 字体颜色
         */
        private void fontColor_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                colorFont.BackColor = colorDialog1.Color;
                fontColor.BackColor = colorDialog1.Color;
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        /**
         * 工具栏菜单 - 字体底纹颜色
         */
        private void fontBackgroundColor_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                colorBackground.BackColor = colorDialog1.Color;
                fontBackgroundColor.BackColor = colorDialog1.Color;
                richTextBox1.SelectionBackColor = colorDialog1.Color;
            }
        }

        /**
         *  工具栏菜单 - 切换字体大小
         */
        private void fontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = fontType.Text;
            string fontSizeText = fontSize.Text;
            Font selectionFont = richTextBox1.SelectionFont;
            if (null != selectionFont)
            {
                richTextBox1.SelectionFont = new Font(StringUtil.isNotEmpty(fontName) ? fontName : selectionFont.Name, 
                    StringUtil.isNotEmpty(fontSizeText) ? FontSizeUtil.getSize(fontSizeText) : selectionFont.Size);
            }
            else
            {
                richTextBox1.Font = new Font(StringUtil.isNotEmpty(fontName) ? fontName : richTextBox1.Font.Name, 
                    StringUtil.isNotEmpty(fontSizeText) ? FontSizeUtil.getSize(fontSizeText) : richTextBox1.Font.Size);
            }
        }

        /**
         * 工具栏菜单 - 切换字体样式
         */

        private void fontType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontName = fontType.Text;
            string fontSizeText = fontSize.Text;
            Font selectionFont = richTextBox1.SelectionFont;
            if (null != selectionFont)
            {
                richTextBox1.SelectionFont = new Font(StringUtil.isNotEmpty(fontName) ? fontName : selectionFont.Name,
                    StringUtil.isNotEmpty(fontSizeText) ? FontSizeUtil.getSize(fontSizeText) : selectionFont.Size);
            }
            else
            {
                richTextBox1.Font = new Font(StringUtil.isNotEmpty(fontName) ? fontName : richTextBox1.Font.Name,
                    StringUtil.isNotEmpty(fontSizeText) ? FontSizeUtil.getSize(fontSizeText) : richTextBox1.Font.Size);
            }
        }

        /**
         * 菜单栏
         */
        private void menu_file_create_Click(object sender, EventArgs e)
        {
            create.PerformClick();
        }

        private void menu_file_open_Click(object sender, EventArgs e)
        {
            open.PerformClick();
        }

        private void menu_file_save_Click(object sender, EventArgs e)
        {
            save.PerformClick();
        }

        private void menu_file_save_as_Click(object sender, EventArgs e)
        {
            // 另存为
            String filePath = "";
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "rtf 文件(*.rtf)|*.rtf|txt 文件(*.txt)|*.txt|word 文件(*.doc)|*.doc|所有文件|*.*";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
            }
            if (StringUtil.isEmpty(filePath))
            {
                // 没有创建文件,不做任何操作
                return;
            }
            try
            {
                // 保存文件
                if ((System.IO.Path.GetExtension(filePath)).ToLower() == ".txt")
                {
                    // 文本格式保存到txt文件
                    richTextBox1.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                }
                else
                {
                    // 同时保存文本样式
                    richTextBox1.SaveFile(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menu_file_exit_Click(object sender, EventArgs e)
        {
            // 判断是否需要保存
            if (g_isChanged)
            {
                if (MessageBox.Show("是否保存文件", "退出", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    save.PerformClick();
                    MessageBox.Show("保存成功");
                }
            }
            this.Close();
        }

        private void menu_edit_undo_Click(object sender, EventArgs e)
        {
            undo.PerformClick();
        }

        private void menu_edit_redo_Click(object sender, EventArgs e)
        {
            redo.PerformClick();
        }

        private void menu_edit_cut_Click(object sender, EventArgs e)
        {
            cut.PerformClick();
        }

        private void menu_edit_copy_Click(object sender, EventArgs e)
        {
            copy.PerformClick();
        }

        private void menu_edit_paste_Click(object sender, EventArgs e)
        {
            paste.PerformClick();
        }

        /**
         *  查找
         */
        private void menu_edit_search_Click(object sender, EventArgs e)
        {
            if (-1 != richTextBox1.SelectionStart)
            {
                g_indexFind = richTextBox1.SelectionStart;
            }
            FindWnd findWnd = new FindWnd();
            findWnd.OnGetFindStrEvent += this.GetFindStr;
            findWnd.Show();
        }

        /**
         * 替换
         */
        private void menu_edit_replace_Click(object sender, EventArgs e)
        {
            if (-1 != richTextBox1.SelectionStart)
            {
                g_indexFind = richTextBox1.SelectionStart;
            }
            ReplaceWnd replaceWnd = new ReplaceWnd();
            replaceWnd.OnGetFindStrEvent += this.GetFindStr;
            replaceWnd.OnGetReplaceStrEvent += this.GetReplaceStr;
            replaceWnd.OnGetReplaceAllStrEvent += this.GetReplaceAllStr;
            replaceWnd.Show();

        }
        /**
         *  查找委托方法
         */
        private void GetFindStr(string findStr, bool isMatchCase, bool isMatchWord, bool isCycle)
        {
            if (StringUtil.isEmpty(findStr))
            {
                return;
            }
            RichTextBoxFinds finds = RichTextBoxFinds.None;
            if (isMatchCase)
            {
                finds = finds | RichTextBoxFinds.MatchCase;
            }
            if (isMatchWord)
            {
                finds = finds | RichTextBoxFinds.WholeWord;
            }
            if (!isCycle)
            {
                int index = richTextBox1.Text.IndexOf(findStr, g_indexFind);
                if (-1 == index)
                {
                    MessageBox.Show("查找无结果");
                    return;
                }
            }
            g_indexFind = richTextBox1.Find(findStr, g_indexFind, finds);
            if (-1 == g_indexFind)
            {
                if (isCycle)
                {
                    g_indexFind = 0;
                }
                else
                {
                    MessageBox.Show("查找无结果");
                    return;
                }
            }
            g_indexFind = g_indexFind + findStr.Length;
            this.Focus();
        }
        private void GetReplaceStr(string findStr, string replaceStr, bool isMatchCase, bool isMatchWord, bool isCycle)
        {
            if (StringUtil.isEmpty(richTextBox1.SelectedText))
            {
                GetFindStr(findStr, isMatchCase, isMatchWord, isCycle);
            }
            if (StringUtil.isNotEmpty(richTextBox1.SelectedText))
            {
                richTextBox1.SelectedText = replaceStr;
            }
            this.Focus();
        }
        private void GetReplaceAllStr(string findStr, string replaceStr, bool isMatchCase, bool isMatchWord, bool isCycle)
        {
            int index = 0;
            while((index = richTextBox1.Find(findStr)) != -1)
            {
                richTextBox1.SelectedText = replaceStr;
            }
            this.Focus();
        }


        private void menu_edit_check_all_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void format_align_left_Click(object sender, EventArgs e)
        {
            alignLeft.PerformClick();
        }

        private void format_align_right_Click(object sender, EventArgs e)
        {
            alignRight.PerformClick();
        }

        private void format_align_center_Click(object sender, EventArgs e)
        {
            alignCenter.PerformClick();
        }

        private void menu_format_bold_Click(object sender, EventArgs e)
        {
            bold.PerformClick();
        }

        private void menu_format_italic_Click(object sender, EventArgs e)
        {
            italic.PerformClick();
        }

        private void menu_format_underline_Click(object sender, EventArgs e)
        {
            underline.PerformClick();
        }

        private void menu_format_deleteline_Click(object sender, EventArgs e)
        {
            deleteline.PerformClick();
        }

        private void menu_format_color_Click(object sender, EventArgs e)
        {
            fontColor.PerformClick();
        }

        private void menu_format_background_Click(object sender, EventArgs e)
        {
            fontBackgroundColor.PerformClick();
        }

        private void menu_help_about_Click(object sender, EventArgs e)
        {
            // about
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            g_indexFind = richTextBox1.SelectionStart;
        }

    }
}
