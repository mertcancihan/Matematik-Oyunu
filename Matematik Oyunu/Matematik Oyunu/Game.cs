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
    public partial class Game : Form
    {
        public static Game obj = new Game();
        public Button[] buttons, pasButtons;
        public PictureBox[] picBoxExamArray;
        public int level = 0, islem = 2; //İşlem A=1 B=2 C=3 D=4
        int timerNum = 40, timerTime = 0;
        bool pass = false, passEnable = false;// en son pas tuşu koyduktan sonra true yapılacak
        bool pic1Cont, pic2Cont, pic3Cont, pic4Cont, pic5Cont;

        public Game()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            runMethods();
            Operation.obj.runMethods();
        }
        public void runMethods()
        {
            createObj();
            editPicBoxBtn();
        }
        private void createObj()
        {
            if (obj == null)
                obj = this;
        }
        private void editPicBoxBtn()
        {
            buttons = new Button[]{ btn_A1, btn_B1, btn_C1, btn_D1, btn_A2, btn_B2, btn_C2, btn_D2,
                                    btn_A3, btn_B3, btn_C3, btn_D3, btn_A4, btn_B4, btn_C4, btn_D4,
                                    btn_A5, btn_B5, btn_C5, btn_D5};
            pasButtons = new Button[] { btn_pas1, btn_pas2, btn_pas3, btn_pas4 ,btn_pas5};
            picBoxExamArray = new PictureBox[] { picBoxExam1, picBoxExam2, picBoxExam3, picBoxExam4, picBoxExam5};

            for (int j = 0; j < 4; j++)
                buttons[j].Parent = picBoxExam1;
            for (int j = 4; j < 8; j++)
                buttons[j].Parent = picBoxExam2;
            for (int j = 8; j < 12; j++)
                buttons[j].Parent = picBoxExam3;
            for (int j = 12; j < 16; j++)
                buttons[j].Parent = picBoxExam4;
            for (int j = 16; j < 20; j++)
                buttons[j].Parent = picBoxExam5;

            for (int i = 0; i < buttons.Length; i++)
                buttons[i].BackColor = Color.Transparent;

            btn_pas1.Parent = picBoxExam1;
            btn_pas2.Parent = picBoxExam2;
            btn_pas3.Parent = picBoxExam3;
            btn_pas4.Parent = picBoxExam4;
            btn_pas5.Parent = picBoxExam5;

            for (int i = 0; i < pasButtons.Length; i++)
                pasButtons[i].BackColor = Color.Transparent;

            btn_pas1.Location = new Point(275, 170);
            btn_pas2.Location = new Point(275, 170);
            btn_pas3.Location = new Point(275, 170);
            btn_pas4.Location = new Point(275, 170);
            btn_pas5.Location = new Point(275, 170);

            btn_A1.Location = new Point(15, 93);
            btn_B1.Location = new Point(15, 132);
            btn_C1.Location = new Point(15, 170);
            btn_D1.Location = new Point(15, 207);
            btn_A2.Location = new Point(15, 93);
            btn_B2.Location = new Point(15, 132);
            btn_C2.Location = new Point(15, 170);
            btn_D2.Location = new Point(15, 207);
            btn_A3.Location = new Point(15, 93);
            btn_B3.Location = new Point(15, 132);
            btn_C3.Location = new Point(15, 170);
            btn_D3.Location = new Point(15, 207);
            btn_A4.Location = new Point(15, 93);
            btn_B4.Location = new Point(15, 132);
            btn_C4.Location = new Point(15, 170);
            btn_D4.Location = new Point(15, 207);
            btn_A5.Location = new Point(15, 93);
            btn_B5.Location = new Point(15, 132);
            btn_C5.Location = new Point(15, 170);
            btn_D5.Location = new Point(15, 207);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            timerNum--;

            if (timerNum == timerTime)
            {
                timer.Enabled = false;
                timerNotChoosenOption();
            }
            lbl_time.Text = "Süre : " + timerNum.ToString();
        }
        void timerNotChoosenOption()
        {
            if (pic1Cont == false)
                Operation.obj.islemSec("Pass", "A1", 0, islem, level);
            if (pic2Cont == false)
                Operation.obj.islemSec("Pass", "A2", 0, islem, level);
            if (pic3Cont == false)
                Operation.obj.islemSec("Pass", "A3", 0, islem, level);
            if (pic4Cont == false)
                Operation.obj.islemSec("Pass", "A4", 0, islem, level);
            if (pic5Cont == false)
                Operation.obj.islemSec("Pass", "A5", 0, islem, level);
            pic1Cont = true;
            pic2Cont = true;
            pic3Cont = true;
            pic4Cont = true;
            pic5Cont = true;
        }
        void timerControl(){
            if (level == 1)
            {
                timerNum = 40;
            }
            else if (level == 2)
            {
                timerNum = 60;
            }
            else if (level == 3)
            {
                timerNum = 80;
            }
            else if (level == 4)
            {
                timerNum = 100;
            }
            else if (level == 5)
            {
                timerNum = 120;
            }
        }
        private void btn_nextLevel_Click(object sender, EventArgs e)
        {
            if (level < 5 && pic1Cont == true && pic2Cont == true && pic3Cont == true && pic4Cont == true && pic5Cont == true)
            {
                level++;
                Operation.obj.chooseIslem(islem, level);
                timerControl();
                timer.Enabled = true;
                lbl_level.Text="Seviye : "+level.ToString();
                for (int i = 0; i < buttons.Length; i++)
                    buttons[i].Image = null;
                pic1Cont = false;
                pic2Cont = false;
                pic3Cont = false;
                pic4Cont = false;
                pic5Cont = false;
                pass = false;
                passEnable = false;
                btn_pas1.BackColor = Color.White;
                btn_pas2.BackColor = Color.White;
                btn_pas3.BackColor = Color.White;
                btn_pas4.BackColor = Color.White;
                btn_pas5.BackColor = Color.White;
            }
        }
        public void startGame()
        {
            timerControl();
            timer.Enabled = true;
            level++;
            Operation.obj.chooseIslem(islem, level);
        }
        private void btn_A1_Click(object sender, EventArgs e)
        {
            if (pic1Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("A", "A1", 0, islem);
                else
                    Operation.obj.islemSec("A", "A1", 0, islem, level);
                pic1Cont = true;
            }
        }
        private void btn_B1_Click(object sender, EventArgs e)
        {
            if (pic1Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("B", "B1", 1, islem);
                else
                    Operation.obj.islemSec("B", "B1", 1, islem, level);
                pic1Cont = true;
            }
        }
        private void btn_C1_Click(object sender, EventArgs e)
        {
            if (pic1Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("C", "C1", 2, islem);
                else
                    Operation.obj.islemSec("C", "C1", 2, islem, level);
                pic1Cont = true;
            }
        }
        private void btn_D1_Click(object sender, EventArgs e)
        {
            if (pic1Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("D", "D1", 3, islem);
                else
                    Operation.obj.islemSec("D", "D1", 3, islem, level);
                pic1Cont = true;
            }
        }
        private void btn_A2_Click(object sender, EventArgs e)
        {
            if (pic2Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("A", "A2", 0, islem);
                else
                    Operation.obj.islemSec("A", "A2", 0, islem, level);
                pic2Cont = true;
            }
        }
        private void btn_B2_Click(object sender, EventArgs e)
        {
            if (pic2Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("B", "B2", 1, islem);
                else
                    Operation.obj.islemSec("B", "B2", 1, islem, level);
                pic2Cont = true;
            }
        }
        private void btn_C2_Click(object sender, EventArgs e)
        {
            if (pic2Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("C", "C2", 2, islem);
                else
                    Operation.obj.islemSec("C", "C2", 2, islem, level);
                pic2Cont = true;
            }
        }
        private void btn_D2_Click(object sender, EventArgs e)
        {
            if (pic2Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("D", "D2", 3, islem);
                else
                    Operation.obj.islemSec("D", "D2", 3, islem, level);
                pic2Cont = true;
            }
        }
        private void btn_A3_Click(object sender, EventArgs e)
        {
            if (pic3Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("A", "A3", 0, islem);
                else
                    Operation.obj.islemSec("A", "A3", 0, islem, level);
                pic3Cont = true;
            }
        }
        private void btn_B3_Click(object sender, EventArgs e)
        {
            if (pic3Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("B", "B3", 1, islem);
                else
                    Operation.obj.islemSec("B", "B3", 1, islem, level);
                pic3Cont = true;
            }
        }
        private void btn_C3_Click(object sender, EventArgs e)
        {
            if (pic3Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("C", "C3", 2, islem);
                else
                    Operation.obj.islemSec("C", "C3", 2, islem, level);
                pic3Cont = true;
            }
        }
        private void btn_D3_Click(object sender, EventArgs e)
        {
            if (pic3Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("D", "D3", 3, islem);
                else
                    Operation.obj.islemSec("D", "D3", 3, islem, level);
                pic3Cont = true;
            }
        }
        private void btn_A4_Click(object sender, EventArgs e)
        {
            if (pic4Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("A", "A4", 0, islem);
                else
                    Operation.obj.islemSec("A", "A4", 0, islem, level);
                pic4Cont = true;
            }
        }
        private void btn_B4_Click(object sender, EventArgs e)
        {
            if (pic4Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("B", "B4", 1, islem);
                else
                    Operation.obj.islemSec("B", "B4", 1, islem, level);
                pic4Cont = true;
            }
        }     

        private void btn_C4_Click(object sender, EventArgs e)
        {
            if (pic4Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("C", "C4", 2, islem);
                else
                    Operation.obj.islemSec("C", "C4", 2, islem, level);
                pic4Cont = true;
            }
        }
        private void btn_D4_Click(object sender, EventArgs e)
        {
            if (pic4Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("D", "D4", 3, islem);
                else
                    Operation.obj.islemSec("D", "D4", 3, islem, level);
                pic4Cont = true;
            }
        }
        private void btn_A5_Click(object sender, EventArgs e)
        {
            if (pic5Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("A", "A5", 0, islem);
                else
                    Operation.obj.islemSec("A", "A5", 0, islem, level);
                pic5Cont = true;
            }
        }

        private void btn_B5_Click(object sender, EventArgs e)
        {
            if (pic5Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("B", "B5", 1, islem);
                else
                    Operation.obj.islemSec("B", "B5", 1, islem, level);
                pic5Cont = true;
            }
        }

        private void btn_C5_Click(object sender, EventArgs e)
        {
            if (pic5Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("C", "C5", 2, islem);
                else
                    Operation.obj.islemSec("C", "C5", 2, islem, level);
                pic5Cont = true;
            }
        }

        private void btn_D5_Click(object sender, EventArgs e)
        {
            if (pic5Cont == false)
            {
                if (pass == true)
                    Operation.obj.islemPassSec("D", "D5", 0, islem);
                else
                    Operation.obj.islemSec("D", "D5", 0, islem, level);
                pic5Cont = true;
            }
        }

        private void btn_pas5_Click(object sender, EventArgs e)
        {
            if (pic5Cont == false)
            {
                btn_pas5.BackColor = Color.LightCoral;
                if (level == 1)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(1);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A1", 0, islem, level);
                if (level == 2)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(1);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A1", 0, islem, level);
                if (level == 3)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(1);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A1", 0, islem, level);
                if (level == 4)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(1);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A1", 0, islem, level);
                if (level == 5)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(1);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A1", 0, islem, level);
                pic5Cont = true;
            }
        }
        private void btn_pas1_Click(object sender, EventArgs e)
        {
            if (pic1Cont == false)
            {
                btn_pas1.BackColor = Color.LightCoral;
                if (level == 1)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(1);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A1", 0, islem, level);
                if (level == 2)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(1);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A1", 0, islem, level);
                if (level == 3)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(1);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A1", 0, islem, level);
                if (level == 4)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(1);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A1", 0, islem, level);
                if (level == 5)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(1);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A1", 0, islem, level);
                pic1Cont = true;
            }
        }
        private void btn_pas2_Click(object sender, EventArgs e)
        {
            if (pic2Cont == false)
            {
                btn_pas2.BackColor = Color.LightCoral;
                if (level == 1)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(1);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A2", 0, islem, level);
                if (level == 2)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(5);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A2", 0, islem, level);
                if (level == 3)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(9);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A2", 0, islem, level);
                if (level == 4)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(13);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A2", 0, islem, level);
                if (level == 5)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(17);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A2", 0, islem, level);
                pic2Cont = true;
            }
        }
        private void btn_pas3_Click(object sender, EventArgs e)
        {
            if (pic3Cont == false)
            {
                btn_pas3.BackColor = Color.LightCoral;
                if (level == 1)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(2);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A3", 0, islem, level);
                if (level == 2)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(6);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A3", 0, islem, level);
                if (level == 3)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(10);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A3", 0, islem, level);
                if (level == 4)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(14);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A3", 0, islem, level);
                if (level == 5)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(18);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A3", 0, islem, level);
                pic3Cont = true;
            }
        }
        private void btn_pas4_Click(object sender, EventArgs e)
        {
            if (pic4Cont == false)
            {
                btn_pas4.BackColor = Color.LightCoral;
                if (level == 1)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(3);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A4", 0, islem, level);
                if (level == 2)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(7);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A4", 0, islem, level);
                if (level == 3)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(11);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A4", 0, islem, level);
                if (level == 4)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(15);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A4", 0, islem, level);
                if (level == 5)
                    if (passEnable == false)
                    {
                        Operation.obj.controlPass(19);
                        passEnable = true;
                    }
                    else
                        Operation.obj.islemSec("Pass", "A4", 0, islem, level);
                pic4Cont = true;
            }
        }
        private void btn_ChoosenPass_Click(object sender, EventArgs e)
        {
            Operation.obj.choosePassIslem(islem);
            for (int i = 0; i < 4; i++)
            {
                listBox1.Items.Add(Operation.obj.imageIndex[i]);
            }
            lbl_level.Text = "Pas Seçilen Sorular";
            lbl_level.Location = new Point(256, 16);
            for (int i = 0; i < buttons.Length; i++)
                buttons[i].Image = null;
            pic1Cont = false;
            pic2Cont = false;
            pic3Cont = false;
            pic4Cont = false;
            pic5Cont = false;
            btn_pas1.Visible = false;
            btn_pas2.Visible = false;
            btn_pas3.Visible = false;
            btn_pas4.Visible = false;
            btn_pas5.Visible = false;
            pass = true;
            passEnable = false;
        }

    }
}
