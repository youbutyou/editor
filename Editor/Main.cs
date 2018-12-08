using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Editor.util;

namespace Editor
{
    public partial class Main : Form
    {
        // 新建或打开的文件路径
        private string g_filePath = "";
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
            statusStripMain.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            status_detail.Alignment = ToolStripItemAlignment.Right;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            alignLeft.Checked = true;
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
            openFileDialog1.Filter = "txt 文件(*.txt)|*.txt|rtf 文件(*.rtf)|*.rtf|所有文件|*.*";
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
                    StreamReader streamReader = new StreamReader(g_filePath, Encoding.UTF8);
                    string text = "";
                    // 若读取的文本不为空，则循环读取
                    while ((text = streamReader.ReadLine()) != null)
                    {
                        richTextBox1.AppendText(text);
                    }
                    // 写文件流 用完后必须关闭
                    streamReader.Close();
                }
                Console.WriteLine("【Editor】打开文件：" + g_filePath);
            }
            else
            {
                Console.WriteLine("【Editor】点击取消按钮");
            }
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
                saveFileDialog1.Filter = "txt 文件(*.txt)|*.txt|rtf 文件(*.rtf)|*.rtf|所有文件|*.*";
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    g_filePath = saveFileDialog1.FileName; 
                }
                if (StringUtil.isEmpty(g_filePath))
                {
                    // 没有创建文件
                    return;
                }
            }
            StreamWriter streamWriter = new StreamWriter(g_filePath);
            // 获取编辑文本
            String content = richTextBox1.Text;
            // 写入文本
            streamWriter.Write(content);
            streamWriter.Flush();
            // 写文件流 用完后必须关闭
            streamWriter.Close();
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
        }

        /**
         * 选中事件，根据选中内容修改工具栏状态
         */
        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
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
            bold.Checked = bold.Checked ^ true;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
        }

        /**
         * 工具栏菜单 - 字体倾斜
         */
        private void italic_Click(object sender, EventArgs e)
        {
            italic.Checked = italic.Checked ^ true;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
        }

        /**
         * 工具栏菜单 - 下划线
         */
        private void underline_Click(object sender, EventArgs e)
        {
            underline.Checked = underline.Checked ^ true;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
        }
        /**
         * 工具栏菜单 - 删除线
         */
        private void deleteline_Click(object sender, EventArgs e)
        {
            deleteline.Checked = deleteline.Checked ^ true;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Strikeout);
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

    }
}
