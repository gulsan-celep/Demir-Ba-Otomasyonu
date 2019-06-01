using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimSinama
{
    public class DBOperasyon
    {
        public string kontrol { get; set; }
        string connection = "Data Source=LAPTOP-T6PJ8NRA\\SQLEXPRESS;Initial Catalog=YazilimSinama;Integrated Security=True";
        public List<string[]> Select(string command, List<string> keys, List<string> values)
        {
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(command, conn);

            for (int i = 0; i < keys.Count; i++)
                sqlCommand.Parameters.AddWithValue("@" + keys[i], values[i]);

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            List<string[]> result = new List<string[]>();

            while (sqlReader.Read())
            {
                string[] tmp = new string[sqlReader.FieldCount];
                for (int i = 0; i < sqlReader.FieldCount; i++)
                    tmp[i] = sqlReader[i].ToString();

                result.Add(tmp);
            }
            return result;
            conn.Close();

        }
       
        public List<string[]> Select(string command)
        {
            SqlConnection conn = new SqlConnection(connection);

            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(command, conn);

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            List<string[]> result = new List<string[]>();

            while (sqlReader.Read())
            {
                string[] tmp = new string[sqlReader.FieldCount];
                for (int i = 0; i < sqlReader.FieldCount; i++)
                    tmp[i] = sqlReader[i].ToString();

                result.Add(tmp);
            }
            return result;
            conn.Close();

        }
        public List<string[]> Arama(int oda )
        {
            SqlConnection conn = new SqlConnection(connection);

            conn.Open();
        string command = "SELECT o.OdaAdi ,f.FakulteAdi,p.PersonelAdi,d.DepartmanAdi,DB.DemirbasAdi FROM tblDemirbas DB INNER JOIN tblFakulteler f ON DB.FakulteID=f.FakulteID INNER JOIN tblDepartmanlar d ON DB.DepartmanID=d.DepartmanID INNER JOIN tblOdaDemirbasAtama ODA INNER JOIN tblPersonel P ON ODA.PersonelID=P.PersonelID INNER JOIN tblOda o ON ODA.OdaID=o.OdaID ON DB.DemirbasID=ODA.DemirbasID Where o.OdaID="+oda;
        SqlCommand sqlCommand = new SqlCommand(command, conn);

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            List<string[]> result = new List<string[]>();

            while (sqlReader.Read())
            {
                string[] tmp = new string[sqlReader.FieldCount];
                for (int i = 0; i < sqlReader.FieldCount; i++)
                    tmp[i] = sqlReader[i].ToString();

                result.Add(tmp);
            }
            return result;
            kontrol = result[0][4].ToString();
            conn.Close();

        }
        public List<string[]> PersonelUzerindeDemirbasArama(int PersonelID)
        {
            SqlConnection conn = new SqlConnection(connection);

            conn.Open();
            string command = "SELECT d.DemirbasID , d.DemirbasAdi ,od.Adet ,o.OdaAdi,p.PersonelAdi FROM tblDemirbas d INNER JOIN tblOdaDemirbasAtama od ON d.DemirbasID = od.DemirbasID INNER JOIN tblPersonel p ON od.PersonelID = p.PersonelID INNER JOIN tblOda o ON o.OdaID = od.OdaID where p.PersonelID =" + PersonelID;
            SqlCommand sqlCommand = new SqlCommand(command, conn);

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            List<string[]> result = new List<string[]>();

            while (sqlReader.Read())
            {
                string[] tmp = new string[sqlReader.FieldCount];
                for (int i = 0; i < sqlReader.FieldCount; i++)
                    tmp[i] = sqlReader[i].ToString();

                result.Add(tmp);
            }
            conn.Close();
            kontrol = result[0][0];

            return result;
        }

        public List<string[]> StokListele()
        {
            SqlConnection conn = new SqlConnection(connection);

            conn.Open();
            string command = "SELECT dt.DemirbasTuruAdi, d.DemirbasAdi ,d.Aciklama,d.Fiyat,d.AlimTarihi,d.Adet,d.Stok FROM tblDemirbas d, tblDemirbasTurleri dt Where d.DemirBasTuruID = dt.DemirBasTuruID";
            SqlCommand sqlCommand = new SqlCommand(command, conn);

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            List<string[]> result = new List<string[]>();

            while (sqlReader.Read())
            {
                string[] tmp = new string[sqlReader.FieldCount];
                for (int i = 0; i < sqlReader.FieldCount; i++)
                    tmp[i] = sqlReader[i].ToString();

                result.Add(tmp);
            }
            return result;
           
            conn.Close();
            kontrol = result[0][1];

        }
        public List<string[]> OdaDemirbasListeleme()
        {
            SqlConnection conn = new SqlConnection(connection);

            conn.Open();
            string command = "SELECT dt.DemirBasTuruAdi,d.DemirbasAdi,d.Aciklama,d.Adet,d.Stok,o.OdaAdi,p.PersonelAdi,od.Adet FROM tblDemirbas d INNER JOIN tblOdaDemirbasAtama od ON d.DemirbasID = od.DemirbasID INNER JOIN tblOda o  ON od.OdaID = o.OdaID INNER JOIN tblPersonel p  ON od.PersonelID = p.PersonelID  INNER JOIN tblDemirbasTurleri dt ON d.DemirbasTuruID = dt.DemirBasTuruID";
            SqlCommand sqlCommand = new SqlCommand(command, conn);

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            List<string[]> result = new List<string[]>();

            while (sqlReader.Read())
            {
                string[] tmp = new string[sqlReader.FieldCount];
                for (int i = 0; i < sqlReader.FieldCount; i++)
                    tmp[i] = sqlReader[i].ToString();

                result.Add(tmp);
            }
            return result;
            conn.Close();

        }
        public List<string[]> DepartmanSelect(string command)
        {
            SqlConnection conn = new SqlConnection(connection);

            conn.Open();
            SqlCommand sqlCommand = new SqlCommand(command, conn);

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            List<string[]> result = new List<string[]>();

            while (sqlReader.Read())
            {
                string[] tmp = new string[sqlReader.FieldCount];         
                for (int i = 0; i < sqlReader.FieldCount; i++)
                    tmp[i] = sqlReader[i].ToString();

                result.Add(tmp);
            }
            return result;
            conn.Close();

        }
        public bool Insert(string Adi,string Soyadi, string tc)
        { 
              
               SqlConnection conn = new SqlConnection(connection);                     
                conn.Open();
                
             string kayit = "insert into tblPersonel(PersonelAdi,PersonelSoyadi,PersonelTC) values (@PersonelAdi,@PersonelSoyadi,@PersonelTC)";
       
             SqlCommand komut = new SqlCommand(kayit,conn);
       
                komut.Parameters.AddWithValue("@PersonelAdi", Adi);
                komut.Parameters.AddWithValue("@PersonelSoyadi", Soyadi);
                komut.Parameters.AddWithValue("@PersonelTC", tc);
                 komut.ExecuteNonQuery();              
                conn.Close();
            return true;                               
    }
        public void OdaDemirbasInsert(int OdaID, int DemirbasID,int Adet,int PersonelID)
        {

            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            string kayit = "insert into tblOdaDemirbasAtama(OdaID,DemirbasID,Adet,PersonelID) values (@OdaID,@DemirbasID,@Adet,@PersonelID)";

            SqlCommand komut = new SqlCommand(kayit, conn);

            komut.Parameters.AddWithValue("@OdaID",OdaID);
            komut.Parameters.AddWithValue("@DemirbasID",DemirbasID);
            komut.Parameters.AddWithValue("@Adet",Adet);
            komut.Parameters.AddWithValue("@PersonelID",PersonelID);
            komut.ExecuteNonQuery();
            conn.Close();
        }
        public void DemirbasInsert(string DemirbasAdi,int Fiyat, DateTime AlimTarihi,int DemirbasTuruID,int FakulteID, int DepartmanID,int Adet,string Aciklama)
        {

            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            string kayit = "insert into tblDemirbas(DemirbasAdi,Fiyat,AlimTarihi,DemirbasTuruID,FakulteID,DepartmanID,Adet,Aciklama,Stok) values (@DemirbasAdi,@Fiyat,@AlimTarihi,@DemirbasTuruID,@FakulteID,@DepartmanID,@Adet,@Aciklama,@Stok)";

            SqlCommand komut = new SqlCommand(kayit, conn);

            komut.Parameters.AddWithValue("@DemirbasAdi",DemirbasAdi);
            komut.Parameters.AddWithValue("@Fiyat",Fiyat);
            komut.Parameters.AddWithValue("@AlimTarihi",AlimTarihi);
            komut.Parameters.AddWithValue("@DemirbasTuruID",DemirbasTuruID);
            komut.Parameters.AddWithValue("@FakulteID",FakulteID);
            komut.Parameters.AddWithValue("@DepartmanID",DepartmanID);
            komut.Parameters.AddWithValue("@Adet",Adet);
            komut.Parameters.AddWithValue("@Aciklama",Aciklama);
            komut.Parameters.AddWithValue("@Stok",Adet);
            komut.ExecuteNonQuery();
            conn.Close();
        }
        public void DemirbasTuruInsert(string DemirBasTuruAdi)
        {

            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            string kayit = "insert into tblDemirbasTurleri(DemirBasTuruAdi) values (@DemirBasTuruAdi)";

            SqlCommand komut = new SqlCommand(kayit, conn);

            komut.Parameters.AddWithValue("@DemirBasTuruAdi",DemirBasTuruAdi);           
            komut.ExecuteNonQuery();
            conn.Close();
        }
        public bool Guncelle(int yetki,int personelID)
        {
            int result = 0;
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
            SqlCommand kmt = null;
            if (yetki==1)
            {
                string kayit = "UPDATE tblKullanicilar SET YetkiID=1 WHERE personelID=(Select PersonelID from tblKullanicilar Where KullaniciID=" + personelID + ")";
                 kmt = new SqlCommand(kayit, conn);
                kmt.Parameters.AddWithValue("@YetkiID", yetki);
            }
           else if (yetki == 0)
            {
                string kayit = "UPDATE tblKullanicilar SET YetkiID=0 WHERE personelID=(Select PersonelID from tblKullanicilar Where KullaniciID=" + personelID + ")";
                kmt = new SqlCommand(kayit, conn);
                kmt.Parameters.AddWithValue("@YetkiID", yetki);
               
            }

            result = kmt.ExecuteNonQuery();
            conn.Close();

            if (result == 1)
                return true;
            return false;

        }
        public void DemirbasGuncelle(int adet)
        {

            SqlConnection conn = new SqlConnection(connection);
            conn.Open();                     
                string kayit = "UPDATE tblDemirbas SET Adet="+adet;
                SqlCommand kmt = new SqlCommand(kayit, conn);
                kmt.Parameters.AddWithValue("@Adet",adet);
                kmt.ExecuteNonQuery();                    
            conn.Close();

        }

        public void KullaniciInsert(string KullaniciAdi, string Sifre,string PersonelID)
        {

            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            string kayit = "insert into tblKullanicilar(personelID,KullaniciAdi,YetkiID,Sifre) values (@personelID,@KullaniciAdi,@YetkiID,@Sifre)";

            SqlCommand komut = new SqlCommand(kayit, conn);

            komut.Parameters.AddWithValue("@personelID",Convert.ToInt32(PersonelID));
            komut.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi);
            komut.Parameters.AddWithValue("@YetkiID", 0);
            komut.Parameters.AddWithValue("@Sifre", Sifre);                 
            komut.ExecuteNonQuery();
            conn.Close();

        }
        public bool InsertOda(string OdaAdi,int DepartmanID)

        {

            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            string kayit = "insert into tblOda(DepartmanID,OdaAdi) values (@DepartmanID,@OdaAdi)";

            SqlCommand komut = new SqlCommand(kayit, conn);

            komut.Parameters.AddWithValue("@DepartmanID",DepartmanID);
            komut.Parameters.AddWithValue("@OdaAdi",OdaAdi);           
            komut.ExecuteNonQuery();
            conn.Close();
            return true;
        }


        public void PersonelSil(string Adi, string Soyadi ,string Tc, int ID)
        {

            SqlConnection conn = new SqlConnection(connection);
            conn.Open();
                      
            string silmeSorgusu = "DELETE FROM tblPersonel  WHERE PersonelID="+ID;
            SqlCommand silKomutu = new SqlCommand(silmeSorgusu, conn);
                     silKomutu.Parameters.AddWithValue("@PersonelAdi", Adi);
                     silKomutu.Parameters.AddWithValue("@PersonelSoyadi", Soyadi);
                     silKomutu.Parameters.AddWithValue("@PersonelTC", Tc);
                     silKomutu.Parameters.AddWithValue("@PersonelID", ID);
                     silKomutu.ExecuteNonQuery();
            conn.Close();                
                        
        }
       

    }
}
