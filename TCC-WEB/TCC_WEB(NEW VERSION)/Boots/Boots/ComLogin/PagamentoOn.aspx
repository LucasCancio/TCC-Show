<%@ Page Title="Pagamento" Language="C#" MasterPageFile="~/ModeloOn.Master" AutoEventWireup="true" CodeBehind="PagamentoOn.aspx.cs" Inherits="Boots.ComLogin.PagamentoOn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #fundoAgenda {
        }

            #fundoAgenda a {
                border-bottom: 4px solid white;
            }

        #cont, #cont3 {
            text-align: center;
        }

        .payments {
            max-width: 700px;
            margin: 0 auto;
            padding: 25px;
            overflow: hidden;
        }

        .button {
            float: left;
            width: 100px;
            height: 150px;
            margin-right: 10px;
            padding: 50px 0 0;
            font-size: 12px;
            line-height: 1;
            text-align: center;
            border: 0;
            border-radius: 3px;
            box-shadow: inset 0 0 0 1px #bbb;
        }
    </style>

    <script type="text/javascript">

        $(document).on("focus", "#ContentPlaceHolder1_txtCEP", function () {
            $(this).mask("99999-999");
        });




    </script>
    <style>
        .headerCssClass {
            background-color: #dedede;
            color: white;
            border: 1px solid black;
            padding: 4px;
        }

        .contentCssClass {
            background-color: white;
            color: black;
            border: 1px dotted black;
            padding: 4px;
        }

        .headerSelectedCss {
            background-color: black;
            color: white;
            border: 1px solid black;
            padding: 4px;
        }
    </style>
    <script type="text/javascript">



        function openModal() {
            $('#ContentPlaceHolder1_mymodal').modal('show');
        }

        function openMessageBox() {
            $('#ContentPlaceHolder1_msgBox').modal('show');
        }
        function openBoletoBox() {
            $('#ContentPlaceHolder1_boletobox').modal('show');
        }

        $(document).on('hidden.bs.modal', '#ContentPlaceHolder1_mymodal', function () {
            window.location.assign('../ComLogin/HomeOn.aspx')
        })



    </script>

    <script>
        function AbrirBoleto() {
            window.open('../BoletoBancario.aspx');
            window.location.assign('../ComLogin/HomeOn.aspx')
        }
    </script>
    <style type="text/css">
        .card-img-top {
            width: 100%;
            height: 5.3vw;
            object-fit: contain;
        }

        label > input { /* HIDE RADIO */
            visibility: hidden; /* Makes input not-clickable */
            position: absolute; /* Remove input from document flow */
        }

        label > div > input { /* HIDE RADIO */
            visibility: hidden; /* Makes input not-clickable */
            position: absolute; /* Remove input from document flow */
        }

        label > input + img { /* IMAGE STYLES */
            cursor: pointer;
            border: 2px solid transparent;
            border-radius: 10px;
        }

        label > input:checked + img { /* (RADIO CHECKED) IMAGE STYLES */
            border: 2px solid #f00;
        }

        label > div > input + img { /* IMAGE STYLES */
            cursor: pointer;
            border: 2px solid transparent;
        }

        label > div > input:checked + img { /* (RADIO CHECKED) IMAGE STYLES */
            border: 2px solid #f00;
            border-radius: 10px;
        }
    </style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />

    <div class="container" id="cont">
        <br />
        <h1>Finalizar Compra</h1>
        <br />
    </div>

    <div class="container" id="cont2" runat="server">
        <asp:UpdatePanel runat="server" ID="updatePanel1">
            <ContentTemplate>
                <asp:ScriptManager runat="server" ID="ScriptManager1"></asp:ScriptManager>

                <div class="container col-lg-8">
                    <div class="card">
                        <div class="card-header bg-primary">
                            <div class="row">
                                <div class="col-md-4">
                                    <p class="text-center h3" style="color: aqua"><b>Valor Total:</b></p>
                                </div>
                                <div class="col-md-4 col-md-offset-4">
                                    <asp:Label ID="lblValorTotal" runat="server" ForeColor="White" CssClass="text-left h2" Font-Bold="true"></asp:Label>
                                </div>
                            </div>

                        </div>
                        <div class="card-body">
                            <div class="form-group">
                                <asp:Label runat="server" ID="Label1" Text="Código Promocional"></asp:Label>
                                <div class="input-group mb-3">
                                    <asp:TextBox ID="txtCodPromo" autocomplete="off" placeholder="Preencha com o código promocional.." CssClass="form-control" runat="server" Font-Names="Quicksand"></asp:TextBox>
                                    <div class="input-group-append">
                                        <asp:Button ID="btnVerificar" CssClass="btn btn-success bg-danger" OnClick="VerificarDesconto" runat="server" Font-Names="Quicksand" Font-Size="Larger" Text="Verificar" />
                                    </div>
                                </div>
                                <small id="emailHelp" class="form-text text-muted">Se você possui um Voucher, digite o código correspondente e receba descontos!</small>



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
                            <asp:Panel runat="server" ID="pnDesconto" Visible="false">
                                <div class="form-group">
                                    <div class="col-sm-6 mx-auto borda">
                                        <div class="row">
                                            <label for="exampleInputEmail1">Desconto</label>
                                            <asp:TextBox ID="txtDesconto" Enabled="false" CssClass="form-control" Text="0" runat="server" Font-Size="Larger" Font-Names="Quicksand"></asp:TextBox>
                                        </div>
                                        <div class="row">
                                            <label for="exampleInputEmail1">Porcentual</label>
                                            <asp:TextBox ID="txtPorct" CssClass="form-control" Enabled="false" runat="server" Font-Size="Larger" Font-Names="Quicksand"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </asp:Panel>
                            <br />
                            <form class="form-horizontal">
                                <div class="row">

                                    <div class="col-lg-4 text-center  mx-auto">
                                        <label>
                                            <div>
                                                <asp:RadioButton Checked="true" AutoPostBack="True" GroupName="forma" ID="rbCredito" runat="server" OnCheckedChanged="MudarForma" />
                                                <asp:Image CssClass="img-fluid card-img-top" Width="250px" runat="server" ID="img1" ImageUrl="~/img/Credit.png" />
                                                <b>Crédito</b>
                                            </div>
                                        </label>
                                    </div>


                                    <div class="col-lg-4 text-center  mx-auto">
                                        <label>
                                            <div>
                                                <asp:RadioButton AutoPostBack="True" GroupName="forma" ID="rbBoleto" runat="server" OnCheckedChanged="MudarForma" />
                                                <asp:Image CssClass="img-fluid card-img-top" runat="server" ID="Image3" ImageUrl="~/img/Boleto.png" />
                                                <b>Boleto</b>
                                            </div>
                                        </label>
                                    </div>


                                    <div class="col-lg-4 text-center  mx-auto">
                                        <label>
                                            <div>
                                                <asp:RadioButton GroupName="forma" ID="rbDebito" runat="server" AutoPostBack="True" OnCheckedChanged="MudarForma" />
                                                <asp:Image CssClass="img-fluid card-img-top" runat="server" ID="Image2" ImageUrl="~/img/Debit.png" />
                                                <b>Débito</b>
                                            </div>
                                        </label>
                                    </div>


                                </div>
                                <br />

                                <asp:Panel runat="server" ID="pnCartao" Visible="true">
                                    <div class="col-sm-6 mx-auto borda">
                                        <div class="form-group" style="text-align: center;">
                                            <label for="inputPassword3">Bandeira</label>
                                            <div class="row mx-auto">



                                                <div class="col-lg-6">
                                                    <label>

                                                        <asp:RadioButton AutoPostBack="True" GroupName="cartao" ID="rbVisa" runat="server" />
                                                        <asp:Image runat="server" CssClass="img-fluid" ImageUrl="~/img/visa.png" />
                                                    </label>



                                                </div>
                                                <div class="col-lg-6">
                                                    <label>
                                                        <asp:RadioButton AutoPostBack="True" GroupName="cartao" ID="rbMasterCard" runat="server" />
                                                        <asp:Image runat="server" CssClass="img-fluid" ImageUrl="~/img/mastercard.png" />
                                                    </label>
                                                </div>




                                            </div>
                                        </div>


                                        <asp:Panel runat="server" ID="pnParcelas" Visible="true">
                                            <div class="form-group">
                                                <label for="inputPassword3">Nº de Parcelas</label>
                                                <asp:DropDownList ID="ddlParcelas" CssClass="form-control" Font-Names="Quicksand" runat="server" Font-Size="Larger" OnSelectedIndexChanged="ddlParcelas_SelectedIndexChanged" AutoPostBack="True">
                                                    <asp:ListItem>1x</asp:ListItem>
                                                    <asp:ListItem>2x</asp:ListItem>
                                                    <asp:ListItem>3x</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </asp:Panel>

                                    </div>

                                </asp:Panel>

                                <asp:Panel runat="server" ID="pnBoleto" Visible="false">
                                    <div class="col-sm-6 mx-auto borda">
                                        <div class="form-group">
                                            <div class="row">



                                                <div class="form-group">

                                                    <label for="exampleInputEmail1">CEP</label>
                                                    <div class="input-group mb-3">
                                                        <asp:TextBox ID="txtCEP" class="form-control" placeholder="Digite seu CEP..." runat="server"></asp:TextBox>
                                                        <div class="input-group-append">
                                                            <asp:LinkButton OnClick="VerificarCep" CssClass="btn btn-outline-secondary" runat="server" ID="btnPesquisar"> <i class="fa fa-search"></i> </asp:LinkButton>
                                                        </div>
                                                    </div>
                                                    <small id="emailHelp" class="form-text text-muted">Após digitar o CEP, clique no botão do lado, para ser feito a busca do endereço.</small>
                                                </div>

                                            </div>






                                        </div>


                                    </div>
                                    <div class="col-sm-10 mx-auto form-group">
                                        <asp:Panel ID="pnCEP" CssClass="form-group" runat="server" Enabled="false">

                                            <div class="form-group">
                                                <label for="exampleInputEmail1">Logradouro</label>
                                                <asp:TextBox ID="txtLogradouro" class="form-control" placeholder="Digite seu Logradouro..." runat="server"></asp:TextBox>

                                            </div>

                                            <div class="form-group">
                                                <label for="exampleInputEmail1">Bairro</label>
                                                <asp:TextBox ID="txtBairro" class="form-control" placeholder="Digite seu Bairro..." runat="server"></asp:TextBox>

                                            </div>

                                            <div class="form-group">
                                                <label for="exampleInputEmail1">Cidade</label>
                                                <asp:TextBox ID="txtCidade" class="form-control" placeholder="Digite sua Cidade..." runat="server"></asp:TextBox>

                                            </div>

                                            <div class="form-group">
                                                <label for="exampleInputEmail1">Estado</label>
                                                <asp:DropDownList ID="ddlEstados" CssClass="form-control" Font-Names="Quicksand" runat="server" Font-Size="Larger" OnSelectedIndexChanged="ddlParcelas_SelectedIndexChanged" AutoPostBack="True">
                                                    <asp:ListItem>AC</asp:ListItem>
                                                    <asp:ListItem>AL</asp:ListItem>
                                                    <asp:ListItem>AP</asp:ListItem>
                                                    <asp:ListItem>AM</asp:ListItem>
                                                    <asp:ListItem>BA</asp:ListItem>
                                                    <asp:ListItem>CE</asp:ListItem>
                                                    <asp:ListItem>DF</asp:ListItem>
                                                    <asp:ListItem>ES</asp:ListItem>
                                                    <asp:ListItem>GO</asp:ListItem>
                                                    <asp:ListItem>MA</asp:ListItem>
                                                    <asp:ListItem>MT</asp:ListItem>
                                                    <asp:ListItem>MS</asp:ListItem>
                                                    <asp:ListItem>MG</asp:ListItem>
                                                    <asp:ListItem>PA</asp:ListItem>
                                                    <asp:ListItem>PB</asp:ListItem>
                                                    <asp:ListItem>PR</asp:ListItem>
                                                    <asp:ListItem>PE</asp:ListItem>
                                                    <asp:ListItem>PI</asp:ListItem>
                                                    <asp:ListItem>RJ</asp:ListItem>
                                                    <asp:ListItem>RN</asp:ListItem>
                                                    <asp:ListItem>RS</asp:ListItem>
                                                    <asp:ListItem>RO</asp:ListItem>
                                                    <asp:ListItem>RR</asp:ListItem>
                                                    <asp:ListItem>SC</asp:ListItem>
                                                    <asp:ListItem>SP</asp:ListItem>
                                                    <asp:ListItem>SE</asp:ListItem>
                                                    <asp:ListItem>TO</asp:ListItem>
                                                </asp:DropDownList>

                                            </div>



                                        </asp:Panel>
                                        <div class="form-group">
                                            <div class="form-group">
                                                <label for="exampleInputEmail1">Número</label>
                                                <asp:TextBox ID="txtNumero" class="form-control" placeholder="Digite o Número..." runat="server" TextMode="Number"></asp:TextBox>


                                            </div>

                                            <div class="form-group">
                                                <label for="exampleInputEmail1">Complemento(Opcional)</label>
                                                <asp:TextBox ID="txtComplemento" class="form-control" placeholder="Digite o Complemento..." runat="server"></asp:TextBox>

                                            </div>
                                        </div>
                                    </div>

                                </asp:Panel>
                                <br />
                                <div class="form-group">

                                    <p class="text-center">
                                        <asp:CheckBox AutoPostBack="true" OnCheckedChanged="ckTermos_CheckedChanged" runat="server" ID="ckTermos" /><label for="exampleInputEmail1">&nbsp;Li e concordo com os </label>
                                        &nbsp;<asp:LinkButton ID="lblTermos" runat="server" OnClick="lblTermos_Click">termos e condições da Comedy House.</asp:LinkButton>
                                    </p>




                                    <div class="form-group ">
                                        <asp:Panel ID="pnTermos" runat="server" CssClass="table-responsive rounded border border-primary shadow p-3 mb-5 " Style="max-height: 200px" Visible="false">
                                            <p style="margin: 0px 0px 0.7em; padding: 0px; box-sizing: border-box; color: rgba(0, 0, 0, 0.87); font-family: QuickSand; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
                                                Termos e Condições de Compra e Venda de Comedy House, com sede na rua Augusta, 1129, capital de São Paulo. , doravante denominada simplesmente Comedy House, e, de outro lado, o cliente Comedy House, qualificado no momento da compra dos produtos Comedy House, doravante denominado simplesmente Cliente.
                                            </p>
                                            <p style="margin: 0px 0px 0.7em; padding: 0px; box-sizing: border-box; color: rgba(0, 0, 0, 0.87); font-family: QuickSand; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
                                                Considerando que a Comedy House realiza venda de produtos e serviços pela internet; Considerando o interesse do Cliente na compra dos produtos oferecidos pela Comedy House (&quot;Produtos&quot;) em seus canais de venda; O presente contrato tem por finalidade estabelecer as condições gerais de uso e compra de produtos e serviços do cliente do site Comedy House.
                                            </p>
                                            <p style="margin: 0px 0px 0.7em; padding: 0px; box-sizing: border-box; color: rgba(0, 0, 0, 0.87); font-family: QuickSand; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
                                                <b>I. Confidencialidade:</b> é de responsabilidade da Comedy House a preservação da confidencialidade de todos os dados e informações fornecidos pelo Cliente no processo de compra. A segurança do site é auditada diariamente e garantida contra a ação de hackers, através do selo &quot;Site Blindado&quot;.
                                            </p>
                                            <p style="margin: 0px 0px 0.7em; padding: 0px; box-sizing: border-box; color: rgba(0, 0, 0, 0.87); font-family: QuickSand; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
                                                <b>II. Serviço de Atendimento ao Cliente (SAC):</b> O cliente dispõe desse serviço para sanar suas dúvidas, solucionar eventuais solicitações ou reclamações a respeito do seu pedido ou de qualquer conteúdo disponibilizado no site. O SAC poderá ser acionado por meio de telefone ou de formulário do site.
                                            </p>
                                            <p style="margin: 0px 0px 0.7em; padding: 0px; box-sizing: border-box; color: rgba(0, 0, 0, 0.87); font-family: QuickSand; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
                                                <b>III. Política de entrega:</b> o prazo para entrega dos Produtos é informado durante o procedimento de compra, contabilizado em dias úteis. As entregas dos Produtos são realizadas de segunda a sexta-feira, das 8h às 22h. Excepcionalmente, algumas entregas de Produtos podem ocorrer aos sábados, domingos e feriados.
                                            </p>
                                            <p style="margin: 0px 0px 0.7em; padding: 0px; box-sizing: border-box; color: rgba(0, 0, 0, 0.87); font-family: QuickSand; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
                                                <b>III.I</b> - A conferência da adequação das dimensões do produto é de responsabilidade do Cliente, que deverá se assegurar de que estas estão de acordo com os limites espaciais dos elevadores, portas e corredores do local da entrega. Não será realizada a montagem ou desmontagem do produto, transporte pela escada e/ou portas e janelas, ou içamento das entregas.
                                            </p>
                                            <p style="margin: 0px 0px 0.7em; padding: 0px; box-sizing: border-box; color: rgba(0, 0, 0, 0.87); font-family: QuickSand; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
                                                <b>III.II</b> - Serão realizadas até três tentativas de entrega no local informado, em dias alternados, com intervalo de até 48h entre uma entrega e outra. É indispensável que, no endereço solicitado, haja uma pessoa autorizada pelo comprador, maior de 18 anos, e portando documento de identificação para receber a mercadoria e assinar o protocolo de entrega. Se houver três tentativas de entrega sem sucesso, o pedido retornará para o Centro de Distribuição da Comedy House.
                                            </p>
                                            <p style="margin: 0px 0px 0.7em; padding: 0px; box-sizing: border-box; color: rgba(0, 0, 0, 0.87); font-family: QuickSand; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
                                                <b>III.III</b> - Após a finalização do pedido não é possível alterar a forma de pagamento e/ou endereço de entrega, solicitar adiantamento ou, ainda, prioridade da entrega.
                                            </p>
                                            <p style="margin: 0px 0px 0.7em; padding: 0px; box-sizing: border-box; color: rgba(0, 0, 0, 0.87); font-family: QuickSand; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
                                                <b>III.IV</b> - O prazo de entrega informado durante o procedimento de compra do Produto leva em consideração o estoque, a região, o processo de emissão da nota fiscal e o tempo de preparo do produto. A cada atualização no status de entrega do pedido, o sistema da Comedy House envia, automaticamente, e-mails de alerta para o Cliente.
                                            </p>
                                            <p style="margin: 0px 0px 0.7em; padding: 0px; box-sizing: border-box; color: rgba(0, 0, 0, 0.87); font-family: QuickSand; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
                                                <b>III.V</b> - O valor do frete da entrega é calculado com base no local de entrega, peso e dimensões do Produto.
                                            </p>
                                            <p style="margin: 0px 0px 0.7em; padding: 0px; box-sizing: border-box; color: rgba(0, 0, 0, 0.87); font-family: QuickSand; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
                                                <b>III.VI</b> - A Comedy House não autoriza a transportadora a: entrar no domicílio; entregar por meios alternativos (exemplo: içar produto por janela); realizar instalação ou manutenção de produtos; abrir a embalagem do produto; realizar entrega em endereço diferente do que consta no DANFE; realizar entrega a menor de idade ou sem documento de identificação.
                                            </p>
                                            <p style="margin: 0px 0px 0.7em; padding: 0px; box-sizing: border-box; color: rgba(0, 0, 0, 0.87); font-family: QuickSand; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
                                                <b>III.VII</b> - A Comedy House não se responsabiliza pela retenção de mercadorias na SEFAZ quando esta se dever exclusivamente a pendências do cliente, sendo, portanto, necessário seu comparecimento no posto fiscal para que a mercadoria seja liberada, tendo em vista que nestes casos as informações referentes a liberações e pagamentos só são passadas aos interessados.
                                            </p>
                                            <p style="margin: 0px 0px 0.7em; padding: 0px; box-sizing: border-box; color: rgba(0, 0, 0, 0.87); font-family: QuickSand; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
                                                <b>IV. Direito de arrependimento:</b> ao Cliente será facultado o exercício do direito de arrependimento da compra, com a finalidade de devolução do Produto, hipótese na qual deverão ser observadas as seguintes condições: o prazo de desistência da compra do produto é de até 7 (sete) dias corridos, a contar da data do recebimento; em caso de devolução, o produto deverá ser devolvido à Comedy House na embalagem original, acompanhado do DANFE (Documento Auxiliar da Nota Fiscal Eletrônica), do manual e de todos os seus acessórios.
                                            </p>
                                            <p style="margin: 0px 0px 0.7em; padding: 0px; box-sizing: border-box; color: rgba(0, 0, 0, 0.87); font-family: QuickSand; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
                                                <b>IV.I</b> - O Cliente deverá solicitar a devolução através do Serviço de Atendimento ao Cliente (SAC) ou diretamente no Painel de Controle, no tópico &quot;cancelar pedido&quot;. As despesas decorrentes de coleta ou postagem do Produto serão custeadas pela Comedy House.
                                            </p>
                                            <p style="margin: 0px 0px 0.7em; padding: 0px; box-sizing: border-box; color: rgba(0, 0, 0, 0.87); font-family: QuickSand; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
                                                <b>IV.II</b> - Após a chegada do produto ao Centro de Distribuição, a Comedy House verificará se as condições supra citadas foram atendidas. Em caso afirmativo, providenciará a restituição no valor total da compra.
                                            </p>
                                            <p style="margin: 0px 0px 0.7em; padding: 0px; box-sizing: border-box; color: rgba(0, 0, 0, 0.87); font-family: QuickSand; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
                                                <b>IV.III</b> - Em compras com cartão de crédito a administradora do cartão será notificada e o estorno ocorrerá na fatura seguinte ou na posterior, de uma só vez, seja qual for o número de parcelas utilizado na compra. O prazo de ressarcimento e, ainda, a cobrança das parcelas remanescentes após o estorno integral do valor do Produto no cartão de crédito do Cliente realizado pela Comedy House, é de responsabilidade da administradora do cartão. Na hipótese de cobrança de parcelas futuras pela administradora do cartão, o Cliente não será onerado, vez que a Comedy House, conforme mencionado acima, realiza o estorno do valor integral do Produto em uma única vez, sendo o crédito referente ao estorno concedido integralmente pela administradora do cartão na fatura de cobrança subsequente ao mês do cancelamento.
                                            </p>
                                            <p style="margin: 0px 0px 0.7em; padding: 0px; box-sizing: border-box; color: rgba(0, 0, 0, 0.87); font-family: QuickSand; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial;">
                                                <b>IV.IV</b> - Em compras pagas com boleto bancário ou débito em conta, a restituição será efetuada por meio de depósito bancário, em até 10 (dez) dias úteis, somente na conta corrente do(a) comprador(a), que deve ser individual. É necessário que o CPF do titular da conta corrente.
                                            </p>
                                        </asp:Panel>
                                    </div>
                                </div>




                            </form>
                            <asp:UpdatePanel runat="server" ID="UpdatePanel3">
                                <ContentTemplate>

                                    <br />

                                    <!-- lblERRO -->

                                    <asp:Panel runat="server" ID="pnErro2" Visible="false">
                                        <div class="alert alert-danger" role="alert">
                                            <i class="glyphicon glyphicon-exclamation-sign erro fa fa-exclamation-triangle"></i>
                                            <span class="sr-only">Error:</span>
                                            <asp:Label runat="server" Text="aa" ID="lblErro2"></asp:Label>
                                        </div>
                                    </asp:Panel>


                                    <!-- /lblERRO -->


                                </ContentTemplate>
                            </asp:UpdatePanel>

                            <asp:Button runat="server" OnClick="Finalizar" Enabled="false" ID="btnComprar" CssClass="btn btn-primary btn-lg btn-block" Text="Comprar" Font-Bold="true"></asp:Button>


                        </div>

                    </div>
                </div>

                <!-- SUCESSMSG -->
                <!-- The Modal -->
                <asp:Panel runat="server" ID="mymodal" CssClass="modal fade">
                    <div class="modal-dialog modal-dialog-centered">
                        <div class="modal-content" style="background-color: #d4edda; color: #155724">

                            <!-- Modal Header -->
                            <div class="modal-header">
                                <h4 class="modal-title font-weight-bold"><i class="fa fa-check"></i>Compra efetuada com sucesso!</h4>
                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                            </div>

                            <!-- Modal body -->
                            <div class="modal-body">


                                <h6><b>Detalhes da venda podem ser conferidos no seu Histórico!</b>
                                    <i>(Para acessa-lo, basta acessar o PERFIL,localizado no canto direito superior da tela, e descer a barra de rolagem até o Histórico!)</i></h6>
                                <br />
                                <p class="h5">Obrigado por comprar na <b style="color: rgb(145,0,0)">Comedy House!</b></p>
                            </div>

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


                                <h5 class="text-center"><b>Deseja efetuar o Pagamento?!</b>
                                    <i>
                                        <br />
                                        (Caso queira efetuar, você será redirecionado para o site da Paypal, onde terminará a transação!)</i></h5>
                                <br />

                            </div>

                            <!-- Modal footer -->
                            <div class="modal-footer">
                                <button type="button" class="btn-danger btn-secondary font-weight-bold" data-dismiss="modal">Cancelar</button>
                                <asp:Button runat="server" ID="btnEfetuar" OnClick="EfetuarCompra" class="btn-info btn-secondary font-weight-bold" Text="Sim" />
                            </div>

                        </div>
                    </div>
                </asp:Panel>
                <!-- /MSGBOX -->




                <!-- BOLETOBOX -->
                <!-- The Modal -->
                <asp:Panel runat="server" ID="boletobox" CssClass="modal fade">
                    <div class="modal-dialog modal-lg modal-dialog-centered">
                        <div class="modal-content" style="background-color: #fff3cd; color: #856404">

                            <!-- Modal Header -->
                            <div class="modal-header">
                                <h3 class="modal-title font-weight-bold"><i class="fa fa-exclamation-triangle"></i>Atenção!</h3>
                                <button type="button" class="close" data-dismiss="modal">&times;</button>
                            </div>

                            <!-- Modal body -->
                            <div class="modal-body">


                                <h5 class="text-center"><b>Seu boleto foi gerado com sucesso e será enviado após a confirmação desta mensagem.</b>
                                    <i>

                                        <br />
                                        (Um email será mandando para você, nele poderá ser encontrada a 2º via!)</i>
                                    <br />
                                    <p class="h5">Obrigado por comprar na <b style="color: rgb(145,0,0)">Comedy House!</b></p>
                                </h5>


                            </div>

                            <!-- Modal footer -->
                            <div class="modal-footer">

                                <asp:Button runat="server" ID="btnBoletoBox" OnClick="EfetuarCompra" class="btn-info btn-secondary font-weight-bold" Text="Confirmar" />
                            </div>

                        </div>
                    </div>
                </asp:Panel>
                <!-- /BOLETOBOX -->


            </ContentTemplate>
        </asp:UpdatePanel>
    </div>










    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
