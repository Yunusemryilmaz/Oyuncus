<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Kullanicilar.aspx.cs" Inherits="Kullanicilar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style14 {
            width: 362px;
        }
        .auto-style15 {
            width: 363px;
            text-align: right;
        }
        .auto-style16 {
            width: 424px;
        }
        .auto-style17 {
            width: 362px;
            text-align: left;
        }
        .auto-style18 {
            width: 38px;
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager EnablePartialRendering="true"
 ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:Panel ID="Panel1" runat="server">
                <table class="auto-style8">
                    <tr>
                        <td class="auto-style16" style="border-style: double">KULLANİCİLAR
                            </td>
                        <td class="auto-style33"><strong>
                            <asp:Button ID="Button1" runat="server" CssClass="fb" Height="40px" Text="+/-" Width="40px" OnClick="Button1_Click1" />
                            </strong></td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server">
                <asp:DataList ID="DataList1" runat="server" Width="476px">
                    <ItemTemplate>
                        <table class="auto-style8" style="border: thin groove #99CCFF">
                            <tr>
                                <td class="auto-style18">
                                    <asp:Image ID="Image4" runat="server" Height="30px" ImageUrl='<%# Eval("Kullanicifoto") %>' Width="30px" />
                                </td>
                                <td class="auto-style17">
                                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("kullaniciad") %>'></asp:Label>
                                </td>
                                <td class="auto-style15"><a href='Kullanicidetay.aspx?kullaniciid=<%#Eval("kullaniciid")%>'>
                                    <asp:Image ID="Image3" runat="server" Height="31px" ImageUrl="~/Iconlar/refresh.png" Width="32px" />
                                    </a><a href='Kullanicilar.aspx?kullaniciid=<%#Eval("kullaniciid") %>&amp;islem=sil'>
                                    <asp:Image ID="Image1" runat="server" Height="30px" ImageUrl="~/Iconlar/delete.png" Width="30px" />
                                    </a></td>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </asp:Panel>
            <div style="background-color:#081d71">
            </div>
            <asp:Panel ID="Panel3" runat="server">
                <table class="auto-style8">
                    <tr>
                        <td class="auto-style16" style="border-style: double">
                            <asp:TextBox ID="TextBox1" runat="server" Height="37px" Width="389px" placeholder="Kullanıcı Ara" CssClass="tb"></asp:TextBox>
                        </td>
                        <td class="auto-style33"><strong>
                            <asp:Button ID="Button2" runat="server" CssClass="auto-style25" Height="40px" Text="Ara" Width="40px" OnClick="Button2_Click"  />
                            </strong></td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="Panel4" runat="server">
                <asp:DataList ID="DataList2" runat="server" Width="476px">
                    <ItemTemplate>
                        <table class="auto-style8" style="border: thin groove #99CCFF">
                            <tr>
                                <td class="auto-style14">
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("kullaniciad") %>'></asp:Label>
                                </td>
                                <td class="auto-style15">
                                    <a href="Kullanicidetay.aspx?kullaniciid=<%#Eval("kullaniciid") %>"> <asp:Image ID="Image3" runat="server" Height="31px" ImageUrl="~/Iconlar/refresh.png" Width="32px" /></a>
                                    <a href='Kullanicilar.aspx?kullaniciid=<%#Eval("kullaniciid") %>&amp;islem=sil'>
                                    <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/Iconlar/delete.png" Width="30px" />
                                    </a></td>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </asp:Panel>
            <div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

