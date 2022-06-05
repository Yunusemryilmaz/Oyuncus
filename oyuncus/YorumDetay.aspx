<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="YorumDetay.aspx.cs" Inherits="YorumDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style14 {
            border: 2px solid #456789;
            border-radius: 3px;
            outline: none;
            font-weight: bold;
        }
        .auto-style15 {
            text-align: right;
            font-size: large;
        }
        .auto-style16 {
            border: 2px solid #456789;
            border-radius: 3px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style8">
        <tr>
            <td class="auto-style15"><strong>Ad Soyad:</strong></td>
            <td>
                <asp:TextBox ID="TxtAd" runat="server" CssClass="tb"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style15"><strong>Mail:</strong></td>
            <td>
                <asp:TextBox ID="TxtMail" runat="server" CssClass="tb"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style15"><strong>İçerik:</strong></td>
            <td>
                <asp:TextBox ID="TxtIcerik" runat="server" CssClass="auto-style16" Height="61px" TextMode="MultiLine" Width="233px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style15"><strong>Oyun:</strong></td>
            <td>
                <asp:TextBox ID="TxtOyun" runat="server" CssClass="tb"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td><strong>
                <asp:Button ID="BtnOnay" runat="server" CssClass="auto-style14" Text="Onay" Width="235px" OnClick="BtnOnay_Click" />
                </strong></td>
        </tr>
    </table>
</asp:Content>

