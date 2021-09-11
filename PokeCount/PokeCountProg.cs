using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeCount
{
    public partial class PokeCountProg : Form
    {
        const int MAX_CONTROL_NUM = 9;
        const int DEFAULT_CONTROL_NUM = 1;
        private int m_user_control_num = DEFAULT_CONTROL_NUM;
        private UserControl1[] m_user_controls;
        private PokeInfo m_pokeinfo;
        private string m_resource_folder_path = "";


        public PokeCountProg()
        {
            InitializeComponent();
            m_resource_folder_path = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "..", "..", "resource");
            m_pokeinfo = new PokeInfo(m_resource_folder_path);
            this.m_user_controls = new UserControl1[m_user_control_num];
            InitializeView(0, m_user_control_num);
            this.menuBar1.UpdateUserControlCountsEvent += new MenuBar.MenuBarEventHandler(CallBackEventChangeUserControlCounts);
            this.menuBar1.ResetContentsEvent += new EventHandler(CallBackEventResetAllInfo);
            this.menuBar1.LoadLogEvent += new EventHandler(CallBackLoadLog);
            this.menuBar1.SaveLogEvent += new EventHandler(CallBackSaveLog);
        }
        public void InitializeView(int start, int end)
        {
            Array.Resize(ref this.m_user_controls, end);
            for (int i = start; i < end; ++i)
            {
                Initialize(i);

            }
            this.Size = new Size(663, 110 * m_user_control_num + 70);
            return;
        }
        public void Initialize(int i)
        {
            this.m_user_controls[i] = new PokeCount.UserControl1(m_resource_folder_path);
            this.m_user_controls[i].Location = new System.Drawing.Point(0, 110 * i + 30);
            this.m_user_controls[i].Name = "userControl1-" + Convert.ToString(i);
            this.m_user_controls[i].Size = new System.Drawing.Size(692, 118);
            this.m_user_controls[i].TabIndex = i;
            this.Controls.Add(this.m_user_controls[i]);
            this.m_user_controls[i].MyProgressEvent += new UserControl1.MyEventHandler(CallBackEventProgress);
        }

        private void ChangeUserControlCounts(int count)
        {
            if (count < m_user_control_num)
            {
                for (int i = count; i < m_user_control_num; ++i)
                {
                    this.Controls.Remove(this.m_user_controls[i]);
                    this.m_user_controls[i] = null;
                }
            }
            else if (count > m_user_control_num)
            {
                InitializeView(m_user_control_num, count);
            }
            m_user_control_num = count;
            this.Size = new Size(663, 110 * m_user_control_num + 70);
        }

        private void CallBackEventProgress(UserControl1.MyEventArgs e)
        {
            e.Name = m_pokeinfo.GetPokeName(e.ID);
        }

        private void CallBackEventChangeUserControlCounts(MenuBar.MenuBarEventArgs e)
        {
            ChangeUserControlCounts(e.Count);
        }

        private void CallBackEventResetAllInfo(object sender, EventArgs e) 
        {
            for (int i = 0; i < m_user_control_num; ++i)
            {
                this.m_user_controls[i].InitializeAllData(m_resource_folder_path);
            }
            return;
        }
        private void CallBackLoadLog(object sender, EventArgs e)
        {
            //Log.
            LoadLog(ref m_user_controls, System.IO.Path.Combine(m_resource_folder_path, "result"));
            return;
        }
        private void CallBackSaveLog(object sender, EventArgs e)
        {
            Log.SaveLog(ref m_user_controls, System.IO.Path.Combine(m_resource_folder_path, "result"));
            return;
        }

        public void LoadLog(ref UserControl1[] userContorls, string result_folder_path)
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
                        // 末尾まで繰り返す
                        string[] lines = new string[0];
                        Array.Resize(ref this.m_user_controls, MAX_CONTROL_NUM);
                        while (!sr.EndOfStream)
                        {
                            // CSVファイルの一行を読み込む
                            string line = sr.ReadLine();
                            string[] values = line.Split(',');
                            if (i >= m_user_control_num) {
                                
                                Initialize(i);
                            }
                            m_user_controls[i].DictNum = Convert.ToInt32(values[0]);
                            m_user_controls[i].CountColor = Convert.ToInt32(values[1]);
                            m_user_controls[i].CountAll = Convert.ToInt32(values[2]);
                            m_user_controls[i].UpdatePokeInfo();
                            ++i;
                        }
                        ChangeUserControlCounts(i);
                    }
                }
            }
        }
    }
}
