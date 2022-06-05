<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Yorumlar.aspx.cs" Inherits="Yorumlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style22 {
            width: 413px;
            height: 45px;
            font-size: large;
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
        .auto-style20 {
            border: 2px solid #456789;
            border-radius: 3px;
            outline: none;
            font-size: large;
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
        .auto-style13 {
        text-align: right;
            height: 34px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style8" >
        <tr>
            <td class="auto-style22" style="border-style: double" ><strong>ONAYLI YORUM LİSTESİ</strong></td>
            <td class="auto-style27" ><strong>
                <asp:Button ID="Button1" runat="server" CssClass="auto-style20" Height="40px" Text="+/-" Width="40px" OnClick="Button1_Click" />
                </strong></td>
        </tr>
    </table>
    <asp:Panel ID="Panel1" runat="server">
        <asp:DataList ID="DataList1" runat="server" Width="476px">
            <ItemTemplate>
                <table class="auto-style8" style="border: thin groove #99CCFF">
                    <tr>
                        <td class="auto-style14">
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("kullaniciad") %>'></asp:Label>
                        </td>
                        <td class="auto-style15">
                          <a href="Yorumlar.aspx?yorumid=<%#Eval("yorumid") %>&islem=sil">  <asp:Image ID="Image1" runat="server" Height="30px" ImageUrl="~/Iconlar/delete.png" Width="30px" /> </a>
                        </td>
                        <td class="auto-style13">
                          <a href="YorumDetay.aspx?yorumid=<%#Eval("yorumid")%>"><asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/Iconlar/refresh.png" Width="30px" /></a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
    <table class="auto-style8" >
        <tr>
            <td class="auto-style22" style="border-style: double" ><strong>ONAYSIZ YORUM LİSTESİ</strong></td>
            <td class="auto-style27"><strong>
                <asp:Button ID="Button2" runat="server" CssClass="auto-style20" Height="40px" Text="+/-" Width="40px" OnClick="Button2_Click" />
                </strong></td>
        </tr>
    </table>
     <asp:Panel ID="Panel2" runat="server">
        <asp:DataList ID="DataList2" runat="server" Width="476px">
            <ItemTemplate>
                <table class="auto-style8" style="border: thin groove #99CCFF">
                    <tr>
                        <td class="auto-style14">
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("kullaniciad") %>'></asp:Label>
                        </td>
                        <td class="auto-style15">
                           <a href="Yorumlar.aspx?yorumid=<%#Eval("yorumid") %>&islem=sil"> <asp:Image ID="Image1" runat="server" Height="30px" ImageUrl="~/Iconlar/delete.png" Width="30px" /></a>
                        </td>
                        <td class="auto-style13">
                            <a href="YorumDetay.aspx?yorumid=<%#Eval("yorumid")%>"><asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/Iconlar/refresh.png" Width="30px"/></a> 
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
</asp:Content>

