using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSinama
{
    public class sorgularcs
    {
        public static string Kullanicigirisi = "SELECT * FROM tblKullanicilar";
        public static string Personel = "SELECT * FROM tblPersonel WHERE PersonelAdi=@PersonelAdi AND PersonelSoyadi=@PersonelSoyadi AND PersonelTC=@PersonelTC";
        public static List<string> PersonelParametreler = new List<string>() { "PersonelAdi", "PersonelSoyadi","PersonelTC"};

        public static string KullaniciListele = "SELECT YetkiID FROM tblKullanicilar";
        public static string PersonelListele = "SELECT * FROM tblPersonel";

        public static string Kullanici = "Select k.KullaniciID ,p.PersonelAdi,p.PersonelSoyadi,p.PersonelTC, k.YetkiID from tblKullanicilar k , tblPersonel p where k.personelID=p.PersonelID";
        
        public static string Departman= "SELECT * FROM tblDepartmanlar"; 
        public static string Fakulte = "SELECT * FROM tblFakulteler";
        public static string DemirbasTuru = "SELECT * FROM tblDemirbasTurleri";
        public static string Oda = "SELECT * FROM tblOda";
        public static string Demirbas = "SELECT * FROM tblDemirbas";

        public static string DemirbasArama = "SELECT d.DemirbasAdi ,d.Fiyat,d.AlimTarihi,d.Adet, dt.DemirBasTuruAdi FROM tblDemirbas d, tblDemirbasTurleri dt Where d.DemirBasTuruID=dt.DemirBasTuruID";

    }
}
