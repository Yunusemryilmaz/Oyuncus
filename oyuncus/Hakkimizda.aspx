<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Hakkimizda.aspx.cs" Inherits="Hakkimizda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style11 {
            text-align: left;
        }
        .auto-style13 {
            text-align: center;
            font-size: x-large;
        }
        .auto-style14 {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <div class="auto-style13">
            <strong>HAKKIMIZDA</strong></div>
        <asp:DataList ID="DataList2" runat="server">
            <ItemTemplate>
                <div class="auto-style11">
                    <strong>
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("Metin") %>'></asp:Label>
                    <br />
                    </strong>
                </div>
            </ItemTemplate>
        </asp:DataList>
    <p class="auto-style14">
        <asp:Image ID="Image3" runat="server" Height="141px" ImageUrl="~/Resimler/header.png" Width="604px" />
    </p>
    </asp:Content>

