<%@ Page Title="Login" Language="C#" MasterPageFile="~/Modelos/Modelos_Cliente/Padrão.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TCC_Oficial.Telas.Cliente.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Content/bootstrap.min.css" rel="stylesheet" />
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
   
            padding-top: 2%;
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
          
           
           
        }
        .auto-style7{
            width: 100%;
            margin: auto;
        }
        .auto-style8 {
            width: 100%;
        }
        .auto-style10 {
            padding-left: 10%;
            padding-top: 1%;
            text-align: left;
            
        }

          
        
        .auto-style11 {
            text-align: center;
            height: 24px;
        }
        .auto-style12 {
            font-size: 70%;
            text-decoration: none;
            color: white;
        }
        .auto-style13 {
            font-size: x-large;
            margin-top: 1%;
        }
        .auto-style14 {
            padding-top: 2%;
            text-align: left;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <table class="auto-style1">
         <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
          <asp:UpdatePanel ID="UpdatePanel1" runat="server">
              <ContentTemplate></ContentTemplate>
                </asp:UpdatePanel>
       
        <tr>
            <td class="auto-style3"></td>
            
            <td class="linha2">
                <br />
                <h1 id="titulo"><b>Digite seus dados</b>
                    
                </h1>
               
                    <table class="auto-style7">
                        <tr class="linhageral">
                            <td class="auto-style10">
                                &nbsp;<asp:Image ID="Image1" runat="server" Height="31px" ImageUrl="~/img/UserIcone.png" Width="28px" />
&nbsp;
                                <asp:Label ID="Label1" Text="Usuário:" runat="server" Font-Size="X-Large"></asp:Label>
                                <br />
                            </td>
                            <td class="auto-style14">
                                <asp:TextBox ID="txtUsuario" CssClass="txts"  runat="server" Font-Size="X-Large" Font-Names="Quicksand" Font-Bold="True" AutoCompleteType="Disabled" EnableViewState="False" Wrap="False" Width="425px" Height="43px"></asp:TextBox> <asp:RequiredFieldValidator ID="erroUsuario" runat="server" ErrorMessage="Informe um Usuário válido." ControlToValidate="txtUsuario" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style10">
                                &nbsp;<asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/img/PasswordIcone1.png" Width="27px" />
&nbsp;
                                <asp:Label ID="Label2" Text="Senha:" runat="server" Font-Size="X-Large"></asp:Label>
                            </td>
                            <td class="auto-style14">
                                <asp:TextBox ID="txtSenha" CssClass="txts" runat="server" Font-Size="X-Large" Font-Names="Quicksand" Font-Bold="True" TextMode="Password" Width="425px" Height="43px"></asp:TextBox> <asp:RequiredFieldValidator ID="erroSenha" runat="server" ErrorMessage="Informe uma Senha válida!" ControlToValidate="txtSenha" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                    </table>
                    <table class="auto-style8">
                        <tr>
                            <td class="auto-style11">
                                <asp:Label ID="lblErro" runat="server" Font-Bold="True" Font-Italic="True" Font-Names="Quicksand" ForeColor="Red" Text="Usuário e/ou Senha inválidos" Visible="False" CssClass="auto-style13"></asp:Label>
                                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ShowMessageBox="True" ShowSummary="False" Height="38px" />
                                <br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td class="linha3">
                    <asp:Button ID="btnEntrar" runat="server" Font-Bold="True" Font-Names="Quicksand" Font-Size="X-Large" Height="44px" OnClick="btnEntrar_Click" Text="Entrar" Width="490px" BackColor="Lime" />
                            </td>
                        </tr>
                        </table>
                        <br />
                                <asp:HyperLink ID="linkCadastro" CssClass="auto-style12" Font-Bold="True" Font-Names="Quicksand" runat="server" NavigateUrl="~/Telas/Cliente/Cadastro.aspx" >Ainda não possui cadastro?</asp:HyperLink>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="btnEsqueceuSenha" runat="server" CausesValidation="False" CssClass="auto-style15" Font-Bold="True" Font-Size="Large" ForeColor="White" OnClick="btnEsqueceuSenha_Click">Esqueceu a senha?</asp:LinkButton>
                </fieldset>
            </td>
            <td class="auto-style5">
               
                
               
            </td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td></td>
            <td class="auto-style5"></td>
        </tr>
    </table>
    
</asp:Content>
