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
        public const int DISPLAY_WIDTH = 345;
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
        private PokeMenu[] m_pokemenu;
        private PokeInfo m_pokeinfo;
        private string m_resource_folder_path = "";


        public PokeCountProg()
        {
            InitializeComponent();
            m_resource_folder_path = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "..", "..", "resource");
            m_pokeinfo = new PokeInfo(m_resource_folder_path);
            this.m_pokemenu = new PokeMenu[m_user_control_num];
            InitializeView(0, m_user_control_num);
            this.menuBar1.UpdateUserControlCountsEvent += new MenuBar.MenuBarEventHandler(CallBackEventChangeUserControlCounts);
            this.menuBar1.ResetContentsEvent += new EventHandler(CallBackEventResetAllInfo);
            this.menuBar1.LoadLogEvent += new EventHandler(CallBackLoadLog);
            this.menuBar1.SaveLogEvent += new EventHandler(CallBackSaveLog);
        }
        public void InitializeView(int start, int end)
        {
            Array.Resize(ref this.m_pokemenu, end);
            for (int i = start; i < end; ++i)
            {
                Initialize(i);

            }
            this.Size = new Size(DISPLAY_WIDTH, 110 * m_user_control_num + 70);
            return;
        }
        public void Initialize(int i)
        {
            this.m_pokemenu[i] = new PokeCount.PokeMenu(m_resource_folder_path);
            this.m_pokemenu[i].Location = new System.Drawing.Point(0, 110 * i + 30);
            this.m_pokemenu[i].Name = "userControl1-" + Convert.ToString(i);
            this.m_pokemenu[i].Size = new System.Drawing.Size(DISPLAY_WIDTH, 118);
            this.m_pokemenu[i].TabIndex = i;
            this.Controls.Add(this.m_pokemenu[i]);
            this.m_pokemenu[i].PokeMenuEvent += new PokeMenu.PokeMenuEventHandler(CallBackEventProgress);
        }

        public void SetValues(string[] values, int i) {
            this.m_pokemenu[i].SetValues(values);
            return;
        }

        public void ChangeUserControlCounts(int count)
        {
            if (count < m_user_control_num)
            {
                for (int i = count; i < m_user_control_num; ++i)
                {
                    this.Controls.Remove(this.m_pokemenu[i]);
                    this.m_pokemenu[i] = null;
                }
            }
            else if (count > m_user_control_num)
            {
                InitializeView(m_user_control_num, count);
            }
            m_user_control_num = count;
            this.Size = new Size(DISPLAY_WIDTH, 110 * m_user_control_num + 70);
        }

        private void CallBackEventProgress(PokeMenu.PokeMenuEventArgs e)
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
                this.m_pokemenu[i].InitializeAllData(m_resource_folder_path);
            }
            return;
        }
        private void CallBackLoadLog(object sender, EventArgs e)
        {
            Log.LoadLog(this, ref m_pokemenu, System.IO.Path.Combine(m_resource_folder_path, "result"), MAX_CONTROL_NUM);
            return;
        }
        private void CallBackSaveLog(object sender, EventArgs e)
        {
            Log.SaveLog(this, ref m_pokemenu, System.IO.Path.Combine(m_resource_folder_path, "result"));
            return;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            Log.SaveLog(this, ref m_pokemenu, System.IO.Path.Combine(m_resource_folder_path, "result"));
        }
    }
}
