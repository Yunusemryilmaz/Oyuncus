using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Gonderlilenler : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    string islem = "";
    string gonderiid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        bgl.baglanti().Close();
        if (Page.IsPostBack == false)
        {   //Sayfa yüklendiğinde public tanımladığım değişkenlerime değer veriyorum ve değişmemeleri için 
            //if içinde yazıyorum
            gonderiid = Request.QueryString["gonderiid"];
            islem = Request.QueryString["islem"];
            Panel1.Visible = false;
        }   
        //Gönderileri datalist içine çekiyorum
        SqlCommand komut = new SqlCommand("Select * From Tbl_Gonderi", bgl.baglanti());
        SqlDataReader oku = komut.ExecuteReader();
        DataList1.DataSource=oku;
        DataList1.DataBind();
        //Silme ikonuna verdiğim eval sayesinde islem değişkeninin sil olduğunu kontrol ediyorum
        if (islem == "sil")
        {
            //Seçilen gönderiyi idsine göre siliyorum
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Gonderi where gonderiid=@a", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@a", gonderiid);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();


        }
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {//Panel açıp kapamak için button kullanıyorum
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