<%@ Page Title="Humoristas" Language="C#" MasterPageFile="~/Modelos/Modelos_Cliente/Padrão.Master" AutoEventWireup="true" CodeBehind="Artistas.aspx.cs" Inherits="TCC_Oficial.Telas.Cliente.Artistas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1{
            width: 100%;
            margin-bottom: 9%;
        }
        .auto-style2, .auto-style4 {
            width: 15%;
        }
        .auto-style5 {
            width: 100%;
        }
        #titulo{
            width: 100%;
            font-size: 200%;
            text-align: center;
        }
        #gpboxArtista{
            background-color: #050000;
        }
        .lbl{
            width: 60%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ScriptManager runat="server"></asp:ScriptManager>
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style7">
                <h1 id="titulo">Quem já passou por aqui..</h1>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:csTCCSHOW %>" SelectCommand="SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO,  RD.FACEBOOK, RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA ORDER BY AG.ID_ARTISTA_GERAL"></asp:SqlDataSource>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                    <asp:ListItem>Nome</asp:ListItem>
                </asp:DropDownList>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="212px"></asp:TextBox>
                <asp:DataList ID="dtArtistas" runat="server" DataSourceID="SqlDataSource3" RepeatDirection="Horizontal" RepeatColumns="1" RepeatLayout="Flow" OnItemCommand="DataList1_ItemCommand">
                    <ItemTemplate>
                        <fieldset id="gpboxArtista" style="border-color: Red; border-width:2px;">
                            <table class="auto-style5">
                                <tr>
                                    <td rowspan="2">
                                        <asp:Image ID="img_art" runat="server" Width="350px" Height="250px" AlternateText=" Imagem não encontrada!" />
                                    </td>
                                    <td class="lbl">
                                        <asp:Label ID="Label7" runat="server" Font-Bold="true" Text="Nome:" CssClass="auto-style11"></asp:Label> 
                                        <br />
                                        <br />
                                        <asp:Label ID="lblNomeArt" runat="server" Text='<%# Eval("NOME") %>' CssClass="auto-style11"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="lbl">
                                        <asp:LinkButton ID="btnAvancar" runat="server" CommandArgument='<%#Eval("ID_ARTISTA_GERAL") +";"+Eval("TIPO_PESSOA")%>' CommandName="verMais" CssClass="auto-style11">Ler mais...</asp:LinkButton>
                                        <br />
                                        <asp:Label ID="ID_ARTISTA_GERAL" runat="server" Text='<%# Eval("ID_ARTISTA_GERAL") %>' Visible="False"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                        </fieldset>
                    </ItemTemplate>
                </asp:DataList>


            </td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td></td>
            <td class="auto-style4"></td>
        </tr>
    </table>
            </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
