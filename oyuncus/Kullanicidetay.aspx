<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Kullanicidetay.aspx.cs" Inherits="Kullanicidetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style14 {
            width: 221px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style8">
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style14">Kullanici Adı:</td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">Kullanıcı Rolü:</td>
            <td>
                
                <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="210px">
                    <asp:ListItem>Rol Seçiniz</asp:ListItem>
                    <asp:ListItem Value="True">Admin</asp:ListItem>
                    <asp:ListItem Value="False">Kullanıcı</asp:ListItem>
                  </asp:DropDownList>
                
            </td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Güncelle" Width="207px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td>
                <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

