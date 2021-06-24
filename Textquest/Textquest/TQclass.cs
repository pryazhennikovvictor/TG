/*Пряженников Виктор
 * Группа: ВМК-19
 * Текстовий квест с визуализацией
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Textquest
{
    class TQclass {
        // кнопки для каждой сцены
        public string MassageButton1;
        public string MassageButton2;
        public string MassageButton3;
        //пути
        public Image Image;
        //ссылки на сцены
        public TQclass next1;
        public TQclass next2;
        public TQclass next3;


    }
}
