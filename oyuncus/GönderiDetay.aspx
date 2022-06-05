<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="GönderiDetay.aspx.cs" Inherits="GönderiDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style13 {
            margin-left: 40px;
        }
        .auto-style14 {
            border: 2px solid #456789;
            border-radius: 3px;
        }
        .auto-style15 {
            height: 32px;
            width: 150px;
        }
        .auto-style16 {
            height: 32px;
            margin-left: 40px;
            width: 322px;
        }
        .auto-style18 {
            height: 29px;
            width: 150px;
        }
        .auto-style19 {
            margin-left: 40px;
            height: 29px;
            width: 322px;
        }
        .auto-style20 {
            width: 150px;
        }
        .auto-style23 {
            width: 322px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style8">
        <tr>
            <td class="auto-style20">&nbsp;</td>
            <td class="auto-style23">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style18">OYUN ADI:</td>
            <td class="auto-style19">
                <asp:TextBox ID="TextBox4" runat="server" CssClass="tb"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style18">RESİM EKLE:</td>
            <td class="auto-style19">
                <asp:FileUpload ID="FileUpload1" runat="server" CssClass="auto-style14" Width="234px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style15">OYUN İÇERİK:</td>
            <td class="auto-style16">
                <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style14" Height="167px" TextMode="MultiLine" Width="232px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">YAZAR:</td>
            <td class="auto-style16">
                <asp:TextBox ID="TextBox6" runat="server" CssClass="tb" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">YAZAR MAİL:</td>
            <td class="auto-style16">
                <asp:TextBox ID="TextBox7" runat="server" CssClass="tb"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style15">KATEGORİ:</td>
            <td class="auto-style16">
                <asp:DropDownList ID="DropDownList1" runat="server" >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style15"></td>
            <td class="auto-style16">
                <asp:Button ID="Button1" runat="server" CssClass="fb" Text="Onay" OnClick="Button1_Click" Width="230px" />
            </td>
        </tr>
    </table>
</asp:Content>

