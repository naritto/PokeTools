using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeCount
{
    public partial class UserControl1 : UserControl
    {
        public event MyEventHandler MyProgressEvent;
        private void UpdatePokeName(int id, string name)
        {
            MyEventArgs e = new MyEventArgs(id, name);
            MyProgressEvent(e);
            DictNum = e.ID;
            PokeName = e.Name;
        }

        //-----------------------------------
        //イベントハンドラのデリゲートを定義
        public delegate void MyEventHandler(MyEventArgs e);

        //-----------------------------------
        // 渡せるイベントデータ引数、EventArgsを継承したクラスを拡張
        public class MyEventArgs : EventArgs
        {
            private int _id;
            private string _name;
            public int ID { get { return _id; } }
            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    _name = value;
                }
            }

            public MyEventArgs(int id, string name)
            {
                _id = id;
                _name = name;
            }

        }

        private int m_dict_num = 0;
        public int DictNum
        {
            set
            {
                if (dict_num.Text != "")
                {
                    m_dict_num = value;
                }
                else
                {
                    m_dict_num = 0;
                }
                dict_num.Text = Convert.ToString(m_dict_num);
            }
            get
            {
                return m_dict_num;
            }
        }
        private string m_poke_name = "empty";
        public string PokeName
        {
            set
            {
                m_poke_name = value;
                pokename.Text = m_poke_name;
            }
            get
            {
                return m_poke_name;
            }
        }

        private int m_count_all = 0;
        public int CountAll
        {
            set
            {
                if (encount_all.Text != "")
                {
                    m_count_all = value;
                }
                else
                {
                    m_count_all = 0;
                }
                encount_all.Text = Convert.ToString(m_count_all);
            }
            get
            {
                return m_count_all;
            }
        }

        private int m_count_color = 0;
        public int CountColor
        {
            set
            {
                if (encount_color.Text != "")
                {
                    m_count_color = value;
                }
                else
                {
                    m_count_color = 0;
                }
                encount_color.Text = Convert.ToString(m_count_color);
            }
            get
            {
                return m_count_color;
            }
        }


        private string m_folder_path = "";
        private string m_pokepic_images_folder_path = "";


        public UserControl1(string resource_folder_path)
        {
            InitializeComponent();
            InitializeAllData(resource_folder_path);
        }

        public void InitializeAllData(string resource_folder_path)
        {
            m_dict_num = 0;
            dict_num.Text = Convert.ToString(m_dict_num);

            m_poke_name = "ポケモン名";
            pokename.Text = m_poke_name;

            m_count_all = 0;
            encount_all.Text = Convert.ToString(m_count_all);

            m_count_color = 0;
            encount_color.Text = Convert.ToString(m_count_color);

            m_poke_name = pokename.Text;
            m_folder_path = System.Windows.Forms.Application.StartupPath;
            pokepic.SizeMode = PictureBoxSizeMode.StretchImage;
            m_pokepic_images_folder_path = System.IO.Path.Combine(resource_folder_path, "poke_pic");
            pokepic.ImageLocation = System.IO.Path.Combine(m_pokepic_images_folder_path, "noimage.png");
        }

        public void UpdatePokeInfo()
        {
            if (dict_num.Text != "0")
            {
                dict_num.Text = dict_num.Text.TrimStart(new Char[] { '0' });
            }
            string image_location = System.IO.Path.Combine(m_pokepic_images_folder_path, dict_num.Text + ".png");
            if (System.IO.File.Exists(image_location))
            {
                pokepic.ImageLocation = image_location;
            }
            else
            {
                pokepic.ImageLocation = System.IO.Path.Combine(m_pokepic_images_folder_path, "noimage.png");
            }
            UpdatePokeName(m_dict_num, m_poke_name);
        }

        // textbox
        private void dict_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            return;
        }
        private void dict_num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdatePokeInfo();
            }
            return;
        }
        private void dict_num_TextChanged(object sender, EventArgs e)
        {
            if (dict_num.Text == "")
            {
                m_dict_num = 0;
            }
            else
            {
                m_dict_num = Convert.ToInt32(dict_num.Text);
            }
        }
        private void pokename_TextChanged(object sender, EventArgs e)
        {
            m_poke_name = pokename.Text;
        }

        private void encount_all_KeyPress(object sender, KeyPressEventArgs e)
        {

            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void encount_TextChanged(object sender, EventArgs e)
        {
            m_count_all = Int32.Parse(encount_all.Text);
        }


        private void encount_color_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }
        private void encount_color_TextChanged(object sender, EventArgs e)
        {
            m_count_color = Int32.Parse(encount_color.Text);
        }

        // button
        private void plus_button_Click(object sender, EventArgs e)
        {
            ++m_count_all;
            encount_all.Text = Convert.ToString(m_count_all);
        }
        private void minus_button_Click(object sender, EventArgs e)
        {
            if (m_count_all != 0)
            {
                --m_count_all;
                encount_all.Text = Convert.ToString(m_count_all);
            }
        }
        private void color_button_Click(object sender, EventArgs e)
        {
            ++m_count_color;
            encount_color.Text = Convert.ToString(m_count_color);
        }
        private void show_pic_Click(object sender, EventArgs e)
        {
            UpdatePokeInfo();
        }
    }
}
