using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chanjet.T.PU.ReflectorCai;

namespace FlectorAndAbstractFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private System.Reflection.Assembly assembly = null;

        /// <summary>
        /// 利用反射取得程序集dll里面的Sportshop的子类，
        /// 加入到combox里面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();

            //文本文件(*.txt)|*.txt|所有文件(*.*)||*.*
            of.Filter = "exe文件|*.exe|dll文件|*.dll";

            //对话框的初始目录
            of.InitialDirectory = Application.StartupPath;

            //是否成功打开
            if(of.ShowDialog() == DialogResult.OK)
            {
                this.assembly = System.Reflection.Assembly.LoadFile(of.FileName);

                this.comboBox1.Items.Clear();

                //反射集里面的类型
                foreach(var item in this.assembly.GetTypes())
                {
                    if (item.IsSubclassOf(typeof(Chanjet.T.PU.ReflectorCai.Sportshop)))
                    {
                        this.comboBox1.Items.Add(item);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chanjet.T.PU.ReflectorCai.Shoes s = null;
            Chanjet.T.PU.ReflectorCai.Hat h = null;

            Chanjet.T.PU.ReflectorCai.Sportshop shop = null;

            String typeName = ((Type)this.comboBox1.SelectedItem).FullName; 

            //利用发射创建实例
            shop = (Chanjet.T.PU.ReflectorCai.Sportshop)this.assembly.CreateInstance(typeName);

            s = shop.CreateShoes();
            h = shop.CreateHat();

            MessageBox.Show(string.Format("帽子：{0} 鞋子：{1}", h.ToString(), s.ToString()));
        }
    }
}
