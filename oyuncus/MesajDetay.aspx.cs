using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class MesajDetay : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    string mesajid = "";
    protected void Page_Load(object sender, EventArgs e)
    {   
        //mesaj bilgilerini gerekli labellara çekiyorum
        mesajid = Request.QueryString["mesajid"];
        SqlCommand komut = new SqlCommand("Select * From Tbl_Mesajlar where mesajid=@p1",bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", mesajid);
        SqlDataReader oku = komut.ExecuteReader();
        
        while (oku.Read())
        {
            Label1.Text = oku[1].ToString();
            Label2.Text = oku[2].ToString();
            Label3.Text = oku[3].ToString();
            Label4.Text = oku[4].ToString();
        }
        bgl.baglanti().Close();
    }
}