using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


public partial class Arama : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //Master pageden başka bir sayada arama yapabilmek için gereken bağlantıları yapıyorum
        string anabaglanti = ConfigurationManager.ConnectionStrings["baglantim"].ConnectionString;
        SqlConnection baglanti = new SqlConnection(anabaglanti);
        baglanti.Open();
       
        SqlCommand komut = new SqlCommand();
        //Aranan değer ile eşlenen değerleri datadan çekiyorum
        string sqlquary = "select* from[dbo].[Tbl_Oyunlar] where oyunad like '%' + @oyunadi + '%'";
        komut.CommandText = sqlquary;
        komut.Connection = baglanti;
        //Master pageden gelen result değişkenini parametreme atıyorum
        komut.Parameters.AddWithValue("oyunadi",Request.QueryString["result"]);
        DataTable dt = new DataTable();
        SqlDataAdapter sda = new SqlDataAdapter(komut);
        sda.Fill(dt);
        DataList2.DataSource = dt;
        DataList2.DataBind();
        baglanti.Close();
        
       
    }
}