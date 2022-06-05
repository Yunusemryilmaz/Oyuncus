using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Yorumlar : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    string islem = "";
    string yorumid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            yorumid = Request.QueryString["yorumid"];
            islem = Request.QueryString["islem"];

        
        //onayli yorumlar
        SqlCommand komut = new SqlCommand("Select kullaniciad,yorumid from Tbl_Yorumlar inner join Tbl_Kullanicilar on Tbl_Yorumlar.kullaniciid = Tbl_Kullanicilar.kullaniciid where yorumonay=1", bgl.baglanti());
        SqlDataReader oku = komut.ExecuteReader();
        DataList1.DataSource = oku;
        DataList1.DataBind();
        



        //onaysiz yorumlar
        SqlCommand komut2 = new SqlCommand("Select kullaniciad,yorumid from Tbl_Yorumlar inner join Tbl_Kullanicilar on Tbl_Yorumlar.kullaniciid = Tbl_Kullanicilar.kullaniciid where yorumonay=0", bgl.baglanti());
        SqlDataReader oku2 = komut2.ExecuteReader();
        DataList2.DataSource = oku2;
        DataList2.DataBind();
        }
        if (islem == "sil")
        {
           
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Yorumlar where yorumid=@a", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@a", yorumid);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            Response.Redirect("Yorumlar.aspx");

        }



    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Panel1.Visible == false)
        {
            Panel1.Visible = true;
        }
        else 
        {
            Panel1.Visible = false;
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
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