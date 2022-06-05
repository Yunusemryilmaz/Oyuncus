using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Oyungonder : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    string mail = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
                //Kullaniciadini kullanarak mail adresini çekiyorum
                SqlCommand kmt = new SqlCommand("Select * From Tbl_Kullanicilar  where kullaniciad=@p1", bgl.baglanti());
                kmt.Parameters.AddWithValue("@p1", sqlsinif.name);
                
                SqlDataReader oku = kmt.ExecuteReader();

                while (oku.Read())
                {
                    Txtmail.Text = oku[3].ToString();

                }
                //oyun gönderek kullanici ise kullancici adını ve mailini değiştirelemez yapıyıp yazdırıyorum
                if (sqlsinif.name != "")
                {
                Txtisim.Text = sqlsinif.name;
                Txtmail.Enabled = false;
                Txtisim.Enabled = false;

                }

            

            
            bgl.baglanti().Close();

        }
    }

    protected void Btnoyungönder_Click(object sender, EventArgs e)
    {

        //Gönderi  tablosuna girilen değerleri ekliyorum

        SqlCommand komut = new SqlCommand("insert into Tbl_Gonderi(gonderiad,gonderiicerik,gönderisahip,gönderimail) values (@o1,@o3,@o4,@o5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@o1", TxtOyunad.Text);
            komut.Parameters.AddWithValue("@o3", Txtoyuniçerik.Text);
            komut.Parameters.AddWithValue("@o4", Txtisim.Text);
            komut.Parameters.AddWithValue("@o5", Txtmail.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            
        
        //abloları temizleyip mesaj iletiyorum
        TxtOyunad.Text = string.Empty; 
        Txtoyuniçerik.Text = string.Empty; 
        Label6.Text = "Gönderi işleminiz başarı ile gerçekleşmiştir, onaylanması beklenmekte.";


    }
}