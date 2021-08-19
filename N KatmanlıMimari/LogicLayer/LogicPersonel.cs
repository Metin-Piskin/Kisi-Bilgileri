using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }
        public static int LLPersonelEkle(EntityPersonel p)
        {
            if(p.Ad1!="" && p.Soyad1 !="" && p.Maaş1>=3500 && p.Ad1.Length >= 3)
            {
                return DALPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }
        } 
        public static bool LLPersonelSil(int per)
        {
            if(per >= 1)
            {
                return DALPersonel.PersonelSil(per);
            }
            else
            {
                return false;
            }
        }
        public static bool LLPersonelGüncelle(EntityPersonel ent)
        {
            if (ent.Ad1.Length > 3 && ent.Ad1 != "" && ent.Maaş1 >= 4500)
            {
                return DALPersonel.PersonelGüncelle(ent);
            }
            else
            {
                return false;
            }
        }
    }
}
