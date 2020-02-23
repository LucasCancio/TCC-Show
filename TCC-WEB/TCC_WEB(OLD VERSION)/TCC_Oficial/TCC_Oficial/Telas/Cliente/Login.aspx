<%@ Page Title="Login" Language="C#" MasterPageFile="~/Modelos/Modelos_Cliente/Padrão.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TCC_Oficial.Telas.Cliente.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
    </script>
    <style type="text/css">
        .auto-style1{
            margin-bottom: 9%;
        }
        .auto-style3, .auto-style5 {
            width: 15%; 
        }
        #titulo{
            text-align: center;
            font-size: 200%;
        }
        .labels{
            width: 35%;
            text-align: left;
            padding-left: 30%;
        }
        .txts{
            width: 50%;
            text-align: left;
        }
        .linha2, .linha3, .linha4{
            text-align: center;
        }
        #gpboxLogin1{
            margin-bottom: 3%;
            background-color: #050000;
        }
        .link{
            font-size: 120%;
            text-decoration: none;
            color: white;
        }
        .link:hover{
            color: red;
        }
        .btnEntrar{
            text-align: center;
            margin-top: 5%;
            width: 10%;
        }
        .auto-style7{
            width: 100%;
            margin: auto;
        }
        .auto-style8 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <table class="auto-style1">
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style6">
                <h1 id="titulo">Digite seus dados</h1>
                <fieldset id="gpboxLogin1" style="border-color: Red; border-width:2px;">
                    <table class="auto-style7">
                        <tr class="linhageral">
                            <td class="labels">
                                <asp:Label ID="Label1" Text="Usuário:" runat="server" Font-Size="Larger"></asp:Label>
                                <br />
                            </td>
                            <td class="txts">
                                <asp:TextBox ID="txtUsuario" runat="server" Font-Size="Larger" Font-Names="Quicksand" Font-Bold="true"></asp:TextBox> <asp:RequiredFieldValidator ID="erroUsuario" runat="server" ErrorMessage="Informe um Usuário válido." ControlToValidate="txtUsuario" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="labels">
                                <asp:Label ID="Label2" Text="Senha:" runat="server" Font-Size="Larger"></asp:Label>
                            </td>
                            <td class="txts">
                                <asp:TextBox ID="txtSenha" runat="server" Font-Size="Larger" Font-Names="Quicksand" Font-Bold="true" TextMode="Password"></asp:TextBox> <asp:RequiredFieldValidator ID="erroSenha" runat="server" ErrorMessage="Informe uma Senha válida!" ControlToValidate="txtSenha" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                    <table class="auto-style8">
                        <tr>
                            <td class="linha2">
                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ShowMessageBox="True" ShowSummary="False" />
                                <br />
                                <asp:HyperLink ID="esqueceuSenha" CssClass="link" Font-Bold="True" runat="server" NavigateUrl="~/Telas/Cliente/EsqueceuSenha.aspx">Esqueceu sua senha?</asp:HyperLink>
                            </td>
                        </tr>
                        <tr>
                            <td class="linha3">
                                <br />
                                <asp:HyperLink ID="linkCadastro" CssClass="link" Font-Bold="True" runat="server" NavigateUrl="~/Telas/Cliente/Cadastro.aspx">Ainda não possui cadastro?</asp:HyperLink>
                            </td>
                        </tr>
                        <tr>
                            <td class="linha4">
                                <br />
                                <asp:Button ID="btnEntrar_log" CssClass="btnEntrar" Font-Bold="true" Font-Names="Quicksand" runat="server" Text="Entrar" OnClick="btnEntrar_log_Click" />
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td></td>
            <td class="auto-style5"></td>
        </tr>
    </table>
    
</asp:Content>
