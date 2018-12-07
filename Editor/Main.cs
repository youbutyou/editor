using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class Main : Form
    {
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
        }
    }
}
