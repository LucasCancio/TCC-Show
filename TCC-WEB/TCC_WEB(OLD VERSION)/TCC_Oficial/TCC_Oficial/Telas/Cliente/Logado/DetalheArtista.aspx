<%@ Page Title="" Language="C#" MasterPageFile="~/Telas/Cliente/Logado/Logado.Master" AutoEventWireup="true" CodeBehind="DetalheArtista.aspx.cs" Inherits="TCC_Oficial.Telas.Cliente.Logado.DetalheArtista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style7 {
            width: 138px;
        }
        .auto-style8 {
            width: 847px;
        }
        .auto-style10 {
            width: 353px;
            text-align: center;
        }
        .auto-style11 {
            width: 847px;
            text-align: center;
        }
        .auto-style12 {
            font-size: x-large;
        }
        .auto-style14 {
            height: 65px;
            width: 239px;
        }
        .auto-style15 {
            width: 100%;
            height: 437px;
        }
        .auto-style16 {
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table class="auto-style1">
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style8">
                <table class="auto-style15">
                    <tr>
                        <td class="auto-style10" rowspan="6">
                                <asp:Image ID="img_artista" Width="98%" Height="15%" runat="server" AlternateText="Artista" />
                            </td>
                        <td class="auto-style14">&nbsp;&nbsp;
                            <asp:Label ID="Label4" runat="server" Text="Nome"></asp:Label>
&nbsp;&nbsp;
                            <asp:TextBox ID="txtNome" runat="server" Width="346px" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style14">
                            <asp:Label ID="Label13" runat="server" Text="Sexo"></asp:Label>
                            <asp:TextBox ID="txtSexo" runat="server" Width="346px" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style14">&nbsp;&nbsp;
                            <asp:Label ID="Label5" runat="server" Text="Data de Nascimento"></asp:Label>
&nbsp;&nbsp;
                            <asp:TextBox ID="txtDataNasc" runat="server" TextMode="Date" Width="346px" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style14">&nbsp;&nbsp;
                            <asp:Label ID="Label6" runat="server" Text="Facebook"></asp:Label>
&nbsp;&nbsp;
                            <asp:TextBox ID="txtFacebook" runat="server" Width="345px" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style14">&nbsp;&nbsp;
                            <asp:Label ID="Label7" runat="server" Text="Twitter"></asp:Label>
&nbsp;&nbsp;
                            <asp:TextBox ID="txtTwitter" runat="server" Width="345px" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style14">&nbsp;&nbsp;
                            <asp:Label ID="Label8" runat="server" Text="Instagram"></asp:Label>
&nbsp;&nbsp;
                            <asp:TextBox ID="txtInstagram" runat="server" Width="345px" Enabled="False"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <br />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style11">
                <span class="auto-style12">
                <asp:Panel ID="pnEmpresario" runat="server">
                    <asp:Label ID="Label9" runat="server" Text="Empresário" CssClass="auto-style12" Font-Bold="True" ForeColor="#00CCFF"></asp:Label>
                    &nbsp;
                    <asp:Label ID="lblTipoPessoa" runat="server" ForeColor="#CC0000" CssClass="auto-style16"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblNomePrincipal" runat="server" Text="Nome Civil"></asp:Label>
                    <asp:TextBox ID="txtNomePrincipal" runat="server" Width="274px" Enabled="False"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label11" runat="server" Text="Telefone/Celular"></asp:Label>
                    <asp:TextBox ID="txtTelefone" runat="server" Width="274px" Enabled="False"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="Label12" runat="server" Text="Email"></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" Width="274px" Enabled="False"></asp:TextBox>
                </asp:Panel>
                <br />
                Histórico de eventos<br />
                </span><br />
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Height="151px" Width="853px">
                    <Columns>
                        <asp:BoundField DataField="TITULO" HeaderText="Título" SortExpression="TITULO" />
                        <asp:BoundField DataField="DATA_EVENTO" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Data do Evento" SortExpression="DATA_EVENTO" />
                        <asp:BoundField DataField="HORARIO_INICIO" DataFormatString="{0:HH:mm}" HeaderText="Horario Inicial" SortExpression="HORARIO_INICIO" />
                        <asp:BoundField DataField="HORARIO_FINAL" DataFormatString="{0:HH:mm}" HeaderText="Horario Final" SortExpression="HORARIO_FINAL" />
                        <asp:BoundField DataField="DURACAO" HeaderText="Duração" SortExpression="DURACAO" />
                        <asp:BoundField DataField="N_ARTISTAS" HeaderText="Número de Artistas" SortExpression="N_ARTISTAS" >
                        <HeaderStyle Font-Size="Smaller" />
                        </asp:BoundField>
                        <asp:BoundField DataField="DESCRICAO" HeaderText="Descrição" SortExpression="DESCRICAO" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:csTCCSHOW %>" SelectCommand="SELECT EV.TITULO, EV.DATA_EVENTO, EV.HORARIO_INICIO , EV.HORARIO_FINAL, EV.DURACAO, EV.N_ARTISTAS,EV.DESCRICAO,EV.TIPO_PAG ,EV.VALOR_EVENTO FROM TB_EVENTO EV INNER JOIN TB_EVENTO_ARTISTA EA ON EA.ID_EVENTO= EV.ID_EVENTO WHERE EA.ID_PESSOA= (SELECT P.ID_PESSOA FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA WHERE AG.ID_ARTISTA_GERAL= @ID_ARTISTA_GERAL);">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="ID_ARTISTA_GERAL" QueryStringField="id" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        </table>

    </asp:Content>
