<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Kaydol.aspx.cs" Inherits="Kaydol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
 <div style="margin: 0 auto; width:285px; margin-top:80px;">
                <div class="üst"> KULLANICI GİRİŞ</div>
            
                <div class="alt" style="height: 210px">
                    
                    <span>Kullanıcı Adı:</span>
                    <asp:TextBox ID="TxtKullaniciAdi" CssClass="txtbox" runat="server" placeholder="Kullanıcı Adı"></asp:TextBox>
                    <span>Parola:</span>
                    <asp:TextBox ID="TxtParola"  CssClass="txtbox" runat="server" TextMode="Password" placeholder="Parola"></asp:TextBox>
                     <span>Parola Tekrarı:</span>
                    <asp:TextBox ID="TxtParolaTekrar"  CssClass="txtbox" runat="server" TextMode="Password" placeholder="Parola Tekrarı"></asp:TextBox>
                    <span>Mail:</span>
                    <asp:TextBox ID="Txtmail" runat="server" CssClass="txtbox" TextMode="Email" placeholder="Mail Adresi"></asp:TextBox>
&nbsp;<div style="width:228px;"><asp:Label ID="Label3" runat="server" Text=""></asp:Label></div>
                    
                    <asp:Button ID="BtnKaydol" CssClass="Btnkayit" runat="server" Text="Kaydol" OnClick="BtnKaydol_Click"  />
                    
                  
                    

                </div>
                    </div>

</asp:Content>

