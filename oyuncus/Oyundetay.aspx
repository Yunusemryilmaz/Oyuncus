<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Oyundetay.aspx.cs" Inherits="Oyundetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .yorum{
            margin-top:30px;
        }
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            text-align: left;
        }
        .auto-style4 {
            width: 100%;
        }
        .auto-style7 {
            text-align: center;
        }
        .auto-style8 {
            font-size: large;
        }
        .auto-style9 {
            font-size: xx-large;
        }
        .auto-style10 {
            text-align: left;
            font-size: x-small;
            font-weight: normal;
            height: 18px;
        }
        .auto-style11 {
            width: 100%;
            font-size: x-small;
        }
        .auto-style12 {
            text-align: left;
            font-size: x-small;
            font-weight: normal;
            height: 28px;
        }
        .auto-style16 {
            width: 49px;
        }
        .auto-style18 {
            text-align: center;
            height: 151px;
        }
        .auto-style19 {
            color: #790505;
            float: left;
            text-align: center;
            padding-left: 20px;
        }
        .auto-style20 {
            height: 50px;
            text-align: center;
            line-height:50px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table __designer:mapid="65" class="auto-style1">
        <tr __designer:mapid="66">
            <td __designer:mapid="67">&nbsp;</td>
        </tr>
        <tr __designer:mapid="68">
            <td __designer:mapid="69" class="auto-style1"><strong>
                <asp:Label ID="Label4" runat="server" CssClass="auto-style9" Text='<%# Eval("oyunad") %>'></asp:Label>
                </strong></td>
        </tr>
        <tr __designer:mapid="6c">
            <td __designer:mapid="6d" class="auto-style1">
                &nbsp;</td>
        </tr>
        <tr __designer:mapid="6f">
            <td __designer:mapid="70" class="auto-style3">&nbsp;</td>
        </tr>
        <tr __designer:mapid="6f">
            <td __designer:mapid="70" class="auto-style12">
                <asp:Image ID="Image3" runat="server" CssClass="img" Height="280px" ImageUrl='<%# Eval("oyunresim") %>' Width="600px" />
            </td>
        </tr>
        <tr __designer:mapid="6f">
            <td __designer:mapid="70" class="auto-style10">
                &nbsp;</td>
        </tr>
        <tr __designer:mapid="6f">
            <td __designer:mapid="70" class="auto-style10">
                <asp:Label ID="Label5" runat="server" Text='<%# Eval("oyunbilgi") %>' CssClass="auto-style8"></asp:Label>
            </td>
        </tr>
        <tr __designer:mapid="6f">
            <td __designer:mapid="70" class="auto-style10">
                <asp:Label ID="Label6" runat="server" CssClass="auto-style11" Text='<%# Eval("oyuntarih") %>'></asp:Label>
            </td>
        </tr>
    </table>
    

    <div style="border-bottom-style: double; border-bottom-width: medium; border-bottom-color: #265155; border-top-style: double; border-top-width: medium; border-top-color: #265155;" class="auto-style20">
        
        YORUMLAR
       
    </div>
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
            <table class="auto-style4">
                <tr>
                    <td class="auto-style16">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style16">
                        <asp:Image ID="Image4" runat="server" Height="40px" ImageUrl='<%# Eval("kullanicifoto") %>' Width="40px" />
                    </td>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text='<%# Eval("kullaniciad") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label8" runat="server" Text='<%# Eval("yorumiçerik") %>'></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="Label11" runat="server" Text='<%# Eval("yorumtarih") %>'></asp:Label>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
     <div style="border-bottom-style: double; border-bottom-width: medium; border-bottom-color: #265155; border-top-style: double; border-top-width: medium; border-top-color: #265155;" class="auto-style20">
        
        
       
         <strong __designer:mapid="194">Yorum Yap:</strong></div>
    <asp:Panel ID="pnlyorumuyarı" runat="server" CssClass="auto-style19" Width="600px">
        
        <strong>
        <asp:Label ID="Label10" runat="server" Text="Yorum yapabilmek için üye olmanız gerekmektedir."></asp:Label>
        </strong>
        
    </asp:Panel>
    <asp:Panel ID="pnlyormyap" runat="server" CssClass="pnlyorum">
        <table class="auto-style4">
            <tr>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style18" style="border: thin groove #004F4F">
                    <strong><asp:TextBox ID="TextBox1" runat="server" CssClass="TxtYorum" TextMode="MultiLine" Height="130px" Width="610px" ></asp:TextBox>
                    <br />
                    </strong>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label12" runat="server" Text=""></asp:Label>
                    <br />
                    <asp:Button ID="Button1" runat="server" CssClass="Btngiris" Text="Yorumla" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    

</asp:Content>

