
using System;
namespace p2c_cs
{
    static class common
    {
        public enum RowType : int
        {
            ResNum = 0,
            Image = 1,
            ImageAdopt = 2,
            Comment = 3,
            Res = 4,
            ResAdopt = 5,
            ImageName = 6,
            Timestamp = 7,
            Name = 8,
            Mail = 9,
            DateId = 10,
            ResRaw = 11,

            HavenCode

        }

        //DataGridView1.Columns.Add("ga1", "画像選択")
        //    DataGridView1.Columns.Add("ga2", "画像採用")
        //    DataGridView1.Columns.Add("Comment", "コメント")
        //    DataGridView1.Columns.Add("Res", "レス")
        //    DataGridView1.Columns.Add("res2", "レス採用")

        //'hidden
        //    DataGridView1.Columns.Add("h1", "画像ファイル名")
        //    DataGridView1.Columns.Add("h2", "timestamp")
        //    DataGridView1.Columns.Add("h3", "name")
        //    DataGridView1.Columns.Add("h4", "mail")
        //    DataGridView1.Columns.Add("h5", "dateid")
        //    DataGridView1.Columns.Add("h6", "予備１")
        //    DataGridView1.Columns.Add("h7", "予備２")
        //    DataGridView1.Columns.Add("h8", "予備３")

        public static string GetExeAppPath()
        {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetEntryAssembly();
            if (asm == null)
            {
                return "";
            }
            else
            {
                return System.IO.Path.GetDirectoryName(asm.Location);
            }
        }

        public static bool IsNumeric(string str) {
            try
            {
                int.Parse(str);
            }
            catch (StackOverflowException)
            {
                throw;
            }
            catch (OutOfMemoryException)
            {
                throw;
            }
            catch (System.Threading.ThreadAbortException)
            {
                throw;
            }
            catch
            {
                return false;
            }

            return true;
        }

        internal static bool IsDate(string s)
        {
            try
            {
                DateTime.Parse(s);
            }
            catch (StackOverflowException)
            {
                throw;
            }
            catch (OutOfMemoryException)
            {
                throw;
            }
            catch (System.Threading.ThreadAbortException)
            {
                throw;
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
