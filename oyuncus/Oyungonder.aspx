<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Oyungonder.aspx.cs" Inherits="Oyungonder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style9 {
        width: 309px;
        margin-left: 40px;
    }
    .auto-style10 {
        width: 29%;
        text-align: right;
    }
    .auto-style12 {
        width: 309px;
    }
        .auto-style17 {
            width: 700px;
            height: 45px;
            text-align: center;
            margin-left: 40px;
        }
        .auto-style18 {
            width: 29%;
            text-align: left;
        }
        .auto-style19 {
            text-align: center;
        }
        .auto-style20 {
            width: 309px;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style10">&nbsp;</td>
        <td class="auto-style20">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style10"><strong>Oyun Adı:</strong></td>
        <td class="auto-style12">
            <asp:TextBox ID="TxtOyunad" runat="server" Width="300px" CssClass="tb"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style10"><strong>Oyun İçeriği:</strong></td>
        <td class="auto-style9">
            <asp:TextBox ID="Txtoyuniçerik" runat="server" Height="250px" TextMode="MultiLine" Width="300px" CssClass="tb"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style10"><strong>İsim:</strong>

        </td> 
        
        <td class="auto-style9">
            <asp:TextBox ID="Txtisim" runat="server" Width="300px" CssClass="tb"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style10"><strong>Mail:</strong></td>
        <td class="auto-style9">
            <asp:TextBox ID="Txtmail" runat="server" AutoCompleteType="Email" Width="300px" CssClass="tb"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style18">&nbsp;</td>
        <td class="auto-style17">
            <asp:Button ID="Btnoyungönder" runat="server" CssClass="fb" Height="35px" Text="Gönder" Width="100px" OnClick="Btnoyungönder_Click" />
        </td>
    </tr>
    <tr>
        <td class="auto-style19" colspan="2"><strong>
            <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
            </strong></td>
    </tr>
</table>
</asp:Content>

