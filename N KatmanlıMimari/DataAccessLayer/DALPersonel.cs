using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> değerler = new List<EntityPersonel>();
            SqlCommand komut1 = new SqlCommand("Select * From TblBilgi", Bağlantı.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.İd1 = int.Parse(dr["İd"].ToString());
                ent.Ad1 = dr["Ad"].ToString();
                ent.Soyad1 = dr["Soyad"].ToString();
                ent.Şehir1 = dr["Şehir"].ToString();
                ent.Görev1 = dr["Görev"].ToString();
                ent.Maaş1 = short.Parse(dr["Maaş"].ToString());
                değerler.Add(ent);
            }
            dr.Close();
            return değerler;
        }
        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut2 = new SqlCommand("insert into TblBilgi(Ad,Soyad,Görev,Şehir,Maaş) values (@p1,@p2,@p3,@p4,@p5)", Bağlantı.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", p.Ad1);
            komut2.Parameters.AddWithValue("@p2", p.Soyad1);
            komut2.Parameters.AddWithValue("@p3", p.Görev1);
            komut2.Parameters.AddWithValue("@p4", p.Şehir1);
            komut2.Parameters.AddWithValue("@p5", p.Maaş1);
            return komut2.ExecuteNonQuery();
        }
        public static bool PersonelSil(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete From TblBilgi Where İd=@p1", Bağlantı.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static bool PersonelGüncelle(EntityPersonel ent)
        {
            SqlCommand komut4 = new SqlCommand("Update TblBilgi set Ad=@p1,Soyad=@p2,Maaş=@p3,Şehir=@p4,Görev=@p5 where İd=@p6", Bağlantı.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", ent.Ad1);
            komut4.Parameters.AddWithValue("@p2", ent.Soyad1);
            komut4.Parameters.AddWithValue("@p3", ent.Maaş1);
            komut4.Parameters.AddWithValue("@p4", ent.Şehir1);
            komut4.Parameters.AddWithValue("@p5", ent.Görev1);
            komut4.Parameters.AddWithValue("@p6", ent.İd1);
            return komut4.ExecuteNonQuery() > 0;
        }
    }
}
