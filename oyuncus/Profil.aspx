<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Profil.aspx.cs" Inherits="Profil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        
        .auto-style2 {
            width: 222px;
        }
        .auto-style10 {
            width: 311px;
            text-align: right;
        }
        .auto-style11 {
            width: 312px;
            text-align: right;
        }
        
        .auto-style12 {
            width: 254px;
        }
                
    .auto-style13 {
        line-height: 36px;
        margin-right: 10px;
        float: left;
        text-align: center;
        color: #fff;
        background-color: #1D5C63;
        border: 2px solid #1A3C40;
        border-radius: 3px;
        outline: none;
        cursor: pointer;
        color: #EDE6DB;
        font-weight: bold;
        margin-left: 5px;
    }
                
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <ContentTemplate>
            <div class="divgnc">
                <strong>
                <asp:Button ID="Button1" runat="server" CssClass="Btngnc" Height="40px" OnClick="Button1_Click" Text="+/-" Width="40px" />
                Profil Güncelle:</strong></div>
            </asp:panel>
            <asp:Panel ID="pnlprofil" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style12">
                            <asp:Image ID="Image3" runat="server" CssClass="profilfotognc" />
                        </td>
                        <td class="auto-style2">
                            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="auto-style13" Width="244px" />
                            <asp:Button ID="gncprof" runat="server" CssClass="Btngnc" OnClick="gncprof_Click" Text="Güncelle" />
                        </td>
                    </tr>
                </table>
                </table>
            </asp:Panel>
            <div class="divgnc">
                <strong>
                <asp:Button ID="Button3" runat="server" CssClass="Btngnc" Height="40px" OnClick="Button3_Click" Text="+/-" Width="40px" />
                Kullanıcı Adını Güncelle:</strong></div>
            </asp:panel>
            </asp:panel>
            <asp:Panel ID="pnlkullaniciadi" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style11">Kullanıcı Adınız:</td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="txtbox"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style11">
                            <asp:Label ID="klncadi" runat="server" Text=""></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="Button5" runat="server" CssClass="Btngnc" OnClick="Button5_Click" Text="Güncelle" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            <div class="divgnc">
                <strong>
                <asp:Button ID="Button2" runat="server" CssClass="Btngnc" Height="40px" OnClick="Button2_Click" Text="+/-" Width="40px" />
                Şifre Güncelle:</strong></div>
            </asp:panel>
            <asp:Panel ID="pnlsifre" runat="server">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style10">Yeni Şifreniz:</td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" CssClass="txtbox" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style10">Yeni Şifre Tekrarı:</td>
                        <td>
                            <asp:TextBox ID="TextBox3" runat="server" CssClass="txtbox" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style10">Eski Şifre:</td>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server" CssClass="txtbox" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style10">
                            <asp:Label ID="sfre" runat="server" Text=""></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="Button6" runat="server" CssClass="Btngnc" OnClick="Button6_Click" Text="Güncelle" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>
        </ContentTemplate>
    
</asp:Content>

