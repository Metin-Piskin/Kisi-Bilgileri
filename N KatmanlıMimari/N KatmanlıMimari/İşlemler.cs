using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace N_KatmanlıMimari
{
    public partial class İşlemler : Form
    {
        public İşlemler()
        {
            InitializeComponent();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad1 = TxtAd.Text;
            ent.Soyad1 = TxtSoyad.Text;
            ent.Şehir1 = TxtŞehir.Text;
            ent.Maaş1 = short.Parse(TxtMaaş.Text);
            ent.Görev1 = TxtGörev.Text;
            LogicPersonel.LLPersonelEkle(ent);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.İd1 = Convert.ToInt32(Txtİd.Text);
            LogicPersonel.LLPersonelSil(ent.İd1);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.İd1 = Convert.ToInt32(Txtİd.Text);
            ent.Ad1 = TxtAd.Text;
            ent.Soyad1 = TxtSoyad.Text;
            ent.Şehir1 = TxtŞehir.Text;
            ent.Maaş1 = short.Parse(TxtMaaş.Text);
            ent.Görev1 = TxtGörev.Text;
            LogicPersonel.LLPersonelGüncelle(ent);
        }
    }
}
