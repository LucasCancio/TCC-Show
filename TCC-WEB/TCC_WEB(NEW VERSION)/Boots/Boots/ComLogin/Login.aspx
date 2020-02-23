<%@ Page Title="Login" Language="C#" MasterPageFile="~/ModeloOff.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Boots.SemLogin.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            font-family: Quicksand;
        }

        #fundoLogin a {
            border-bottom: 4px solid white;
        }

        .link1, .link2 {
            color: red;
            text-decoration: none;
        }

            .link1:hover, .link2:hover {
                color: black;
                text-decoration: none;
            }
    </style>
    <style type="text/css">
        .lftPad {
            margin-left: 25px;
        }


            .lftPad.glyphicon-exclamation-sign:before {
                position: absolute;
                margin-left: -20px;
            }

        .erro {
            color: red;
            font-weight: bold;
        }
    </style>
    <link rel="stylesheet" href="../css/all.min.css">
    <%--    <link rel="stylesheet" href="../Content/bootstrap.min.css" />--%>
    <script src="/Scripts/jquery-3.3.1.min.js"></script>

    <script type="text/javascript">

        $(document).ready(function () {
            $("#show_hide_password a").on('click', function (event) {
                event.preventDefault();
                if ($('#show_hide_password input').attr("type") == "text") {
                    $('#show_hide_password input').attr('type', 'password');
                    $('#show_hide_password i').addClass("fa-eye-slash");
                    $('#show_hide_password i').removeClass("fa-eye");
                } else if ($('#show_hide_password input').attr("type") == "password") {
                    $('#show_hide_password input').attr('type', 'text');
                    $('#show_hide_password i').removeClass("fa-eye-slash");
                    $('#show_hide_password i').addClass("fa-eye");
                }
            });
        });

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />

    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h2 class="text-center text-white mb-4">Bootstrap 4 Login Form</h2>
                <div class="row">
                    <div class="col-md-6 mx-auto">

                        <!-- form card login -->
                        <div class="card rounded-0">
                            <div class="card-header">
                                <h3 class="mb-0">Login</h3>
                            </div>
                            <div class="card-body">
                                <form class="form" role="form" autocomplete="off" id="formLogin" novalidate="" method="POST">
                                    <div class="form-group">
                                        <asp:Label ID="Label1" Text="Usuário" runat="server" Font-Size="Larger"></asp:Label>
                                        <div class="form-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class=" fa fa-user"></i></span>
                                                <asp:TextBox ID="txtUsuario" CssClass="form-control form-control-lg rounded-0" runat="server" Font-Size="Larger" Font-Names="Quicksand" autocomplete="off" EnableViewState="False" Wrap="False" placeholder="Digite seu usuário..."></asp:TextBox>
                                            </div>
                                        </div>

                                    </div>

                                    <div class="form-group" id="show_hide_password">
                                        <asp:Label ID="Label2" Text="Senha" runat="server" Font-Size="Larger"></asp:Label>

                                        <div class="form-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class=" fa fa-unlock"></i></span>
                                                <asp:TextBox ID="txtSenha" CssClass="form-control form-control-lg rounded" runat="server" Font-Size="Large" Font-Names="Quicksand" AutoCompleteType="Disabled" EnableViewState="False" Wrap="False" TextMode="Password" placeholder="Digite sua senha..."></asp:TextBox>
                                                <div class="input-group-text ">
                                                    <a href=""><i class="fa fa-eye-slash" aria-hidden="true"></i></a>
                                                </div>
                                            </div>

                                        </div>

                                    </div>


                                    <asp:UpdatePanel runat="server" ID="UpdatePanel1">
                                        <ContentTemplate>
                                            <asp:ScriptManager runat="server" ID="ScriptManager1"></asp:ScriptManager>
                                            <br />

                                            <!-- lblERRO -->

                                            <asp:Panel runat="server" ID="pnErro" Visible="false">
                                                <div class="alert alert-danger" role="alert">
                                                    <i class="glyphicon glyphicon-exclamation-sign erro fa fa-exclamation-triangle"></i>
                                                    <span class="sr-only">Error:</span>
                                                    <asp:Label runat="server" Text="aa" ID="lblErro"></asp:Label>
                                                </div>
                                            </asp:Panel>


                                            <!-- /lblERRO -->


                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                    <div>
                                        <asp:HyperLink ID="linkCadastro" CssClass="link2" Font-Size="Large" Font-Names="Quicksand" runat="server" NavigateUrl="~/SemLogin/CadastroOff.aspx">Ainda não possui cadastro?</asp:HyperLink>
                                        <%--<label class="custom-control custom-checkbox">
                                          <input type="checkbox" class="custom-control-input">
                                          <span class="custom-control-indicator"></span>
                                          <span class="custom-control-description small text-dark">Remember me on this computer</span>
                                        </label>--%>
                                        <br />
                                        <asp:LinkButton ID="btnEsqueceuSenha" CssClass="link1" runat="server" Font-Names="Quicksand" Font-Size="Large" OnClick="btnEsqueceuSenha_Click1">Esqueceu a senha?</asp:LinkButton>
                                    </div>
                                    <asp:Button ID="btnLogin" CssClass="btn btn-success btn-lg float-right bg-danger" runat="server" Font-Names="Quicksand" Font-Size="Larger" Text="Entrar" OnClick="Entrar" />
                                    <%--<button type="submit" class="btn btn-success btn-lg float-right" id="btnLogin">Login</button>--%>
                                </form>
                            </div>
                            <!--/card-block-->
                        </div>
                        <!-- /form card login -->
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
    <br />
    <br />
</asp:Content>
