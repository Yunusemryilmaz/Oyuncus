using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class YorumDetay : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    string yorumid = "";
    
    protected void Page_Load(object sender, EventArgs e)
    {
        yorumid = Request.QueryString["yorumid"];
        
        if (Page.IsPostBack == false) 
        { 
            SqlCommand komut = new SqlCommand("Select  yorumiçerik, oyunad From Tbl_Yorumlar inner join Tbl_Oyunlar on Tbl_Yorumlar.oyunid=Tbl_Oyunlar.oyunid where yorumid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", yorumid);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
            TxtIcerik.Text = oku[0].ToString();
            TxtOyun.Text = oku[1].ToString();
           
            }
            
            

            SqlCommand komut1 = new SqlCommand("Select  kullaniciad, kullanicimail From Tbl_Kullanicilar inner join Tbl_Yorumlar on Tbl_Yorumlar.kullaniciid=Tbl_Kullanicilar.kullaniciid where yorumid=@a1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@a1", yorumid);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                
                TxtAd.Text = oku1[0].ToString();
                TxtMail.Text = oku1[1].ToString();

            }
            bgl.baglanti().Close();
        }
    }

    protected void BtnOnay_Click(object sender, EventArgs e)
    {
        SqlCommand komut = new SqlCommand("Update Tbl_yorumlar set yorumiçerik=@p1, yorumonay=@p2 where yorumid=@p3",bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", TxtIcerik.Text);

        komut.Parameters.AddWithValue("@p2", "true");
        komut.Parameters.AddWithValue("@p3", yorumid);
        komut.ExecuteNonQuery();
        bgl.baglanti().Close();
        Response.Redirect("Yorumlar.aspx");



    }
}