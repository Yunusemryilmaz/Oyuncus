using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Kullanicidetay : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    string kullaniciid = "";


    protected void Page_Load(object sender, EventArgs e)
    {//kullaniciidsini çekiyorum
        kullaniciid = Request.QueryString["kullaniciid"];
        
       
        
        if (Page.IsPostBack == false)
        {
            //Kullanici id ile kullanici adini çekiyorum
            SqlCommand komut = new SqlCommand("Select kullaniciad from Tbl_Kullanicilar where kullaniciid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", kullaniciid);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Label1.Text = oku["kullaniciad"].ToString();


            }
            bgl.baglanti().Close();





        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        { //kullanici rolü düzenleme
            SqlCommand komut = new SqlCommand("update Tbl_Kullanicilar set kullanicirol=@p1 where kullaniciid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", DropDownList1.SelectedValue.ToString());
            komut.Parameters.AddWithValue("@p2", kullaniciid);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Response.Redirect("Kullanicilar.aspx");
        }
        catch
        {

            Label4.Text = DropDownList1.SelectedValue.ToString();
        }
        
        
    }
}