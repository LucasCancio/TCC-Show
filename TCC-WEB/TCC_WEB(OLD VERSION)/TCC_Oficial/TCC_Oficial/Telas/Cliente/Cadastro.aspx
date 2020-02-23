<%@ Page Title="Cadastro" Language="C#" MasterPageFile="~/Modelos/Modelos_Cliente/Padrão.Master" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="TCC_Oficial.Telas.Cliente.Cadastro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 9%;
        }

        #titulo, #titulo2, #titulo3, #titulo4 {
            text-align: center;
        }

        #titulo {
            font-size: 200%;
        }

        .dados {
            width: 100%;
        }

        .ladoesq {
            width: 50%;
            text-align: right;
            padding-right: 4%;
        }

        .ladodir {
            width: 50%;
            text-align: right;
            padding-right: 9%;
        }

        .ladoesq_tit, .ladodir_tit {
            text-align: center;
        }

        #tbl_botao {
            width: 100%;
            text-align: center;
        }

        .btnSalvar_css {
            font-family: Quicksand Bold;
            text-align: center;
            width: 10%;
        }

        #gpboxCadastro1 {
            background-color: #050000;
        }

        .auto-style13 {
            font-size: x-large;
            margin-top: 1%;
        }

        *, ::after, ::before {
            text-shadow: none !important;
            box-shadow: none !important
        }

        *, ::after, ::before {
            box-sizing: border-box
        }

        .auto-style14 {
            width: 50%;
            text-align: right;
            padding-right: 4%;
            height: 72px;
        }

        .auto-style15 {
            width: 50%;
            text-align: right;
            padding-right: 9%;
            height: 72px;
        }

        .auto-style16 {
            margin-left: 0px;
        }
    </style>
    <script src="/Scripts/jquery-3.3.1.min.js"></script>
    <script src="/Scripts/jquery.maskedinput.min.js"></script>
    <script type="text/javascript">
        //$(document).ready(function () {
        //      alert("Test alert");
        //    $("#txtCPF").mask("999.999.999-99");

        //});
        function VerificarCpf() {
            var TxtCpf = document.getElementById("ContentPlaceHolder1_txtCPF");
            if (TxtCpf.value.length == 14) {
                
            }
        }
        jQuery(function ($) {
            $("#ContentPlaceHolder1_txtCPF").mask("999.999.999-99");
         
    });
       
    </script>



