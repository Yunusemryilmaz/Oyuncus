using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Kaydol : System.Web.UI.Page
{ 
    sqlsinif bgl = new sqlsinif();
    protected void Page_Load(object sender, EventArgs e)
    {   
        //Eğer kaydol sayfasına giren kişi kullanıcı ise anasayfaya atıyorum

        if (sqlsinif.name != "")
        {
            Response.Redirect("~/Anasayfa.aspx");

        }
    
    
    }

    protected void BtnKaydol_Click(object sender, EventArgs e)
    {
        
        //girilen değerleri tanımlıyorum
        string username = TxtKullaniciAdi.Text;
        string pasword = TxtParola.Text;
        string mail = Txtmail.Text;
        string pasword1 = TxtParolaTekrar.Text;
        string kontrol = username + pasword + mail;
        bool onay = true;


        //Kullanici adı alınmışmı diye kontrol edtmek için okuma işlemi  veriyorum
        SqlCommand komutk = new SqlCommand("Select * From Tbl_Kullanicilar where kullaniciad=@p1", bgl.baglanti());
        komutk.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
        SqlDataReader okuk = komutk.ExecuteReader();


        
        //kullanici adi, mail ve şifrede boşluk karakteri olup olmadığını kontrol ediyorum
        for (int i = 0; i < kontrol.Length; i++)
        {
            if (kontrol[i].ToString() == " ")
            {
                onay = false;
                break;
            }
        }

        
        //okuma işlemi olursa kullanici adı uyarısı veriyorum
        if (okuk.Read())
        {

            Label3.Text = "Bu kullanıcı adı daha önceden alınmış.";

            
        }
       //Ve birkaç şifre,kullaniciadi kontrolü
        else if (username.Length < 5)
        {
            Label3.Text = "Kullanıcı adınız en az 5 karakterden oluşmalıdır.";
        }
        
        else if (pasword.Length < 9)
        {
            Label3.Text = "Şifreniz en az 9 karakterden oluşmalıdır.";
        }
        else if (username.Length > 25)
        {
            Label3.Text = "Kullanıcı adınız 25 karakterden büyük olamaz.";
        }
        else if (pasword != pasword1)
        {
            Label3.Text = "Parolalarınız uyuşmamaktadır.";
        }
        else if (onay == false)
        {
            Label3.Text = "Kullanıcı adınız, parolanızda veya mailinizde boşluk karakteri kullanamazsınız.";
        }

        else
        {   //parolayı şifreleyip yeni değişkene atıyorum
           string sfrpar= Sifreleme.ComputeSha256Hash(pasword);
            try
            {   //kaydetme işlemini yaptırıyorum
                SqlCommand komut = new SqlCommand("insert into Tbl_Kullanicilar(kullaniciad,kullanicisifre,kullanicimail) values (@o1,@o2,@o3)", bgl.baglanti());
                komut.Parameters.AddWithValue("@o1", TxtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@o2", sfrpar);
                komut.Parameters.AddWithValue("@o3", mail);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                


                Session.Add("ad", TxtKullaniciAdi.Text);
                sqlsinif.name = TxtKullaniciAdi.Text;
                Response.Redirect("~/Anasayfa.aspx");

            }
            catch
            {
                Label3.Text = "Kayıt sırasında beklenmedik bir hata oluştu.";
            }



        }
        bgl.baglanti().Close();
    }
    
    protected void BtnAnasayfa_Click(object sender, EventArgs e)
    {//Kaydolmaktan vazgeçenler için anasayfa butonu
        Response.Redirect("Anasayfa.aspx");
    }
}
