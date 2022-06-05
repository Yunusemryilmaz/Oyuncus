using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Oyunlar : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
   
    string islem = "";
    string oyunid = "";
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Page.IsPostBack == false)
        {   //oyunid ve işlem değişkenleri sayfa başında çekiyorum
            oyunid = Request.QueryString["oyunid"];
            islem = Request.QueryString["islem"];
            //panelleri başlangıçta gizliyorum
            Panel2.Visible = false;
            Panel4.Visible = false;
            Panel6.Visible = false;
            //Kategoriler tablosundan kategoad ve kategoriidyi değer
            //ve gösterilcek kısım olarak çekip dropdownliste atıyorum
            SqlCommand komut2 = new SqlCommand("Select * from Tbl_Kategoriler", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            DropDownList1.DataTextField = "kategoriad";
            DropDownList1.DataValueField = "kategoriid";
            DropDownList1.DataSource = oku2;
            DropDownList1.DataBind();



        }









        //oyunlar listesi
        SqlCommand komut = new SqlCommand("Select * From Tbl_Oyunlar order by oyunid desc ", bgl.baglanti());
        SqlDataReader oku = komut.ExecuteReader();
        DataList1.DataSource = oku;
        DataList1.DataBind();

        //Oyun Silme

        if (islem == "sil")
        {
            SqlCommand kmteksilt = new SqlCommand("Update Tbl_Kategoriler set kategoriadet=kategoriadet-1 from Tbl_Kategoriler inner join Tbl_Oyunlar on Tbl_Kategoriler.kategoriid = Tbl_Oyunlar.kategoriid where oyunid=@a1",bgl.baglanti());
            kmteksilt.Parameters.AddWithValue("@a1", oyunid);
            kmteksilt.ExecuteNonQuery();
            bgl.baglanti().Close();


            //Hata almamak için önce yorumları siliyoruz.
            SqlCommand komutsil = new SqlCommand("Delete Tbl_Yorumlar where oyunid=@a", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@a", oyunid);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            //Oyunları Siliyoruz.
            SqlCommand komutsil2 = new SqlCommand("Delete from Tbl_Oyunlar where oyunid=@a", bgl.baglanti());
            komutsil2.Parameters.AddWithValue("@a", oyunid);
            komutsil2.ExecuteNonQuery();
            bgl.baglanti().Close();
            
            Response.Redirect("Oyunlar.aspx");
            

        }

        
        
        
        
        
        
        
        
        
        
       
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Panel2.Visible == false)
        {
            Panel2.Visible = true;
        }
        else
        {
            Panel2.Visible = false;
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Panel4.Visible == false)
        {
            Panel4.Visible = true;
        }
        else
        {
            Panel4.Visible = false;
        }
    }

    protected void BtnEkle_Click(object sender, EventArgs e)
    {

        string kategoriid = "";
        kategoriid = DropDownList1.SelectedValue;
        //Kategori Sayısını 1 arttırma
        SqlCommand komut2 = new SqlCommand("update Tbl_Kategoriler set kategoriadet=kategoriadet+1 where kategoriid=@p1", bgl.baglanti());
        komut2.Parameters.AddWithValue("@p1", kategoriid);
        komut2.ExecuteNonQuery();
        bgl.baglanti().Close();

        //Oyun ekleme
        SqlCommand komut = new SqlCommand("insert into Tbl_Oyunlar (oyunad , oyunbilgi , kategoriid) values (@p1,@p2,@p3)",bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", TextBox1.Text);
        komut.Parameters.AddWithValue("@p2", TextBox2.Text);
        komut.Parameters.AddWithValue("@p3", kategoriid);
        komut.ExecuteNonQuery();
        bgl.baglanti().Close();
        


        string id = "";

        SqlCommand kmt = new SqlCommand("SELECT top 1 * FROM Tbl_oyunlar order by oyunid desc ", bgl.baglanti());
        SqlDataReader read = kmt.ExecuteReader();
        while (read.Read())
        {
            id = read[0].ToString();
        }
        bgl.baglanti().Close();

        if (FileUpload1.HasFile)
        {

            FileUpload1.SaveAs(Server.MapPath("~/resimler/oyunlar") + id + ".jpg");

        }


        SqlCommand kmt1 = new SqlCommand("update Tbl_Oyunlar set oyunresim=@p1 where oyunid=@p2", bgl.baglanti());
        kmt1.Parameters.AddWithValue("p2", id);
        kmt1.Parameters.AddWithValue("@p1", "~/resimler/oyunlar" + id + ".jpg");
        kmt1.ExecuteNonQuery();
        bgl.baglanti().Close();

        
        
        Response.Redirect("Oyunlar.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        if (Panel6.Visible == false)
        {
            Panel6.Visible = true;

        }
        //oyun arama
        SqlCommand arama = new SqlCommand("Select * from Tbl_Oyunlar where Oyunad like '%' + @oyunad + '%'", bgl.baglanti());
      
        arama.Parameters.AddWithValue("@oyunad", oyunara.Text);
        SqlDataReader oku = arama.ExecuteReader();
        DataList2.DataSource = oku;
        DataList2.DataBind();
    }
}