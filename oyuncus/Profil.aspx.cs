using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Profil : System.Web.UI.Page
{
    string kullaniciid = "";
    sqlsinif bgl = new sqlsinif();
    protected void Page_Load(object sender, EventArgs e)
    {   //kullanici olmayan kişi linkten girmesini düşünerek anasayfaya atıyoruz
        if (sqlsinif.name == "")
        {
            Response.Redirect("Anasayfa.aspx");
        }
        if (Page.IsPostBack == false)
        {   //sayfa yüklendiğinde panelleri gizliyoruz
            pnlprofil.Visible = false;
            pnlkullaniciadi.Visible = false;
            pnlsifre.Visible = false;

        }
        //Kullanici tablosundan giriş yapanın bilgilerini çekiyoruz
        SqlCommand komut = new SqlCommand("Select * from Tbl_Kullanicilar where kullaniciad=@p1", bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", sqlsinif.name);
        SqlDataReader oku = komut.ExecuteReader();
        while (oku.Read())
        {  //Kullanici idsini ileride kullanmak için alıyoruz
            kullaniciid = oku[0].ToString();
            TextBox1.Text = oku[1].ToString();
            Image3.ImageUrl = oku[4].ToString();
        }
        bgl.baglanti().Close();



    }
    //Buton aç kapa
    protected void Button3_Click(object sender, EventArgs e)
    {

        if (pnlkullaniciadi.Visible == false)
        {
            pnlkullaniciadi.Visible = true;
        }
        else
        {
            pnlkullaniciadi.Visible = false;
        }
    }//Buton aç kapa

    protected void Button1_Click(object sender, EventArgs e)
    {

        if (pnlprofil.Visible == false)
        {
            pnlprofil.Visible = true;
        }
        else
        {
            pnlprofil.Visible = false;
        }
    }
    //Buton aç kapa
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (pnlsifre.Visible == false)
        {
            pnlsifre.Visible = true;
        }
        else
        {
            pnlsifre.Visible = false;
        }
    }

    protected void gncprof_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {//dosya yüklenmiş ise kullaniciidsini dosya adı  parak kaydediyuorum
            FileUpload1.SaveAs(Server.MapPath("/Resimler/Kullanici/" + kullaniciid + ".jpg"));


            //Kullanicinin adına göre dosya yolunu atama yapıyorum.
            SqlCommand komut = new SqlCommand("update Tbl_Kullanicilar set kullanicifoto=@p1 where kullaniciad=@p2", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", "~/Resimler/Kullanici/" + kullaniciid + ".jpg");
            komut.Parameters.AddWithValue("@p2", sqlsinif.name);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        //yükleme işlemine anlık şahit olabilmek için Thread sleep yapıyorum
        System.Threading.Thread.Sleep(2000);
        Response.Redirect("Profil.aspx");


    }

    protected void Button5_Click(object sender, EventArgs e)
    {

        //Kullaniciadını dğeiştirmek için değer alıyorum
        string yeniad = TextBox1.Text;
        bool onay = true;
        SqlCommand komutk = new SqlCommand("Select * From Tbl_Kullanicilar where kullaniciad=@p1", bgl.baglanti());
        komutk.Parameters.AddWithValue("@p1", yeniad);
        SqlDataReader okuk = komutk.ExecuteReader();
        //Kullaniciadindan boşluk var mı diye kontrol ediyorum
        for (int i = 0; i < yeniad.Length; i++)
        {
            if (yeniad[i].ToString() == " ")
            {
                onay = false;
                break;
            }
        }






        //Gereken kontrolleri yapıp sorunları iletiyorum
        if (yeniad == sqlsinif.name)
        {

        }
        else if (okuk.Read())
        {

            klncadi.Text = "Bu kullanıcı adı daha önceden alınmış.";


        }
        else if (yeniad.Length < 5)
        {
            klncadi.Text = "Kullanıcı adınız en az 5 karakterden oluşmalıdır.";
        }
        else if (yeniad.Length > 25)
        {
            klncadi.Text = "Kullanıcı adınız 25 karakterden büyük olamaz.";
        }
        else if (onay == false)
        {
            klncadi.Text = "Kullanıcı adınızda boşluk karakteri kullanamazsınız.";
        }
        else
        {//Tüm şartlar sağlanıyorsa kullanıcı adını güncelliyorum
            SqlCommand komut = new SqlCommand("update Tbl_Kullanicilar set kullaniciad=@p1 where kullaniciad=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", sqlsinif.name);
            komut.Parameters.AddWithValue("@p1", yeniad);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            sqlsinif.name = yeniad;
            System.Threading.Thread.Sleep(2000);
            Response.Redirect("Profil.aspx");
        }






















    }

    protected void Button6_Click(object sender, EventArgs e)
    {//sifre değiştirmek için alıyorum
        string sifre = "";
        SqlCommand kmtsfr = new SqlCommand("Select * From Tbl_Kullanicilar where kullaniciad=@p1", bgl.baglanti());
        kmtsfr.Parameters.AddWithValue("@p1", sqlsinif.name);
        SqlDataReader okuid = kmtsfr.ExecuteReader();
        while (okuid.Read())
        {
            sifre = okuid[2].ToString();

        }
        bgl.baglanti().Close();


        
        string pasword = TextBox2.Text;
        string pasword1 = TextBox3.Text;
        //parolayı şifreleyip datadaki ile kontrol ediyorum
        if (Sifreleme.ComputeSha256Hash(TextBox4.Text) == sifre)
        {//Boşluk kontrolu için for kullanıyorum
            bool onay = true;
            for (int i = 0; i < pasword.Length; i++)
            {
                if (pasword[i].ToString() == " ")
                {
                    onay = false;
                    break;
                }
            }
            if (pasword != pasword1)
            {
                sfre.Text = "Parolalarınız uyuşmamaktadır.";
            }
            else if (onay != true)
            {
                sfre.Text = "Şifrenizde boşluk karakteri olamaz.";
            }
            else if (pasword.Length < 9)
            {
                sfre.Text = "Şifreniz en az 9 karakterden oluşmalıdır.";
            }
            else if (pasword.Length > 20)
            {
                sfre.Text = "Şifreniz en fazla 20 karakterden oluşmalıdır.";
            }
            else if (onay == false)
            {
                sfre.Text = "Parolanızda boşluk karakteri kullanamazsınız.";
            }
            else
            {//gerekli şartlar sağlandıysa şifreyi yeniliyoruz
                SqlCommand komut = new SqlCommand("update Tbl_Kullanicilar set kullanicisifre=@p1 where kullaniciad=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p2", sqlsinif.name);
                komut.Parameters.AddWithValue("@p1", Sifreleme.ComputeSha256Hash(pasword));

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                sfre.Text = "Sifreniz başarılı bir şekilde değiştirilmiştir.";
                System.Threading.Thread.Sleep(2000);
                Response.Redirect("Profil.aspx");
            }


        }
        else
        {
            sfre.Text = "Hatalı şifre.";
        }


    }
}