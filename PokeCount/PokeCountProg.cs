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
        public const int MAX_CONTROL_NUM = 9;
        const int DEFAULT_CONTROL_NUM = 1;
        private int m_user_control_num = DEFAULT_CONTROL_NUM;
        public int UserControlNum
        {
            set
            {
                m_user_control_num = value;
            }
            get
            {
                return m_user_control_num;
            }
        }
        private PokeMenu[] m_user_controls;
        private PokeInfo m_pokeinfo;
        private string m_resource_folder_path = "";


        public PokeCountProg()
        {
            InitializeComponent();
            m_resource_folder_path = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "..", "..", "resource");
            m_pokeinfo = new PokeInfo(m_resource_folder_path);
            this.m_user_controls = new PokeMenu[m_user_control_num];
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
            this.m_user_controls[i] = new PokeCount.PokeMenu(m_resource_folder_path);
            this.m_user_controls[i].Location = new System.Drawing.Point(0, 110 * i + 30);
            this.m_user_controls[i].Name = "userControl1-" + Convert.ToString(i);
            this.m_user_controls[i].Size = new System.Drawing.Size(692, 118);
            this.m_user_controls[i].TabIndex = i;
            this.Controls.Add(this.m_user_controls[i]);
            this.m_user_controls[i].MyProgressEvent += new PokeMenu.MyEventHandler(CallBackEventProgress);
        }

        public void ChangeUserControlCounts(int count)
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

        private void CallBackEventProgress(PokeMenu.MyEventArgs e)
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
            Log.LoadLog(this, ref m_user_controls, System.IO.Path.Combine(m_resource_folder_path, "result"), MAX_CONTROL_NUM);
            return;
        }
        private void CallBackSaveLog(object sender, EventArgs e)
        {
            Log.SaveLog(ref m_user_controls, System.IO.Path.Combine(m_resource_folder_path, "result"));
            return;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            Log.SaveLog(ref m_user_controls, System.IO.Path.Combine(m_resource_folder_path, "result"));
        }
    }
}
