using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ns_PokeCount
{
    class PokeNameReader
    {
        public PokeNameReader() { }

        public void ReadCSV(string file_path, ref Dictionary<int, string> info)
        {
            // 読み込みたいCSVファイルのパスを指定して開く
            StreamReader sr = new StreamReader(file_path);
            {
                // 末尾まで繰り返す
                while (!sr.EndOfStream)
                {
                    // CSVファイルの一行を読み込む
                    string line = sr.ReadLine();
                    // 読み込んだ一行をカンマ毎に分けて配列に格納する
                    string[] values = line.Split(',');
                    if (values.Length == 2) {
                        int key = Convert.ToInt32(values[0]); // 正しい形式か確認すべき
                        string value = values[1].TrimEnd();
                        info[key] = value;
                    }
                }
            }
            return;
        }
    }
}
