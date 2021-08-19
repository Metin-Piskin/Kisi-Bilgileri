using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityPersonel
    {
        private int İd;
        private string Ad;
        private string Soyad;
        private string Şehir;
        private string Görev;
        private short Maaş;

        public int İd1 { get => İd; set => İd = value; }
        public string Ad1 { get => Ad; set => Ad = value; }
        public string Soyad1 { get => Soyad; set => Soyad = value; }
        public string Şehir1 { get => Şehir; set => Şehir = value; }
        public string Görev1 { get => Görev; set => Görev = value; }
        public short Maaş1 { get => Maaş; set => Maaş = value; }
    }
}
