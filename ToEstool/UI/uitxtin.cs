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
    public partial class uitxtin : Form
    {
        public uitxtin()
        {
            InitializeComponent();
            //设置选择数据
            comboBox_splitstr.Items.AddRange(constants.splitstr);
            comboBox_splitstr.SelectedIndex = 0;
            Parameter.splitstr = "**";
        }

        private void button_true_Click(object sender, EventArgs e)
        {
            //获取用户选择
            string selectedOption = comboBox_splitstr.SelectedItem.ToString();
            Parameter.splitstr = constants.splitstr_Dict[selectedOption];
            Close();
        }
    }
}
