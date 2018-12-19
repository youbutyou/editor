using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Editor.util;
namespace Editor
{
    public partial class FindAndReplaceWnd : Form
    {
        // 定义委托 传递 参数给父窗口
        // 查找
        public delegate void GetFindStr(string findStr, bool isMatchCase, bool isMatchWord, bool isCycle);
        public event GetFindStr OnGetFindStrEvent;
        // 替换单个
        public delegate void GetReplaceStr(string findStr, string replaceStr, bool isMatchCase, bool isMatchWord, bool isCycle);
        public event GetReplaceStr OnGetReplaceStrEvent;
        // 替换全部
        public delegate void GetReplaceAllStr(string findStr, string replaceStr, bool isMatchCase, bool isMatchWord, bool isCycle);
        public event GetReplaceStr OnGetReplaceAllStrEvent;

        public FindAndReplaceWnd()
        {
            InitializeComponent();
        }

        /**
         * 查找页面点击查找按钮事件
         */
        private void Find_btFind_Click(object sender, EventArgs e)
        {
            if (StringUtil.isEmpty(Find_tbFind.Text))
            {
                MessageBox.Show("请输入要查找的内容");
                return;
            }
            if (null != OnGetFindStrEvent)
            {
                // 执行父窗口查找委托事件
                OnGetFindStrEvent(Find_tbFind.Text, Find_cbMatchCase.Checked, Find_cbMatchWord.Checked, Find_cbCycle.Checked);
            }
        }

        /**
         * 替换页面点击查找按钮事件
         */
        private void Replace_btFind_Click(object sender, EventArgs e)
        {
            if (StringUtil.isEmpty(Replace_tbFind.Text))
            {
                MessageBox.Show("请输入要查找的内容");
                return;
            }
            if (null != OnGetFindStrEvent)
            {
                // 执行父窗口查找委托事件
                OnGetFindStrEvent(Replace_tbFind.Text, Replace_cbMatchCase.Checked, Replace_cbMatchWord.Checked, Replace_cbCycle.Checked);
            }
        }

        /**
         * 替换页面点击替换按钮事件
         */
        private void Replace_btReplace_Click(object sender, EventArgs e)
        {
            if (StringUtil.isEmpty(Replace_tbFind.Text))
            {
                MessageBox.Show("请输入要查找的内容");
                return;
            }
            if (StringUtil.isEmpty(Replace_tbReplace.Text))
            {
                MessageBox.Show("请输入要替换的内容");
                return;
            }
            if (Replace_tbFind.Text.Equals(Replace_tbReplace.Text))
            {
                MessageBox.Show("替换内容与查找内容相同，请检查");
                return;
            }
            if (null != OnGetReplaceStrEvent)
            {
                // 执行父窗口替换委托事件
                OnGetReplaceStrEvent(Replace_tbFind.Text, Replace_tbReplace.Text, Replace_cbMatchCase.Checked, Replace_cbMatchWord.Checked, Replace_cbCycle.Checked);
            }
        }

        /**
         * 替换页面点击替换全部按钮事件
         */
        private void Replace_btReplaceAll_Click(object sender, EventArgs e)
        {
            if (StringUtil.isEmpty(Replace_tbFind.Text))
            {
                MessageBox.Show("请输入要查找的内容");
                return;
            }
            if (StringUtil.isEmpty(Replace_tbReplace.Text))
            {
                MessageBox.Show("请输入要替换的内容");
                return;
            }
            if (Replace_tbFind.Text.Equals(Replace_tbReplace.Text))
            {
                MessageBox.Show("替换内容与查找内容相同，请检查");
                return;
            }
            if (null != OnGetReplaceAllStrEvent)
            {
                // 执行父窗口替换全部委托事件
                OnGetReplaceAllStrEvent(Replace_tbFind.Text, Replace_tbReplace.Text, Replace_cbMatchCase.Checked, Replace_cbMatchWord.Checked, Replace_cbCycle.Checked);
            }
        }
    }
}
