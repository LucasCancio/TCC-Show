<%@ Page Title="Recuperação de Senha" Language="C#" MasterPageFile="~/Modelos/Modelos_Cliente/Padrão.Master" AutoEventWireup="true" CodeBehind="EsqueceuSenha.aspx.cs" Inherits="TCC_Oficial.Telas.Cliente.EsqueceuSenha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1{
            margin-bottom: 9%;
        }
        .auto-style3, .auto-style5 {
            width: 15%;
        }
        .tbl{
            width: 100%;
            margin: auto;
        }
        .tbl2{
            width: 60%;
            margin: auto;
        }
        #titulo{
            text-align: center;
            font-size: 200%;
        }
        #gpboxEsqueceu1{
            text-align: center;
            background-color: #050000;
        }
        .ladoesq{
            width: 50%;
            text-align: right;
        }
        .ladodir{
            text-align: left;
            width: 50%;
        }
        .btnSalvar{
            width: 10%;
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

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <table class="auto-style1">
        <tr>
            <td class="auto-style3"></td>
            <td>
                <h1 id="titulo">Alteração de Senha</h1>
                <fieldset id="gpboxEsqueceu1" style="border-color: Red; border-width:2px;">
                    <table class="tbl">
                        <tr>
                            <td>
                                <br />
                                <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="Usuário:"></asp:Label>
                                <asp:TextBox ID="txtUsuario" runat="server"  Font-Size="Larger" Font-Names="Quicksand" Font-Bold="true" Width="325px" Enabled="False"></asp:TextBox>
                                <br /> 
                            </td>
                        </tr>
                    </table>
                    <br />
                    <table class="tbl2">
                        <tr>
                            <td class="ladoesq">
                                <asp:Label ID="Label2" runat="server" Text="Pergunta:" Font-Size="Larger"></asp:Label><br /><br />
                            </td> 
                            <td class="ladodir">
                                <asp:TextBox ID="txtPergunta" Font-Size="Larger" Font-Names="Quicksand" Font-Bold="true" runat="server" Width="95%" TextMode="MultiLine" Enabled="False"></asp:TextBox>
                                <br /><br />
                            </td>
                        </tr>
                        <tr>
                            <td class="ladoesq">
                                <asp:Label ID="Label3" runat="server" Text="Resposta:" Font-Size="Larger"></asp:Label><br /><br />
                            </td> 
                            <td class="ladodir">
                                <asp:TextBox ID="txtResposta" Font-Size="Larger" Font-Names="Quicksand" Font-Bold="true" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtResposta" ErrorMessage="Informe sua Resposta." ForeColor="Red">*</asp:RequiredFieldValidator>
                                <br /><br />
                            </td>
                        </tr>
                        <tr>
                            <td class="ladoesq">
                                <asp:Label ID="Label4" runat="server" Text="Senha Nova:" Font-Size="Larger" ></asp:Label><br /><br />
                            </td> 
                            <td class="ladodir">
                                <asp:TextBox ID="txtSenha" Font-Size="Larger" Font-Names="Quicksand" Font-Bold="true" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSenha" ErrorMessage="Informe uma Senha Nova." ForeColor="Red">*</asp:RequiredFieldValidator><br /><br />
                            </td>
                        </tr>
                        <tr>
                            <td class="ladoesq">
                                <asp:Label ID="Label5" runat="server" Text="Confirmar Senha:" Font-Size="Larger"></asp:Label><br /><br />
                            </td> 
                            <td class="ladodir">
                                <asp:TextBox ID="txtConfirmarSenha" Font-Size="Larger" runat="server" Font-Names="Quicksand" Font-Bold="true" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtConfirmarSenha" ErrorMessage="Confirme sua Senha." ForeColor="Red">*</asp:RequiredFieldValidator><br /><br />
                            </td>
                        </tr>    
                    </table>
                    <br />
                                
                                <asp:Label ID="lblErro" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Quicksand Bold" ForeColor="Red" Text="Resposta Inválida!" Visible="False" CssClass="auto-style13"></asp:Label>
                             
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ShowMessageBox="True" ShowSummary="False" />
                    <br />
                    <asp:Button ID="btnSalvar_log" Font-Bold="true" Font-Names="Quicksand" runat="server" Text="Salvar" OnClick="Salvar" Width="239px" />
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
