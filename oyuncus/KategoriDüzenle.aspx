<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="KategoriDüzenle.aspx.cs" Inherits="KategoriDüzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style8">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td >Kategori Ad:</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="tb"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td >Adet:</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="tb"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" CssClass="fb" OnClick="Button1_Click" Text="Güncelle" Width="237px" />
            </td>
        </tr>
    </table>
</asp:Content>

