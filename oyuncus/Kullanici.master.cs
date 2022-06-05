using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class Kullanici : System.Web.UI.MasterPage
{
    sqlsinif bgl = new sqlsinif();
    Sifreleme sfr = new Sifreleme();

    protected void Page_Load(object sender, EventArgs e)
    {
        
        string datetime = "";
        string date = "";
        string rol = "";
        //Kullanici bilgilerini çekiyorum
        SqlCommand komut = new SqlCommand("Select  kullaniciad,kullanicitarih,kullanicifoto from Tbl_kullanicilar where kullaniciad=@p1", bgl.baglanti());
        komut.Parameters.AddWithValue("@p1", sqlsinif.name);
        SqlDataReader oku = komut.ExecuteReader();
        

        while (oku.Read())
        {


            //Kaydolma tarihinin sonundaki 00:00:00 silmek için for döngüsü kullanıyorum yapıyorum :(
            Label4.Text = oku[0].ToString();
            datetime = oku[1].ToString();
            for (int i = 0; i < datetime.Length - 8; i++)
            {
                date = date + datetime[i].ToString();
            }
            Label5.Text = date;
            profilfoto.ImageUrl = oku[2].ToString();


        }
        oku.Close();
        bgl.baglanti().Close();

        //admin kontrolü yapıyorum
        
        SqlCommand admn = new SqlCommand("Select kullanicirol from Tbl_Kullanicilar where kullaniciad=@p1", bgl.baglanti());
        admn.Parameters.AddWithValue("@p1", sqlsinif.name);
        SqlDataReader okuadmn = admn.ExecuteReader();

        while (okuadmn.Read())
        {
            rol = okuadmn[0].ToString();
        }
        bgl.baglanti().Close();


        //adminse eper profil ve admin paneli kısmını görünür kılıyorum
        if (rol == "True")
        {
            pnlgirisekran.Visible = false;
            pnlkullaniciad.Visible = true;
            profil.Visible = true;
            admin.Visible = true;

        }
        //kullanıcı ise profil kısmını görünür yapıyorum

        else if (sqlsinif.name != "")
        {
            pnlgirisekran.Visible = false;
            pnlkullaniciad.Visible = true;
            profil.Visible = true;
            admin.Visible = false;


        }
        else
        {
            pnlkullaniciad.Visible = false;
            pnlgirisekran.Visible = true;
            profil.Visible = false;
            admin.Visible = false;


        }
        //Eval verdiğim menüdeki kategori kısmını çekiyorum
        
        SqlCommand komut1 = new SqlCommand("Select * from Tbl_Kategoriler", bgl.baglanti());
        SqlDataReader oku2 = komut1.ExecuteReader();
        DataList1.DataSource = oku2;
        DataList1.DataBind();
        bgl.baglanti().Close();
    }



    protected void BtnArama_Click(object sender, EventArgs e)
    {//Arama sayfasına göndereceğimiz result değerini çekiyorum
        string result = "Arama.aspx?result=" + TxtArama.Text;
        Response.Redirect(result);
    }


    protected void btncikis_Click(object sender, EventArgs e)
    {//Global değişkeni sıfırlayıp sayfayı yeniliyorum
        sqlsinif.name = "";
        Response.Redirect(Request.RawUrl);
    }


    protected void BtnGiris_Click(object sender, EventArgs e)
    {
        //Gerekli bilgileri çekiyorum
        
        SqlCommand komut = new SqlCommand("Select * From Tbl_Kullanicilar where kullaniciad=@p1 and kullanicisifre = @p2 ", bgl.baglanti());
        string sfrpar = Sifreleme.ComputeSha256Hash(TxtParola.Text);
        komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
        komut.Parameters.AddWithValue("@p2", sfrpar);
        SqlDataReader oku = komut.ExecuteReader();


        if (oku.Read())
        {
            Session.Timeout = 300;
            //Global değişkene değerini veriyorum
            sqlsinif.name = oku["kullaniciad"].ToString();
            Response.Redirect(Request.RawUrl);

        }
        else
        {
            Label3.Text = "Hatalı şifre veya kullanıcı adı.";
        }


        bgl.baglanti().Close();



    }
}
