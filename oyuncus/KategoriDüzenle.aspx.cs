using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class KategoriDüzenle : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    string kategoriid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        kategoriid = Request.QueryString["Kategoriid"];
        //Textboxlara kategori adlarını çekiyorum
        if (Page.IsPostBack == false) { 
        SqlCommand komut = new SqlCommand("Select * from Tbl_Kategoriler where kategoriid=@p1",bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", kategoriid);
        SqlDataReader oku = komut.ExecuteReader();
        while (oku.Read())
        {
            TextBox1.Text = oku[1].ToString();
            TextBox2.Text = oku[2].ToString();

        }
        bgl.baglanti().Close();
    }
        }

    protected void Button1_Click(object sender, EventArgs e)
    {   //Textboxlarda ki değerleri seçilen idye sahip katerilere aktarıyorum
        //Hatalarda meydana gelebilecek kategori adet sayısını manuel düzeltilmesini sağlıyorum
        SqlCommand komut = new SqlCommand("update Tbl_Kategoriler set kategoriad=@p1,kategoriadet=@p2 where kategoriid=@p3",bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", TextBox1.Text);
        komut.Parameters.AddWithValue("@p2", TextBox2.Text);
        komut.Parameters.AddWithValue("@p3", kategoriid);
        komut.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
}