using System;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Data;

namespace ToEstool.UI
{
    public partial class UItolerance : Form
    {
        ways.wayspy py_way = new ways.wayspy();
        ways.waysfile file_way = new ways.waysfile();
        ways.wayssql sqlite_way = new ways.wayssql();
        ways.waydata data_way = new ways.waydata();
        public UItolerance()
        {
            InitializeComponent();
        }
        //窗口重载
        public UItolerance(string datapath)
        {
            InitializeComponent();
            computer_gif(false);
            sys_show(false);
            textBox_path.Text = datapath;
            textBox_k0.Text = Parameter.igg3_k0.ToString();
            textBox_k1.Text = Parameter.igg3_k1.ToString();
            textBox_dtopmax.Text = Parameter.igg3_max1.ToString();
            textBox_ee.Text = Parameter.igg3_max2.ToString();
        }
        //计算GIF隐藏
        private void computer_gif(bool visble)
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
        //清除显示
        private void dll_data()
        {
            dataGridView_resultX.DataSource =null;
            dataGridView_resultV.DataSource =null;
        }
        //修改表头
        private void setcolHeader()
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
        private void show_sysargument(bool _sys,DataTable datatable_)
        {
            sys_show(_sys);
            if (_sys)
            {
                textBox_sys.Text = data_way.sys_scalingcorrection(datatable_);
            }
        }

        //启动线程计算平差
        private async void btnStartCalculation(object sender, EventArgs e,double k0, double k1, double max1, double max2,bool sys_bool)
        {
            DataTable xx_datatable = null;
            DataTable x_datatable = null;
            DataTable v_datatable = null;
            // 显示 PictureBox
            computer_gif(true);
            // 在后台线程执行计算操作
            await Task.Run(() =>
            {
                //Thread.Sleep(5000);
                int type = 2;
                string[] pydata = py_way.Get_Itolerance(textBox_path.Text, sys_bool, type, k0, k1, max1 * Math.Pow(10,max2));
                string[] outdata = py_way.Py_process(Parameter.py_PythonexePath, pydata[0], pydata[1]);
                if (outdata[1]=="" & outdata[0] != "")
                {
                    //x_datatable = sqlite_way.Get_sqldata(constants.query_corunknowns_igg3, Parameter.dbFilePath);
                    //v_datatable = sqlite_way.Get_sqldata(constants.query_corestimates_igg3, Parameter.dbFilePath);
                    //四舍五入Parameter.round_num位数
                    x_datatable = data_way.RoundDoubleValuesInDataTable(sqlite_way.Get_sqldata(constants.query_corunknowns_igg3, Parameter.dbFilePath), Parameter.round_num);
                    v_datatable = data_way.RoundDoubleValuesInDataTable(sqlite_way.Get_sqldata(constants.query_corestimates_igg3, Parameter.dbFilePath), Parameter.round_num);
                    xx_datatable= data_way.RoundDoubleValuesInDataTable(sqlite_way.Get_sqldata(constants.query_x_igg3, Parameter.dbFilePath), Parameter.round_num);
                }
                Thread.Sleep(100);
            });
            // 计算结束后隐藏 PictureBox
            if (v_datatable != null & x_datatable != null)
            {
                show_sysargument(sys_bool, xx_datatable);
                //dataGridView_resultX.DataSource = xx_datatable;
                dataGridView_resultX.DataSource = x_datatable;
                dataGridView_resultV.DataSource = v_datatable;
                //setcolHeader();
            }
            else
            {
                dll_data();
                MessageBox.Show(constants.error_compute);
            }
            computer_gif(false);
        }

        //计算button
        private void button_compute_Click(object sender, EventArgs e)
        {
            bool sys_bool = checkBox1.Checked;
            if (textBox_path.Text != "")
            {                
                btnStartCalculation(sender, e, Parameter.igg3_k0, Parameter.igg3_k1, Parameter.igg3_max1, Parameter.igg3_max2, sys_bool);
            }
            else
            {
                MessageBox.Show(constants.noselect_file);
            }
        }
        //textbox内容发生变化
        private void textBox_k0_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox_k0.Text == "")
                {
                    Parameter.igg3_k0 = 0;
                }
                else
                {
                    double m = Convert.ToDouble(textBox_k0.Text);
                    Parameter.igg3_k0 = m;
                }

            }
            catch (Exception)
            {

                MessageBox.Show(constants.error_num);
                textBox_k0.Text = Parameter.igg3_k0.ToString();
            }
            
        }
        //textbox内容发生变化
        private void textBox_k1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox_k1.Text=="")
                {
                    Parameter.igg3_k1 = 0;
                }
                else
                {
                    double m = Convert.ToDouble(textBox_k1.Text);
                    Parameter.igg3_k1 = m;
                }


            }
            catch (Exception)
            {

                MessageBox.Show(constants.error_num);
                textBox_k1.Text = Parameter.igg3_k1.ToString();
            }
        }
        //textbox内容发生变化
        private void textBox_dtopmax_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox_dtopmax.Text == "")
                {
                    Parameter.igg3_max1 = 0;
                }
                else
                {
                    double m = Convert.ToDouble(textBox_dtopmax.Text);
                    Parameter.igg3_max1 = m;
                }
            }
            catch (Exception)
            {

                MessageBox.Show(constants.error_num);
                textBox_dtopmax.Text = Parameter.igg3_max1.ToString();
            }
        }
        //textbox内容发生变化
        private void textBox_ee_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox_ee.Text == "" | textBox_ee.Text == "-" | textBox_ee.Text == "+")
                {
                    Parameter.igg3_max2 = 0;
                }
                else
                {
                    double m = Convert.ToDouble(textBox_ee.Text);
                    Parameter.igg3_max2= m;
                }
            }
            catch (Exception)
            {

                MessageBox.Show(constants.error_num);
                textBox_ee.Text = Parameter.igg3_max2.ToString();
            }
        }
    }
}