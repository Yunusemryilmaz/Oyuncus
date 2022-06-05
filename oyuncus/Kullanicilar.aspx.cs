using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Kullanicilar : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    protected void Page_Load(object sender, EventArgs e)
    {
        string islem = "";
        string kullaniciid = "";
        string ad = "";
        if (Page.IsPostBack == false)
        {
            kullaniciid = Request.QueryString["kullaniciid"];
            islem = Request.QueryString["islem"];
            //kullaniciları çekip dataliste yayınlıyorum
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kullanicilar", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            DataList1.DataSource = oku;
            DataList1.DataBind();

           


            Panel4.Visible = false;
            Panel2.Visible = false;
        }
       

        if (islem == "sil")
        {//silme butonuna basılırsa idye göre silme işlemi yapıyorum
            SqlCommand cmd = new SqlCommand("select kullaniciad from Tbl_Kullanicilar where kullaniciid=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", kullaniciid);
            SqlDataReader okucmd = cmd.ExecuteReader();

            while (okucmd.Read())
            {
                ad = okucmd[0].ToString();
            }
            bgl.baglanti().Close();

            //Kullaniciyi silerken yaptığı yorumdan dolayı hata almamak için önce yorumlarını siliyoruz

            SqlCommand komutyorumsil = new SqlCommand("Delete From Tbl_Yorumlar where kullaniciid=@a", bgl.baglanti());
            komutyorumsil.Parameters.AddWithValue("@a", kullaniciid);
            komutyorumsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            //Kullaniciyi siliyorum
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Kullanicilar where kullaniciid=@a", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@a", kullaniciid);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();

            if(ad == sqlsinif.name)
            {   
                //kullanici kenidini sildiyse çıkış yapmasını sağlıyorum
                sqlsinif.name = "";
                Session.Abandon();
                 Response.Redirect("Anasayfa.aspx");
            }
           


        }


    }



    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Panel4.Visible == false)
        {
            Panel4.Visible = true;

        }

        SqlCommand arama = new SqlCommand("Select * from Tbl_Kullanicilar where kullaniciad like '%' + @kullaniciad + '%'", bgl.baglanti());
        arama.Parameters.AddWithValue("@kullaniciad", TextBox1.Text);
        SqlDataReader oku = arama.ExecuteReader();
        DataList2.DataSource = oku;
        DataList2.DataBind();
    }

    protected void Button1_Click1(object sender, EventArgs e)
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
}