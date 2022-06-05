<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="OyunDüzenle.aspx.cs" Inherits="OyunDüzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style13 {
            text-align: right;
            font-size: large;
        }
        .auto-style15 {
            border: 2px solid #456789;
            border-radius: 3px;
        }
        .auto-style16 {
            text-align: right;
            font-size: large;
            height: 29px;
        }
        .auto-style17 {
            height: 29px;
        }
        .auto-style18 {
            text-align: left;
        }
        .auto-style19 {
            border: 2px solid #1A3C40;
            border-radius: 3px;
            height: 22px;
            width: 230px;
            resize: none;
            margin-bottom: 32;
        }
        .auto-style20 {
            text-align: center;
            font-size: large;
            height: 29px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     
                <ContentTemplate>
                    <table class="auto-style8">
                        <tr>
                            <td class="auto-style16">&nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style16"><strong>Oyun Ad:</strong></td>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style19" Width="270px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style20" colspan="2">
                                <asp:Image ID="Image2" runat="server" Height="206px" Width="352px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style16"><strong>Yeni Görsel Ekle:</strong></td>
                            <td>
                                <asp:FileUpload ID="FileUpload1" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style16"><strong>Oyun İçerik:</strong></td>
                            <td class="auto-style17">
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style15" Height="250px" TextMode="MultiLine" Width="270px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td><strong>Kategori:</strong></td>
                            <td class="auto-style18">
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="tb" Width="274px">
                                    <asp:ListItem>Kategori Seçiniz</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                            </td>
                            <td class="auto-style18"><em><strong>
                                <asp:Button ID="Button1" runat="server" CssClass="fb" OnClick="Button1_Click" Text="Güncelle" Width="274px" />
                                </strong></em></td>
                        </tr>
                    </table>
                </ContentTemplate>
           
        
</asp:Content>

