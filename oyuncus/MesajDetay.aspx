<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="MesajDetay.aspx.cs" Inherits="MesajDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style13 {
            height: 23px;
        }
        .auto-style14 {
            width: 150px;
        }
        .auto-style15 {
            height: 23px;
            width: 150px;
        }
        .auto-style16 {
            width: 150px;
            height: 26px;
        }
        .auto-style17 {
            height: 26px;
        }
        .auto-style18 {
            height: 23px;
            float: left;
            color: #555;
            overflow: hidden;
            white-space: normal;
            box-shadow: 0px 0px 12px 1px rgba(0, 0, 0, 0.3);
            text-align: left;
            margin-left: 130px;
            padding-left: 17.5px;
            padding-right: 17.5px;
            padding-top: 30px;
            padding-bottom: 17.5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style8" style="border-style: double">
        <tr>
            <td class="auto-style16" style="border-style: double"><strong>Mesaj Gönderen:</strong></td>
            <td class="auto-style17" style="border-style: double">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style15" style="border-style: double"><strong>Baslık:</strong></td>
            <td class="auto-style17" style="border-style: double">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style14" style="border-style: double"><strong>Mail:</strong></td>
            <td style="border-style: double">
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" style="border-style: double"><strong>Mesaj İçeriği:</strong></td>
            <td class="auto-style17" style="border-style: double">
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

