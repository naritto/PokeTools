using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeCount
{
    static class Log
    {
        public static void LoadLog(ref UserControl1[] userContorls, string result_folder_path)
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
                        // 末尾まで繰り返す
                        while (!sr.EndOfStream)
                        {
                            // CSVファイルの一行を読み込む
                            string line = sr.ReadLine();
                            // 読み込んだ一行をカンマ毎に分けて配列に格納する
                            string[] values = line.Split(',');
                            if (values.Length == 3)
                            {
                            }
                        }
                    }
                }
            }
        }

        public static void SaveLog(ref UserControl1[] user_controls, string result_folder_path)
        {
            //SaveFileDialogクラスのインスタンスを作成
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
                    //ファイルに書き込む
                    StreamWriter sw = new System.IO.StreamWriter(stream);
                    for (int i = 0; i < user_controls.Length; ++i)
                    {
                        sw.Write(user_controls[i].DictNum + "," + user_controls[i].CountColor + "," + user_controls[i].CountAll + "\n");
                    }
                    //閉じる
                    sw.Close();
                    stream.Close();
                }
            }
            return;
        }
    }
}
