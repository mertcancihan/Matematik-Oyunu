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
    public partial class Register : Form
    {
        public static Register obj;
        public string name;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            createObj();
        }
        void createObj()
        {
            if (obj == null)
                obj = this;
        }
        public void restartGame()
        {
            Application.Restart();
        }

        private void rastIslemSec_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Game.obj.islem = rand.Next(1, 5);
            Game.obj.Show();
            Game.obj.startGame();
            name = nameTxt.Text;
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            Game.obj.islem = 1;
            Game.obj.Show();
            Game.obj.startGame();
            name = nameTxt.Text;
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            Game.obj.islem = 2;
            Game.obj.Show();
            Game.obj.startGame();
            name = nameTxt.Text;
        }

        private void btn_divided_Click(object sender, EventArgs e)
        {
            Game.obj.islem = 3;
            Game.obj.Show();
            Game.obj.startGame();
            name = nameTxt.Text;
        }

        private void btn_cross_Click(object sender, EventArgs e)
        {
            Game.obj.islem = 4;
            Game.obj.Show();
            Game.obj.startGame();
            name = nameTxt.Text;
        }
    }
}
