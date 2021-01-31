using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSV_Convertor
{
    public class CSVConvertor<T>
    {
        static char[] TrimEndChars { get; } = { ' ', ',' };

        public static string ConvertAndWriteToFile(List<T> objects, string path)
        {
            string csvValue = ConvertToCSV(objects);

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(path))
            {
                file.Write(csvValue);
            }

            return csvValue;
        }

        public static string ConvertToCSV(List<T> objects)
        {
            StringBuilder strb = new StringBuilder();
            List<PropertyInfo> props = new List<PropertyInfo>();
            foreach (var prop in typeof(T).GetProperties())
            {
                props.Add(prop);

                strb.Append(prop.Name);
                strb.Append(',');
            }

            strb.AppendLine();

            foreach (var obj in objects)
            {
                foreach (var prop in props)
                {
                    var val = prop.GetValue(obj);
                    strb.Append(val.ToString().Replace(',', '.')).Append(", ");
                }
                strb.AppendLine();
            }

            return strb.ToString().TrimEnd(TrimEndChars);
        }
    }
}
