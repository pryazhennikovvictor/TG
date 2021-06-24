/*Пряженников Виктор
 * Группа: ВМК-19
 * Текстовий квест с визуализацией
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Textquest
{
    public partial class Cave : Form
    {
        TQclass current;
        
        //сцены k - 1 путь, l - 2 путь, m - 3 путь;       
        TQclass k = new TQclass();
        TQclass k1 = new TQclass();
        TQclass k2 = new TQclass();
        TQclass k3 = new TQclass();
        TQclass k4 = new TQclass();
        TQclass k5 = new TQclass();
        TQclass k6 = new TQclass();
        TQclass k7 = new TQclass();
        TQclass k8 = new TQclass();
        TQclass k9 = new TQclass();
        TQclass k10 = new TQclass();

        TQclass l1 = new TQclass();
        TQclass l2 = new TQclass();
        TQclass l3 = new TQclass();
        TQclass l4 = new TQclass();
        TQclass l5 = new TQclass();
        TQclass l6 = new TQclass();
        TQclass l7 = new TQclass();
        TQclass l8 = new TQclass();

        TQclass m1 = new TQclass();
        TQclass m2 = new TQclass();
        TQclass m3 = new TQclass();
        TQclass m4 = new TQclass();
        TQclass m5 = new TQclass();
         
        public Cave()
        {
            InitializeComponent();
            //Содержимое кнопок   
            //Image = new Bitmap(@...) - загрузка картинок на фон
            k.MassageButton1 = "Зажечь факел";
            k.next1 = k1;
            //k.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\1(начало).jpg");
            k.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\1(начало).jpg");

            k1.MassageButton1 = "Зайти в 1 проем";
            k1.next1 = k2;
            k1.MassageButton2 = "Зайти во 2 ";
            k1.next2 = l1;
            k1.MassageButton3 = "Зайти в 3";
            k1.next3 = m1;
            
            k1.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\2.jpg");

            k2.MassageButton1 = "Взять ключ";
            k2.next1 = k3;
           
            k2.MassageButton2 = "Пройти мимо";
            k2.next2 = l2;
            k2.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\key.jpeg");          

            k3.MassageButton1 = "Кинуться с мечем";
            k3.next1 = k4;
            k3.MassageButton2 = "Кинуть яд";
            k3.next2 = l3;
            k3.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\spider.jpg");
           
            k4.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\youdeadspider.png");
            
            k5.MassageButton1 = "42";
            k5.next1 = k8;
            k5.MassageButton2 = "21";
            k5.next2 = k10;
            k5.MassageButton3 = "22";
            k5.next3 = k9;
            k5.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\skeleton2.jpg");

            k6.MassageButton2 = "Далее";
            k6.next2 = k7;
            k6.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\3.jpg");

            k7.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\win.jpg");
            k8.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\youdead.png");
            k9.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\8.png");
            k10.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\exit.jpg");

            l1.MassageButton1 = "да";
            l1.next1 = k5;
            l1.MassageButton2 = "Нет";
            l1.next2 = l7;
            l1.MassageButton3 = "О чем вы?";
            l1.next3 = l8;
            l1.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\skeleton.jpg");

            l2.MassageButton1 = "Кинуться с мечем";
            l2.next1 = k4;
            l2.MassageButton2 = "Кинуть яд";
            l2.next2 = l4;
            l2.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\spider.jpg");

            l3.MassageButton2 = "Далее";
            l3.next2 = k6;
            l3.Image = new Bitmap (@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\spider2.jpg");

            l4.MassageButton2 = "Далее";
            l4.next2 = l5;
            l4.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\spider2.jpg");

            l5.MassageButton2 = "Далее";
            l5.next2 = l6;
            l5.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\4.jpg");

            l6.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\5.png");
            l7.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\7.png");
            l8.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\6.png");

            m1.MassageButton3 = "Далее";
            m1.next3 = m2;
            m1.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\bones.jpg");
            m2.MassageButton1 = "Кинуться с мечем";
            m2.next1 = m3;
            m2.MassageButton2 = "Подойти ближе";
            m2.next2 = m4;
            m2.MassageButton3 = "Кинуть яд";
            m2.next3 = m5;
            m2.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\snake.jpg");

            m3.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\youdeadspider.png");
            m4.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\9.png");
            m5.Image = new Bitmap(@"C:\Users\Алексей\Desktop\УЧЁБА\OOP\Textquest\pictures\exit2.jpg");         
            current = k;
        }
       
        //Обновление сцен
        void update_window()
        {
            //условие на скрытие кнопок и их заполнение
            if (current.MassageButton1 != null){
                Option1.Show();
                Option1.Text = current.MassageButton1;
            } else {
                Option1.Hide();
            }
            if (current.MassageButton2 != null){
                Option2.Show();
                Option2.Text = current.MassageButton2;
            } else {
                Option2.Hide();
            }
            if (current.MassageButton3 != null){
                Option3.Show();
                Option3.Text = current.MassageButton3;
            } else {
                Option3.Hide();
            }        
            this.BackgroundImage = current.Image;//обновление фона
        }

        // Функции при нажатии на 1 кнопку
        private void Option1_Click(object sender, EventArgs e){

             current = current.next1;
             update_window();            
        }

        // Функции при нажатии на 2 кнопку
        private void Option2_Click(object sender, EventArgs e){

                 current = current.next2;
                 update_window();                
        }
            
        // Функции при нажатии на 3 кнопку
        private void Option3_Click(object sender, EventArgs e){

            current = current.next3;
            update_window();
        }
    }
}
