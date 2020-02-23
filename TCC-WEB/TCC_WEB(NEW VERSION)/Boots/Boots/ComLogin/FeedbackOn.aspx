<%@ Page Title="Feedbacks" Language="C#" MasterPageFile="~/ModeloOn.Master" AutoEventWireup="true" CodeBehind="FeedbackOn.aspx.cs" Inherits="Boots.ComLogin.FeedbackOn" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	
	<style>
		#cont {
			text-align: center;
		}

		#feed {
			border: solid 1px rgb(145,0,0);
			padding-bottom: 7px;
			border-radius: 3px;
		}
	</style>
	<style>
		.starRating {
			cursor: pointer;
			background-repeat: no-repeat;
			display: block;
			width: 50px;
			height: 50px;
		}

		.FilledStars {
			background-image: url("../img/EstrelaCheia.png");
		}

		.WaitingStars {
			background-image: url("../img/EstrelaSelect.png");
		}

		.EmptyStars {
			background-image: url("../img/EstrelaVazia.png");
		}
	</style>
	<style type="text/css">
		*,
		::before,
		::after {
			box-sizing: border-box;
		}

		#fundoFeedBack {
			/*background-color: white;
			border-radius: 10px;*/
		}

			#fundoFeedBack a {
				border-bottom: 4px solid white;
				/*color: black;*/
			}


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

		/*p {
			margin: 0 0 1em;
			line-height: 1.5;
		}

		ul {
			margin: 0 0 1em;
			padding: 0 0 0 1em;
		}

		li:not(:last-child) {
			margin-bottom: 0.5em;
		}*/

		/*code {
			padding: 0.2em;
			border-radius: 3px;
			background-color: #e0e0e0;
		}*/

		pre > code {
			display: block;
			padding: 1em;
			margin: 0;
		}

		#contact2 {
			background-color: white;
			color: black;
		}

		.page-section {
			border: solid 2px rgb(145,0,0);
		}

		#cont2 {
			text-align: center;
		}
	</style>
	<style>
		.starRating {
			cursor: pointer;
			background-repeat: no-repeat;
			display: block;
			width: 50px;
			height: 50px;
		}

		.FilledStars {
			background-image: url("../img/EstrelaCheia.png");
		}

		.WaitingStars {
			background-image: url("../img/EstrelaSelect.png");
		}

		.EmptyStars {
			background-image: url("../img/EstrelaVazia.png");
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
            window.location.assign('../ComLogin/FeedbackOn.aspx')
        })
	</script>
	
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<br />
	<br />
	<br />

	<div class="container" id="cont">
		<br />
		<h1>Feedbacks</h1>
	</div>
	<asp:UpdatePanel runat="server" ID="UpdatePanel1">
		<ContentTemplate>
			<asp:ScriptManager runat="server" ID="ScriptManager1"></asp:ScriptManager>
			<div class="container">
				<!--Section: Contact v.2-->
				<section class="section">
					<br />
					<p class="text-center w-responsive mx-auto mb-5">Assistiu algum show nosso? Gostou? Deixe uma mensagem de avaliação, isso é extremamente importante para nós!</p>
					<div class="row" id="feed">
						<!--Grid column-->
						<div class="col-md-9 mb-md-0 mb-5">
							<form id="contact-form" name="contact-form" action="mail.php" method="POST">
								<!--estrelinha-->
								<%--                        <div class="card-body">
							<asp:Label ID="Label2" runat="server" Text="Avaliação: " />
							<p class="text-muted">
								<ajaxToolkit:Rating ToolTip=""  StarCssClass="starRating" FilledStarCssClass="FilledStars" EmptyStarCssClass="EmptyStars" WaitingStarCssClass="WaitingStars" ID="Avaliacao" runat="server"></ajaxToolkit:Rating>
								<p>
								</p>
								<p>
								</p>
							</p>
							  
							</div>--%>
								<div class="row">
									<div class="col-md-12">
										<div class="md-form mb-0">
											<br />
											<label for="subject" class="">Título (opcional)</label>
											<asp:TextBox runat="server" MaxLength="30" ID="txtEnviarTitulo" autocomplete="off" placeholder="Se quiser, digite um titulo..." CssClass="form-control"></asp:TextBox>
										</div>
									</div>
								</div>
								<!--Grid row-->
								<div class="row">
									<!--Grid column-->
									<div class="col-md-12">
										<div class="md-form">
											<label for="message">Avaliação</label>
											<asp:TextBox MaxLength="120" runat="server" ID="txtEnviarMensagem" autocomplete="off" placeholder="Digite sua mensagem aqui..." TextMode="MultiLine" CssClass="form-control md-textarea"></asp:TextBox>
										</div>
									</div>
								</div>
								<!--Grid row-->
								<div class="row">
									<!--Grid column-->
									<div class="col-md-12">
										<div class="md-form">

											<ajaxToolkit:Rating runat="server" ID="Avaliacao" WaitingStarCssClass="WaitingStars" EmptyStarCssClass="EmptyStars" FilledStarCssClass="FilledStars" StarCssClass="starRating"></ajaxToolkit:Rating>
										</div>
									</div>
								</div>
								<!--Grid row-->
							</form>
							<div class="text-center text-md-left">
								<br />
                                    <asp:Button runat="server" ID="btnEnviar" CssClass="btn btn-primary" Text="Enviar" OnClick="Enviar"></asp:Button>
								<br />
							</div>
							<asp:UpdatePanel runat="server" ID="UpdatePanel2">
								<ContentTemplate>

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
						</div>
						<!--Grid column-->
						<div class="col-md-3 text-center">
							<ul class="list-unstyled mb-0">
								<br />
								<%--<li><img src="../img/endereco.png" width="40px" />
							<p><b>Rua Augusta, 1100 - Consolação</b></p>
						</li>--%>
								<li>
									<img src="../img/fone.png" width="40px" />
									<p><b>(11)2392-2899 /</b></p>
									<b>(11)8976-3200</b>
								</li>
								<li>
									<img src="../img/email.png" width="40px" />
									<p><b>comedy.house.oficial@gmail.com</b></p>
								</li>
							</ul>
						</div>
						<!--Grid column-->
					</div>
				</section>
				<!--Section: Contact v.2-->
			</div>
			<br />
			<br />

			<asp:ListView runat="server" ID="lvFeedBackCliente" OnItemDataBound="lvFeedBackCliente_ItemDataBound"  DataSourceID="SqlDataSource2" OnItemCommand="lvFeedBackCliente_ItemCommand" ItemPlaceholderID="itemPlaceHolder1">
				<%--<EmptyDataTemplate>
					<div class="container text-center font-weight-bold">
						Nenhum FeedBack...
					</div>
				</EmptyDataTemplate>--%>
				<ItemTemplate>
					<div class="container">
						<%--  <ajaxToolkit:Rating ToolTip=""  StarCssClass="starRating" FilledStarCssClass="FilledStars" EmptyStarCssClass="EmptyStars" WaitingStarCssClass="WaitingStars" ID="Avaliacao" runat="server"></ajaxToolkit:Rating>--%>
						<div class="alert alert-success" role="alert" runat="server" id="divAlerta">
							<asp:Label runat="server" ID="TituloAlerta" CssClass="alert-heading" Font-Size="X-Large" Font-Bold="true" Text='<%#Eval("TITULO") %>'></asp:Label>
							<br />
							<asp:Label runat="server" ID="MensagemAlerta" Text='<%#Eval("MENSAGEM") %>'></asp:Label>
							<br />
							<ajaxToolkit:Rating runat="server" ID="AvaliacaoAlerta" WaitingStarCssClass="WaitingStars" ReadOnly="true" CssClass="mb-0" MaxRating="5" CurrentRating='<%#Convert.ToInt32(Eval("AVALIACAO")) %>' EmptyStarCssClass="EmptyStars" FilledStarCssClass="FilledStars" StarCssClass="starRating"></ajaxToolkit:Rating>
							<br />
							<br />
							<hr>
							<asp:Label runat="server" CssClass="mb-0" Text='<%#Eval("NOME") %>'></asp:Label>
							<br />
							<asp:Label runat="server" CssClass="mb-0" Text='<%#Eval("DATA_ENVIO").ToString().Substring(0,16) %>'></asp:Label>
							<br />
							<div class="row">
								<asp:Button CssClass="btn-danger btn-primary ml-auto" runat="server" ID="btnRemoverFB" CommandName="Remover" CommandArgument='<%#Eval("ID_FEEDBACK") %>' Text="Excluir" />
								
							</div>

						</div>
					</div>
				</ItemTemplate>
				<LayoutTemplate>
					<div class="container" style="border: solid 1px rgb(145,0,0)">
						<div class="row"><h2 class="mx-auto">Meus FeedBacks...</h2></div>
						<div class="row">
							<asp:PlaceHolder runat="server" ID="itemPlaceHolder1"></asp:PlaceHolder>
						</div>

					</div>
				</LayoutTemplate>
			</asp:ListView>
			<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:TCCSHOWConnectionString %>" SelectCommand="SELECT FB.ID_FEEDBACK, FB.TITULO, FB.MENSAGEM, FB.AVALIACAO, FB.DATA_ENVIO, P.NOME FROM TB_FEEDBACK FB INNER JOIN TB_PESSOA P ON P.ID_PESSOA = FB.ID_PESSOA WHERE P.ID_PESSOA=(SELECT P.ID_PESSOA FROM TB_CLIENTE CLI INNER JOIN TB_PESSOA P ON P.ID_PESSOA= CLI.ID_PESSOA WHERE CLI.ID_CLIENTE=@ID_CLIENTE)">
				<SelectParameters>
					<asp:SessionParameter Name="ID_CLIENTE" SessionField="IdCliente-LOGADO" />
				</SelectParameters>
			</asp:SqlDataSource>

			<br />
			<br />

			<asp:ListView runat="server" ID="lvFeedBack" OnItemDataBound="lvFeedBack_ItemDataBound" DataSourceID="SqlDataSource1">
				<EmptyDataTemplate>
					<div class="container text-center font-weight-bold">
						Nenhum FeedBack...
					</div>
				</EmptyDataTemplate>
				<ItemTemplate>
					<div class="container">
						<%--  <ajaxToolkit:Rating ToolTip=""  StarCssClass="starRating" FilledStarCssClass="FilledStars" EmptyStarCssClass="EmptyStars" WaitingStarCssClass="WaitingStars" ID="Avaliacao" runat="server"></ajaxToolkit:Rating>--%>
						<div class="alert alert-success" role="alert" runat="server" id="divAlerta">
							<asp:Label runat="server" ID="TituloAlerta" CssClass="alert-heading" Font-Size="X-Large" Font-Bold="true" Text='<%#Eval("TITULO") %>'></asp:Label>
							<br />
							<asp:Label runat="server" ID="MensagemAlerta" Text='<%#Eval("MENSAGEM") %>'></asp:Label>
							<br />
							<ajaxToolkit:Rating runat="server" ID="AvaliacaoAlerta" WaitingStarCssClass="WaitingStars" ReadOnly="true" CssClass="mb-0" MaxRating="5" CurrentRating='<%#Convert.ToInt32(Eval("AVALIACAO")) %>' EmptyStarCssClass="EmptyStars" FilledStarCssClass="FilledStars" StarCssClass="starRating"></ajaxToolkit:Rating>
							<br />
							<br />
							<hr>
							<asp:Label runat="server" CssClass="mb-0" Text='<%#Eval("NOME") %>'></asp:Label>
							<br />
							<asp:Label runat="server" CssClass="mb-0" Text='<%#Eval("DATA_ENVIO").ToString().Substring(0,16) %>'></asp:Label>
							<br />

						</div>
					</div>
				</ItemTemplate>
			</asp:ListView>
			<!-- SUCESSMSG -->
			<!-- The Modal -->
			<asp:Panel runat="server" ID="mymodal" CssClass="modal fade">
				<div class="modal-dialog modal-dialog-centered">
					<div class="modal-content" style="background-color: #d4edda; color: #155724">

						<!-- Modal Header -->
						<div class="modal-header">
							<h4 class="modal-title font-weight-bold"><i class="fa fa-check"></i><asp:Label ID="lblTituloSUC" runat="server" Text="FeedBack enviado com sucesso!"></asp:Label></h4>
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


							<h5 class="text-center"><b>
                                <asp:Label ID="lblMSGBOX" runat="server" Text="Deseja enviar o FeedBack?!"></asp:Label></b>
							</h5>
							<br />

						</div>

						<!-- Modal footer -->
						<div class="modal-footer">
							<button type="button" class="btn-danger btn-secondary font-weight-bold" data-dismiss="modal">Cancelar</button>
							<asp:Button runat="server" ID="btnMSGBOX" OnClick="Enviar2" class="btn-info btn-secondary font-weight-bold" Text="Sim" />
                            <asp:Button runat="server" ID="btnREMOVER" OnClick="RemoverFeedBack" class="btn-info btn-secondary font-weight-bold" Text="Sim" />
						</div>

					</div>
				</div>
			</asp:Panel>
			<!-- /MSGBOX -->
		</ContentTemplate>
	</asp:UpdatePanel>
	<br />
	<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TCCSHOWConnectionString %>" SelectCommand="SELECT FB.TITULO, FB.MENSAGEM, FB.AVALIACAO, FB.DATA_ENVIO, P.NOME FROM TB_FEEDBACK FB INNER JOIN TB_PESSOA P ON P.ID_PESSOA = FB.ID_PESSOA"></asp:SqlDataSource>
	<br />
	<br />
	<br />
	<br />
	<br />
		 
</asp:Content>
