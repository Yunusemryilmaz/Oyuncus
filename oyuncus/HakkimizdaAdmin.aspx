<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="HakkimizdaAdmin.aspx.cs" Inherits="HakkimizdaAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style14 {
        border: 2px solid #456789;
        border-radius: 3px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style7">
    <strong>HAKKIMIZDA<asp:TextBox ID="TextBox1" runat="server" CssClass="tb" Height="207px" TextMode="MultiLine" Width="472px"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" CssClass="fb" Height="37px" Text="GÜNCELLE" OnClick="Button1_Click" />
    </strong>
</p>
</asp:Content>

