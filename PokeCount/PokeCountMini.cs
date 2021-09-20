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

namespace ns_PokeCount
{
    public partial class PokeCountMini : Form
    {
        public static readonly int MAX_CONTROL_NUM = 8;
        public const int DEFAULT_CONTROL_NUM = 1;
        private int m_user_control_num = DEFAULT_CONTROL_NUM;
        public const int DISPLAY_WIDTH = 345;
        public const int POKEMENU_HEIGHT = 110;
        public const int MENUBAR_HEIGHT = 20;
        public const int TOOL_INFO_HEIGHT = 50;
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
        private PokeMenuMini[] m_pokemenu;
        private PokeInfo m_pokeinfo;
        private string m_resource_folder_path = "";

        public int m_has_changed;
        public int HasChanged {
            set {
                m_has_changed = value;
            }
            get {
                return m_has_changed;
            }
        }
        private int m_count_total = 0;
        public int CountTotal
        {
            set
            {
                if (total_num_label.Text != "")
                {
                    m_count_total = value;
                }
                else
                {
                    m_count_total = 0;
                }
                total_num_label.Text = Convert.ToString(m_count_total);
            }
            get
            {
                return m_count_total;
            }
        }


        public PokeCountMini()
        {
            InitializeComponent();
            m_resource_folder_path = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "..", "..", "resource");
            m_pokeinfo = new PokeInfo(m_resource_folder_path);
            this.m_pokemenu = new PokeMenuMini[m_user_control_num];
            InitializeView(0, m_user_control_num);
            this.menuBar1.UpdateUserControlCountsEvent += new MenuBar.MenuBarEventHandler(CallBackEventChangeUserControlCounts);
            this.menuBar1.ResetContentsEvent += new EventHandler(CallBackEventResetAllInfo);
            this.menuBar1.LoadLogEvent += new EventHandler(CallBackLoadLog);
            this.menuBar1.SaveLogEvent += new EventHandler(CallBackSaveLog);
            HasChanged = 0;
        }
        public void InitializeView(int start, int end)
        {
            ResizePokeMenu(end);
            for (int i = start; i < end; ++i)
            {
                Initialize(i);

            }
            this.Size = new Size(DISPLAY_WIDTH, POKEMENU_HEIGHT * m_user_control_num + MENUBAR_HEIGHT + TOOL_INFO_HEIGHT + 35);
            return;
        }

        public void ResizePokeMenu(int size) {
            Array.Resize(ref this.m_pokemenu, size);
            return;
        }

        public void Initialize(int i)
        {
            this.m_pokemenu[i] = new PokeMenuMini(m_resource_folder_path)
            {
                Location = new Point(0, POKEMENU_HEIGHT * i + MENUBAR_HEIGHT + TOOL_INFO_HEIGHT),
                Name = "userControl1-" + Convert.ToString(i),
                Size = new System.Drawing.Size(DISPLAY_WIDTH, POKEMENU_HEIGHT),
                TabIndex = i
            };
            this.Controls.Add(this.m_pokemenu[i]);
            this.m_pokemenu[i].PokeMenuEvent += new PokeMenuMini.PokeMenuEventHandler(CallBackEventProgress);
            this.m_pokemenu[i].HasChangedEvent += new EventHandler(CallBackEventHasChanged);
            this.CountTotal = 0;

        }

        public void CalcCountTotal() {
            int temp = 0;
            for (int i = 0; i < UserControlNum; ++i) {
                temp += m_pokemenu[i].CountAll;
            }
            CountTotal = temp;
            return;
        }

        public void SetValues(string[] values, int i)
        {
            this.m_pokemenu[i].SetValues(values);
            HasChanged = 1;
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
            this.Size = new Size(DISPLAY_WIDTH, POKEMENU_HEIGHT * m_user_control_num + MENUBAR_HEIGHT + TOOL_INFO_HEIGHT + 35);
        }

        public string MakeOutputLine(int i)
        {
            return m_pokemenu[i].MakeLine();
        }

        private void CallBackEventProgress(PokeMenuMini.PokeMenuEventArgs e)
        {
            e.Name = m_pokeinfo.GetPokeName(e.ID);
        }

        private void CallBackEventChangeUserControlCounts(MenuBar.MenuBarEventArgs e)
        {
            ChangeUserControlCounts(e.Count);
        }
        private void CallBackEventHasChanged(object sender, EventArgs e)
        {
            HasChanged = 1;
            CalcCountTotal();
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
            if (HasChanged == 1)
            {
                LogMini.SaveLog(this, Path.Combine(m_resource_folder_path, "result"));
            }
            LogMini.LoadLog(this, Path.Combine(m_resource_folder_path, "result"));
            CalcCountTotal();
            return;
        }
        private void CallBackSaveLog(object sender, EventArgs e)
        {
            if (HasChanged == 1) {
                LogMini.SaveLog(this, Path.Combine(m_resource_folder_path, "result"));
            }
            return;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (HasChanged == 1)
            {
                LogMini.SaveLog(this, Path.Combine(m_resource_folder_path, "result"));
            }
        }
    }
}
