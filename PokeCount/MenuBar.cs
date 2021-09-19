using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ns_PokeCount
{
    public partial class MenuBar : UserControl
    {

        public event MenuBarEventHandler UpdateUserControlCountsEvent;
        public event EventHandler ResetContentsEvent;
        public event EventHandler LoadLogEvent;
        public event EventHandler SaveLogEvent;
        public delegate void MenuBarEventHandler(MenuBarEventArgs e);
        public class MenuBarEventArgs : EventArgs
        {
            private int _cnt;
            public int Count { get { return _cnt; } }
            public MenuBarEventArgs()
            {
            }
            public MenuBarEventArgs(int cnt)
            {
                _cnt = cnt;
            }

        }
        private void UpdateUserControlCounts(int cnt)
        {
            UpdateUserControlCountsEvent(new MenuBarEventArgs(cnt));
        }
        private void ResetContents()
        {
            ResetContentsEvent(this, EventArgs.Empty);
        }
        private void LoadLog()
        {
            LoadLogEvent(this, EventArgs.Empty);
        }
        private void SaveLog()
        {
            SaveLogEvent(this, EventArgs.Empty);
        }
        public MenuBar()
        {
            InitializeComponent();
        }

        private void CountType1_Click(object sender, EventArgs e)
        {
            UpdateUserControlCounts(1);
        }

        private void CountType2_Click(object sender, EventArgs e)
        {
            UpdateUserControlCounts(2);
        }

        private void CountType3_Click(object sender, EventArgs e)
        {
            UpdateUserControlCounts(3);
        }

        private void CountType4_Click(object sender, EventArgs e)
        {
            UpdateUserControlCounts(4);
        }

        private void CountType5_Click(object sender, EventArgs e)
        {
            UpdateUserControlCounts(5);
        }

        private void CountType6_Click(object sender, EventArgs e)
        {
            UpdateUserControlCounts(6);
        }

        private void CountType7_Click(object sender, EventArgs e)
        {
            UpdateUserControlCounts(7);
        }

        private void CountType8_Click(object sender, EventArgs e)
        {
            UpdateUserControlCounts(8);
        }

        private void CountType9_Click(object sender, EventArgs e)
        {
            UpdateUserControlCounts(9);
        }

        public void ResetMenuItem_Click(object sender, EventArgs e)
        {
            ResetContents();
        }

        private void loadLogMenuBar_Click(object sender, EventArgs e)
        {
            LoadLog();
        }

        private void saveLogMenuBar_Click(object sender, EventArgs e)
        {
            SaveLog();
        }
    }
}
