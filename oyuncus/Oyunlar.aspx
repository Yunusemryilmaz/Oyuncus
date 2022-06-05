<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Oyunlar.aspx.cs" Inherits="Oyunlar" %>



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
        .auto-style20 {
            border: 2px solid #456789;
            border-radius: 3px;
            outline: none;
            font-size: large;
        }
        .auto-style21 {
            border: 2px solid #456789;
            border-radius: 3px;
        }
        .auto-style22 {
            width: 191px;
            height: 32px;
        }
        .auto-style23 {
            height: 32px;
            width: 279px;
        }
    .auto-style24 {
        width: 191px;
    }
        .auto-style25 {
            border: 2px solid #456789;
            border-radius: 3px;
            outline: none;
            font-size: large;
            margin-left: 0px;
        }
        .auto-style26 {
            width: 413px;
            text-align: left;
            font-size: large;
        }
        .auto-style28 {
            width: 413px;
            height: 44px;
            font-size: large;
        }
        .auto-style30 {
            width: 191px;
            height: 30px;
        }
        .auto-style31 {
            height: 30px;
            width: 279px;
        }
        .auto-style32 {
            width: 279px;
        }
        .auto-style33 {
            border: 2px solid #456789;
            border-radius: 3px;
            outline: none;
            text-align: center;
        }
        .auto-style35 {
            width: 25px;
            height: 34px;
        }
        .auto-style36 {
            text-align: right;
            width: 31px;
            height: 34px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server">
        <table class="auto-style8">
            <tr>
                <td class="auto-style28" style="border-style: double"><strong>OYUN LİSTESİ</strong></td>
                <td class="auto-style33"><strong>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style25" Height="40px" OnClick="Button1_Click" Text="+/-" Width="40px" />
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
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("oyunad") %>'></asp:Label>
                        </td>
                        <td class="auto-style15"><a href="Oyunlar.aspx?oyunid=<%#Eval("oyunid") %>&islem=sil">
                            <asp:Image ID="Image1" runat="server" Height="30px" ImageUrl="~/Iconlar/delete.png" Width="30px"/>
                            </a></td>
                        <td class="auto-style35"><a href="OyunDüzenle.aspx?oyunid=<%#Eval("oyunid") %>">
                            <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/Iconlar/refresh.png" Width="30px"/>
                            </a></td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
    <div>
    </div>
    <asp:Panel ID="Panel3" runat="server" Width="480px">
        <table class="auto-style8">
            <tr>
                <td class="auto-style26" style="border-style: double"><strong>OYUN EKLEME</strong></td>
                <td class="auto-style33"><strong>
                    <asp:Button ID="Button2" runat="server" CssClass="auto-style20" Height="40px" OnClick="Button2_Click" Text="+/-" Width="40px" />
                    </strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server">
        <table class="auto-style8">
            <tr>
                <td class="auto-style22">OYUN AD:&nbsp;</td>
                <td class="auto-style23">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style21" Width="270px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style24">OYUN İÇERİK:</td>
                <td class="auto-style32">
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style21" Height="200px" TextMode="MultiLine" Width="270px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style24">OYUN RESİM:</td>
                <td class="auto-style32">
                    <asp:FileUpload ID="FileUpload1" runat="server" Width="267px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style24">OYUN KATEGORİ ID:</td>
                <td class="auto-style32">
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style21" Width="270px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style31">
                    <asp:Button ID="BtnEkle" runat="server" CssClass="fb" OnClick="BtnEkle_Click" Text="EKLE" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel5" runat="server">
        <table class="auto-style8">
            <tr>
                <td class="auto-style28" style="border-width: thin; border-style: double;">
                    <asp:TextBox placeholder="Oyun Ara" ID="oyunara" runat="server" Height="34px" Width="411px" CssClass="tb"></asp:TextBox>
                </td>
                <td class="auto-style33" style="border-style: double; border-width: thin"><strong>
                    <asp:Button ID="Button3" runat="server" CssClass="auto-style25" Height="40px" Text="Ara" Width="40px" OnClick="Button3_Click" />
                    </strong></td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel6" runat="server">
        <asp:DataList ID="DataList2" runat="server" Width="476px">
            <ItemTemplate>
                <table class="auto-style8" style="border: thin groove #99CCFF">
                    <tr>
                        <td class="auto-style14">
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("oyunad") %>'></asp:Label>
                        </td>
                        <td class="auto-style15">
                            <a href="Oyunlar.aspx?oyunid=<%#Eval("oyunid") %>&islem=sil"> <asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/Iconlar/delete.png" Width="30px"/> </a>
                        </td>
                        <td class="auto-style36">
                          <a href="OyunDüzenle.aspx?oyunid=<%#Eval("oyunid") %>">  <asp:Image ID="Image4" runat="server" Height="30px" ImageUrl="~/Iconlar/refresh.png" Width="30px"/> </a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
</asp:Panel>
    <div></div>
    </asp:Content>

