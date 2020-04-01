using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Oyunu
{
    public partial class Score : Form
    {
        public static Score obj = new Score();
        public Score()
        {
            InitializeComponent();
        }
        private void Score_Load(object sender, EventArgs e)
        {
            createObj();
            Database.obj.showScoreListPlus(listBoxPlus, "Plus");
            Database.obj.showScoreListPlus(listBoxMinus, "Minus");
            Database.obj.showScoreListPlus(listBoxDivided, "Divided");
            Database.obj.showScoreListPlus(listBoxCross, "Cross");
        }
        private void createObj()
        {
            if (obj == null)
                obj = this;
        }
        private void btn_restart_Click(object sender, EventArgs e)
        {
            Register.obj.restartGame();
            this.Hide();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Register.obj.Close();
        }
        private void btn_score_Click(object sender, EventArgs e)
        {
            Database.obj.showScoreListPlus(listBoxPlus, "Plus");
            Database.obj.showScoreListPlus(listBoxMinus, "Minus");
            Database.obj.showScoreListPlus(listBoxDivided, "Divided");
            Database.obj.showScoreListPlus(listBoxCross, "Cross");
            if(Game.obj.islem == 1)
                Database.obj.saveToScorePlus(listBoxPlus, "Plus");
            if (Game.obj.islem == 2)
                Database.obj.saveToScorePlus(listBoxMinus, "Minus");
            if (Game.obj.islem == 3)
                Database.obj.saveToScorePlus(listBoxDivided, "Divided");
            if (Game.obj.islem == 4)
                Database.obj.saveToScorePlus(listBoxCross, "Cross");
            Database.obj.showScoreListPlus(listBoxPlus, "Plus");
            Database.obj.showScoreListPlus(listBoxMinus, "Minus");
            Database.obj.showScoreListPlus(listBoxDivided, "Divided");
            Database.obj.showScoreListPlus(listBoxCross, "Cross");
            listBoxPlus.Visible = true;
            listBoxMinus.Visible = true;
            listBoxDivided.Visible = true;
            listBoxCross.Visible = true;
            label1.Visible = true;
            btn_score.Visible = false;
        }
    }
}
