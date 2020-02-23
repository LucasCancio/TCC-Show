<%@ Page Title="Agenda" Language="C#" MasterPageFile="~/ModeloOn.Master" AutoEventWireup="true" CodeBehind="AgendaOn.aspx.cs" Inherits="Boots.ComLogin.AgendaOn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #ContentPlaceHolder1_btnPesquisar {
            height: 3vw;
            object-fit: initial;
        }

        table {
            table-layout: fixed;
        }

        td {
            width: 33%;
        }

        .card-img-top {
            width: 100%;
            min-height: 300px;
            /*object-fit: cover;*/
        }

        #cont2 {
            text-align: center;
        }

        #fundoAgenda {
            /* background-color: white;
            border-radius: 10px;*/
        }

            #fundoAgenda a {
                border-bottom: 4px solid white;
            }

        #evento {
            border: solid 1px yellow;
        }

        .linkMais:hover {
            color: red;
        }

        .row {
            text-align: center;
        }

        .col-lg-9 {
            text-align: center;
            /*background-color: forestgreen;*/
            margin: auto;
        }
    </style>

    <style>
        .dropdown.dropdown-lg .dropdown-menu {
            margin-top: -1px;
            padding: 6px 20px;
        }

        .input-group-btn .btn-group {
            display: flex !important;
        }

        .btn-group .btn {
            border-radius: 0;
            margin-left: -1px;
        }

            .btn-group .btn:last-child {
                border-top-right-radius: 4px;
                border-bottom-right-radius: 4px;
            }

        .btn-group .form-horizontal .btn[type="submit"] {
            border-top-left-radius: 4px;
            border-bottom-left-radius: 4px;
        }
        .card-footer {
            background-color:rgb(145,0,0);
            color: white;
        }
        .form-horizontal .form-group {
            margin-left: 0;
            margin-right: 0;
        }

        .form-group .form-control:last-child {
            border-top-left-radius: 4px;
            border-bottom-left-radius: 4px;
        }

        @media screen and (min-width: 768px) {
            #adv-search {
                margin: 0 auto;
            }

            .dropdown.dropdown-lg {
                position: static !important;
            }

                .dropdown.dropdown-lg .dropdown-menu {
                    min-width: 500px;
                }
        }

        .zoom {
            overflow: hidden;
        }

            .zoom img {
                max-width: 100%;
                -moz-transition: all 0.3s;
                -webkit-transition: all 0.3s;
                transition: all 0.3s;
            }

            .zoom:hover img {
                -moz-transform: scale(1.1);
                -webkit-transform: scale(1.1);
                transform: scale(1.1);
            }

        .img_description {
            position: absolute;
           top: 50%;
            bottom: 30%;
            left: 0;
            font-weight:bold;
            right: 0;
            /*background: rgba(29, 106, 154, 0.72);*/
            color: #fff;
            visibility: hidden;
            opacity: 0;
            /* transition effect. not necessary */
            transition: opacity .2s, visibility .2s;
        }



        .zoom:hover .img_description {
            visibility: visible;
            opacity: 1;
        }
    </style>
 
    <script src="/Scripts/jquery-3.3.1.min.js"></script>
    <script src="/Scripts/jquery.maskedinput.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TCCSHOWConnectionString %>" SelectCommand="SELECT EV.ID_EVENTO,EV.TITULO, EV.DATA_EVENTO, CONCAT( CONCAT(FORMAT(EV.HORARIO_INICIO,'HH:mm'), ' até ') , FORMAT(EV.HORARIO_FINAL,'HH:mm') ) as HORARIO, EV.DURACAO, EV.N_ARTISTAS,EV.DESCRICAO,EV.TIPO_PAG, EV.ATIVO, EV.VALOR_EVENTO, EV.URL_IMG FROM TB_EVENTO EV ORDER BY EV.DATA_EVENTO"></asp:SqlDataSource>

    <div class="container">
        <asp:UpdatePanel runat="server" ID="UpdatePanel1">
            <ContentTemplate>
                <asp:ScriptManager runat="server" ID="ScriptManager1"></asp:ScriptManager>
                <div class="container" id="cont">
                    <br />
                    <h1>Próximos Eventos!</h1>
                    <br />
                </div>

                <div class="container" style="text-align: center">
                    <div class="input-group" id="adv-search">
                        <asp:TextBox ID="txtPesquisar" Height="30px" runat="server" Font-Size="Larger" Font-Names="Quicksand" AutoPostBack="True" class="form-control" placeholder="Pesquisar..." autocomplete="off"></asp:TextBox>&nbsp;
                    <asp:DropDownList ID="cbFiltro" Height="30px" Font-Names="Quicksand" runat="server" Font-Size="Larger">
                        <asp:ListItem>Titulo</asp:ListItem>
                        <asp:ListItem>Artista específico</asp:ListItem>
                    </asp:DropDownList>
                        &nbsp;
                    <asp:ImageButton runat="server" ID="btnPesquisar" Style="background-color: lightgrey; height: 30px;  border-radius: 9px;" OnClick="btnPesquisar_Click" ImageUrl="~/img/ProcurarIcone.png"></asp:ImageButton>
                    </div>
                    <br />
                    <asp:Label runat="server" ID="label1" Text="De "></asp:Label>
                    <asp:TextBox ID="dtpHorarioInicio" runat="server" Font-Size="Larger" Font-Names="Quicksand" TextMode="Date"></asp:TextBox>
                    <asp:Label runat="server" ID="labell" Text=" até "></asp:Label>
                    <asp:TextBox ID="dtpHorarioFinal" runat="server" Font-Size="Larger" Font-Names="Quicksand" TextMode="Date"></asp:TextBox>

                  
                       

                        <br />
                    <br />
                        <!-- lblERRO -->

                        <asp:Panel runat="server" ID="pnErro" Visible="false">
                            <div class="alert alert-danger" style="color:red;" role="alert">
                                <i class="glyphicon glyphicon-exclamation-sign erro fa fa-exclamation-triangle"></i>
                                <span class="sr-only">Error:</span>
                                <asp:Label runat="server" Text="aa" ID="lblErro"></asp:Label>
                            </div>
                        </asp:Panel>


                        <!-- /lblERRO -->


                    <br />
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

    <div class="container">
        <asp:UpdatePanel runat="server" ID="UpdatePanel2">
            <ContentTemplate>
                <div class="container" id="cont2">
                    <asp:ListView ID="dtEventos" runat="server" OnItemCommand="dtEventos_ItemCommand" OnItemDataBound="dtEventos_ItemDataBound" GroupItemCount="3" GroupPlaceholderID="groupPlaceHolder1" ItemPlaceholderID="itemPlaceHolder1">
                        <GroupTemplate>
                            <div class="row text-center">
                                <asp:PlaceHolder runat="server" ID="itemPlaceHolder1"></asp:PlaceHolder>
                            </div>
                        </GroupTemplate>
                        <ItemTemplate>
                            <%--                        <div class="row" style="background-color:forestgreen">--%>
                            <div class="col-lg-4 col-md-6 mb-4">
                                <div class="card h-100" style="box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(59, 37, 37, 0.19);">
                                    <div class="zoom">
                                        <asp:Image runat="server" class="card-img-top" Width="100%" Height="50%" ID="imgEvento" ImageUrl='<%# Eval("URL_IMG") %>' />
                                        <div class="img_description" style=" -webkit-text-stroke-width: 0.5px; /* largura da borda */
    -webkit-text-stroke-color: #000; /* cor da borda */">
                                            <i class="fa fa-calendar"></i>
                                             <asp:Label runat="server" Text='<%# Eval("DATA_EVENTO").ToString().Substring(0,10) %>'></asp:Label>
                                            <br />
                                            <i class="fa fa-clock"></i>
                                            <asp:Label runat="server" Text='<%# Eval("HORARIO") %>'></asp:Label>


                                        </div>
                                    </div>
                                    <div class="card-body">
                                        <h4 class="card-title">
                                            <asp:HyperLink Text='<%# Eval("TITULO") %>' ID="DynamicHyperLink1" Font-Bold="True" runat="server"></asp:HyperLink>
                                        </h4>
                                    <%--    <h5 class="card-text">
                                            <asp:Label ID="Label2" runat="server" Text="Horário: " Font-Bold="True" />
                                            <asp:Label ID="DATA_EVENTO" runat="server" Text='<%# Eval("HORARIO") %>' Font-Italic="True" />
                                        </h5>--%>


                                    </div>
                                    <div class="card-footer">
                                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="verMais" CssClass="linkMais" ForeColor="White" CommandArgument='<%#Eval("ID_EVENTO") %>' Font-Bold="True">Ver Mais</asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                            <%--</div>--%>
                            <br />
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <br>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
