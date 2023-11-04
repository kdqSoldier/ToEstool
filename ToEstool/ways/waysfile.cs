using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ToEstool.ways
{
    class waysfile
    {
        public string outpath(string[] typefiledata)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string selectedFilePath=string.Empty;

            openFileDialog.Title = typefiledata[1];

            openFileDialog.Filter = typefiledata[2];

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
            }
            return selectedFilePath;
        }

        public  void ExportDataTableToTxt(DataTable dataTable)
        {
            string filePath = @"\out.txt";
            // 打开文件流
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // 写入列名
                foreach (DataColumn column in dataTable.Columns)
                {
                    sw.Write($"{column.ColumnName.PadRight(10)}"); // 15 是一个示例值，你可以根据需要调整宽度
                }
                sw.WriteLine();

                // 写入数据
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        sw.Write($"{item.ToString().PadRight(10)}"); // 15 是一个示例值，你可以根据需要调整宽度
                    }
                    sw.WriteLine();
                }
            }
        }
    }
}
