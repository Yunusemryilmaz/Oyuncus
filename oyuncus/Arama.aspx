<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Arama.aspx.cs" Inherits="Arama" %>
<%@ MasterType VirtualPath="~/Kullanici.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList2" runat="server" RepeatLayout="Flow" CssClass="hidebr"  >
    <ItemTemplate>
      <abbr  class="oyuniçer" title="<%# Eval("oyunbilgi")%>"> <abbr class="oyunad" title="<%# Eval("oyunad")%>">  <a href="oyundetay.aspx?oyunid=<%#Eval("oyunid")%>">
        <asp:Image ID="Image2"  CssClass="imgdl" runat="server" ImageUrl='<%# Eval("oyunresim") %>' />
        </a> </abbr> </abbr>
    </ItemTemplate>
</asp:DataList>
</asp:Content>

