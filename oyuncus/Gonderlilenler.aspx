<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Gonderlilenler.aspx.cs" Inherits="Gonderlilenler" %>

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
        .auto-style28 {
            width: 256px;
        }
        .auto-style29 {
            width: 40px;
            height: 40px;
        }
        .auto-style30 {
            width: 377px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style8" >
        <tr>
            <td class="auto-style22" style="border-style: double" ><strong>GÖNDERİLEN OYUNLAR</strong></td>
            <td class="auto-style27" ><strong>
                <asp:Button ID="Button1" runat="server" CssClass="auto-style20" Height="40px" Text="+/-" Width="40px" OnClick="Button1_Click" />
                </strong></td>
        </tr>
    </table>
    <asp:Panel ID="Panel1" runat="server">
        <asp:DataList ID="DataList1" runat="server" Width="476px">
            <ItemTemplate>
                <table class="auto-style8">
                    <tr>
                       <td class="auto-style30" style="border-style: double"><strong><a href='GönderiDetay.aspx?gonderiid=<%#Eval("gonderiid")%>'>
                           <asp:Label ID="Label1" runat="server" CssClass="auto-style28" style="font-size: large" Text='<%# Eval("gonderiad") %>'></asp:Label>
                           </a></strong></td>
                        <td class="auto-style7" style="border-style: double">
                         <a href="Gonderlilenler.aspx?gonderiid=<%#Eval("gonderiid")%>&islem=sil">    <img alt="" class="auto-style29" src="Iconlar/delete.png" /> </a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
</asp:Content>