</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table class="auto-style1">
        <tr>
            <td class="auto-style3"></td>
            <td>
                <h1 id="titulo">Cadastro de Usuário</h1>
                <fieldset id="gpboxCadastro1" style="border-color: Red; border-width: 2px;">
                    <table class="dados">
                        <tr>
                            <td class="ladoesq_tit">
                                <br />
                                <asp:Label ID="Label11" Text="Dados Pessoais" Font-Bold="true" Font-Size="Larger" runat="server"></asp:Label><br />
                            </td>
                            <td class="ladodir_tit">
                                <br />
                                <asp:Label ID="Label12" Text="Dados p/ Login" Font-Bold="true" Font-Size="Larger" runat="server" ToolTip="Insira seu usuário p/ Login."></asp:Label><br />
                            </td>
                        </tr>
                        <tr>
                            <td class="ladoesq">
                                <br />
                                <asp:Label ID="Label1" Text="Nome:" Font-Size="Larger" runat="server" ToolTip="Insira seu nome completo."></asp:Label>
                                <asp:TextBox ID="txtNome" runat="server" Font-Names="Quicksand" Font-Size="Larger" Width="78%" Font-Bold="true" ToolTip="Insira seu nome completo."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Font-Names="Quicksand" ControlToValidate="txtNome" ErrorMessage="Digite seu nome." ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                            <td class="ladodir">
                                <br />
                                <asp:Label ID="Label5" Text="Usuário:" Font-Size="Larger" runat="server" ToolTip="Insira seu usuário p/ Login."></asp:Label>
                                <asp:TextBox ID="txtUsuario" Font-Size="Larger" runat="server" Width="65%" Font-Names="Quicksand" Font-Bold="true" ToolTip="Insira seu usuário p/ Login."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Font-Names="Quicksand" ControlToValidate="txtUsuario" ErrorMessage="Crie um Usuário." ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="ladoesq">
                                <br />
                                <asp:Label ID="Label4" Font-Size="Larger" Text="CPF:" runat="server" ToolTip="Insira seu CPF."></asp:Label>

                                <asp:TextBox ID="txtCPF" runat="server" Font-Size="Larger" Width="40%" autocomplete="off" onChange="VerificarCpf()" Font-Names="Quicksand" Font-Bold="true" ToolTip="Insira seu CPF."></asp:TextBox>



                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Font-Names="Quicksand" ControlToValidate="txtCPF" ErrorMessage="Informe seu CPF." ForeColor="Red">*</asp:RequiredFieldValidator>
                              
                            </td>
                            <td class="ladodir">
                                <br />
                                <asp:Label ID="Label6" Text="Senha:" Font-Size="Larger" runat="server" ToolTip="Insira sua senha de acesso."></asp:Label>
                                <asp:TextBox ID="txtSenha" runat="server" Font-Size="Larger" Width="65%" Font-Names="Quicksand" Font-Bold="true" TextMode="Password" ToolTip="Insira sua senha de acesso."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Font-Names="Quicksand" ControlToValidate="txtSenha" ErrorMessage="Crie uma Senha." ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style14">
                                <br />
                                <asp:Label ID="Label2" Font-Size="Larger" Text="Data de Nasc.:" runat="server" ToolTip="Insira sua data de nascimento."></asp:Label>
                                <asp:TextBox ID="txtDataNasc" runat="server" Font-Size="Larger" Font-Names="Quicksand" Font-Bold="true" TextMode="Date" ToolTip="Insira sua data de nascimento."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Font-Names="Quicksand" ControlToValidate="txtDataNasc" ErrorMessage="Informe sua Data de Nascimento." ForeColor="Red">*</asp:RequiredFieldValidator>
                                <br />
                                <br />
                                <asp:CompareValidator ID="vDateInvalid" runat="server" ControlToValidate="txtDataNasc" ErrorMessage="CompareValidator" Font-Bold="True" Font-Names="Quicksand Bold" ForeColor="Red" Operator="GreaterThan" Type="Date">Data Inválida</asp:CompareValidator>
                                <br />
                                <asp:CompareValidator ID="vDateMaior18" runat="server" ControlToValidate="txtDataNasc" ErrorMessage="CompareValidator" Font-Bold="True" Font-Names="Quicksand Bold" ForeColor="Red" Operator="LessThan" Type="Date">É necessário ter no mínimo 18 anos</asp:CompareValidator>
                            </td>
                            <td class="auto-style15">
                                <br />
                                <asp:Label ID="Label9" Text="Confirmar:" Font-Size="Larger" runat="server" ToolTip="Confirme sua senha. Certifique-se de que ela é segura."></asp:Label>
                                <asp:TextBox ID="txtConfirmarSenha" runat="server" Font-Size="Larger" Width="65%" Font-Names="Quicksand" Font-Bold="true" TextMode="Password" ToolTip="Confirme sua senha. Certifique-se de que ela é segura."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Font-Names="Quicksand" ControlToValidate="txtConfirmarSenha" ErrorMessage="Confirme sua Senha." ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="ladoesq">
                                <br />
                                <asp:Label ID="Label3" Text="Sexo:" Font-Size="Larger" runat="server" ToolTip="Informe seu sexo."></asp:Label>
                                &nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="cbSexo" runat="server" CssClass="auto-style16" Font-Names="Quicksand Bold" Font-Size="Large" Height="25px" Width="298px">
                                    <asp:ListItem>Masculino</asp:ListItem>
                                    <asp:ListItem>Feminino</asp:ListItem>
                                    <asp:ListItem>N.I</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;
                            </td>
                            <td class="ladodir">
                                <br />
                                <asp:Label ID="Label7" Text="Pergunta:" Font-Size="Larger" runat="server" ToolTip="Insira uma pergunta p/ uma possível recuperação de senha."></asp:Label>
                                <asp:TextBox ID="txtPergunta" runat="server" Font-Names="Quicksand" Width="65%" Font-Size="Larger" Font-Bold="true" TextMode="MultiLine" ToolTip="Insira uma pergunta p/ uma possível recuperação de senha."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" Font-Names="Quicksand" ControlToValidate="txtPergunta" ErrorMessage="Crie uma Pergunta Secreta (p/ recuperação de senha)." ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="ladoesq">
                                <br />
                                <asp:Label ID="Label10" Text="E-mail:" Font-Size="Larger" runat="server" ToolTip="Insira seu e-mail."></asp:Label>
                                <asp:TextBox ID="txtEmail" Font-Size="Larger" runat="server" Width="77%" Font-Names="Quicksand" Font-Bold="true" ToolTip="Insira seu e-mail."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" Font-Names="Quicksand" ControlToValidate="txtEmail" ErrorMessage="Informe seu E-mail." ForeColor="Red">*</asp:RequiredFieldValidator>

                            </td>
                            <td class="ladodir">
                                <br />
                                <asp:Label ID="Label8" Text="Resposta:" Font-Size="Larger" runat="server" ToolTip="Insira a resposta. Não a esqueça pois ela é sua chave de segurança."></asp:Label>
                                <asp:TextBox ID="txtResposta" runat="server" Font-Names="Quicksand" Width="65%" Font-Size="Larger" Font-Bold="true" ToolTip="Insira a resposta. Não a esqueça pois ela é sua chave de segurança."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" Font-Names="Quicksand" ControlToValidate="txtResposta" ErrorMessage="Crie uma Resposta." ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>

                    <table id="tbl_botao">
                        <tr>
                            <td>
                                <br />

                                <asp:Label ID="lblErro" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Quicksand Bold" ForeColor="Red" Text="Usuário e/ou Senha inválidos" CssClass="auto-style13"></asp:Label>

                                <br />

                                <br />
                                &nbsp;
                                <asp:Button ID="btnSalvar" runat="server" CssClass="btnSalvar_css" Text="Salvar" OnClick="btnSalvar_cad_Click" />
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ShowMessageBox="True" ShowSummary="False" />
            </td>
            <td class="auto-style5"></td>
        </tr>
    </table>
</asp:Content>
