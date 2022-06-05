<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Kategoridetay.aspx.cs" Inherits="Kategoridetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <table>
         <tr>
            <td>
                <asp:DataList ID="DataList2" runat="server" RepeatLayout="Flow" CssClass="hidebr"  >
                    <ItemTemplate>
                       <a href="oyundetay.aspx?oyunid=<%#Eval("oyunid")%>">  <asp:Image ID="Image2"  CssClass="imgdl" runat="server" ImageUrl='<%# Eval("oyunresim") %>' /> </a>
                    </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
    </table>
    
    <ItemStyle HorizontalAlign="Center" VerticalAlign="Top" 
	CssClass="tdContainer"/>
</asp:Content>

