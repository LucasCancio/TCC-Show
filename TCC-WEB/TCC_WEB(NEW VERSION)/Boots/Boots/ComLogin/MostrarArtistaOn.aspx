<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloOn.Master" AutoEventWireup="true" CodeBehind="MostrarArtistaOn.aspx.cs" Inherits="Boots.ComLogin.MostrarArtistaOn" %>

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
        #fundoArtista {
        }

            #fundoArtista a {
                border-bottom: 4px solid white;
            }

        .card-title, .card-text {
            text-align: center;
        }

        #tree {
            text-align: center;
        }

        .tree {
            margin: auto;
        }

        .card {
            border: solid 1px rgb(145,0,0);
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
            background-color: rgb(145,0,0);
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
            top: 55%;
            bottom: 30%;
            left: 0;
            font-weight: bold;
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />

    <div class="container" id="cont">
        <br />
        <h1>Detalhes</h1>
        <br />
    </div>

    <div class="container">
        <div class="row">
            <div class="col-lg-6 my-auto">
                <div class="card">
                    <asp:Image runat="server" ID="imgArtista" CssClass="card-img-top" />
                </div>
            </div>
            <div class="col-lg-6">
                <div class="form-group">
                    <label for="exampleInputEmail1">Nome Completo</label>
                    <asp:TextBox ID="txtNome" CssClass="form-control" Enabled="false" runat="server" Font-Names="Quicksand"></asp:TextBox>
                    <br />
                    <label for="exampleInputEmail1">Data de Nascimento</label>
                    <asp:TextBox ID="txtDataNasc" CssClass="form-control" Enabled="false" runat="server" TextMode="Date" Font-Names="Quicksand"></asp:TextBox>
                    <br />
                    <label for="exampleInputEmail1">Facebook</label>
                    <asp:TextBox ID="txtFacebook" CssClass="form-control" Enabled="false" runat="server" Font-Names="Quicksand"></asp:TextBox>
                    <br />
                    <label for="exampleInputEmail1">Instagram</label>
                    <asp:TextBox ID="txtInstagram" CssClass="form-control" Enabled="false" runat="server" Font-Names="Quicksand"></asp:TextBox>
                    <br />
                    <label for="exampleInputEmail1">Twitter</label>
                    <asp:TextBox ID="txtTwitter" CssClass="form-control" Enabled="false" runat="server" Font-Names="Quicksand"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-12">
                <asp:Panel ID="pnEmpresario" runat="server">
                    <h5 class="card-text">
                        <br />
                        <asp:Label runat="server" CssClass="lblTituloEmpr" ID="lblTituloEmpr" Text="Nome do contato" Font-Bold="True"></asp:Label>
                    </h5>
                    <div class="form-group">
                        <label id="lblNomePrincipal" for="exampleInputEmail1" runat="server">Nome do contato</label>
                        <asp:TextBox ID="txtNomePrincipal" CssClass="form-control" Enabled="false" runat="server" Font-Names="Quicksand"></asp:TextBox>
                        <br />
                        <label for="exampleInputEmail1">Telefone/Celular</label>
                        <asp:TextBox ID="txtFone" CssClass="form-control" Enabled="false" runat="server" Font-Names="Quicksand"></asp:TextBox>
                        <br />
                        <label for="exampleInputEmail1">Email</label>
                        <asp:TextBox ID="txtEmail" CssClass="form-control" Enabled="false" runat="server" Font-Names="Quicksand"></asp:TextBox>
                    </div>
                </asp:Panel>
            </div>
        </div>
        <div class="row text-center">
            <div class="col-12">
                <br />
                <h2>Histórico do Artista</h2>
                <div id="tree">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                            <asp:Label runat="server" ID="label5" Text="De "></asp:Label>
                            <asp:TextBox autocomplete="off" ID="dtpHorarioInicial" runat="server" Font-Size="Larger" Font-Names="Quicksand" TextMode="Date"></asp:TextBox>
                            <asp:Label runat="server" ID="labell" Text=" até "></asp:Label>
                            <asp:TextBox autocomplete="off" ID="dtpHorarioFinal" runat="server" Font-Size="Larger" Font-Names="Quicksand" TextMode="Date"></asp:TextBox>
                            <asp:ImageButton runat="server" ID="btnPesquisar" Style="background-color: lightgrey; height: 20px; border-radius: 9px;" ImageUrl="~/img/ProcurarIcone.png" OnClick="btnPesquisar_Click"></asp:ImageButton>
                            <br />

                            <br />
                            <br />
                            <asp:UpdatePanel runat="server" ID="UpdatePanel2">
                                <ContentTemplate>
                                    <div class="container" id="cont2">
                                        <asp:ListView ID="dtEventos" runat="server" OnItemDataBound="dtEventos_ItemDataBound" GroupItemCount="3" GroupPlaceholderID="groupPlaceHolder1" ItemPlaceholderID="itemPlaceHolder1">
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
                                                            <div class="img_description" style="-webkit-text-stroke-width: 0.5px; /* largura da borda */
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
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />
</asp:Content>
