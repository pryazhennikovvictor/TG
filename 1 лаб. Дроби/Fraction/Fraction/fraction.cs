using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class fraction
    {
        // закрытый раздел
        private  int num; // поля
        private  int denum;
        // открытый раздел

        public fraction()// конструктор без параметров
        {
            this.ch = 0;
            this.zn = 0;
        }

        public fraction(int num, int denum)//конструктор с параметром \ num - ch - числитель \ denum - zn - знаменатель
        {
            this.ch = num;
            this.zn = denum;
           
        } 


        public int ch // Сеттер и геттер числителя
        {
            get{ return ch; }

            set{ ch = value;}
        }
        public int zn // Сеттер и геттер знаменателя
        {
            get { return zn; }

            set { zn = value;}
        }
        //Сложение
        public static fraction operator +(fraction a1, fraction a2, fraction a3)
        {
            fraction result = new fraction
            {
                if (a1.denum != a2.denum) {
                a3.denum = a1.denum * a2.denum;
                a1.num = a1.num * a2.denum;
                a2.num = a2.num * a1.denum;
                a3.num = a1.num + a2.num;
                    } else{
                a3.denum = a1.denum;
                a3.num = a1.num + a2.num;
            }
            return result;
        }
    }
}
