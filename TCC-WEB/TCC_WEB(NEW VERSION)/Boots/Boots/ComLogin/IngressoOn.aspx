<%@ Page Title="Compra de Ingressos" Language="C#" MasterPageFile="~/ModeloOn.Master" AutoEventWireup="true" CodeBehind="IngressoOn.aspx.cs" Inherits="Boots.ComLogin.IngressoOn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
</script>
    <style>
          #fundoAgenda {
            
        }

            #fundoAgenda a {
               border-bottom:4px solid white;
            }


        #cont2 {
            text-align: center;
        }

        .table {
            margin: auto;
            overflow-y: scroll;
            width: 1110px;
            background-color: #050000;
            /*background-image: url("/img/hahaha3.jpeg");*/
            color: white;
        }

        .ladoesq {
            text-align: right;
            width: 50%;
        }

        .ladodir {
            text-align: left;
            width: 50%;
        }

        .foto {
            text-align: right;
        }

        #tabela1 {
            text-align: center;
            border-left: solid 5px rgb(145,0,0);
            border-right: solid 5px rgb(145,0,0);
            border-bottom: solid 5px rgb(145,0,0);
        }

        #tabela {
            border-left: solid 5px rgb(145,0,0);
            border-right: solid 5px rgb(145,0,0);
            border-top: solid 5px rgb(145,0,0);
        }

        #tabela2 {
            border-left: solid 5px rgb(145,0,0);
            border-right: solid 5px rgb(145,0,0);
        }
        #tabela3 {
            width: 100%;
        }
        .dgv{
           border-color: white;
             overflow-y: scroll;
        }
        .linkMais:hover {
            color: red;
            text-decoration: underline;
        }
        #cont2{
            text-align: center;
        }
        #tb #td1, #td2{
            text-align: center;
            width: 50%;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TCCSHOWConnectionString %>" SelectCommand="SELECT AG.ID_ARTISTA_GERAL, AG.URL_IMG, P.NOME, TP.TIPO_PESSOA, P.SEXO,  RD.FACEBOOK, RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA ORDER BY AG.ID_ARTISTA_GERAL"></asp:SqlDataSource>

    <div class="container" id="cont">
        <br />
        <asp:Label ID="lblTitulo" runat="server" Text="Label" Font-Size="250%"></asp:Label>
        <h6>Compra de Ingressos</h6>
        <br />
    </div>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:Panel ID="pnAssentos" runat="server">
                <div class="container">
                    <div class="table-responsive">
                        <table class="table" id="tabela">
                            <tr>
                                <td>
                                    <fieldset id="gpboxEsqueceu2" style="border-color: white; border-width: 2px; text-align: center; color: white; font-style: oblique">
                                        <h1><b>Palco</b></h1>
                                    </fieldset>
                                </td>
                            </tr>
                        </table>
                        <table class="table" id="tabela2">
                            <tr>
                                <td class="ladoesq">
                                    <asp:Label runat="server" Text="1" Font-Bold="true"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="2" Font-Bold="true"></asp:Label>&nbsp;&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="3" Font-Bold="true"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="4" Font-Bold="true"></asp:Label>&nbsp;&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="5" Font-Bold="true"></asp:Label>&nbsp;&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="6" Font-Bold="true"></asp:Label>&nbsp;&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="7" Font-Bold="true"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="8" Font-Bold="true"></asp:Label>&nbsp;&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="9" Font-Bold="true"></asp:Label>&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="10" Font-Bold="true"></asp:Label>&nbsp;&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="11" Font-Bold="true"></asp:Label>&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="12" Font-Bold="true"></asp:Label>&nbsp;&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="13" Font-Bold="true"></asp:Label>&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="14" Font-Bold="true"></asp:Label>&nbsp;
                                    <br />
                                    <asp:Label runat="server" CssClass="leg" Text="A" ForeColor="Goldenrod" ToolTip="Fileira A - Setor Ouro" Font-Bold="true"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                                    
                                    <asp:ImageButton ID="A12ESP" runat="server" Height="26px" ImageUrl="~/img/AssentoIconeEspecial.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="A13ESP" runat="server" Height="26px" ImageUrl="~/img/AssentoIconeEspecial.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="A14ESP" runat="server" Height="26px" ImageUrl="~/img/AssentoIconeEspecial.png" Width="26px" OnClick="EscolherAssento" />
                                    <br />
                                    <asp:Label runat="server" CssClass="leg" Text="B" ForeColor="Goldenrod" ToolTip="Fileira B - Setor Ouro" Font-Bold="true"></asp:Label>&nbsp;
                                    <asp:ImageButton ID="B1" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B2" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B3" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B4" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B5" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B6" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B7" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B8" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B9" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B10" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B11" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B12" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B13" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B14" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <br />
                                    <asp:Label runat="server" Text="C" ForeColor="Goldenrod" ToolTip="Fileira C - Setor Ouro" Font-Bold="true"></asp:Label>&nbsp;
                                    <asp:ImageButton ID="C1e2DUP" runat="server" Height="30px" ImageUrl="~/img/AssentoIconeDuplo.png" Width="56px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="ImageButton1" runat="server" Height="26px" Enabled="false" ImageUrl="~/img/Indisponivel.png" Width="26px" />
                                    <asp:ImageButton ID="C4e5DUP" runat="server" Height="30px" ImageUrl="~/img/AssentoIconeDuplo.png" Width="56px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="ImageButton4" runat="server" Height="26px" Enabled="false" ImageUrl="~/img/Indisponivel.png" Width="26px" />
                                    <asp:ImageButton ID="C7e8DUP" runat="server" Height="30px" ImageUrl="~/img/AssentoIconeDuplo.png" Width="56px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="ImageButton3" runat="server" Height="26px" Enabled="false" ImageUrl="~/img/Indisponivel.png" Width="27px" />
                                    <asp:ImageButton ID="C10e11DUP" runat="server" Height="30px" ImageUrl="~/img/AssentoIconeDuplo.png" Width="56px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="ImageButton2" runat="server" Height="26px" Enabled="false" ImageUrl="~/img/Indisponivel.png" Width="28px" />
                                    <asp:ImageButton ID="C13e14DUP" runat="server" Height="30px" ImageUrl="~/img/AssentoIconeDuplo.png" Width="56px" OnClick="EscolherAssento" />
                                    <br />
                                    <asp:Label runat="server" Text="D" ForeColor="Silver" ToolTip="Fileira D - Setor Prata" Font-Bold="true"></asp:Label>&nbsp;
                                    <asp:ImageButton ID="D1" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D2" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D3" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D4" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D5" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D6" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D7" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D8" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D9" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D10" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D11" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D12" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D13" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D14" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <br />
                                    <asp:Label runat="server" Text="E" ForeColor="Silver" ToolTip="Fileira E - Setor Prata" Font-Bold="true"></asp:Label>&nbsp;
                                    <asp:ImageButton ID="E1" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E2" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E3" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E4" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E5" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E6" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E7" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E8" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E9" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E10" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E11" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E12ESP" runat="server" Height="26px" ImageUrl="~/img/AssentoIconeEspecial.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E13ESP" runat="server" Height="26px" ImageUrl="~/img/AssentoIconeEspecial.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E14ESP" runat="server" Height="26px" ImageUrl="~/img/AssentoIconeEspecial.png" Width="26px" OnClick="EscolherAssento" />
                                    <br />
                                    <asp:Label runat="server" Text="F" ForeColor="#cd7f32" ToolTip="Fileira F - Setor Bronze" Font-Bold="true"></asp:Label>&nbsp;
                                    <asp:ImageButton ID="F1" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F2" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F3" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F4" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F5" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F6" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F7" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F8" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F9" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F10" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F11" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F12" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F13" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F14" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <br />
                                    <asp:Label runat="server" Text="G" ForeColor="#cd7f32" ToolTip="Fileira A - Setor Bronze" Font-Bold="true"></asp:Label>&nbsp;
                                    <asp:ImageButton ID="G1" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G2" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G3" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G4" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G5" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G6" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G7" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G8" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G9" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G10" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G11" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G12" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G13" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G14" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <br />
                                    <asp:Label runat="server" Text="H" ForeColor="#cd7f32" Font-Bold="true"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:ImageButton ID="H8" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="H9" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="H10" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="H11" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="H12" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="H13" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="H14" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <br />
                                    <br />
                                </td>
                                <td class="ladodir">
                                    &nbsp;<asp:Label runat="server" Text="15" Font-Bold="true"></asp:Label>&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="16" Font-Bold="true"></asp:Label>&nbsp;&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="17" Font-Bold="true"></asp:Label>&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="18" Font-Bold="true"></asp:Label>&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="19" Font-Bold="true"></asp:Label>&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="20" Font-Bold="true"></asp:Label>&nbsp;
                                    <asp:Label runat="server" Text="21" Font-Bold="true"></asp:Label>&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="22" Font-Bold="true"></asp:Label>&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="23" Font-Bold="true"></asp:Label>&nbsp;
                                    <asp:Label runat="server" Text="24" Font-Bold="true"></asp:Label>&nbsp;
                                    <asp:Label runat="server" Text="25" Font-Bold="true"></asp:Label>&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="26" Font-Bold="true"></asp:Label>&nbsp;
                                    <asp:Label runat="server" Text="27" Font-Bold="true"></asp:Label>&nbsp;&nbsp;
                                    <asp:Label runat="server" Text="28" Font-Bold="true"></asp:Label>
                                    <br />
                                    <asp:ImageButton ID="A15ESP" runat="server" Height="26px" ImageUrl="~/img/AssentoIconeEspecial.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="A16ESP" runat="server" Height="26px" ImageUrl="~/img/AssentoIconeEspecial.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="A17ESP" runat="server" Height="26px" ImageUrl="~/img/AssentoIconeEspecial.png" Width="26px" OnClick="EscolherAssento" />
                                    <br />
                                    <asp:ImageButton ID="B15" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B16" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B17" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B18" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B19" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B20" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B21" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B22" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B23" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B24" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B25" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B26" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B27" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="B28" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <br />
                                    <asp:ImageButton ID="C15e16DUP" runat="server" Height="30px" ImageUrl="~/img/AssentoIconeDuplo.png" Width="56px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="ImageButton5" runat="server" Height="26px" Enabled="false" ImageUrl="~/img/Indisponivel.png" Width="28px" />
                                    <asp:ImageButton ID="C18e19DUP" runat="server" Height="30px" ImageUrl="~/img/AssentoIconeDuplo.png" Width="56px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="ImageButton6" runat="server" Height="26px" Enabled="false" ImageUrl="~/img/Indisponivel.png" Width="27px" />
                                    <asp:ImageButton ID="C21e22DUP" runat="server" Height="30px" ImageUrl="~/img/AssentoIconeDuplo.png" Width="56px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="ImageButton7" runat="server" Height="26px" Enabled="false" ImageUrl="~/img/Indisponivel.png" Width="26px" />
                                    <asp:ImageButton ID="C24e25DUP" runat="server" Height="30px" ImageUrl="~/img/AssentoIconeDuplo.png" Width="56px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="ImageButton8" runat="server" Height="26px" Enabled="false" ImageUrl="~/img/Indisponivel.png" Width="26px" />
                                    <asp:ImageButton ID="C27e28DUP" runat="server" Height="30px" ImageUrl="~/img/AssentoIconeDuplo.png" Width="56px" OnClick="EscolherAssento" />
                                    <br />
                                    <asp:ImageButton ID="D15" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D16" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D17" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D18" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D19" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D20" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D21" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D22" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D23" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D24" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D25" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D26" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D27" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="D28" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <br />
                                    <asp:ImageButton ID="E15ESP" runat="server" Height="26px" ImageUrl="~/img/AssentoIconeEspecial.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E16ESP" runat="server" Height="26px" ImageUrl="~/img/AssentoIconeEspecial.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E17ESP" runat="server" Height="26px" ImageUrl="~/img/AssentoIconeEspecial.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E18" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E19" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E20" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E21" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E22" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E23" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E24" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E25" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E26" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E27" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="E28" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <br />
                                    <asp:ImageButton ID="F15" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F16" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F17" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F18" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F19" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F20" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F21" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F22" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F23" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F24" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F25" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F26" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F27" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="F28" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <br />
                                    <asp:ImageButton ID="G15" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G16" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G17" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G18" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G19" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G20" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G21" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G22" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G23" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G24" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G25" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G26" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G27" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="G28" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <br />
                                    <asp:ImageButton ID="H15" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="H16" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="H17" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="H18" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="H19" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="H20" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <asp:ImageButton ID="H21" runat="server" Height="26px" ImageUrl="~/img/AssentoIcone.png" Width="26px" OnClick="EscolherAssento" />
                                    <br />
                                    <br />
                                </td>
                            </tr>
                        </table>
                        <table class="table" id="tabela1">
                            <tr>
                                <td>
                                    <asp:Label runat="server" Font-Bold="True" Text="Assentos Disponíveis:"></asp:Label>&nbsp;&nbsp;<asp:Label ID="lblAssentosDisponiveis" runat="server">170</asp:Label>
                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Image ID="Image5" Width="26" Height="26" runat="server" AlternateText="Assento" ImageUrl="~/img/AssentoIcone.png" /><asp:Label ID="Label4" runat="server" Font-Bold="true" Text=" = Simples"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Image ID="Image7" Width="56" Height="30" runat="server" AlternateText="Assento" ImageUrl="~/img/AssentoIconeDuplo.png" /><asp:Label ID="Label8" runat="server" Font-Bold="true" Text=" = Duplo"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Image ID="Image6" Width="26" Height="26" runat="server" AlternateText="Assento" ImageUrl="~/img/AssentoIconeEspecial.png" /><asp:Label ID="Label7" runat="server" Font-Bold="true" Text=" = Especial"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Image ID="Image8" Width="26" Height="26" runat="server" AlternateText="Assento" ImageUrl="~/img/SimplesSelec.png" /><asp:Label ID="Label9" runat="server" Font-Bold="true" Text=" = Selecionado"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Image ID="Image4" Width="26" runat="server" AlternateText="Assento" ImageUrl="~/img/AssentoRemovido.png" /><asp:Label ID="Label1" runat="server" Font-Bold="true" Text=" = Ocupado"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <br />
                </div>
            </asp:Panel>

            <div class="container">
                <div class="table-responsive" id="tabela7" style="Height:150px;">
                    <asp:GridView ID="dgvAssentos" CssClass="dgv" BackColor="White" ForeColor="Black" runat="server" AutoGenerateColumns="False" Width="100%" OnRowCommand="dgvAssentos_RowCommand" EnableModelValidation="False" OnRowDeleting="dgvAssentos_RowDeleting" >
                        <Columns>
                            <asp:BoundField HeaderText="Número" DataField="ASSENTO_NUMER" />
                            <asp:BoundField HeaderText="Fileira" DataField="ASSENTO_FILEIRA" />
                            <asp:BoundField HeaderText="Tipo" DataField="ASSENTO_TIPO" />
                            <asp:BoundField HeaderText="Setor" DataField="ASSENTO_SETOR" />
                            <asp:BoundField HeaderText="Valor (R$)" DataField="VALOR" />
                            <asp:CommandField ButtonType="Image" CancelText=""  DeleteImageUrl="~/img/XIcone.png" DeleteText="Cancelar"  EditText="" InsertText="" ShowDeleteButton="True" CausesValidation="False">
                            <ControlStyle Width="20px" />
                            </asp:CommandField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>

            <div class="container" id="cont2">
                <br />
                <table id="tb" style="width:100%; border: solid 0.5px rgb(145,0,0)">
                    <tr>
                        <td id="td1">
                            <asp:Label ID="Label12" runat="server" Font-Size="X-Large" Text="Total:"></asp:Label>
                            <asp:Label ID="lblTotalEscolhido" runat="server" Font-Size="X-Large" Font-Bold="True">0 Assentos</asp:Label>
                        </td>
                        <td id="td2">
                            <asp:Label ID="lblValorTotal" runat="server" Font-Size="X-Large" Font-Bold="True"></asp:Label>
                        </td>
                    </tr>
                </table>
                <br />
                <asp:LinkButton runat="server" ID="btnAvancar" CssClass="btn btn-primary" Font-Bold="true" Font-Underline="false" Text="Avançar" OnClick="btnAvancar_Click"></asp:LinkButton>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
