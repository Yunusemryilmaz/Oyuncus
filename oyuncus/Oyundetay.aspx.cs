using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Oyundetay : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    string oyunid = "";
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //Sayfaya giren kullanici ise yorum panelini açıyorum
        // yorum yapmak için üye olun kısmını kapatıyorum
        if (sqlsinif.name != "")
        {
            pnlyormyap.Visible = true;
            pnlyorumuyarı.Visible = false;
        }
        else
        {
            pnlyorumuyarı.Visible = true;
            pnlyormyap.Visible = false;
        }


        oyunid = Request.QueryString["oyunid"];


        

        //Sayfanın sol tarafında kullanici bilgilerini gösteriyorum

        SqlCommand komut = new SqlCommand("Select oyunad , oyunbilgi  , oyuntarih,oyunresim from Tbl_Oyunlar where oyunid=@p1", bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", oyunid);
        SqlDataReader oku = komut.ExecuteReader();

        while (oku.Read())
        {
            Label4.Text = oku[0].ToString();
            Label5.Text = oku[1].ToString();
            Label6.Text = oku[2].ToString();
            Image3.ImageUrl = oku[3].ToString();

        }
        bgl.baglanti().Close();
        //Yorumlar
        //Yorum yapanın bilgilerini yorum ve kullanici tablosunu birleştirerek çekiyorum
        SqlCommand komut2 = new SqlCommand("Select kullanicifoto, kullaniciad, yorumiçerik, yorumtarih from Tbl_Yorumlar inner join Tbl_Kullanicilar on Tbl_Kullanicilar.kullaniciid= Tbl_Yorumlar.kullaniciid where Oyunid=@p2 and yorumonay='true'  ORDER BY yorumtarih desc", bgl.baglanti());
        
        komut2.Parameters.AddWithValue("@p2", oyunid);
        SqlDataReader oku2 = komut2.ExecuteReader();
        DataList2.DataSource = oku2;
        DataList2.DataBind();
        
    }



    protected void Button1_Click(object sender, EventArgs e)
    {   
        //yorum bilgilerini alıyorum
        SqlCommand kmtmail = new SqlCommand("Select kullanicimail, kullanicifoto, kullaniciid from Tbl_Kullanicilar where kullaniciad=@p1", bgl.baglanti());
        
        kmtmail.Parameters.AddWithValue("@p1", sqlsinif.name);
        SqlDataReader oku = kmtmail.ExecuteReader();
        string mail = "";
        string foto = "";
        string id = "";
        while (oku.Read())
        {
            mail = oku[0].ToString();
            foto = oku[1].ToString();
            id = oku[2].ToString();
           
        }
        bgl.baglanti().Close();
        //yorum bilgilerini yorumlar tablosuna aktarıyorum
        SqlCommand komut = new SqlCommand("insert into Tbl_yorumlar (yorumiçerik, oyunid, kullaniciid) values(@p1,@p2,@p3)", bgl.baglanti());
        
        komut.Parameters.AddWithValue("@p1", TextBox1.Text);
        komut.Parameters.AddWithValue("@p2", oyunid);
        komut.Parameters.AddWithValue("@p3", id);
        komut.ExecuteNonQuery();
        bgl.baglanti().Close();
        //Onay mesajaını döndürüyorum
        Label12.Text = "Yorumunuz alınmıştır, onaylandıktan sonra yayınlanacaktır.";
    }
}