using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class Kategoriler : System.Web.UI.Page
{
    sqlsinif bgl = new sqlsinif();
    string kategoriid = "";
    string islem = "";
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            kategoriid = Request.QueryString["kategoriid"];
            islem = Request.QueryString["islem"];
        }

        //Kategori Listeleme

        SqlCommand komut = new SqlCommand("Select * From Tbl_Kategoriler", bgl.baglanti());
        SqlDataReader oku = komut.ExecuteReader();
        DataList1.DataSource = oku;
        DataList1.DataBind();

        //Kategori Silme
        
        if (islem == "sil")
        {
            
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Kategoriler where kategoriid=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", kategoriid);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();

        }

        if (Page.IsPostBack == false)
        {
            Panel2.Visible = false;
            Panel4.Visible = false;
        }
    }

    protected void BtnEkle_Click(object sender, EventArgs e)
    {//Yeni kategoriyi ekliyorum
        SqlCommand komut = new SqlCommand("insert into Tbl_Kategoriler (kategoriad) values(@p1)",bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", TextBox1.Text);
        komut.ExecuteNonQuery();
        bgl.baglanti().Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {//panel aç kapa işlemi için buton
        if (Panel2.Visible == false)
        {
            Panel2.Visible = true;
        }
        else if (Panel2.Visible == true)
        {
            Panel2.Visible = false;
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {//panel aç kapa işlemi için buton
        if (Panel4.Visible == false)
        {
            Panel4.Visible = true;
        }
        else
        {
            Panel4.Visible = false;
        }
    }
}