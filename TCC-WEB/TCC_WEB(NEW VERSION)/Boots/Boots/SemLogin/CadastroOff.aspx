<%@ Page Title="Cadastro" Language="C#" MasterPageFile="~/ModeloOff.Master" AutoEventWireup="true" CodeBehind="CadastroOff.aspx.cs" Inherits="Boots.SemLogin.CadastroOff" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #fundoLogin a {
            border-bottom: 4px solid white;
        }

        #cont3 {
            text-align: center;
        }
    </style>
    <style>
        #cont4 {
            background-color: green;
        }

        #cont2 {
            display: inline-flex;
        }

        #lbl {
            color: white;
        }

        #bt {
            text-align: center;
        }
        .erro {
            color: red;
            font-weight: bold;
        }
    </style>
    <script type="text/javascript">


        jQuery(function ($) {
            $("#ContentPlaceHolder1_txtCPF").mask("999.999.999-99");

        });

    </script>
      <script type="text/javascript">

        function openModal() {
            $('#ContentPlaceHolder1_mymodal').modal('show');
        }

        function openMessageBox() {
            $('#ContentPlaceHolder1_msgBox').modal('show');
        }

        $(document).on('hidden.bs.modal', '#ContentPlaceHolder1_mymodal', function () {
            window.location.assign('../ComLogin/Login.aspx')
        })
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />

    <div class="container" id="cont">
        <br />
        <h1>Cadastro</h1>
        <br />
    </div>
   
    <div class="container">
        <div class="row" id="cont2" runat="server">
            <div class="col-lg-6 bg-light ">
                <div class="form-group">
                    <label for="exampleInputEmail1">Nome Completo</label>
                    <asp:TextBox ID="txtNome" autocomplete="off" placeholder="Digite seu nome completo..." CssClass="form-control" runat="server" Font-Size="Larger" ToolTip="Insira seu nome completo." Font-Names="Quicksand"></asp:TextBox>
                    <%--<input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email">--%>
                    <small id="emailHelp" class="form-text text-muted">(Campo obrigatório)</small>
                </div>
                <div class="form-group">
                    <label for="exampleInputPassword1">CPF</label>
                    <asp:TextBox ID="txtCPF" autocomplete="off" placeholder="Digite seu CPF..." CssClass="form-control" runat="server" Font-Size="Larger" ToolTip="Insira seu CPF." Font-Names="Quicksand"></asp:TextBox>
                    <%--<input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">--%>
                    <small id="emailHelp" class="form-text text-muted">(Campo obrigatório)</small>
                </div>
                <div class="form-group">
                    <label for="exampleInputPassword1">Data de Nasc.</label>
                    <asp:TextBox ID="txtDataNasc" TextMode="Date" CssClass="form-control" runat="server" ToolTip="Insira sua data de nascimento (18 anos ou mais)." Font-Size="Larger" Font-Names="Quicksand"></asp:TextBox>
                    <%--<input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">--%>
                    <small id="emailHelp" class="form-text text-muted">(Campo obrigatório)</small>
                </div>
                <div class="form-group">
                    <label for="exampleSelect1">Sexo</label>
                    <asp:DropDownList ID="cbSexo" CssClass="form-control" Font-Names="Quicksand" ToolTip="Insira seu sexo." runat="server" Font-Size="Larger">
                        <asp:ListItem>Masculino</asp:ListItem>
                        <asp:ListItem>Feminino</asp:ListItem>
                        <asp:ListItem>N.I</asp:ListItem>
                    </asp:DropDownList>
                    <small id="emailHelp" class="form-text text-muted">(Campo obrigatório)</small>
                </div>
                <div class="form-group">
                    <label for="exampleInputPassword1">Email</label>
                    <asp:TextBox ID="txtEmail" CssClass="form-control" autocomplete="off" placeholder="Digite seu email..." runat="server" Font-Size="Larger" ToolTip="Insira seu email." Font-Names="Quicksand"></asp:TextBox>
                    <%--<input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">--%>
                    <small id="emailHelp" class="form-text text-muted">(opcional)</small>
                </div>
            </div>
            <div class="col-lg-6 bg-light">
                <div class="form-group">
                    <label for="exampleInputPassword1">Usuário</label>
                    <asp:TextBox ID="txtUsuario" autocomplete="off" placeholder="Digite seu usuário..." CssClass="form-control" runat="server" Font-Size="Larger" ToolTip="Insira um usuário p/ login." Font-Names="Quicksand"></asp:TextBox>
                    <%--<input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">--%>
                    <small id="emailHelp" class="form-text text-muted">(Campo obrigatório)</small>
                </div>
                <div class="form-group">
                    <label for="exampleInputPassword1">Senha</label>
                    <asp:TextBox ID="txtSenha" CssClass="form-control" autocomplete="off" placeholder="Digite sua senha..." runat="server" TextMode="Password" Font-Size="Larger" ToolTip="Insira uma senha p/ login." Font-Names="Quicksand"></asp:TextBox>
                    <%--<input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">--%>
                    <small id="emailHelp" class="form-text text-muted">(Campo obrigatório)</small>
                </div>
                <div class="form-group">
                    <label for="exampleInputPassword1">Pergunta Secreta</label>
                    <asp:TextBox ID="txtPergunta" autocomplete="off" placeholder="Digite sua pergunta secreta..." CssClass="form-control" runat="server" Font-Size="Larger" ToolTip="Insira uma pergunta secreta." Font-Names="Quicksand"></asp:TextBox>
                    <%--<input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">--%>
                    <small id="emailHelp" class="form-text text-muted">(Campo obrigatório)</small>
                </div>
                <div class="form-group">
                    <label for="exampleInputPassword1">Resposta</label>
                    <asp:TextBox ID="txtResposta" autocomplete="off" placeholder="Digite sua resposta..." CssClass="form-control" runat="server" Font-Size="Larger" ToolTip="Insira uma resposta." Font-Names="Quicksand"></asp:TextBox>
                    <%--<input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">--%>
                    <small id="emailHelp" class="form-text text-muted">(Campo obrigatório)</small>
                </div>
                <div class="form-group text-center">
                </div>

            </div>
        </div>
        <asp:UpdatePanel runat="server" ID="UpdatePanel1">
            <ContentTemplate>
            <asp:ScriptManager runat="server" ID="ScriptManager1"></asp:ScriptManager>
                <div class="form-group text-center">

                    
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



                </div>
                <div class="form-group" id="bt">
                    <label id="lbl" for="exampleInputPassword1">dddddd</label>
                    <br />
                    <asp:Button ID="btnSalvar_cad" OnClick="btnSalvar_cad_Click" CssClass="btn btn-primary bg-danger" Font-Bold="true" Font-Names="Quicksand" runat="server" Text="Efetuar Cadastro" />
                </div>
             </ContentTemplate>
        </asp:UpdatePanel>
    </div>
                <!-- SUCESSMSG -->
        <!-- The Modal -->
    <asp:Panel runat="server" ID="mymodal" CssClass="modal fade">
            <div class="modal-dialog modal-dialog-centered">
                <div class="modal-content" style="background-color: #d4edda; color: #155724">

                    <!-- Modal Header -->
                    <div class="modal-header">
                        <h4 class="modal-title font-weight-bold"><i class="fa fa-check"></i>Cadastro efetuado com sucesso!</h4>
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                    </div>

                    <!-- Modal body -->
                    <%--<div class="modal-body">


                        <h6><b>Detalhes da venda podem ser conferidos no seu Histórico!</b>
                            <i>(Para acessa-lo, basta acessar o PERFIL,localizado no canto direito superior da tela, e descer a barra de rolagem até o Histórico!)</i></h6>
                        <br />
                        <p class="h5">Obrigado por comprar na <b style="color: rgb(145,0,0)">Comedy House!</b></p>
                    </div>--%>

                    <!-- Modal footer -->
                    <div class="modal-footer">
                        <button type="button" class="btn-danger btn-secondary" data-dismiss="modal">Fechar</button>
                    </div>

                </div>
            </div>
        </asp:Panel>
        <!-- /SUCESSMSG -->

        <!-- MSGBOX -->
        <!-- The Modal -->
    <asp:Panel runat="server" ID="msgBox" CssClass="modal fade">
            <div class="modal-dialog modal-dialog-centered">
                <div class="modal-content" style="background-color: #fff3cd; color: #856404">

                    <!-- Modal Header -->
                    <div class="modal-header">
                        <h3 class="modal-title font-weight-bold"><i class="fa fa-exclamation-triangle"></i>Atenção!</h3>
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                    </div>

                    <!-- Modal body -->
                    <div class="modal-body">


                        <h5 class="text-center"><b>Deseja finalizar o Cadastro?!</b>
                        </h5>
                       

                    </div>

                    <!-- Modal footer -->
                    <div class="modal-footer">
                        <button type="button" class="btn-danger btn-secondary font-weight-bold" data-dismiss="modal">Cancelar</button>
                        <asp:Button runat="server" ID="btnSalvarAlt" OnClick="Salvar" class="btn-info btn-secondary font-weight-bold" Text="Sim" />
                    </div>

                </div>
            </div>
        </asp:Panel>
        <!-- /MSGBOX -->

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
