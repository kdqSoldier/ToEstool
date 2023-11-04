using System.IO;


namespace ToEstool
{
    class Parameter
    {
        //当前工作文件夹
        public static string currentDirectory= Directory.GetCurrentDirectory();
        // 数据库文件路径
        public static string dbFilePath= currentDirectory + constants.dbFilePath;
        // LOG文件路径
        public static string logFilePath= currentDirectory + constants.logFilePath;
        //Python解释器路径
        public static string py_PythonexePath = currentDirectory + constants.py_PythonexePath;
        //读取文件是否成功
        public static bool _bool_readfile =false;
        //用户选择的txt文件分隔符
        public static string splitstr = "*";
        //数据地址
        public static string datapath = null;
        //IGG3默认参数
        public static double igg3_k0 = 1.5;
        public static double igg3_k1 = 2.5;
        public static double igg3_max1 = 1;
        public static double igg3_max2 = -6;
        //全局设置
        //数据位数保留设置
        public static int round_num = 4;
    }
}
