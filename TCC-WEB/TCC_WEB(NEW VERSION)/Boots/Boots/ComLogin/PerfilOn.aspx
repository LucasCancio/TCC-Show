<%@ Page Title="Perfil" Language="C#" MasterPageFile="~/ModeloOn.Master" AutoEventWireup="true" CodeBehind="PerfilOn.aspx.cs" Inherits="Boots.ComLogin.PerfilOn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #fundoPerfil a {
            border-bottom: 4px solid white;
        }

        #cont3 {
            text-align: center;
        }

        #tree {
            text-align: center;
        }

        .tree {
            margin: auto;
            width: auto;
        }

        #cont2 {
            display: inline-flex;
        }

        #lbl {
            color: white;
        }

        .bt {
            text-align: center;
        }

        #success_message {
            display: none;
        }

        .erro {
            color: red;
            font-weight: bold;
        }

        .sepText {
            background: #ffffff;
            margin: -15px 0 0 -38px;
            padding: 5px 0;
            position: absolute;
            left: 43%;
            text-align: center;
        }

        details:hover summary {
            color: dodgerblue;
        }
    </style>


    <script type="text/javascript">

        function openModal() {
            $('#ContentPlaceHolder1_mymodal').modal('show');
        }

        function openMessageBox() {
            $('#ContentPlaceHolder1_msgBox').modal('show');
        }

        $(document).on('hidden.bs.modal', '#ContentPlaceHolder1_mymodal', function () {
            window.location.assign('../ComLogin/HomeOn.aspx')
        })
    </script>
    <script type="text/javascript">


        jQuery(function ($) {
            $("#ContentPlaceHolder1_txtCPF").mask("999.999.999-99");

        });

        function AtivarDatePick() {

        }
    </script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#show_hide_password3 a").on('click', function (event) {
                event.preventDefault();
                if ($('#show_hide_password3 input').attr("type") == "text") {
                    $('#show_hide_password3 input').attr('type', 'password');
                    $('#show_hide_password3 i').addClass("fa-eye-slash");
                    $('#show_hide_password3 i').removeClass("fa-eye");
                } else if ($('#show_hide_password3 input').attr("type") == "password") {
                    $('#show_hide_password3 input').attr('type', 'text');
                    $('#show_hide_password3 i').removeClass("fa-eye-slash");
                    $('#show_hide_password3 i').addClass("fa-eye");
                }
            });
        });

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

        $(document).ready(function () {
            $("#show_hide_password2 a").on('click', function (event) {
                event.preventDefault();
                if ($('#show_hide_password2 input').attr("type") == "text") {
                    $('#show_hide_password2 input').attr('type', 'password');
                    $('#show_hide_password2 i').addClass("fa-eye-slash");
                    $('#show_hide_password2 i').removeClass("fa-eye");
                } else if ($('#show_hide_password2 input').attr("type") == "password") {
                    $('#show_hide_password2 input').attr('type', 'text');
                    $('#show_hide_password2 i').removeClass("fa-eye-slash");
                    $('#show_hide_password2 i').addClass("fa-eye");
                }
            });
        });


    </script>


    <style type="text/css">
        details {
            margin: 1rem auto;
            padding: 0 1rem;
            width: 35em;
            max-width: calc(100% - 2rem);
            position: relative;
            border: 1px solid #78909c;
            border-radius: 6px;
            background-color: #eceff1;
            color: #263238;
            transition: background-color 0.15s;
        }

            details > :last-child {
                margin-bottom: 1rem;
            }

            details::before {
                width: 100%;
                height: 100%;
                content: "";
                position: absolute;
                top: 0;
                left: 0;
                border-radius: inherit;
                opacity: 0.15;
                box-shadow: 0 0.25em 0.5em #263238;
                pointer-events: none;
                transition: opacity 0.2s;
                z-index: -1;
            }

            details[open] {
                background-color: #fff;
            }

                details[open]::before {
                    opacity: 0.6;
                }

        summary {
            padding: 1rem 2em 1rem 0;
            display: block;
            position: relative;
            font-size: 1.33em;
            font-weight: bold;
            cursor: pointer;
        }

            summary::before, summary::after {
                width: 0.75em;
                height: 2px;
                position: absolute;
                top: 50%;
                right: 0;
                content: "";
                background-color: currentColor;
                text-align: right;
                -webkit-transform: translateY(-50%);
                transform: translateY(-50%);
                transition: -webkit-transform 0.2s ease-in-out;
                transition: transform 0.2s ease-in-out;
                transition: transform 0.2s ease-in-out, -webkit-transform 0.2s ease-in-out;
            }

            summary::after {
                -webkit-transform: translateY(-50%) rotate(90deg);
                transform: translateY(-50%) rotate(90deg);
            }

        [open] summary::after {
            -webkit-transform: translateY(-50%) rotate(180deg);
            transform: translateY(-50%) rotate(180deg);
        }

        summary::-webkit-details-marker {
            display: none;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />

    <div class="container" id="cont">
        <br />
        <h1>Meu Perfil</h1>
        <br />
    </div>
    <%--bg-light border-top border-bottom border-dark--%>
    <div class="container">
        <div class="row">
            <asp:ScriptManager runat="server" ID="ScriptManager2"></asp:ScriptManager>

            <div class="col-lg-6 border-dark">
                <details>
                    <summary class="text-center">
                        <h3 class="font-weight-bold"><i class="fas fa-info-circle float-sm-left align-middle"></i>Informações</h3>
                    </summary>
                    <p>
                        <div class="form-group">
                            <label for="exampleInputEmail1">Nome Completo</label>
                            <asp:TextBox ID="txtNome" placeholder="Digite seu nome completo..." autocomplete="off" CssClass="form-control" runat="server" Font-Size="Larger" ToolTip="Seu nome completo." Font-Names="Quicksand"></asp:TextBox>
                            <%--<input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email">--%>
                            <%--<small id="emailHelp" class="form-text text-muted">(Campo obrigatório)</small>--%>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">CPF</label>
                            <asp:TextBox ID="txtCPF" placeholder="Digite seu CPF..." autocomplete="off" CssClass="form-control" runat="server" Font-Size="Larger" ToolTip="Seu CPF." Font-Names="Quicksand"></asp:TextBox>
                            <%--<input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">--%>
                            <%--<small id="emailHelp" class="form-text text-muted">(Campo obrigatório)</small>--%>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">Data de Nasc.</label>
                            <asp:TextBox ID="txtDataNasc" TextMode="Date" CssClass="form-control" runat="server" ToolTip="Sua data de nascimento (18 anos ou mais)." Font-Size="Larger" Font-Names="Quicksand"></asp:TextBox>
                            <%--<input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">--%>
                            <%--<small id="emailHelp" class="form-text text-muted">(Campo obrigatório)</small>--%>
                        </div>
                        <div class="form-group">
                            <label for="exampleSelect1">Sexo</label>
                            <asp:DropDownList ID="cbSexo" CssClass="form-control" Font-Names="Quicksand" ToolTip="Seu sexo." runat="server" Font-Size="Larger">
                                <asp:ListItem>Masculino</asp:ListItem>
                                <asp:ListItem>Feminino</asp:ListItem>
                                <asp:ListItem>N.I</asp:ListItem>
                            </asp:DropDownList>
                            <%--<small id="emailHelp" class="form-text text-muted">(Campo obrigatório)</small>--%>
                        </div>
                        <div class="form-group">
                            <label for="exampleInputPassword1">Email</label>
                            <asp:TextBox ID="txtEmail" CssClass="form-control" placeholder="Digite seu email..." autocomplete="off" runat="server" Font-Size="Larger" ToolTip="Seu email." Font-Names="Quicksand"></asp:TextBox>
                            <%--<input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">--%>
                            <%--<small id="emailHelp" class="form-text text-muted">(opcional)</small>--%>
                        </div>
                        <div class="form-group text-center">
                            <asp:UpdatePanel runat="server" ID="UpdatePanel5">
                                <ContentTemplate>


                                    <br />
                                    <!-- lblERRO -->

                                    <asp:Panel runat="server" ID="pnErroInf" Visible="false">
                                        <div class="alert alert-danger" role="alert">
                                            <i class="glyphicon glyphicon-exclamation-sign erro fa fa-exclamation-triangle"></i>
                                            <span class="sr-only">Error:</span>
                                            <asp:Label runat="server" Text="aa" ID="lblErroInf"></asp:Label>
                                        </div>
                                    </asp:Panel>


                                    <!-- /lblERRO -->


                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                        <div class="form-group bt">
                            <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                                <ContentTemplate>

                                    <asp:Button ID="btnSalvar_inf" CssClass="btn btn-primary bg-danger" Font-Bold="true" Font-Names="Quicksand" runat="server" Text="Salvar Alterações" OnClick="Salvar" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </p>
                </details>
            </div>

            <div class="col-lg-6">
                <div class="border-dark">
                    <asp:UpdatePanel runat="server" ID="UpdatePanelG">
                        <ContentTemplate>
                            <details>
                                <summary class="text-center">
                                    <h3 class="font-weight-bold"><i class="fas fa-sign-in-alt float-sm-left align-middle"></i>Login</h3>
                                </summary>
                                <p>


                                    <asp:Panel runat="server" ID="pnSenha" Visible="true">


                                        <div class="form-group" id="show_hide_password3">
                                            <asp:Label ID="Label4" Text="Senha" runat="server" Font-Size="Larger">Senha Atual</asp:Label>

                                            <div class="form-group">
                                                <div class="input-group-prepend">

                                                    <asp:TextBox ID="txtSenhaAtual" placeholder="Digite sua senha atual..." autocomplete="off" CssClass="form-control" TextMode="Password" runat="server" Font-Size="Larger" ToolTip="Sua resposta." Font-Names="Quicksand"></asp:TextBox>
                                                    <div class="input-group-text ">
                                                        <a href=""><i class="fa fa-eye-slash" aria-hidden="true"></i></a>
                                                    </div>
                                                </div>

                                            </div>

                                        </div>


                                        <div class="form-group text-center">




                                            <!-- lblERRO -->

                                            <asp:Panel runat="server" ID="pnErroSenha" Visible="false">
                                                <br />
                                                <div class="alert alert-danger" role="alert">
                                                    <i class="glyphicon glyphicon-exclamation-sign erro fa fa-exclamation-triangle"></i>
                                                    <span class="sr-only">Error:</span>
                                                    <asp:Label runat="server" Text="aa" ID="lblErroSenha"></asp:Label>
                                                </div>
                                            </asp:Panel>


                                            <!-- /lblERRO -->



                                        </div>


                                        <div class="form-group bt">


                                            <asp:Button ID="btnVerificarSenha" CssClass="btn btn-primary bg-danger" Font-Bold="true" Font-Names="Quicksand" runat="server" Text="Verificar" OnClick="VerificarSenha" />

                                        </div>

                                    </asp:Panel>


                                    <asp:Panel runat="server" ID="pnLogin" Visible="false">

                                        <div class="form-group">
                                            <label for="exampleInputPassword1">Usuário</label>
                                            <asp:TextBox ID="txtUsuario" placeholder="Digite seu usuário..." autocomplete="off" CssClass="form-control" runat="server" Font-Size="Larger" ToolTip="Seu usuário p/ login." Font-Names="Quicksand"></asp:TextBox>
                                            <%--<input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">--%>
                                            <%--<small id="emailHelp" class="form-text text-muted">(Campo obrigatório)</small>--%>
                                        </div>





                                        <div class="form-group" id="show_hide_password">
                                            <asp:Label ID="Label2" Text="Senha" runat="server" Font-Size="Larger"></asp:Label>

                                            <div class="form-group">
                                                <div class="input-group-prepend">

                                                    <asp:TextBox ID="txtSenha" CssClass="form-control form-control-lg rounded" runat="server" Font-Size="Large" Font-Names="Quicksand" AutoCompleteType="Disabled" EnableViewState="False" Wrap="False" TextMode="Password" placeholder="Digite sua senha..."></asp:TextBox>
                                                    <%-- <div class="input-group-text ">
														<a id="show1" runat="server" href=""><i class="fa fa-eye-slash" aria-hidden="true"></i></a>
													</div>--%>
                                                </div>

                                            </div>

                                        </div>




                                        <div class="form-group">
                                            <label for="exampleInputPassword1">Pergunta Secreta</label>
                                            <asp:TextBox TextMode="MultiLine" MaxLength="128" ID="txtPergunta" placeholder="Digite sua pergunta secreta..." autocomplete="off" CssClass="form-control" runat="server" Font-Size="Larger" ToolTip="Sua pergunta secreta." Font-Names="Quicksand"></asp:TextBox>
                                            <%--<input type="password" class="form-control" id="exampleInputPassword1" placeholder="Password">--%>
                                            <%--<small id="emailHelp" class="form-text text-muted">(Campo obrigatório)</small>--%>
                                        </div>




                                        <div class="form-group" id="show_hide_password2">
                                            <asp:Label ID="Label3" Text="Senha" runat="server" Font-Size="Larger">Resposta</asp:Label>

                                            <div class="form-group">
                                                <div class="input-group-prepend">

                                                    <asp:TextBox ID="txtResposta" placeholder="Digite sua resposta..." autocomplete="off" CssClass="form-control" runat="server" Font-Size="Larger" ToolTip="Sua resposta." Font-Names="Quicksand"></asp:TextBox>
                                                    <%-- <div class="input-group-text ">
														<a id="show2" runat="server" href=""><i class="fa fa-eye-slash" aria-hidden="true"></i></a>
													</div>--%>
                                                </div>

                                            </div>

                                        </div>




                                        <div class="form-group text-center">



                                            <br />
                                            <!-- lblERRO -->

                                            <asp:Panel runat="server" ID="pnErroLog" Visible="false">
                                                <div class="alert alert-danger" role="alert">
                                                    <i class="glyphicon glyphicon-exclamation-sign erro fa fa-exclamation-triangle"></i>
                                                    <span class="sr-only">Error:</span>
                                                    <asp:Label runat="server" Text="aa" ID="lblErroLog"></asp:Label>
                                                </div>
                                            </asp:Panel>


                                            <!-- /lblERRO -->



                                        </div>
                                        <div class="form-group bt">


                                            <asp:Button ID="btnSalvar_log" CssClass="btn btn-primary bg-danger" Font-Bold="true" Font-Names="Quicksand" runat="server" Text="Salvar Alterações" OnClick="Salvar" />

                                        </div>

                                    </asp:Panel>

                                </p>
                            </details>
                        </ContentTemplate>

                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
    </div>



    <%--<div class="form-group">

		<div class="sep">
			<hr>
		</div>

	</div>--%>
    <div class="container" id="cont3">


        <br />
        <h2>Histórico</h2>
        <br />
    </div>

    <div class="container" id="cont3">
        <div id="tree">

            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="row">
                        <div class="mx-auto my-auto">
                            <asp:Label runat="server" Font-Bold="true" ID="label1" Text="De "></asp:Label>
                            <asp:TextBox autocomplete="off" ID="dtpHorarioInicial" runat="server" Font-Size="Larger" Font-Names="Quicksand" TextMode="Date" AutoPostBack="false"></asp:TextBox>
                            <asp:Label runat="server" ID="labell" Font-Bold="true" Text=" Até "></asp:Label>
                            <asp:TextBox autocomplete="off" ID="dtpHorarioFinal" runat="server" Font-Size="Larger" Font-Names="Quicksand" TextMode="Date" AutoPostBack="false"></asp:TextBox>
                            <asp:ImageButton runat="server" ID="btnPesquisar" Style="background-color: lightgrey; height: 20px; border-radius: 9px;" ImageUrl="~/img/ProcurarIcone.png" OnClick="btnPesquisar_Click"></asp:ImageButton>
                        </div>
                    </div>
                    <div class="form-group text-center">



                        <br />
                        <!-- lblERRO -->

                        <asp:Panel runat="server" ID="pnErroHist" Visible="false">
                            <div class="alert alert-danger" role="alert">
                                <i class="glyphicon glyphicon-exclamation-sign erro fa fa-exclamation-triangle"></i>
                                <span class="sr-only">Error:</span>
                                <asp:Label runat="server" Text="aa" ID="lblErroHist"></asp:Label>
                            </div>
                        </asp:Panel>


                        <!-- /lblERRO -->



                    </div>
                    <br />


                    <asp:TreeView ID="tvHistorico" CssClass="tree" runat="server" ForeColor="Black" Font-Underline="false" BorderColor="#910000" BorderStyle="Solid" ExpandDepth="0" OnSelectedNodeChanged="tvHistorico_SelectedNodeChanged">
                        <SelectedNodeStyle Font-Underline="False" />
                        <Nodes>
                            <asp:TreeNode Text="Novo Nó" Value="Novo Nó" SelectAction="Expand"></asp:TreeNode>

                        </Nodes>

                        <ParentNodeStyle Font-Underline="false" Font-Bold="True" ForeColor="Red" />
                    </asp:TreeView>

                   

                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>

        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <!-- SUCESSMSG -->
        <!-- The Modal -->
        <asp:Panel runat="server" ID="mymodal" CssClass="modal fade">
            <div class="modal-dialog modal-dialog-centered">
                <div class="modal-content" style="background-color: #d4edda; color: #155724" runat="server" id="TheModal">

                    <!-- Modal Header -->
                    <div class="modal-header">
                        <h4 class="modal-title font-weight-bold"><i class="fa fa-check"></i>
                            <asp:Label runat="server" ID="lblModal" Text="Alteração efetuada com sucesso!"> </asp:Label></h4>
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


                        <h5 class="text-center"><b>Deseja salvar a Alteração?!</b>
                        </h5>
                        <br />

                    </div>

                    <!-- Modal footer -->
                    <div class="modal-footer">
                        <button type="button" class="btn-danger btn-secondary font-weight-bold" data-dismiss="modal">Cancelar</button>
                        <asp:Button runat="server" ID="btnSalvarAlt" OnClick="SalvarAlteração" class="btn-info btn-secondary font-weight-bold" Text="Sim" />
                    </div>

                </div>
            </div>
        </asp:Panel>
        <!-- /MSGBOX -->
    </div>



</asp:Content>
