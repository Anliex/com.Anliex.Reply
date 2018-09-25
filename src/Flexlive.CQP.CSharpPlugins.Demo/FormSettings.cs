using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Flexlive.CQP.Framework;
using System.Data.SqlClient;

namespace Flexlive.CQP.CSharpPlugins.Demo
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();

            //加载标题。
            this.Text = System.Reflection.Assembly.GetAssembly(this.GetType()).GetName().Name + " 参数设置";
        }

        /// <summary>
        /// 退出按钮事件处理方法。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 保存按钮事件处理方法。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //参数保存处理代码。
            MyPlugin.Chance = Convert.ToInt32(nud.Value);
            MyPlugin.Time = Convert.ToInt32(nud2.Value);
            MyPlugin._Time = checkBox1.Checked;

            this.btnExit_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SQL conn = new SQL();
            //conn.Open();
            //string sql = "create table minzu(xuhao int auto_increment primary key,  minzu varchar(50) not null);";
            //conn.DoCommand(sql);
            //conn.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            nud.Value = trackBar1.Value;
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = Convert.ToInt32(nud.Value);
        }

        private void nud2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            nud.Value = MyPlugin.Chance;
            nud2.Value = MyPlugin.Time;
            checkBox1.Checked = MyPlugin._Time;
            label2.Text = "触发CD剩余" + MyPlugin.tempTime + "秒。";
        }
    }
}
