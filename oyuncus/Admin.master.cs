using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Admin : System.Web.UI.MasterPage
{
    sqlsinif bgl = new sqlsinif();
    //Her classdan çağırabilmek için public tanımlaama yapıyorum.
    string islem = "";
    string rol = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        

        object admin = Session["kullaniciad"];
        //Admin mi olup olmadığını kontrol ediyorum.
        SqlCommand admn = new SqlCommand("Select kullanicirol from Tbl_Kullanicilar where kullaniciad=@p1", bgl.baglanti());
        admn.Parameters.AddWithValue("@p1", sqlsinif.name);
        SqlDataReader okuadmn = admn.ExecuteReader();

        while (okuadmn.Read())
        {
            rol = okuadmn[0].ToString();
        }
        bgl.baglanti().Close();

        //Sayfaya linkden gelen giriş yapmış adminlare panelleri göstermek için kontrol yapıyorum
        if (rol=="True")
        {
            Panelgiris.Visible = false;
            Paneladmin.Visible = true;
            panelkategori.Visible = true;
            adminad.Text = sqlsinif.name;
            bgl.baglanti().Close();
        }
        //sayfada giriş yapanlara panelleri göstermek için kontrol yapıyorum
        else if (admin != null)
        {
            
            Panelgiris.Visible = false;
            Paneladmin.Visible = true;
            panelkategori.Visible = true;
            adminad.Text = admin.ToString();
            bgl.baglanti().Close();


        }
        else
        {
            Panelgiris.Visible = true;
            Paneladmin.Visible = false;
            panelkategori.Visible = false;
            bgl.baglanti().Close();

        }

       


    }

    protected void BtnGiris_Click(object sender, EventArgs e)
    {
        //Girilen parolayı datadaki parolalarla kıyaslamak için şifreliyorum
        
        string pasword = Sifreleme.ComputeSha256Hash(TxtParola.Text);
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kullanicilar where kullaniciad=@p1 and kullanicisifre = @p2 and kullanicirol= @p3 ", bgl.baglanti());
           
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2",pasword );
            komut.Parameters.AddWithValue("@p3", "true");
            SqlDataReader oku = komut.ExecuteReader();
        bgl.baglanti().Close();
        
        //Okuma işlemi gerçekleşiyorsa giriş yapılmasına izin veriyorum
        if (oku.Read())
            {
                Session.Timeout = 300;
                Session.Add("kullaniciad", oku["kullaniciad"].ToString());
                Response.Redirect(Request.RawUrl);
                 bgl.baglanti().Close();


        }
        else
            {
                Label3.Text = "Hatalı şifre veya kullanıcı adı.";
            }


    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {   //Global değişkeni çıkış yapınca boş hale getiriyorum.
        
        sqlsinif.name = "";
        Session.Abandon();
        Response.Redirect("Anasayfa.aspx");
    }
}
