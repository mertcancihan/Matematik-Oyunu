using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Oyunu
{
    class Operation
    {
        public static Operation obj = new Operation();
        int indexIslem,indexNum = 0, score = 0;
        public int[] imageIndex = new int[5];
        int[] levelIndex = new int[5];

        Image[] plusArray = new Image[100];
        Image[] minusArray = new Image[100];
        Image[] divideArray = new Image[100];
        Image[] crossArray = new Image[100];
        Image[] redImage = new Image[4];
        Image[] greenImage = new Image[4];

        public void runMethods()
        {
            gettingImages();
            setRightChoose();
        }
        public void setScore(int getScore)
        {
            score = getScore;
        }
        public int getScore()
        {
            return score;
        }
        void writeScore()
        {
            setScore(getScore() + 10);
            Game.obj.lbl_score.Text = "Skor : " + getScore().ToString();
        }
        public void chooseIslem(int islem, int level)//settingImages methodunu besliyor
        {            
            if (islem == 1)            
                settingImages(level, plusArray);            
            if (islem == 2)            
                settingImages(level, minusArray);            
            if (islem == 3)            
                settingImages(level, divideArray);            
            if (islem == 4)            
                settingImages(level, crossArray);            
        }
        public void islemSec(string choosenOption, string howPic, int btn_num, int islem, int level)//rigthChoose methodunu besliyor
        {
            if (islem == 1)            
                rightChoose(choosenOption, howPic, level, btn_num, plusArray);            
            if (islem == 2)            
                rightChoose(choosenOption, howPic, level, btn_num, minusArray);            
            if (islem == 3)            
                rightChoose(choosenOption, howPic, level, btn_num, divideArray);            
            if (islem == 4)            
                rightChoose(choosenOption, howPic, level, btn_num, crossArray);            
        }               
        public void settingImages(int level, Image[] choosenIslem) // seviyelere göre soruları getiriyor
        {
            if (level == 1)            
                for (int i = 0; i < Game.obj.picBoxExamArray.Length; i++)              
                    Game.obj.picBoxExamArray[i].Image = choosenIslem[i];             
            
            else if (level == 2)            
                for (int i = 0; i < Game.obj.picBoxExamArray.Length; i++)                
                    Game.obj.picBoxExamArray[i].Image = choosenIslem[i + 5];                
            
            else if (level == 3)            
                for (int i = 0; i < Game.obj.picBoxExamArray.Length; i++)                
                    Game.obj.picBoxExamArray[i].Image = choosenIslem[i + 10];                
            
            else if (level == 4)            
                for (int i = 0; i < Game.obj.picBoxExamArray.Length; i++)                
                    Game.obj.picBoxExamArray[i].Image = choosenIslem[i + 15];                
            
            else if (level == 5)            
                for (int i = 0; i < Game.obj.picBoxExamArray.Length; i++)                
                    Game.obj.picBoxExamArray[i].Image = choosenIslem[i + 20];    
        }
        private void rightChoose(string choosenOption, string howPic, int getLevel, int btn_num, Image[] choosenIslem)//doğru şık mı kontrol yapıyor
        { //but_num A=0, B=1, C=2, D=3

            if (howPic == "A1" || howPic == "B1" || howPic == "C1" || howPic == "D1")
            {
                if (getLevel == 1)
                    indexIslem = 0;
                if (getLevel == 2)
                    indexIslem = 5;
                if (getLevel == 3)
                    indexIslem = 10;
                if (getLevel == 4)
                    indexIslem = 15;
                if (getLevel == 5)
                    indexIslem = 20;

                if (choosenOption == choosenIslem[indexIslem].Tag.ToString())
                {
                    Game.obj.buttons[btn_num].Image = greenImage[btn_num];
                    writeScore();
                }
                else
                {
                    Game.obj.buttons[btn_num].Image = redImage[btn_num];
                    if (choosenIslem[indexIslem].Tag.ToString() == "A")
                    {
                        Game.obj.buttons[0].Image = greenImage[0];
                    }
                    else if (choosenIslem[indexIslem].Tag.ToString() == "B")
                    {
                        Game.obj.buttons[1].Image = greenImage[1];
                    }
                    else if (choosenIslem[indexIslem].Tag.ToString() == "C")
                    {
                        Game.obj.buttons[2].Image = greenImage[2];
                    }
                    else if (choosenIslem[indexIslem].Tag.ToString() == "D")
                    {
                        Game.obj.buttons[3].Image = greenImage[3];
                    }
                }
            }
            if (howPic == "A2" || howPic == "B2" || howPic == "C2" || howPic == "D2")
            {
                if (getLevel == 1)
                    indexIslem = 1;
                if (getLevel == 2)
                    indexIslem = 6;
                if (getLevel == 3)
                    indexIslem = 11;
                if (getLevel == 4)
                    indexIslem = 16;
                if (getLevel == 5)
                    indexIslem = 21;

                if (choosenOption == choosenIslem[indexIslem].Tag.ToString())
                {
                    Game.obj.buttons[btn_num + 4].Image = greenImage[btn_num];
                    writeScore();
                }
                else
                {
                    Game.obj.buttons[btn_num + 4].Image = redImage[btn_num];
                    if (choosenIslem[indexIslem].Tag.ToString() == "A")
                    {
                        Game.obj.buttons[4].Image = greenImage[0];
                    }
                    else if (choosenIslem[indexIslem].Tag.ToString() == "B")
                    {
                        Game.obj.buttons[5].Image = greenImage[1];
                    }
                    else if (choosenIslem[indexIslem].Tag.ToString() == "C")
                    {
                        Game.obj.buttons[6].Image = greenImage[2];
                    }
                    else if (choosenIslem[indexIslem].Tag.ToString() == "D")
                    {
                        Game.obj.buttons[7].Image = greenImage[3];
                    }
                }
            }
            if (howPic == "A3" || howPic == "B3" || howPic == "C3" || howPic == "D3")
            {
                if (getLevel == 1)
                    indexIslem = 2;
                if (getLevel == 2)
                    indexIslem = 7;
                if (getLevel == 3)
                    indexIslem = 12;
                if (getLevel == 4)
                    indexIslem = 17;
                if (getLevel == 5)
                    indexIslem = 22;

                if (choosenOption == choosenIslem[indexIslem].Tag.ToString())
                {
                    Game.obj.buttons[btn_num + 8].Image = greenImage[btn_num];
                    writeScore();
                }
                else
                {
                    Game.obj.buttons[btn_num + 8].Image = redImage[btn_num];
                    if (choosenIslem[indexIslem].Tag.ToString() == "A")
                    {
                        Game.obj.buttons[8].Image = greenImage[0];
                    }
                    else if (choosenIslem[indexIslem].Tag.ToString() == "B")
                    {
                        Game.obj.buttons[9].Image = greenImage[1];
                    }
                    else if (choosenIslem[indexIslem].Tag.ToString() == "C")
                    {
                        Game.obj.buttons[10].Image = greenImage[2];
                    }
                    else if (choosenIslem[indexIslem].Tag.ToString() == "D")
                    {
                        Game.obj.buttons[11].Image = greenImage[3];
                    }
                }
            }
            if (howPic == "A4" || howPic == "B4" || howPic == "C4" || howPic == "D4")
            {
                if (getLevel == 1)
                    indexIslem = 3;
                if (getLevel == 2)
                    indexIslem = 8;
                if (getLevel == 3)
                    indexIslem = 13;
                if (getLevel == 4)
                    indexIslem = 18;
                if (getLevel == 5)
                    indexIslem = 23;

                if (choosenOption == choosenIslem[indexIslem].Tag.ToString())
                {
                    Game.obj.buttons[btn_num + 12].Image = greenImage[btn_num];
                    writeScore();
                }
                else
                {
                    Game.obj.buttons[btn_num + 12].Image = redImage[btn_num];
                    if (choosenIslem[indexIslem].Tag.ToString() == "A")
                    {
                        Game.obj.buttons[12].Image = greenImage[0];
                    }
                    else if (choosenIslem[indexIslem].Tag.ToString() == "B")
                    {
                        Game.obj.buttons[13].Image = greenImage[1];
                    }
                    else if (choosenIslem[indexIslem].Tag.ToString() == "C")
                    {
                        Game.obj.buttons[14].Image = greenImage[2];
                    }
                    else if (choosenIslem[indexIslem].Tag.ToString() == "D")
                    {
                        Game.obj.buttons[15].Image = greenImage[3];
                    }
                }
            }
            if (howPic == "A5" || howPic == "B5" || howPic == "C5" || howPic == "D5")
            {
                if (getLevel == 1)
                    indexIslem = 4;
                if (getLevel == 2)
                    indexIslem = 9;
                if (getLevel == 3)
                    indexIslem = 14;
                if (getLevel == 4)
                    indexIslem = 19;
                if (getLevel == 5)
                    indexIslem = 24;

                if (choosenOption == choosenIslem[indexIslem].Tag.ToString())
                {
                    Game.obj.buttons[btn_num + 16].Image = greenImage[btn_num];
                    writeScore();
                }
                else
                {
                    Game.obj.buttons[btn_num + 16].Image = redImage[btn_num];
                    if (choosenIslem[indexIslem].Tag.ToString() == "A")
                    {
                        Game.obj.buttons[16].Image = greenImage[0];
                    }
                    else if (choosenIslem[indexIslem].Tag.ToString() == "B")
                    {
                        Game.obj.buttons[17].Image = greenImage[1];
                    }
                    else if (choosenIslem[indexIslem].Tag.ToString() == "C")
                    {
                        Game.obj.buttons[18].Image = greenImage[2];
                    }
                    else if (choosenIslem[indexIslem].Tag.ToString() == "D")
                    {
                        Game.obj.buttons[19].Image = greenImage[3];
                    }
                }
            }
        }
        public void choosePassIslem(int islem)//settingPassImages methodunu besliyor
        {
            if (islem == 1)
                settingPassImages( imageIndex,  plusArray);
            if (islem == 2)
                settingPassImages( imageIndex,  minusArray);
            if (islem == 3)
                settingPassImages( imageIndex,  divideArray);
            if (islem == 4)
                settingPassImages( imageIndex,  crossArray);
        }        
        public void settingPassImages(int[] imageIndex ,Image[] choosenIslem)
        {
            for (int i = 0; i < Game.obj.picBoxExamArray.Length; i++)
            {
                Game.obj.picBoxExamArray[i].Visible = false;
            }
            for (int i = 0; i < indexNum; i++)
            {
                if (i == 0)
                {
                    Game.obj.picBoxExamArray[i].Image = choosenIslem[imageIndex[i]];
                    Game.obj.picBoxExamArray[i].Visible = true;
                }
                if (i == 1)
                {
                    Game.obj.picBoxExamArray[i].Image = choosenIslem[imageIndex[i]];
                    Game.obj.picBoxExamArray[i].Visible = true;
                }
                if (i == 2)
                {
                    Game.obj.picBoxExamArray[i].Image = choosenIslem[imageIndex[i]];
                    Game.obj.picBoxExamArray[i].Visible = true;
                }
                if (i == 3)
                {
                    Game.obj.picBoxExamArray[i].Image = choosenIslem[imageIndex[i]];
                    Game.obj.picBoxExamArray[i].Visible = true;
                }
            }
        }
        public void islemPassSec(string choosenOption, string howPic, int btn_num, int islem)//rigthPassChoose methodunu besliyor
        {
            if (islem == 1)
                rightPassChoose(choosenOption, howPic, btn_num, imageIndex, plusArray);
            if (islem == 2)
                rightPassChoose(choosenOption, howPic, btn_num, imageIndex, minusArray);
            if (islem == 3)
                rightPassChoose(choosenOption, howPic, btn_num, imageIndex, divideArray);
            if (islem == 4)
                rightPassChoose(choosenOption, howPic, btn_num, imageIndex, crossArray);
        }
        private void rightPassChoose(string choosenOption, string howPic, int btn_num, int[] imageIndex, Image[] choosenIslem)//Pass doğru şık mı kontrol yapıyor
        { //but_num A=0, B=1, C=2, D=3

            if (howPic == "A1" || howPic == "B1" || howPic == "C1" || howPic == "D1")
            {             
                if (choosenOption == choosenIslem[imageIndex[0]].Tag.ToString())
                {
                    Game.obj.buttons[btn_num].Image = greenImage[btn_num];
                }
                else
                {
                    Game.obj.buttons[btn_num].Image = redImage[btn_num];
                    if (choosenIslem[imageIndex[0]].Tag.ToString() == "A")
                    {
                        Game.obj.buttons[0].Image = greenImage[0];
                    }
                    else if (choosenIslem[imageIndex[0]].Tag.ToString() == "B")
                    {
                        Game.obj.buttons[1].Image = greenImage[1];
                    }
                    else if (choosenIslem[imageIndex[0]].Tag.ToString() == "C")
                    {
                        Game.obj.buttons[2].Image = greenImage[2];
                    }
                    else if (choosenIslem[imageIndex[0]].Tag.ToString() == "D")
                    {
                        Game.obj.buttons[3].Image = greenImage[3];
                    }
                }
            }
            if (howPic == "A2" || howPic == "B2" || howPic == "C2" || howPic == "D2")
            {

                if (choosenOption == choosenIslem[imageIndex[1]].Tag.ToString())
                {
                    Game.obj.buttons[btn_num + 4].Image = greenImage[btn_num];
                }
                else
                {
                    Game.obj.buttons[btn_num + 4].Image = redImage[btn_num];
                    if (choosenIslem[imageIndex[1]].Tag.ToString() == "A")
                    {
                        Game.obj.buttons[4].Image = greenImage[0];
                    }
                    else if (choosenIslem[imageIndex[1]].Tag.ToString() == "B")
                    {
                        Game.obj.buttons[5].Image = greenImage[1];
                    }
                    else if (choosenIslem[imageIndex[1]].Tag.ToString() == "C")
                    {
                        Game.obj.buttons[6].Image = greenImage[2];
                    }
                    else if (choosenIslem[imageIndex[1]].Tag.ToString() == "D")
                    {
                        Game.obj.buttons[7].Image = greenImage[3];
                    }
                }
            }
            if (howPic == "A3" || howPic == "B3" || howPic == "C3" || howPic == "D3")
            {

                if (choosenOption == choosenIslem[imageIndex[2]].Tag.ToString())
                {
                    Game.obj.buttons[btn_num + 8].Image = greenImage[btn_num];
                }
                else
                {
                    Game.obj.buttons[btn_num + 8].Image = redImage[btn_num];
                    if (choosenIslem[imageIndex[2]].Tag.ToString() == "A")
                    {
                        Game.obj.buttons[8].Image = greenImage[0];
                    }
                    else if (choosenIslem[imageIndex[2]].Tag.ToString() == "B")
                    {
                        Game.obj.buttons[9].Image = greenImage[1];
                    }
                    else if (choosenIslem[imageIndex[2]].Tag.ToString() == "C")
                    {
                        Game.obj.buttons[10].Image = greenImage[2];
                    }
                    else if (choosenIslem[imageIndex[2]].Tag.ToString() == "D")
                    {
                        Game.obj.buttons[11].Image = greenImage[3];
                    }
                }
            }
            if (howPic == "A4" || howPic == "B4" || howPic == "C4" || howPic == "D4")
            {
                if (choosenOption == choosenIslem[imageIndex[3]].Tag.ToString())
                {
                    Game.obj.buttons[btn_num + 12].Image = greenImage[btn_num];
                }
                else
                {
                    Game.obj.buttons[btn_num + 12].Image = redImage[btn_num];
                    if (choosenIslem[imageIndex[3]].Tag.ToString() == "A")
                    {
                        Game.obj.buttons[12].Image = greenImage[0];
                    }
                    else if (choosenIslem[imageIndex[3]].Tag.ToString() == "B")
                    {
                        Game.obj.buttons[13].Image = greenImage[1];
                    }
                    else if (choosenIslem[imageIndex[3]].Tag.ToString() == "C")
                    {
                        Game.obj.buttons[14].Image = greenImage[2];
                    }
                    else if (choosenIslem[imageIndex[3]].Tag.ToString() == "D")
                    {
                        Game.obj.buttons[15].Image = greenImage[3];
                    }
                }
            }
            if (howPic == "A5" || howPic == "B5" || howPic == "C5" || howPic == "D5")
            {
                if (choosenOption == choosenIslem[indexIslem].Tag.ToString())
                {
                    Game.obj.buttons[btn_num + 16].Image = greenImage[btn_num];
                    writeScore();
                }
                else
                {
                    Game.obj.buttons[btn_num + 16].Image = redImage[btn_num];
                    if (choosenIslem[indexIslem].Tag.ToString() == "A")
                    {
                        Game.obj.buttons[16].Image = greenImage[0];
                    }
                    else if (choosenIslem[indexIslem].Tag.ToString() == "B")
                    {
                        Game.obj.buttons[17].Image = greenImage[1];
                    }
                    else if (choosenIslem[indexIslem].Tag.ToString() == "C")
                    {
                        Game.obj.buttons[18].Image = greenImage[2];
                    }
                    else if (choosenIslem[indexIslem].Tag.ToString() == "D")
                    {
                        Game.obj.buttons[19].Image = greenImage[3];
                    }
                }
            }

        }
        public void controlPass(int indexImage)
        {
            imageIndex[indexNum] = indexImage;

            //2.pas kontrolü burada yap, level atlayınca kontrolü sıfırlar image indexe yazarsın

            indexNum++;
        }
        public void gettingImages()
        {
            for (int i = 0; i < plusArray.Length; i++)
            {
                plusArray[i] = Image.FromFile(@"picture/plus/" + i + ".png");
            }
            for (int i = 0; i < minusArray.Length; i++)
            {
                minusArray[i] = Image.FromFile(@"picture/minus/" + i + ".png");
            }
            for (int i = 0; i < crossArray.Length; i++)
            {
                crossArray[i] = Image.FromFile(@"picture/cross/" + i + ".png");
            }
            for (int i = 0; i < divideArray.Length; i++)
            {
                divideArray[i] = Image.FromFile(@"picture/divided/" + i + ".png");
            }
            for (int i = 0; i < redImage.Length; i++)
            {
                redImage[i] = Image.FromFile(@"picture/redGreen/red" + i + ".png");
            }
            for (int i = 0; i < greenImage.Length; i++)
            {
                greenImage[i] = Image.FromFile(@"picture/redGreen/green" + i + ".png");
            }
        }
        void setRightChoose()
        {
            plusArray[0].Tag = "A";
            plusArray[1].Tag = "B";
            plusArray[2].Tag = "C";
            plusArray[3].Tag = "A";
            plusArray[4].Tag = "D";
            plusArray[5].Tag = "C";
            plusArray[6].Tag = "A";
            plusArray[7].Tag = "B";
            plusArray[8].Tag = "D";
            plusArray[9].Tag = "A";
            plusArray[10].Tag = "B";
            plusArray[11].Tag = "B";
            plusArray[12].Tag = "D";
            plusArray[13].Tag = "C";
            plusArray[14].Tag = "D";
            plusArray[15].Tag = "A";
            plusArray[16].Tag = "A";
            plusArray[17].Tag = "D";
            plusArray[18].Tag = "A";
            plusArray[19].Tag = "D";
            plusArray[20].Tag = "A";
            plusArray[21].Tag = "C";
            plusArray[22].Tag = "B";
            plusArray[23].Tag = "C";
            plusArray[24].Tag = "D";
            plusArray[25].Tag = "A";
            plusArray[26].Tag = "C";
            plusArray[27].Tag = "B";
            plusArray[28].Tag = "A";
            plusArray[29].Tag = "D";
            plusArray[30].Tag = "C";
            plusArray[31].Tag = "B";
            plusArray[32].Tag = "B";
            plusArray[33].Tag = "C";
            plusArray[34].Tag = "D";
            plusArray[35].Tag = "A";
            plusArray[36].Tag = "D";
            plusArray[37].Tag = "D";
            plusArray[38].Tag = "C";
            plusArray[39].Tag = "C";
            plusArray[40].Tag = "A";
            plusArray[41].Tag = "D";
            plusArray[42].Tag = "C";
            plusArray[43].Tag = "B";
            plusArray[44].Tag = "B";
            plusArray[45].Tag = "C";
            plusArray[46].Tag = "D";
            plusArray[47].Tag = "A";
            plusArray[48].Tag = "C";
            plusArray[49].Tag = "C";
            plusArray[50].Tag = "D";
            plusArray[51].Tag = "B";
            plusArray[52].Tag = "B";
            plusArray[53].Tag = "D";
            plusArray[54].Tag = "A";
            plusArray[55].Tag = "C";
            plusArray[56].Tag = "D";
            plusArray[57].Tag = "B";
            plusArray[58].Tag = "A";
            plusArray[59].Tag = "D";
            plusArray[60].Tag = "A";
            plusArray[61].Tag = "B";
            plusArray[62].Tag = "D";
            plusArray[63].Tag = "C";
            plusArray[64].Tag = "C";
            plusArray[65].Tag = "A";
            plusArray[66].Tag = "A";
            plusArray[67].Tag = "D";
            plusArray[68].Tag = "B";
            plusArray[69].Tag = "C";
            plusArray[70].Tag = "B";
            plusArray[71].Tag = "B";
            plusArray[72].Tag = "A";
            plusArray[73].Tag = "D";
            plusArray[74].Tag = "D";
            plusArray[75].Tag = "C";
            plusArray[76].Tag = "B";
            plusArray[77].Tag = "A";
            plusArray[78].Tag = "D";
            plusArray[79].Tag = "C";
            plusArray[80].Tag = "A";
            plusArray[81].Tag = "D";
            plusArray[82].Tag = "C";
            plusArray[83].Tag = "A";
            plusArray[84].Tag = "D";
            plusArray[85].Tag = "C";
            plusArray[86].Tag = "B";
            plusArray[87].Tag = "D";
            plusArray[88].Tag = "C";
            plusArray[89].Tag = "A";
            plusArray[90].Tag = "C";
            plusArray[91].Tag = "B";
            plusArray[92].Tag = "C";
            plusArray[93].Tag = "A";
            plusArray[94].Tag = "D";
            plusArray[95].Tag = "B";
            plusArray[96].Tag = "B";
            plusArray[97].Tag = "A";
            plusArray[98].Tag = "D";
            plusArray[99].Tag = "B";

            minusArray[0].Tag = "A";
            minusArray[1].Tag = "B";
            minusArray[2].Tag = "C";
            minusArray[3].Tag = "A";
            minusArray[4].Tag = "D";
            minusArray[5].Tag = "C";
            minusArray[6].Tag = "A";
            minusArray[7].Tag = "B";
            minusArray[8].Tag = "D";
            minusArray[9].Tag = "A";
            minusArray[10].Tag = "B";
            minusArray[11].Tag = "B";
            minusArray[12].Tag = "D";
            minusArray[13].Tag = "C";
            minusArray[14].Tag = "D";
            minusArray[15].Tag = "A";
            minusArray[16].Tag = "A";
            minusArray[17].Tag = "D";
            minusArray[18].Tag = "A";
            minusArray[19].Tag = "D";
            minusArray[20].Tag = "A";
            minusArray[21].Tag = "C";
            minusArray[22].Tag = "B";
            minusArray[23].Tag = "C";
            minusArray[24].Tag = "D";
            minusArray[25].Tag = "A";
            minusArray[26].Tag = "C";
            minusArray[27].Tag = "B";
            minusArray[28].Tag = "A";
            minusArray[29].Tag = "D";
            minusArray[30].Tag = "C";
            minusArray[31].Tag = "B";
            minusArray[32].Tag = "B";
            minusArray[33].Tag = "C";
            minusArray[34].Tag = "D";
            minusArray[35].Tag = "A";
            minusArray[36].Tag = "D";
            minusArray[37].Tag = "D";
            minusArray[38].Tag = "C";
            minusArray[39].Tag = "C";
            minusArray[40].Tag = "A";
            minusArray[41].Tag = "D";
            minusArray[42].Tag = "C";
            minusArray[43].Tag = "B";
            minusArray[44].Tag = "B";
            minusArray[45].Tag = "C";
            minusArray[46].Tag = "D";
            minusArray[47].Tag = "A";
            minusArray[48].Tag = "C";
            minusArray[49].Tag = "C";
            minusArray[50].Tag = "D";
            minusArray[51].Tag = "B";
            minusArray[52].Tag = "B";
            minusArray[53].Tag = "D";
            minusArray[54].Tag = "A";
            minusArray[55].Tag = "C";
            minusArray[56].Tag = "D";
            minusArray[57].Tag = "B";
            minusArray[58].Tag = "A";
            minusArray[59].Tag = "D";
            minusArray[60].Tag = "A";
            minusArray[61].Tag = "B";
            minusArray[62].Tag = "D";
            minusArray[63].Tag = "C";
            minusArray[64].Tag = "C";
            minusArray[65].Tag = "A";
            minusArray[66].Tag = "A";
            minusArray[67].Tag = "D";
            minusArray[68].Tag = "B";
            minusArray[69].Tag = "C";
            minusArray[70].Tag = "B";
            minusArray[71].Tag = "B";
            minusArray[72].Tag = "A";
            minusArray[73].Tag = "D";
            minusArray[74].Tag = "D";
            minusArray[75].Tag = "C";
            minusArray[76].Tag = "B";
            minusArray[77].Tag = "A";
            minusArray[78].Tag = "D";
            minusArray[79].Tag = "C";
            minusArray[80].Tag = "A";
            minusArray[81].Tag = "D";
            minusArray[82].Tag = "C";
            minusArray[83].Tag = "A";
            minusArray[84].Tag = "D";
            minusArray[85].Tag = "C";
            minusArray[86].Tag = "B";
            minusArray[87].Tag = "D";
            minusArray[88].Tag = "C";
            minusArray[89].Tag = "A";
            minusArray[90].Tag = "C";
            minusArray[91].Tag = "B";
            minusArray[92].Tag = "C";
            minusArray[93].Tag = "A";
            minusArray[94].Tag = "D";
            minusArray[95].Tag = "B";
            minusArray[96].Tag = "B";
            minusArray[97].Tag = "A";
            minusArray[98].Tag = "D";
            minusArray[99].Tag = "B";

            divideArray[0].Tag = "A";
            divideArray[1].Tag = "B";
            divideArray[2].Tag = "C";
            divideArray[3].Tag = "A";
            divideArray[4].Tag = "D";
            divideArray[5].Tag = "C";
            divideArray[6].Tag = "A";
            divideArray[7].Tag = "B";
            divideArray[8].Tag = "D";
            divideArray[9].Tag = "A";
            divideArray[10].Tag = "B";
            divideArray[11].Tag = "B";
            divideArray[12].Tag = "D";
            divideArray[13].Tag = "C";
            divideArray[14].Tag = "D";
            divideArray[15].Tag = "A";
            divideArray[16].Tag = "A";
            divideArray[17].Tag = "D";
            divideArray[18].Tag = "A";
            divideArray[19].Tag = "D";
            divideArray[20].Tag = "A";
            divideArray[21].Tag = "C";
            divideArray[22].Tag = "B";
            divideArray[23].Tag = "C";
            divideArray[24].Tag = "D";
            divideArray[25].Tag = "A";
            divideArray[26].Tag = "C";
            divideArray[27].Tag = "B";
            divideArray[28].Tag = "A";
            divideArray[29].Tag = "D";
            divideArray[30].Tag = "C";
            divideArray[31].Tag = "B";
            divideArray[32].Tag = "B";
            divideArray[33].Tag = "C";
            divideArray[34].Tag = "D";
            divideArray[35].Tag = "A";
            divideArray[36].Tag = "D";
            divideArray[37].Tag = "D";
            divideArray[38].Tag = "C";
            divideArray[39].Tag = "C";
            divideArray[40].Tag = "A";
            divideArray[41].Tag = "D";
            divideArray[42].Tag = "C";
            divideArray[43].Tag = "B";
            divideArray[44].Tag = "B";
            divideArray[45].Tag = "C";
            divideArray[46].Tag = "D";
            divideArray[47].Tag = "A";
            divideArray[48].Tag = "C";
            divideArray[49].Tag = "C";
            divideArray[50].Tag = "D";
            divideArray[51].Tag = "B";
            divideArray[52].Tag = "B";
            divideArray[53].Tag = "D";
            divideArray[54].Tag = "A";
            divideArray[55].Tag = "C";
            divideArray[56].Tag = "D";
            divideArray[57].Tag = "B";
            divideArray[58].Tag = "A";
            divideArray[59].Tag = "D";
            divideArray[60].Tag = "A";
            divideArray[61].Tag = "B";
            divideArray[62].Tag = "D";
            divideArray[63].Tag = "C";
            divideArray[64].Tag = "C";
            divideArray[65].Tag = "A";
            divideArray[66].Tag = "A";
            divideArray[67].Tag = "D";
            divideArray[68].Tag = "B";
            divideArray[69].Tag = "C";
            divideArray[70].Tag = "B";
            divideArray[71].Tag = "B";
            divideArray[72].Tag = "A";
            divideArray[73].Tag = "D";
            divideArray[74].Tag = "D";
            divideArray[75].Tag = "C";
            divideArray[76].Tag = "B";
            divideArray[77].Tag = "A";
            divideArray[78].Tag = "D";
            divideArray[79].Tag = "C";
            divideArray[80].Tag = "A";
            divideArray[81].Tag = "D";
            divideArray[82].Tag = "C";
            divideArray[83].Tag = "A";
            divideArray[84].Tag = "D";
            divideArray[85].Tag = "C";
            divideArray[86].Tag = "B";
            divideArray[87].Tag = "D";
            divideArray[88].Tag = "C";
            divideArray[89].Tag = "A";
            divideArray[90].Tag = "C";
            divideArray[91].Tag = "B";
            divideArray[92].Tag = "C";
            divideArray[93].Tag = "A";
            divideArray[94].Tag = "D";
            divideArray[95].Tag = "B";
            divideArray[96].Tag = "B";
            divideArray[97].Tag = "A";
            divideArray[98].Tag = "D";
            divideArray[99].Tag = "B";

            crossArray[0].Tag = "A";
            crossArray[1].Tag = "B";
            crossArray[2].Tag = "C";
            crossArray[3].Tag = "A";
            crossArray[4].Tag = "D";
            crossArray[5].Tag = "C";
            crossArray[6].Tag = "A";
            crossArray[7].Tag = "B";
            crossArray[8].Tag = "D";
            crossArray[9].Tag = "A";
            crossArray[10].Tag = "B";
            crossArray[11].Tag = "B";
            crossArray[12].Tag = "D";
            crossArray[13].Tag = "C";
            crossArray[14].Tag = "D";
            crossArray[15].Tag = "A";
            crossArray[16].Tag = "A";
            crossArray[17].Tag = "D";
            crossArray[18].Tag = "A";
            crossArray[19].Tag = "D";
            crossArray[20].Tag = "A";
            crossArray[21].Tag = "C";
            crossArray[22].Tag = "B";
            crossArray[23].Tag = "C";
            crossArray[24].Tag = "D";
            crossArray[25].Tag = "A";
            crossArray[26].Tag = "C";
            crossArray[27].Tag = "B";
            crossArray[28].Tag = "A";
            crossArray[29].Tag = "D";
            crossArray[30].Tag = "C";
            crossArray[31].Tag = "B";
            crossArray[32].Tag = "B";
            crossArray[33].Tag = "C";
            crossArray[34].Tag = "D";
            crossArray[35].Tag = "A";
            crossArray[36].Tag = "D";
            crossArray[37].Tag = "D";
            crossArray[38].Tag = "C";
            crossArray[39].Tag = "C";
            crossArray[40].Tag = "A";
            crossArray[41].Tag = "D";
            crossArray[42].Tag = "C";
            crossArray[43].Tag = "B";
            crossArray[44].Tag = "B";
            crossArray[45].Tag = "C";
            crossArray[46].Tag = "D";
            crossArray[47].Tag = "A";
            crossArray[48].Tag = "C";
            crossArray[49].Tag = "C";
            crossArray[50].Tag = "D";
            crossArray[51].Tag = "B";
            crossArray[52].Tag = "B";
            crossArray[53].Tag = "D";
            crossArray[54].Tag = "A";
            crossArray[55].Tag = "C";
            crossArray[56].Tag = "D";
            crossArray[57].Tag = "B";
            crossArray[58].Tag = "A";
            crossArray[59].Tag = "D";
            crossArray[60].Tag = "A";
            crossArray[61].Tag = "B";
            crossArray[62].Tag = "D";
            crossArray[63].Tag = "C";
            crossArray[64].Tag = "C";
            crossArray[65].Tag = "A";
            crossArray[66].Tag = "A";
            crossArray[67].Tag = "D";
            crossArray[68].Tag = "B";
            crossArray[69].Tag = "C";
            crossArray[70].Tag = "B";
            crossArray[71].Tag = "B";
            crossArray[72].Tag = "A";
            crossArray[73].Tag = "D";
            crossArray[74].Tag = "D";
            crossArray[75].Tag = "C";
            crossArray[76].Tag = "B";
            crossArray[77].Tag = "A";
            crossArray[78].Tag = "D";
            crossArray[79].Tag = "C";
            crossArray[80].Tag = "A";
            crossArray[81].Tag = "D";
            crossArray[82].Tag = "C";
            crossArray[83].Tag = "A";
            crossArray[84].Tag = "D";
            crossArray[85].Tag = "C";
            crossArray[86].Tag = "B";
            crossArray[87].Tag = "D";
            crossArray[88].Tag = "C";
            crossArray[89].Tag = "A";
            crossArray[90].Tag = "C";
            crossArray[91].Tag = "B";
            crossArray[92].Tag = "C";
            crossArray[93].Tag = "A";
            crossArray[94].Tag = "D";
            crossArray[95].Tag = "B";
            crossArray[96].Tag = "B";
            crossArray[97].Tag = "A";
            crossArray[98].Tag = "D";
            crossArray[99].Tag = "B";
        }
    }
}
