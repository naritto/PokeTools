using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeCount
{
    class PokeInfo
    {
        private string m_file_path;
        public PokeInfo(string resource_folder_path) {
            m_poke_info = new Dictionary<int, string>();
            PokeNameReader reader  = new PokeNameReader();
            m_file_path = System.Windows.Forms.Application.StartupPath;
            m_file_path = System.IO.Path.Combine(resource_folder_path, "data", "pokedata.csv");
            reader.ReadCSV(m_file_path, ref m_poke_info);
        }
        public string GetPokeName(int id) {
            string ret = "";
            if (m_poke_info.ContainsKey(id)) {
                ret = m_poke_info[id];
            } else {
                ret = "";
            }
            return ret;

        }

        private Dictionary<int, string> m_poke_info;
    }
}
