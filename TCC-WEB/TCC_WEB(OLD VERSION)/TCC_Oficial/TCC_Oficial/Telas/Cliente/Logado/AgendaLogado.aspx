<%@ Page Title="" Language="C#" MasterPageFile="~/Telas/Cliente/Logado/Logado.Master" AutoEventWireup="true" CodeBehind="AgendaLogado.aspx.cs" Inherits="TCC_Oficial.Telas.Cliente.Logado.AgendaLogado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 9%;
        }

        .auto-style2, .auto-style6 {
            width: 15%;
        }

        .auto-style3 {
            text-align: center;
        }

        #titulo {
            text-align: center;
            font-size: 200%;
        }

        #gpboxEvento1, #gpboxEvento2, #gpboxEvento3, #gpboxEvento4, #gpboxEvento5, #gpboxEvento6 {
            text-align: center;
            background-color: #050000;
        }

        #img_evento1, #img_evento2, #img_evento3, #img_evento4, #img_evento5, #img_evento6 {
            width: 30%;
        }

        .ver_mais {
            color: white;
            text-decoration: none;
        }

            .ver_mais:hover {
                color: red;
            }

        .auto-style7 {
            width: 100%;
        }

        .auto-style8 {
            font-size: x-large;
        }
    </style>
    <script>

        function redicionarPaginaEvento(id) {
            top.location.href = "MostrarEventoLogado.aspx?id=";
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <h1 id="titulo">Próximos Shows</h1>
            <td class="auto-style2"></td>
            <td class="auto-style3">
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:csTCCSHOW %>" SelectCommand="SELECT EV.ID_EVENTO,EV.TITULO, EV.DATA_EVENTO, CONCAT( CONCAT(FORMAT(EV.HORARIO_INICIO,'HH:mm'), ' até ') , FORMAT(EV.HORARIO_FINAL,'HH:mm') ) as HORARIO, EV.DURACAO, EV.N_ARTISTAS,EV.DESCRICAO,EV.TIPO_PAG, EV.ATIVO, EV.VALOR_EVENTO FROM TB_EVENTO EV ORDER BY EV.DATA_EVENTO"></asp:SqlDataSource>
                <asp:Label ID="Label11" Text="Filtrar por:" Font-Bold="true" Font-Size="Larger" runat="server"></asp:Label>
                <asp:DropDownList ID="ddl" runat="server" AutoPostBack="True" Font-Names="Quicksand" Font-Size="Large">
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <br />
                <asp:DataList ID="dtEventos" runat="server" DataSourceID="SqlDataSource2" RepeatDirection="Horizontal" RepeatColumns="3" Width="100%" OnItemCommand="dtEventos_ItemCommand">
                    <ItemTemplate>
                        <fieldset id="gpboxEvento1" style="border-color: Red; border-width: 2px;">
                            <table class="auto-style7">
                                <tr>
                                    <td colspan="2">
                                        <asp:Image ID="Image1" runat="server" Width="260px" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>Título:</td>
                                    <td>
                                        <asp:Label ID="TITULO" runat="server" Text='<%# Eval("titulo") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Data:</td>
                                    <td>
                                        <asp:Label ID="DATA" runat="server" Text='<%# Eval("DATA_EVENTO", "{0:d}") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>Horário:</td>
                                    <td>
                                        <asp:Label ID="HORARIO" runat="server" Text='<%# Eval("HORARIO") %>'></asp:Label>
                                    </td>
                            </table>
                            <br />

                            <asp:LinkButton ID="btnAvancar" runat="server" CommandArgument='<%#Eval("ID_EVENTO") %>' CommandName="verMais" CssClass="auto-style8">Ler mais...</asp:LinkButton>

                            <br />
                            <asp:Label ID="ID_EVENTO" runat="server" Text='<%# Eval("ID_EVENTO") %>' Visible="False"></asp:Label>
                        </fieldset>
                    </ItemTemplate>

                </asp:DataList>
            </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style3"></td>
            <td class="auto-style6"></td>
        </tr>
    </table>
</asp:Content>

