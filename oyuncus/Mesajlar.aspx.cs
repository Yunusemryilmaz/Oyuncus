using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Mesajlar : System.Web.UI.Page
{
    string mesajid = "";
    string islem = "";
    sqlsinif bgl = new sqlsinif();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
        if (Page.IsPostBack == false)
        { //mesaj id ve islem değişkenini çekiyorum
            Panel1.Visible = false;
            mesajid = Request.QueryString["mesajid"];
            islem = Request.QueryString["islem"];
        }
        //Mesajları getiriyorum
        SqlCommand komut = new SqlCommand("Select * From Tbl_Mesajlar", bgl.baglanti());
        SqlDataReader oku = komut.ExecuteReader();
        DataList1.DataSource = oku;
        DataList1.DataBind();



        if (islem =="sil")
        {
            //işlem sil ise seçilen idye ait mesajı siliyorum
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Mesajlar where mesajid=@a", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@a", mesajid);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {//panel açma/kapama
        if (Panel1.Visible == false)
        {
            Panel1.Visible = true;
        }
        else
        {
            Panel1.Visible = false;
        }
    }
}