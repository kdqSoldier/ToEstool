using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToEstool.ways
{
    class wayspy
    {
        public string[] Py_process(string py_PythonexePath,string py_path,string inscriptArguments)
        {
            string[] outdata = new string[2] { string.Empty, string.Empty };
            // 创建一个进程对象
            Process process = new Process();
            // 配置进程启动信息
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = py_PythonexePath,
                Arguments = $"{py_path} {inscriptArguments}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            process.StartInfo = startInfo;
            // 启动进程
            process.Start();
            // 读取Python脚本的输出
            outdata[0]=process.StandardOutput.ReadToEnd();
            outdata[1] = process.StandardError.ReadToEnd();
            return outdata;
        }

        public string[] Get_pyreadsysdata(string datapath)
        {
            string py_readxlspath = Parameter.currentDirectory + constants.py_readxls;
            string inscriptArguments = datapath + " " + Parameter.dbFilePath + " " + Parameter.splitstr;
            string[] data = { py_readxlspath, inscriptArguments };
            return data;

        }
        public string[] Get_indirectadjustment(string datapath,bool sys,int countcmpute=1)
        {
            string py_tecomputepath = Parameter.currentDirectory + constants.py_tecompute;
            string logFilePath = Parameter.currentDirectory + constants.logFilePath;
            string inscriptArguments = datapath + " " + Parameter.dbFilePath + " " + Parameter.splitstr + " " + sys + " " + logFilePath + " " + countcmpute.ToString();
            string[] outdata = { py_tecomputepath, inscriptArguments };
            //string[] outdata =Py_process(Parameter.py_PythonexePath, py_tecomputepath, inscriptArguments);
            return outdata;
        }
        public string[] Get_Itolerance(string datapath, bool sys,int countcmpute = 2,double k0=1.5,double k1=2.5,double stopmax=1e-6)
        {
            string py_tecomputepath = Parameter.currentDirectory + constants.py_tecompute;
            string logFilePath = Parameter.currentDirectory + constants.logFilePath;
            string inscriptArguments = datapath + " " + Parameter.dbFilePath + " " + Parameter.splitstr + " " + sys + " " + logFilePath + " " + 
                countcmpute.ToString() + " " +k0.ToString() + " " +k1.ToString() + " " +stopmax.ToString();
            string[] outdata = { py_tecomputepath, inscriptArguments };
            //string[] outdata =Py_process(Parameter.py_PythonexePath, py_tecomputepath, inscriptArguments);
            return outdata;
        }
    }
}
