<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Mesajlar.aspx.cs" Inherits="Mesajlar" %>

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
        .auto-style13 {
        text-align: right;
            height: 34px;
        }
        .auto-style28 {
            text-align: right;
        }
        .auto-style29 {
            text-align: left;
            width: 427px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <table class="auto-style8" >
        <tr>
            <td class="auto-style22" style="border-style: double" >MESAJLAR</td>
            <td class="auto-style27" ><strong>
                <asp:Button ID="Button1" runat="server" CssClass="auto-style20" Height="40px" Text="+/-" Width="40px" OnClick="Button1_Click" />
                </strong></td>
        </tr>
    </table>
    </p>
    <asp:Panel ID="Panel1" runat="server">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <table class="auto-style8" style="border-top-style: groove; border-bottom-style: groove; border-width: 1px">
                    <tr>
                        <td class="auto-style29"><strong><a href='MesajDetay.aspx?mesajid=<%#Eval("mesajid")%>'>
                            <asp:Label ID="Label1" runat="server" CssClass="auto-style28" Text='<%# Eval("mesajgonderen") %>'></asp:Label>
                            </a></strong></td>
                        <td class="auto-style28">
                            <a href='Mesajlar.aspx?mesajid=<%#Eval("mesajid") %>&amp;islem=sil'>
                                <asp:Image ID="Image1" runat="server" Height="30px" ImageUrl="~/Iconlar/delete.png" Width="30px" />
                            </a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </asp:Panel>
</asp:Content>


