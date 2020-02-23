<%@ Page Title="" Language="C#" MasterPageFile="~/Telas/Cliente/Logado/Logado.Master" AutoEventWireup="true" CodeBehind="PerfilLogado.aspx.cs" Inherits="TCC_Oficial.Telas.Cliente.Logado.PerfilLogado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 9%;
        }

        .auto-style3, .auto-style5 {
            width: 15%;
        }

        #titulo {
            font-size: 200%;
            text-align: center;
        }

        .dados {
            width: 100%;
            background-color: #050000;
        }

        .ladoesq_tit, .ladodir_tit {
            text-align: center;
        }

        .ladoesq {
            width: 50%;
            text-align: right;
            padding-right: 8%;
        }

        .ladodir {
            width: 50%;
            text-align: right;
            padding-right: 9%;
        }

        #tbl_botao {
            width: 100%;
            text-align: center;
        }

        .auto-style9 {
            width: 33%;
            padding-right: 8%;
            height: 98px;
        }

        .auto-style10 {
            width: 33%;
            padding-right: 9%;
            height: 98px;
        }

        .auto-style11 {
            text-align: center;
            width: 40%;
            font-weight: bold;
            font-size: xx-large;
        }

        .auto-style12 {
            width: 33%;
            padding-right: 8%;
        }

        .auto-style13 {
            width: 40%;
            text-align: right;
            padding-right: 8%;
            height: 132px;
        }

        .auto-style15 {
            width: 50%;
            text-align: center;
            padding-right: 9%;
        }

        .auto-style16 {
            width: 35%;
            padding-right: 8%;
            height: 132px;
        }

        .auto-style17 {
            width: 35%;
        }

        .auto-style18 {
            margin-left: 0px;
        }

        .auto-style19 {
            margin-top: 26px;
        }
    </style>
    <script type="text/javascript">
        function checkTextBox() {
            var DtpHorarioFinal = document.getElementById("ContentPlaceHolder1_dtpHorarioFinal");
            var DtpHorarioInicial = document.getElementById("ContentPlaceHolder1_dtpHorarioInicial");
            DateTime DataMinima = Date.parse( <%DateTime.Now.ToString().Substring(0, 10); %>);
            DateTime DataMaxima = Date.parse(<% DateTime.Now.AddDays(-180).ToString().Substring(0, 10); %>);

            if (DtpHorarioFinal.value.length > 0 && DtpHorarioInicial.value.length > 0) {

                if (Date.parse(DtpHorarioFinal.value) <= DataMinima && Date.parse(DtpHorarioInicial.value) >= DataMaxima) {

                    alert('aa');
                }
            }




        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">
                        <h1 id="titulo">
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                            Meu Perfil</h1>
                        <fieldset id="gpboxPerfil1" style="border-color: Red; border-width: 2px;">
                            <table class="dados">
                                <tr>
                                    <td class="auto-style10">
                                        <br />
                                        <asp:Label ID="Label11" Text="Dados Pessoais" Font-Bold="true" Font-Size="Larger" runat="server"></asp:Label><br />
                                    </td>
                                    <td class="auto-style17">
                                        <br />
                                        <asp:Label ID="Label12" Text="Dados p/ Login" Font-Bold="true" Font-Size="Larger" runat="server" ToolTip="Insira seu usuário p/ Login."></asp:Label><br />
                                    </td>
                                    <td class="auto-style11">Histórico</td>
                                </tr>
                                <tr>
                                    <td class="auto-style9">
                                        <br />
                                        <asp:Label ID="Label1" Text="Nome:" Font-Size="Larger" runat="server" ToolTip="Insira seu nome completo."></asp:Label>
                                        <br />
                                        <asp:TextBox ID="txtNome" runat="server" Font-Names="Quicksand" Font-Size="Larger" Width="96%" Font-Bold="true" ToolTip="Insira seu nome completo."></asp:TextBox><br />
                                    </td>
                                    <td class="auto-style17">
                                        <br />
                                        <asp:Label ID="Label5" Text="Usuário:" Font-Size="Larger" runat="server" ToolTip="Insira seu usuário p/ Login."></asp:Label>
                                        <br />
                                        <asp:TextBox ID="txtUsuario" Font-Size="Larger" runat="server" Width="88%" Font-Names="Quicksand" Font-Bold="true" ToolTip="Insira seu usuário p/ Login." CssClass="auto-style18"></asp:TextBox>
                                    </td>
                                    <td class="auto-style15" rowspan="4">

                                        <asp:TreeView ID="tvHistorico" runat="server" CssClass="auto-style19" Height="430px" Width="259px" BorderStyle="Solid" ExpandDepth="0">
                                            <Nodes>
                                                <asp:TreeNode Text="Novo Nó" Value="Novo Nó"></asp:TreeNode>
                                            </Nodes>
                                            <NodeStyle ForeColor="White" />
                                            <ParentNodeStyle ChildNodesPadding="2px" ForeColor="#3333FF" Font-Bold="True" />
                                        </asp:TreeView>

                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style9">
                                        <br />
                                        <asp:Label ID="Label4" Font-Size="Larger" Text="CPF:" runat="server" ToolTip="Insira seu CPF."></asp:Label>
                                        <br />
                                        <asp:TextBox ID="txtCPF" runat="server" Font-Size="Larger" Width="96%" Font-Names="Quicksand" Font-Bold="true" ToolTip="Insira seu CPF." MaxLength="11" TextMode="Number" AutoPostBack="True"></asp:TextBox>
                                    </td>
                                    <td class="auto-style17">
                                        <br />
                                        <asp:Label ID="Label6" Text="Senha:" Font-Size="Larger" runat="server" ToolTip="Insira sua senha de acesso."></asp:Label>
                                        <br />
                                        <asp:TextBox ID="txtSenha" runat="server" Font-Size="Larger" Width="86%" Font-Names="Quicksand" Font-Bold="true" ToolTip="Insira sua senha de acesso."></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style12">
                                        <br />
                                        <asp:Label ID="Label2" Font-Size="Larger" Text="Data de Nasc.:" runat="server" ToolTip="Insira sua data de nascimento."></asp:Label>
                                        <br />
                                        <asp:TextBox ID="txtDataNasc" runat="server" Font-Size="Larger" Font-Names="Quicksand" Font-Bold="true" ToolTip="Insira sua data de nascimento." Width="260px"></asp:TextBox>
                                    </td>
                                    <td class="auto-style16">
                                        <br />
                                        <asp:Label ID="Label9" Text="Confirmar:" Font-Size="Larger" runat="server" ToolTip="Confirme sua senha. Certifique-se de que ela é segura."></asp:Label>
                                        <br />
                                        <asp:TextBox ID="txtConfirmarSenha" runat="server" Font-Size="Larger" Width="95%" Font-Names="Quicksand" Font-Bold="true" TextMode="Password" ToolTip="Confirme sua senha. Certifique-se de que ela é segura."></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style9">
                                        <br />
                                        <asp:Label ID="Label3" Text="Sexo:" Font-Size="Larger" runat="server" ToolTip="Informe seu sexo."></asp:Label>
                                        <br />
                                        <asp:DropDownList ID="cbSexo" Font-Names="Quicksand Bold" runat="server" Font-Size="Large" Height="23px" Width="238px">
                                            <asp:ListItem>Masculino</asp:ListItem>
                                            <asp:ListItem>Feminino</asp:ListItem>
                                            <asp:ListItem>N.I</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    <td class="auto-style17">
                                        <br />
                                        <asp:Label ID="Label7" Text="Pergunta:" Font-Size="Larger" runat="server" ToolTip="Insira uma pergunta p/ uma possível recuperação de senha."></asp:Label>
                                        <br />
                                        <asp:TextBox ID="txtPergunta" runat="server" Font-Names="Quicksand" Width="87%" Font-Size="Larger" Font-Bold="true" TextMode="MultiLine" ToolTip="Insira uma pergunta p/ uma possível recuperação de senha."></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style9">
                                        <br />
                                        <asp:Label ID="Label10" Text="E-mail:" Font-Size="Larger" runat="server" ToolTip="Insira seu e-mail."></asp:Label>
                                        <br />
                                        <asp:TextBox ID="txtEmail" Font-Size="Larger" runat="server" Width="96%" Font-Names="Quicksand" Font-Bold="true" ToolTip="Insira seu e-mail."></asp:TextBox>
                                    </td>
                                    <td class="auto-style17">
                                        <br />
                                        <asp:Label ID="Label8" Text="Resposta:" Font-Size="Larger" runat="server" ToolTip="Insira a resposta. Não a esqueça pois ela é sua chave de segurança."></asp:Label>
                                        <br />
                                        <asp:TextBox ID="txtResposta" runat="server" Font-Names="Quicksand" Width="95%" Font-Size="Larger" Font-Bold="true" ToolTip="Insira a resposta. Não a esqueça pois ela é sua chave de segurança."></asp:TextBox>
                                    </td>
                                    <td class="auto-style15">


                                        <input id="dtpHorarioInicial" name="dtpHorarioInicial" type="text" onchange="checkTextBox()" runat="server" />

                                        Á
                                <br />
                                        <input id="dtpHorarioFinal" name="dtpHorarioFinal" type="text" onchange="checkTextBox()" runat="server" />







                                    </td>
                                </tr>
                            </table>

                            <table id="tbl_botao">
                                <tr>
                                    <td class="ladoesq_tit">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <br />
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                
                                <asp:Label ID="lblErro" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Quicksand Bold" ForeColor="Red" CssClass="auto-style13"></asp:Label>

                                        <br />
                                        <br />
                                        <asp:Button ID="btnSalvar" CssClass="btnSalvar" Font-Bold="true" Font-Names="Quicksand Bold" runat="server" Text="Salvar" OnClick="Salvar" Style="margin-left: 0px" Width="181px" />
                                        <br />
                                    </td>
                                </tr>
                            </table>
                        </fieldset>
                    </td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style3"></td>
                </tr>
            </table>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>


