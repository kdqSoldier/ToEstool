
using System.Collections.Generic;

namespace ToEstool
{
    class constants
    {
        /// <summary>
        /// 文件类型
        /// </summary>
        public static readonly string[] typefile_xls = { ".xls", "选择 .XLS 文件", "Excel 文件 (*.xls)|*.xls|所有文件 (*.*)|*.*" };
        public static readonly string[] typefile_xlsx = { ".xlsx", "选择 .XLSX 文件", "Excel 文件 (*.xlsx)|*.xlsx|所有文件 (*.*)|*.*" };
        public static readonly string[] typefile_csv = { ".csv", "选择 .CSV 文件", "Excel 文件 (*.csv)|*.csv|所有文件 (*.*)|*.*" };
        public static readonly string[] typefile_txt = { ".txt", "选择 .CSV 文件", "文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*" };
        // 要传递给Python脚本的参数
        //public const string py_datapath = @"\Tolerance_estimation\Tolerance_estimation.py";
        // 数据库文件路径
        public const string dbFilePath = @"\Tolerance_estimation\TeDateSqlite.db";
        // LOG文件路径
        public const string logFilePath = @"\Tolerance_estimation\TeDatelog.te";
        //读取文件路径
        public const string py_readxls = @"\Tolerance_estimation\readfiletosql.py";
        //python解释器路径
        public const string py_PythonexePath = @"\Tolerance_estimation\envs\PyenvsTe\python.exe";
        //计算路径
        public const string py_tecompute = @"\Tolerance_estimation\Tolerance_estimation.py";

        /// <summary>
        /// 数据库查询，表
        /// </summary>
        //观测两
        public const string query_elevationdata = "SELECT * FROM elevationdata;";
        //已知点
        public const string query_knowpoint = "SELECT * FROM knowpoint;";
        //未知点估值
        public const string query_estimatespoint = "SELECT * FROM estimatespoint;";
        //未知点改正值
        public const string query_corunknowns_old = "SELECT * FROM corunknowns_old;";
        //观测值改正值
        public const string query_corestimates_old = "SELECT * FROM corestimates_old;";
        //未知点改正值-iggg3
        public const string query_corunknowns_igg3 = "SELECT * FROM corunknowns;";
        //观测值改正值-igg3
        public const string query_corestimates_igg3 = "SELECT * FROM corestimates;";
        //间接平差V
        public const string query_x_old = "SELECT * FROM x_old;";
        //抗差估计V
        public const string query_x_igg3= "SELECT * FROM x;";
        //数据库表单信息
        public const string sqlconstdata = "Sqllitedata";
        //分隔符号
        public static readonly string[] splitstr = { "逗号", "空格", "制表符", "分号" };
        public static readonly Dictionary<string, string> splitstr_Dict = new Dictionary<string, string> { { "逗号", "," }, { "空格", " "},{ "制表符","\t" },{ "分号" ,";"}};
        //界面显示文本数据
        public const string leaddsql_successful = "导入成功：";
        public const string leaddsql_lose = "检查数据文件！";
        public const string noselect_file = "先导入文件。";
        public const string textboxpath_default = "需要导入数据......";
        public const string error_compute = "计算错误，检查参数及数据。";
        //IGG3参数
        public const string error_num = "数值非法！";
        //表头信息
        public static readonly string[] header_elevationdata = { "观测边", "观测边起点", "观测点终点", "观测值/m", "距离" };
        public static readonly string[] header_knowpoint= { "已知点", "已知值/m" };
        public static readonly string[] header_estimated = { "待求点", "预估初值/m" };
        public static readonly string[] header_X = { "待求点", "预估初值/m", "改正数/mm", "平差值/m" };
        public static readonly string[] header_V = { "观测边", "观测值/m", "改正数/mm", "平差值/m" };
        //
    }
}
