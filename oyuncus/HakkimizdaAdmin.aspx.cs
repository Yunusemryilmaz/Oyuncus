using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class HakkimizdaAdmin : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    protected void Page_Load(object sender, EventArgs e)
    {
        bgl.baglanti().Open();
        
        if (Page.IsPostBack == false)
        {   //Hakkımızda kısmını çekiyorum
            SqlCommand komut = new SqlCommand("Select * from tbl_hakkimizda", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                TextBox1.Text = oku[0].ToString();

            }
            bgl.baglanti().Close();
        }
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {   //Textboxa çektiğim hakkımızda kısmının üzerinde yazanları tekrar dataya atıyorum
        bgl.baglanti().Open();
        
        SqlCommand komut = new SqlCommand("Update tbl_Hakkimizda set metin=@p1", bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", TextBox1.Text);
        komut.ExecuteNonQuery();
        bgl.baglanti().Close();
    }
}