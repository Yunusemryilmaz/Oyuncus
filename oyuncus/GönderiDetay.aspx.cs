using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class GönderiDetay : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    //her yerden ulaşabilmek için idyi public tanımlıyorum
    string gonderiid = "";
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {   //gönderi sayfası yüklendiği zaman idyi çekiyorum
            gonderiid = Request.QueryString["gonderiid"];

        }

            //Gönderi Detaylarını çekiyorum
            bgl.baglanti().Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Gonderi where gonderiid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", gonderiid);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                
                
                TextBox4.Text = oku[1].ToString();
                TextBox5.Text = oku[3].ToString();
                TextBox6.Text = oku[4].ToString();
                TextBox7.Text = oku[5].ToString();
            }
            bgl.baglanti().Close();
            bgl.baglanti().Open();
            SqlCommand komut2 = new SqlCommand("Select * from Tbl_Kategoriler", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            DropDownList1.DataTextField = "kategoriad";
            DropDownList1.DataValueField = "kategoriid";
            DropDownList1.DataSource = oku2;
            DropDownList1.DataBind();
            bgl.baglanti().Close();

    }

    protected void Button1_Click(object sender, EventArgs e)

    {

        //Gönderi Kısmından silme
        SqlCommand komut = new SqlCommand("delete from Tbl_Gonderi where gonderiid=@p1", bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", gonderiid);
        komut.ExecuteNonQuery();
        bgl.baglanti().Close();
        //Eklendiği Kategoriyi 1 arttırıyorum
        SqlCommand komut3 = new SqlCommand("update Tbl_Kategoriler set kategoriadet=kategoriadet+1 where kategoriid=@p1", bgl.baglanti());
        komut3.Parameters.AddWithValue("@p1", DropDownList1.SelectedValue);
        komut3.ExecuteNonQuery();
        bgl.baglanti().Close();
        //Oyunu Anasayfaya ekleiyorum
SqlCommand komut2 = new SqlCommand("insert into Tbl_oyunlar(oyunad,oyunbilgi,kategoriid) values (@p1,@p2,@p3)", bgl.baglanti());
        komut2.Parameters.AddWithValue("@p1", TextBox4.Text);
        komut2.Parameters.AddWithValue("@p2", TextBox5.Text);
        komut2.Parameters.AddWithValue("@p3", DropDownList1.SelectedValue);
        
        komut2.ExecuteNonQuery();
        bgl.baglanti().Close();


        
        //Gönderiden çektiğim oyunun idsini bulmak için son eklenen verilerin idsini çekiyorum
            string oyunid = "";

        SqlCommand kmt = new SqlCommand("SELECT top 1 * FROM Tbl_oyunlar order by oyunid desc ", bgl.baglanti());
        SqlDataReader read = kmt.ExecuteReader();
        while (read.Read())
        {
            oyunid = read[0].ToString();
        }
        bgl.baglanti().Close();
        //Bulduğum idyi fotoğrafın ismi yaparak kaydediyorum
        if (FileUpload1.HasFile)
        {

            FileUpload1.SaveAs(Server.MapPath("~/resimler/") + oyunid + ".jpg");
            SqlCommand kmt1 = new SqlCommand("update Tbl_Oyunlar set oyunresim=@p1 where oyunid=@p2", bgl.baglanti());
            kmt1.Parameters.AddWithValue("p2", oyunid);
            kmt1.Parameters.AddWithValue("@p1", "~/resimler/" + oyunid + ".jpg");
            kmt1.ExecuteNonQuery();
            bgl.baglanti().Close();
            bgl.baglanti().Close();

        }
             Response.Redirect("Gonderlilenler.aspx");


    }
}