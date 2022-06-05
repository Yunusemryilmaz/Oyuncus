using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
public partial class OyunDüzenle : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    //Her sınıftan çağırabilmek için public kısımda id tanımlıyorum
    


    protected void Page_Load(object sender, EventArgs e)
    {


        if (Page.IsPostBack == false)
        {   //Düzenlenecek oyunun idsini alıyorum
            string oyunid = Request.QueryString["oyunid"];
        

        //oyun bilgilerini çekiyorum
        SqlCommand komut = new SqlCommand("Select * from Tbl_Oyunlar where oyunid=@p1", bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", oyunid);
        SqlDataReader oku = komut.ExecuteReader();
        while (oku.Read())
        {

            TextBox1.Text = oku[1].ToString();
            TextBox2.Text = oku[3].ToString();
            Image2.ImageUrl = oku[2].ToString();


        }
        bgl.baglanti().Close();

        if (Page.IsPostBack == false)
        {
            SqlCommand komut2 = new SqlCommand("Select * from Tbl_Kategoriler", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            DropDownList1.DataTextField = "kategoriad";
            DropDownList1.DataValueField = "kategoriid";
            DropDownList1.DataSource = oku2;
            DropDownList1.DataBind();

            bgl.baglanti().Close();


        }

        }
        
    
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       string oyunid = Request.QueryString["oyunid"];
        //Değişen kategoriden 1 çıkarıyorum
        SqlCommand kmteksilt = new SqlCommand("Update Tbl_Kategoriler set kategoriadet=kategoriadet-1 from Tbl_Kategoriler inner join Tbl_Oyunlar on Tbl_Kategoriler.kategoriid = Tbl_Oyunlar.kategoriid where oyunid=@a1", bgl.baglanti());
        kmteksilt.Parameters.AddWithValue("@a1", oyunid);
        kmteksilt.ExecuteNonQuery();
        bgl.baglanti().Close();


        //Yeni kategoriye 1 ekliyorum
        SqlCommand komut2 = new SqlCommand("update Tbl_Kategoriler set kategoriadet=kategoriadet+1 where kategoriid=@a", bgl.baglanti());
        komut2.Parameters.AddWithValue("@a", DropDownList1.SelectedValue);
        komut2.ExecuteNonQuery();
        bgl.baglanti().Close();

       

        //Yenilenen bilgileri ekliyorum
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("~/resimler/oyunlar" + oyunid + ".jpg"));

            SqlCommand komut = new SqlCommand("update Tbl_Oyunlar set oyunad=@p1,oyunbilgi=@p2,kategoriid=@p3,oyunresim=@p4 where oyunid=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TextBox1.Text);
            komut.Parameters.AddWithValue("@p2", TextBox2.Text);
            komut.Parameters.AddWithValue("@p3", DropDownList1.SelectedValue);
            komut.Parameters.AddWithValue("@p4", "~/resimler/oyunlar" + oyunid + ".jpg");
            komut.Parameters.AddWithValue("@p6", oyunid);
            komut.ExecuteNonQuery();
           
            


        }
        else
        {

            SqlCommand komut = new SqlCommand("update Tbl_Oyunlar set oyunad=@p1,oyunbilgi=@p2,kategoriid=@p3 where oyunid=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TextBox1.Text);
            komut.Parameters.AddWithValue("@p2", TextBox2.Text);
            komut.Parameters.AddWithValue("@p3", DropDownList1.SelectedValue);
            komut.Parameters.AddWithValue("@p4", oyunid);
            komut.ExecuteNonQuery();
            
        }

        Response.Redirect("Oyunlar.aspx");


        
        

    }
}