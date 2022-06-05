<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.master" AutoEventWireup="true" CodeFile="Anasayfa.aspx.cs" Inherits="Anasayfa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script>

        

        var yazi = document.getElementsByClassName(".oyuniçer:hover::after");
        document.onmousemove = function () {
            var x = event.clientX;
            var y = event.clienY;

            yazi.style.top = y;
            yazi.style.left = x;
            
        }


    </script>
    <style type="text/css">
       
    </style>
    </asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1" >


    


    <table>
        
        <tr>
            <td>
                <asp:DataList ID="DataList2" runat="server" RepeatLayout="Flow" CssClass="hidebr"  >
                   
                        <ItemTemplate>
                           
                              
           
        <abbr  class="oyuniçer" title="<%# Eval("oyunbilgi")%>"> <abbr class="oyunad" title="<%# Eval("oyunad")%>">   <a href="oyundetay.aspx?oyunid=<%#Eval("oyunid")%>">  <asp:Image ID="Image2" CssClass="imgdl" runat="server" ImageUrl='<%# Eval("oyunresim") %>' /> </a> </abbr> </abbr>
         
                  
                            </ItemTemplate> 

                   
                </asp:DataList>
            </td>
        </tr>
    </table>
    
    

</asp:Content>


