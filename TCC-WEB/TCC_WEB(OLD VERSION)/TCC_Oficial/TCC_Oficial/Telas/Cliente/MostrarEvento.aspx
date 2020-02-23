<%@ Page Title="Evento" Language="C#" MasterPageFile="~/Modelos/Modelos_Cliente/Padrão.Master" AutoEventWireup="true" CodeBehind="MostrarEvento.aspx.cs" Inherits="TCC_Oficial.Telas.Cliente.MostrarEvento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1{
            margin-bottom: 9%
        }
        .auto-style2, .auto-style4 {
            width: 15%;
        }
        #titulo{
            width: 100%;
            font-size: 200%;
            text-align: center;
        }
        #gpboxMEvento{
            background-color: #050000;
            text-align: center;
        }
        .tbl_dados{
            width: 100%;
            text-align: left;
        }
        .link{
            font-size: 120%;
            text-decoration: none;
            color: white;
        }
        .link:hover{
            color: red;
        }
        .dado{
            width: 47%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder1">
   <table class="auto-style1">
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style3">
                <h1 id="titulo">Detalhes do Evento</h1>
                <fieldset id="gpboxMEvento" style="border-color: Red; border-width:2px;">
                    <table class="tbl_dados">
                        <tr>
                            <td rowspan="7"> <%--a ser editado--%>
                                <asp:Image ID="img_artista" Width="95%" Height="15%" runat="server" AlternateText="Artista" />
                            </td>
                        </tr>
                        <tr>
                            <td class="dado">
                                <asp:Label ID="Label1" runat="server" Font-Bold="true" Text="Título:"></asp:Label> <asp:Label ID="lblTitulo" runat="server" Text="Título:"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="dado">
                                <asp:Label ID="Label7" runat="server" Font-Bold="true" Text="Valor Base (em R$):"></asp:Label> <asp:Label ID="lblValor" runat="server" Text="Valor Base:"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="dado">
                                <asp:Label ID="Label3" runat="server" Font-Bold="true" Text="Data:"></asp:Label> 
                                <asp:TextBox ID="dtpData" runat="server" Enabled="False" TextMode="Date"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="dado">
                                <asp:Label ID="Label5" runat="server" Font-Bold="true" Text="Horário:"></asp:Label> <asp:Label ID="lblHorario" runat="server" Text="Horário:"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="dado">
                                <asp:Label ID="Label6" runat="server" Font-Bold="true" Text="Duração:"></asp:Label> <asp:Label ID="lblDuracao" runat="server" Text="Duracao:"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="dado">
                               <asp:Label ID="Label4" runat="server" Font-Bold="true" Text="Descrição:"></asp:Label> <asp:Label ID="lblDescricao" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        </table>
                    <br />
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:csTCCSHOW %>" SelectCommand="SELECT AG.ID_ARTISTA_GERAL, P.NOME, TP.TIPO_PESSOA, P.SEXO, RD.FACEBOOK, RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA  INNER JOIN TB_EVENTO_ARTISTA EA ON EA.ID_PESSOA = P.ID_PESSOA WHERE EA.ID_EVENTO= @ID_EVENTO  ORDER BY AG.ID_ARTISTA_GERAL">
                        <SelectParameters>
                            <asp:QueryStringParameter Name="ID_EVENTO" QueryStringField="id" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                                <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Artistas(s):"></asp:Label> 
                    <br />
                    <asp:GridView ID="dgvArtistasSelect" runat="server" AutoGenerateColumns="False" DataKeyNames="ID_ARTISTA_GERAL" DataSourceID="SqlDataSource1" Height="248px" Width="797px" AllowPaging="True" AllowSorting="True" OnSelectedIndexChanged="dgvArtistasSelect_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="ID_ARTISTA_GERAL" HeaderText="ID_ARTISTA_GERAL" InsertVisible="False" ReadOnly="True" SortExpression="ID_ARTISTA_GERAL" Visible="False" />
                            <asp:BoundField DataField="NOME" HeaderText="NOME" SortExpression="NOME" />
                            <asp:BoundField DataField="TIPO_PESSOA" HeaderText="TIPO_PESSOA" SortExpression="TIPO_PESSOA" />
                            <asp:CommandField SelectText="Ver mais" ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                    <br />
                    <br />
                    <br />
                    <asp:HyperLink ID="linkIngressos" CssClass="link" Font-Bold="True" runat="server" NavigateUrl="~/Telas/Cliente/Ingressos.aspx">Adquirir Ingressos</asp:HyperLink>
                </fieldset>
            </td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style4"></td>
        </tr>
    </table>
</asp:Content>

