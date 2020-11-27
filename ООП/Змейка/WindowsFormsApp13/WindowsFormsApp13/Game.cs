using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp13
{
    class Game
    {
        Snake my_snake = new Snake(Color.Green);
        Block block = new Block(Color.Aquamarine);
        Food my_food = new Food(Color.Yellow);

        int count = 0;//счет игры
        int l = 50; //масштаб  обьектов игры
        Color pole = Color.Chartreuse;//цвет поля
        PictureBox myPb;//Область рисования

        public Game(PictureBox n_myPb)
        {
            myPb = n_myPb;//сонединяем область рисования,
            //которая перадается с формы
            LoadLevel(1);
        }

        public void LoadLevel(int level)
        {
            //StreamReader sr = new StreamReader("1.txt");
            StreamReader sr = new StreamReader(level.ToString() + ".txt");
            int strY = 0;
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                for (int i=0; i<s.Length; i++)
                {
                    if (s[i] == '*')
                    {
                        block.Add(new MyPoint(i, strY));
                    }
                    else if (s[i] == '$')
                    {
                        my_snake.Add(new MyPoint(i, strY));
                    }
                  
                }
                strY++;
            }
            sr.Close();
            my_food.Add(my_food.RandomFoodPoint(l-1, l-1));
            my_food.Add(my_food.RandomFoodPoint(l-1, l-1));

        }

        public void Show()//перерисовка состояния игры
        {
            int k = myPb.Width / l;
            Graphics gr = Graphics.FromImage(myPb.Image);
            
            SolidBrush cl = new SolidBrush(pole);
            gr.FillRectangle(cl, 0, 0, myPb.Width, myPb.Height);

            SolidBrush color_snake = new SolidBrush(my_snake.myColor);//получаем цвет змейки
            for (int i=0; i<my_snake.body.Count; i++)
            {
                int x = my_snake.body[i].x;
                int y = my_snake.body[i].y;

                if (i == 0)
                {
                    SolidBrush bl = new SolidBrush(Color.Black);
                    gr.FillRectangle(bl, x * k, y * k, k, k);
                }
                else {
                    gr.FillRectangle(color_snake, x * k, y * k, k, k);
                }

            }
            SolidBrush color_block= new SolidBrush(block.myColor);
            for (int i = 0; i < block.body.Count; i++)
            {
                int x = block.body[i].x;
                int y = block.body[i].y;
                gr.FillRectangle(color_block, x * k, y * k, k, k);
            }

            SolidBrush color_food = new SolidBrush(my_food.myColor);
            
            for (int i = 0; i < my_food.body.Count; i++)
            {
                int x = my_food.body[i].x;
                int y = my_food.body[i].y;
                gr.FillRectangle(color_food, x * k, y * k, k, k);
            }

            myPb.Refresh();
        }
        public bool Move(int key)
        {
            bool a = true;
            if (key == 1)
            {
                my_snake.Move(0, -1);
            }
            if (key == 2)
            {
                my_snake.Move(0, 1);
            }
            if (key == 3)
            {
                my_snake.Move(1, 0);
            }
            if (key == 4)
            {
                my_snake.Move(-1, 0);
            }
            Show();
            return a;
        }
    }
}
