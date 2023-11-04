using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToEstool.UI
{
    public partial class UIglobalparameter : Form
    {
        public UIglobalparameter()
        {
            InitializeComponent();
        }
        public UIglobalparameter(int round_num)
        {
            InitializeComponent();
            textBox_roundnum.Text = Parameter.round_num.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(textBox_roundnum.Text);
            Parameter.round_num = m;
            // 关闭窗口
            this.Close();
        }

        private void textBox_roundnum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox_roundnum.Text == "")
                {
                    Parameter.round_num = 0;
                }
                else
                {
                    int m = Convert.ToInt32(textBox_roundnum.Text);
                    Parameter.round_num = m;
                }

            }
            catch (Exception)
            {

                MessageBox.Show(constants.error_num);
                textBox_roundnum.Text = Parameter.round_num.ToString();
            }
        }
    }
}
