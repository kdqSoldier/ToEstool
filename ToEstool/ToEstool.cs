using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToEstool
{
    public partial class ToEstool : Form
    {
        UI.uitxtin choicesplitstr = new UI.uitxtin();
        UI.UIIndirectad indirectad = new UI.UIIndirectad();
        ways.wayspy py_way = new ways.wayspy();
        ways.waysfile file_way = new ways.waysfile();
        ways.wayssql sqlite_way = new ways.wayssql();
        ways.waydata data_way = new ways.waydata();

        public ToEstool()
        {
            InitializeComponent();
            Default_textvalue();
        }
        public void setcolHeader()
        {
            for (int i = 0; i < constants.header_elevationdata.Length; i++)
            {
                dataGridView_observation.Columns[i].HeaderText = constants.header_elevationdata[i];
            }
            for (int i = 0; i < constants.header_knowpoint.Length; i++)
            {
                dataGridView_knowpoint.Columns[i].HeaderText = constants.header_knowpoint[i];
                dataGridView_estimated.Columns[i].HeaderText = constants.header_estimated[i];
            }

        }
        /// <summary>
        /// 获取文件路径，完成数据库写入
        /// </summary>
        /// <param name="typefiledata"></param>
        private void Inputdatatosql(string[] typefiledata)
        {
            string datapath = file_way.outpath(typefiledata);
            if (datapath != string.Empty)
            {
                string[] pydata = py_way.Get_pyreadsysdata(datapath);
                string[] outdata = py_way.Py_process(Parameter.py_PythonexePath, pydata[0], pydata[1]);
                if (outdata[1] == string.Empty)
                {
                    textBox_path.Text = constants.leaddsql_successful + datapath;
                    Parameter.datapath = datapath;
                    Parameter._bool_readfile = true;
                }
                else
                {
                    Parameter._bool_readfile = false;
                    Default_textvalue();
                    MessageBox.Show(constants.leaddsql_lose);
                }
            }
            else
            {
                Parameter._bool_readfile = false;
            }
        }
        /// <summary>
        /// 清除dataGridView数据
        /// </summary>
        private void Del_dataGridView()
        {
            dataGridView_observation.DataSource = null;
            dataGridView_knowpoint.DataSource = null;
            dataGridView_estimated.DataSource = null;
        }
        /// <summary>
        /// 清除所有信息
        /// </summary>
        private void Del_all()
        {
            sqlite_way.del_sqldata(Parameter.dbFilePath);
            Del_dataGridView();
            Default_textvalue();
            Parameter.datapath = null;
        }
        /// <summary>
        /// 默认textBOX显示
        /// </summary>
        private void Default_textvalue()
        {
            textBox_path.Text =constants.textboxpath_default;
        }
        private void button_readdata_Click(object sender, EventArgs e)
        {
            if (Parameter._bool_readfile)
            {
                //三个dataGridView写入数据库的数据
                //DataTable observation = sqlite_way.Get_sqldata(constants.query_elevationdata, Parameter.dbFilePath);
                //DataTable knowpoint = sqlite_way.Get_sqldata(constants.query_knowpoint, Parameter.dbFilePath);
                //DataTable estimated = sqlite_way.Get_sqldata(constants.query_estimatespoint, Parameter.dbFilePath);
                dataGridView_observation.DataSource = data_way.RoundDoubleValuesInDataTable(sqlite_way.Get_sqldata(constants.query_elevationdata, Parameter.dbFilePath), Parameter.round_num);
                dataGridView_knowpoint.DataSource = data_way.RoundDoubleValuesInDataTable(sqlite_way.Get_sqldata(constants.query_knowpoint, Parameter.dbFilePath), Parameter.round_num);
                dataGridView_estimated.DataSource = data_way.RoundDoubleValuesInDataTable(sqlite_way.Get_sqldata(constants.query_estimatespoint, Parameter.dbFilePath), Parameter.round_num);
                //data_way.RoundDoubleValuesInDataTable(sqlite_way.Get_sqldata(constants.query_knowpoint, Parameter.dbFilePath), Parameter.round_num);
                //data_way.RoundDoubleValuesInDataTable(sqlite_way.Get_sqldata(constants.query_estimatespoint, Parameter.dbFilePath), Parameter.round_num);
                setcolHeader();
            }
            else
            {
                MessageBox.Show(constants.noselect_file);
            }
        }
        //导入xls
        private void InputfileTM_xls_Click(object sender, EventArgs e)
        {
            Del_all();
            //读取文件到sqlite
            Inputdatatosql(constants.typefile_xls);
        }
        //导入xlsx
        private void inputfileTM_xlsx_Click(object sender, EventArgs e)
        {
            Del_all();
            //读取文件到sqlite
            Inputdatatosql(constants.typefile_xlsx);
        }
        //导入csv
        private void inputfileTM_csv_Click(object sender, EventArgs e)
        {
            Del_all();
            //读取文件到sqlite
            Inputdatatosql(constants.typefile_csv);
        }
        //导入txt
        private void inputfileTM_txt_Click(object sender, EventArgs e)
        {
            Del_all();
            //选取分隔符
            choicesplitstr.ShowDialog();
            if (Parameter.splitstr!=null)
            {
                //读取文件到sqlite
                Inputdatatosql(constants.typefile_txt);
            }
            
        }
        //间接平差
        private void computemTM_Indirect_Click(object sender, EventArgs e)
        {
            //打开UI，传入datapath路径
            UI.UIIndirectad indirectad_ = new UI.UIIndirectad(Parameter.datapath);
            indirectad_.ShowDialog();
            
        }

        private void computemTM_IGG3_Click(object sender, EventArgs e)
        {
            //打开UI，传入datapath路径
            UI.UItolerance tolerance_ = new UI.UItolerance(Parameter.datapath);
            tolerance_.ShowDialog();
        }

        private void 全局参数设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开UI，传入datapath路径
            UI.UIglobalparameter globalparameter_ = new UI.UIglobalparameter(Parameter.round_num);
            globalparameter_.ShowDialog();
        }
    }
}
