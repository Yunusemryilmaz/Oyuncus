<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Kategoriler.aspx.cs" Inherits="Kategoriler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style13 {
        text-align: right;
            height: 34px;
        }
    .auto-style14 {
        text-align: left;
            width: 402px;
            height: 34px;
        }
        .auto-style15 {
            text-align: right;
            width: 200px;
            height: 34px;
        }
        .auto-style19 {
            width: 236px;
        }
        .auto-style20 {
            border: 2px solid #456789;
            border-radius: 3px;
            outline: none;
            font-size: large;
        }
        .auto-style22 {
            width: 413px;
            height: 45px;
            font-size: large;
        }
        .auto-style23 {
            border: 2px solid #456789;
            border-radius: 3px;
            outline: none;
            font-size: large;
            height: 45px;
            width: 43px;
            text-align: center;
        }
        .auto-style25 {
            width: 234px;
        }
        .auto-style27 {
            border: 2px solid #456789;
            border-radius: 3px;
            outline: none;
            font-size: large;
            height: 45px;
            width: 40px;
            text-align: center;
        }
        .auto-style28 {
            text-align: right;
            width: 30px;
            height: 34px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" Width="479px">
        <table class="auto-style8">
            <tr>
               
                <td class="auto-style22" style="border-style: double"><strong>KATAGORİ LİSTESİ</strong></td>
                <td class="auto-style27"><strong>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style20" Height="40px" OnClick="Button1_Click" Text="+/-" Width="40px" />
                    </strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <asp:DataList ID="DataList1" runat="server" Width="476px">
            <ItemTemplate>
                <table class="auto-style8" style="border: thin groove #99CCFF">
                    <tr>
                        <td class="auto-style14">
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("kategoriad") %>'></asp:Label>
                        </td>
                        <td class="auto-style15">
                            <a href="Kategoriler.aspx?kategoriid=<%#Eval("kategoriid") %>&islem=sil"> <asp:Image ID="Image1" runat="server" Height="30px" ImageUrl="~/Iconlar/delete.png" Width="30px" /></a>
                        </td>
                        <td class="auto-style28">
                          <a href="KategoriDüzenle.aspx?kategoriid=<%#Eval("kategoriid") %>">  <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/Iconlar/refresh.png" Width="30px" /></a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
        <div></div>
</asp:Panel>
    <asp:Panel ID="Panel3" runat="server">
        <table class="auto-style8">
            <tr>
                <td class="auto-style22" style="border-style: double"><strong>KATAGORİ EKLEME</strong></td>
                <td class="auto-style23"><strong>
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style20" Height="40px" OnClick="Button2_Click" Text="+/-" Width="40px" />
                    </strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server">
        <table class="auto-style8">
            <tr>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style25">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style19">KATAGORİ AD:&nbsp;</td>
                <td class="auto-style25">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="tb" Width="225px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style19">&nbsp;</td>
                <td class="auto-style25">
                    <asp:Button ID="BtnEkle" runat="server" CssClass="fb" OnClick="BtnEkle_Click" Text="EKLE" />
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

