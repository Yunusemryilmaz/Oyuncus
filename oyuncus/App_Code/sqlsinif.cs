using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
//"Data Source=.\SQLEXPRESS; Initial Catalog = oyuncus; Integrated Security = True"
public class sqlsinif
{
    public static string name = "";
    
   
    public SqlConnection baglanti()
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=oyuncus;Integrated Security=True; Pooling=false;");
        baglan.Open();
        return baglan;
       
    }
}
