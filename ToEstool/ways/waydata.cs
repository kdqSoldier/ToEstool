using System;
using System.Data;

namespace ToEstool.ways
{
    class waydata
    {
       public DataTable RoundDoubleValuesInDataTable(DataTable dataTable, int decimalPlaces)
        {
            DataTable dataTable_=dataTable.Copy();
            foreach (DataRow row in dataTable_.Rows)
            {
                for (int i = 0; i < dataTable_.Columns.Count; i++)
                {
                    if (dataTable_.Columns[i].DataType == typeof(double) && row[i] != DBNull.Value)
                    {
                        if (Double.TryParse(row[i].ToString(), out double originalValue))
                        {
                            //double roundedValue = Math.Round(originalValue, decimalPlaces);
                            //row[i] = roundedValue;
                            // 使用字符串格式化，保留指定小数位数，并用零进行补齐
                            row[i] = originalValue.ToString($"F{decimalPlaces}");
                        }
                        else
                        {
                            // 处理无法解析为 double 的情况
                            // 例如，如果数据表中的字符串不是有效的数字
                        }
                    }
                }
            }
            return dataTable_;
        }
        //获取数据最后一个数为尺度改正
        public string sys_scalingcorrection(DataTable dataTable)
        {
            DataTable dataTable_ = dataTable.Copy();
            string sys_scalingcorrection=string.Empty;
            int len_ = dataTable.Rows.Count;
            // 获取最后一行的数据
            DataRow lastRow = dataTable_.Rows[len_-1];
            // 获取第一列的数据
            object cellValue = lastRow.ItemArray[0];
            double doubleValue = Math.Round((double)cellValue,Parameter.round_num);
            sys_scalingcorrection = doubleValue.ToString();
            return sys_scalingcorrection;
        }
    }
}
