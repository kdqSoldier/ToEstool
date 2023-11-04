using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace ToEstool.UI
{
    public partial class UIIndirectad : Form
    {
        ways.wayspy py_way = new ways.wayspy();
        ways.waysfile file_way = new ways.waysfile();
        ways.wayssql sqlite_way = new ways.wayssql();
        ways.waydata data_way = new ways.waydata();

        public UIIndirectad()
        {
            InitializeComponent();

        }
        public UIIndirectad(string datapath)
        {
            InitializeComponent();            
            computer_gif(false);
            sys_show(false);
            textBox_path.Text = datapath;
        }
        public void computer_gif(bool visble)
        {
            this.pictureBox1.Visible = visble;
            this.label4.Visible = visble;
        }
        //系统误差参数框隐藏
        private void sys_show(bool visble)
        {
            this.textBox_sys.Visible = visble;
            this.label_sys.Visible = visble;
        }
        public void setcolHeader()
        {
            for (int i = 0; i < constants.header_X.Length; i++)
            {
                dataGridView_resultX.Columns[i].HeaderText = constants.header_X[i];
            }
            for (int i = 0; i < constants.header_V.Length; i++)
            {
                dataGridView_resultV.Columns[i].HeaderText = constants.header_V[i];
            }

        }

        //输出系统误差参数
        private void show_sysargument(bool _sys, DataTable datatable_)
        {
            sys_show(_sys);
            if (_sys)
            {
                textBox_sys.Text = data_way.sys_scalingcorrection(datatable_);
            }
        }

        //开始计算
        private void button_compute_Click(object sender, EventArgs e)
        {
            bool sys_bool = checkBox1.Checked;
            if (textBox_path.Text!="")
            {
                btnStartCalculation(sender, e, sys_bool);
            }
            else
            {
                MessageBox.Show(constants.noselect_file);
            }
        }
        //启动线程计算平差
        private async void btnStartCalculation(object sender, EventArgs e, bool sys_bool)
        {
            DataTable x_datatable=null;
            DataTable xx_datatable = null;
            DataTable v_datatable =null;            
            // 显示 PictureBox
            computer_gif(true);
            // 在后台线程执行计算操作
            await Task.Run(() =>
            {
                //Thread.Sleep(5000);
                string[] pydata = py_way.Get_indirectadjustment(textBox_path.Text, sys_bool);
                string[] outdata = py_way.Py_process(Parameter.py_PythonexePath, pydata[0], pydata[1]);
                if (outdata[1] == "" & outdata[0] != "")
                {
                    //x_datatable = sqlite_way.Get_sqldata(constants.query_corunknowns_old, Parameter.dbFilePath);
                    //v_datatable = sqlite_way.Get_sqldata(constants.query_corestimates_old, Parameter.dbFilePath);
                    //四舍五入Parameter.round_num位数
                    x_datatable=data_way.RoundDoubleValuesInDataTable(sqlite_way.Get_sqldata(constants.query_corunknowns_old, Parameter.dbFilePath), Parameter.round_num);
                    v_datatable=data_way.RoundDoubleValuesInDataTable(sqlite_way.Get_sqldata(constants.query_corestimates_old, Parameter.dbFilePath), Parameter.round_num);
                    xx_datatable = data_way.RoundDoubleValuesInDataTable(sqlite_way.Get_sqldata(constants.query_x_old, Parameter.dbFilePath), Parameter.round_num);
                    //保存到txt
                    file_way.ExportDataTableToTxt(v_datatable);
                }
                Thread.Sleep(100);
            });
            // 计算结束后隐藏 PictureBox
            if (v_datatable != null & x_datatable != null)
            {
                show_sysargument(sys_bool, xx_datatable);
                dataGridView_resultX.DataSource = x_datatable;
                dataGridView_resultV.DataSource = v_datatable;
                setcolHeader();
            }
            computer_gif(false);
        }
    }
}
