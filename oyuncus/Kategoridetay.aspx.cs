using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Kategoridetay : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    string kategoriid = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        //Girilen kategori sayfasına ait oyunları çekiyorum ve en son eklenen en 
        //üstte olcak şekilde sıralıyorum
        kategoriid = Request.QueryString["kategoriid"];
        SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Oyunlar  WHERE kategoriid = @p1 ORDER BY oyunid desc ", bgl.baglanti());
        
        komut.Parameters.AddWithValue("@p1", kategoriid);
        SqlDataReader oku = komut.ExecuteReader();
        DataList2.DataSource = oku;
        DataList2.DataBind();
    }
}
