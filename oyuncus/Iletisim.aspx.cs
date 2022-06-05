using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Iletisim : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    protected void Page_Load(object sender, EventArgs e)
    {
            bgl.baglanti().Open();
            if (Page.IsPostBack == false)
            {       
            //Kullanicinin mailini çekmek için sqlcommand kullanıyorum
            SqlCommand kmt = new SqlCommand("Select * From Tbl_Kullanicilar  where kullaniciad=@p1", bgl.baglanti());
            kmt.Parameters.AddWithValue("@p1", sqlsinif.name);

            SqlDataReader oku = kmt.ExecuteReader();
            
            while (oku.Read())
            {

                TxtMail.Text = oku[3].ToString();
                
            }
            //Eğer sayfaya giren kişinin global kullanıcı adı boş değilse isim ve mail kısmını otomatik
            //doldurup değiştirilemez yapıyorum
            if (sqlsinif.name != "")
            {
                Txtgonderen.Text = sqlsinif.name;
                TxtMail.Enabled = false;
                Txtgonderen.Enabled = false;

            }


            bgl.baglanti().Close();

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    { //Gerekli yerlere girilen değerleri mesajlar tabloma aktarıyorum
        bgl.baglanti().Open();
        SqlCommand komut = new SqlCommand("insert into Tbl_Mesajlar (mesajgonderen , mesajbaslik, mesajmail, mesajicerik) values (@p1,@p2,@p3,@p4)",bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", Txtgonderen.Text);
        komut.Parameters.AddWithValue("@p2", TxtBaslik.Text);
        komut.Parameters.AddWithValue("@p3", TxtMail.Text);
        komut.Parameters.AddWithValue("@p4", TxtMesaj.Text);
        komut.ExecuteNonQuery();
        bgl.baglanti().Close();
        //Textboxları temizleyip mesaj iletildi mesajımı veriyorum
        Txtgonderen.Text = string.Empty;
        TxtBaslik.Text = string.Empty;
        TxtMail.Text = string.Empty;
        TxtMesaj.Text = string.Empty;
        Label6.Text = "Mesajınız başarılı bir şekilde iletişmiştir.";
    }

    
}