<%@ Page Title="Recuperação de Senha" Language="C#" MasterPageFile="~/ModeloOff.Master" AutoEventWireup="true" CodeBehind="EsqueceuSenhaOff.aspx.cs" Inherits="Boots.SemLogin.EsqueceuSenhaOff" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
           #fundoLogin {
           
        }

            #fundoLogin a {
                border-bottom:4px solid white;
            }

        #cont{
            text-align: center;
        }
        .erro {
            color: red;
            font-weight: bold;
        }
    </style>
     <link rel="stylesheet" href="../css/all.min.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />

    <%--<div class="invalid-feedback">Enter your password too!</div>--%>

        <div class="container">
    <div class="row">
        <div class="col-md-12">
            <h2 class="text-center text-white mb-4">Bootstrap 4 Login Form</h2>
            <div class="row">
                <div class="col-md-6 mx-auto">

                    <!-- form card login -->
                    <asp:UpdatePanel runat="server" ID="UpdatePanel1"><ContentTemplate><asp:ScriptManager runat="server" ID="ScriptManager1"></asp:ScriptManager>
                    <div class="card rounded-0">
                        <div class="card-header">
                            <h3 class="mb-0">Recuperação de Senha</h3>
                        </div>
                        <div class="card-body">
                            <%--<form class="form" role="form" autocomplete="off" id="formLogin" novalidate="" method="POST">--%>
                           <div class="form-group">
                                                    <div class="input-group-prepend">
                                                        <span class="input-group-text rounded-0 border-right-0"><i class=" fa fa-user"> Usuário</i></span>
                                                        <asp:TextBox ID="txtUsuario" CssClass="form-control form-control-lg rounded-0 border-left-0" runat="server" Font-Size="Larger" Font-Names="Quicksand" AutoCompleteType="Disabled" EnableViewState="False" Wrap="False" Enabled="false"></asp:TextBox>
                                                    </div>
                                                </div>
                        
                                <div class="form-group">
                                    <asp:Label ID="Label2" Text="Pergunta Secreta" runat="server" Font-Size="Larger"></asp:Label>
                                    <asp:TextBox ID="txtPergunta" CssClass="form-control form-control-lg rounded-0" MaxLength="250" TextMode="MultiLine" runat="server" Enabled="false" Font-Size="Large" Font-Names="Quicksand" AutoCompleteType="Disabled" EnableViewState="False" Wrap="False"></asp:TextBox>
                                    <%--<div class="invalid-feedback">Enter your password too!</div>--%>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="Label3" Text="Resposta" runat="server" Font-Size="Larger"></asp:Label>
                                    <div class="input-group-prepend">
                                    <asp:TextBox ID="txtResposta" CssClass="form-control form-control-lg rounded-0" runat="server" Font-Size="Large" Font-Names="Quicksand" autocomplete="off" placeholder="Digite sua resposta..." EnableViewState="False" Wrap="False" AutoPostBack="True"></asp:TextBox>

                                    <%--<div class="invalid-feedback">Enter your password too!</div>--%>
                                    <div class="input-group-lg">
                                    <asp:Button ID="btnVerificar" OnClick="Verificar" CssClass="btn btn-success btn-lg float-right bg-danger" runat="server" Font-Names="Quicksand" Font-Size="Larger" Text="Verificar" />

                                        </div>
                                        </div>
                                </div>
                                
                            <asp:Panel runat="server" ID="pnSenha" Enabled="false">
                                <div class="form-group">
                                    <asp:Label ID="Label4" Text="Senha Nova" runat="server" Font-Size="Larger"></asp:Label>
                                    <asp:TextBox ID="txtSenha" CssClass="form-control form-control-lg rounded-0" runat="server" Font-Size="Large" Font-Names="Quicksand" autocomplete="off" placeholder="Digite sua nova senha.." EnableViewState="False" Wrap="False"></asp:TextBox>
                                    <%--<div class="invalid-feedback">Enter your password too!</div>--%>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="Label5" Text="Confirmar Senha" runat="server" Font-Size="Larger"></asp:Label>
                                    <asp:TextBox ID="txtConfirmarSenha" CssClass="form-control form-control-lg rounded-0"  runat="server" Font-Size="Large" Font-Names="Quicksand" autocomplete="off" placeholder="Digite novamente sua senha.." EnableViewState="False" Wrap="False"></asp:TextBox>
                                    <%--<div class="invalid-feedback">Enter your password too!</div>--%>
                                </div>
                                </asp:Panel>
                                   <!-- lblERRO -->

                                            <asp:Panel runat="server" ID="pnErro" Visible="false">
                                                <div class="alert alert-danger" role="alert">
                                                    <i class="glyphicon glyphicon-exclamation-sign erro fa fa-exclamation-triangle"></i>
                                                    <span class="sr-only">Error:</span>
                                                    <asp:Label runat="server" Text="aa" ID="lblErro"></asp:Label>
                                                </div>
                                            </asp:Panel>


                                            <!-- /lblERRO -->

                                <asp:Button ID="btnSalvar" CssClass="btn btn-success btn-lg float-right bg-danger" runat="server" Font-Names="Quicksand" Font-Size="Larger" OnClick="Salvar" Enabled="false"  Text="Salvar" />
                            <%--</form>--%>
                        </div>
                        
                    </div>
                   
                    </ContentTemplate></asp:UpdatePanel>
                </div>


            </div>
            <!--/row-->

        </div>
        <!--/col-->
    </div>
    <!--/row-->
</div>

    

    <br />
    <br />
    <br />
    <br />
</asp:Content>
