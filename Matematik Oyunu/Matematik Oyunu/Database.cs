using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Oyunu
{
    class Database
    {
        public static Database obj = new Database();
        public FileStream fs, fs2;

        public void showScoreListPlus(ListBox listBox,string islem)
        {
            listBox.Items.Clear();
            fs = new FileStream(@"database/"+islem+".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));
            string name = sr.ReadLine();
            while (name != null)
            {
                listBox.Items.Add(name);
                name = sr.ReadLine();
            }
            sr.Close();
        }
        public void saveToScorePlus(ListBox listBox, string islem)
        {
            listBox.Items.Add("  " + Operation.obj.getScore() + " --- " + Register.obj.name);
            fs2 = new FileStream(@"database/" + islem + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter SaveFile = new StreamWriter(fs2, Encoding.GetEncoding("windows-1254"));
            foreach (var item in listBox.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.Close();
        }
    }
}
