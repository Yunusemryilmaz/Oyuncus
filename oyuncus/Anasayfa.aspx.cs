using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Anasayfa : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    protected void Page_Load(object sender, EventArgs e)
    {   //oyunları son eklenen başlayarak sıralıyorum
        
        SqlCommand komut = new SqlCommand("Select * from Tbl_Oyunlar order by oyunid desc", bgl.baglanti());
        SqlDataReader oku = komut.ExecuteReader();
        DataList2.DataSource = oku;
        DataList2.DataBind();
        bgl.baglanti().Close();


    }
}