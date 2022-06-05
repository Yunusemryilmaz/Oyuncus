<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Iletisim.aspx.cs" Inherits="Iletisim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style10 {
        width: 100%;
    }
    
    .auto-style12 {
        font-size: large;
        text-align: center;
    }
        .auto-style13 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style10">
    <tr>
        <td class="auto-style12" colspan="2"><strong>MESAJ PANELİ</strong></td>
    </tr>
    <tr>
        <td>Ad Soyad:</td>
        <td>
            <asp:TextBox ID="Txtgonderen" runat="server" Width="200px" CssClass="tb"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Mail:</td>
        <td>
            <asp:TextBox ID="TxtMail" runat="server" AutoCompleteType="Email" Width="200px" CssClass="tb" TextMode="Email" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Mesaj Başlık:</td>
        <td>
            <asp:TextBox ID="TxtBaslik" runat="server" Width="200px" CssClass="tb"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Mesaj:</td>
        <td>
            <asp:TextBox ID="TxtMesaj" runat="server" Height="161px" TextMode="MultiLine" Width="200px" CssClass="tb"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td><strong>
            <asp:Button ID="Button1" runat="server" CssClass="fb" Text="Gönder" Width="208px" OnClick="Button1_Click" />
            </strong></td>
    </tr>
    <tr>
        <td class="auto-style13" colspan="2">
            <strong>
            <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
            </strong>
        </td>
    </tr>
</table>
</asp:Content>

