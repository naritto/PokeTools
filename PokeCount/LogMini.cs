using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ns_PokeCount
{
    static class LogMini
    {
        public static void LoadLog(PokeCountMini target, ref PokeMenuMini[] userControls, string result_folder_path, int max_control_num)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "result.csv";
            ofd.InitialDirectory = result_folder_path;
            ofd.Filter = "CSVファイル(*.csv)|*.csv|すべてのファイル(*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.Title = "開くファイルを選択してください";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream stream;
                stream = ofd.OpenFile();
                if (stream != null)
                {

                    StreamReader sr = new StreamReader(stream);
                    {
                        int i = 0;
                        Array.Resize(ref userControls, max_control_num);
                        target.ChangeUserControlCounts(max_control_num);
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string[] values = line.Split(',');
                            if (i >= target.UserControlNum)
                            {

                                target.Initialize(i);
                            }
                            target.SetValues(values, i);
                            ++i;
                        }
                        target.ChangeUserControlCounts(i);
                    }
                }
            }
        }

        public static void SaveLog(PokeCountMini target, ref PokeMenuMini[] user_controls, string result_folder_path)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            DateTime dt = DateTime.Now;
            string dt_str = dt.ToString("yyyyMMddHHmmss");
            sfd.FileName = "result_" + dt_str + ".csv";
            sfd.InitialDirectory = result_folder_path;
            sfd.Filter = "CSVファイル(*.csv)|*.csv|すべてのファイル(*.*)|*.*";
            sfd.FilterIndex = 1;
            sfd.Title = "保存先のファイルを選択してください";
            sfd.RestoreDirectory = true;
            sfd.OverwritePrompt = true;
            sfd.CheckPathExists = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream stream;
                stream = sfd.OpenFile();
                if (stream != null)
                {
                    StreamWriter sw = new System.IO.StreamWriter(stream);
                    for (int i = 0; i < target.UserControlNum; ++i)
                    {
                        string output = target.MakeOutputLine(i);
                        sw.Write(output);

                    }
                    sw.Close();
                    stream.Close();
                }
            }
            return;
        }
    }
}
