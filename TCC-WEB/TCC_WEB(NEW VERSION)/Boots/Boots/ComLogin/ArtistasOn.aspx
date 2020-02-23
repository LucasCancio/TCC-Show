<%@ Page Title="Humoristas" Language="C#" MasterPageFile="~/ModeloOn.Master" AutoEventWireup="true" CodeBehind="ArtistasOn.aspx.cs" Inherits="Boots.ComLogin.ArtistasOn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
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
            height: 21vw;
            object-fit: cover;
        }

        #fundoArtista {
        }

            #fundoArtista a {
                border-bottom: 4px solid white;
            }

        #cont {
            text-align: center;
        }

        .card-body {
            text-align: center;
        }

        .card-footer {
            text-align: center;
        }

        .linkMais:hover {
            color: red;
        }

        .col-lg-9 {
            text-align: center;
            /*background-color: forestgreen;*/
            margin: auto;
        }

        .zoom {
            overflow: hidden;
        }
        .card-footer {
            background-color:rgb(145,0,0);
            color: white;
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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TCCSHOWConnectionString %>" SelectCommand="SELECT AG.ID_ARTISTA_GERAL, AG.URL_IMG, P.NOME, TP.TIPO_PESSOA, P.SEXO,  RD.FACEBOOK, RD.TWITTER, RD.INSTAGRAM, P.ATIVO, P.DATA_CRIACAO FROM TB_PESSOA P INNER JOIN TB_ARTISTA_GERAL AG ON AG.ID_PESSOA= P.ID_PESSOA INNER JOIN TB_REDESOCIAL RD ON RD.ID_REDESOCIAL= AG.ID_REDESOCIAL INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA=P.ID_TIPO_PESSOA ORDER BY AG.ID_ARTISTA_GERAL"></asp:SqlDataSource>

    <div class="container">
        <asp:UpdatePanel runat="server" ID="UpdatePanel1">
            <ContentTemplate>
                <asp:ScriptManager runat="server" ID="ScriptManager1"></asp:ScriptManager>
                <div class="container" id="cont">
                    <br />
                    <h1>Conheça nossos Artistas!</h1>
                    <br />
                </div>
                <div class="container" style="text-align: center">
                    <div class="input-group" id="adv-search">
                        <asp:TextBox ID="txtPesquisar" Height="30px" runat="server" Font-Size="Larger" Font-Names="Quicksand" AutoPostBack="True" class="form-control" placeholder="Pesquisar..." autocomplete="off"></asp:TextBox>&nbsp;
                    <asp:DropDownList ID="cbFiltro" Height="30px" Font-Names="Quicksand" runat="server" Font-Size="Larger">
                        <asp:ListItem>Nome</asp:ListItem>
                    </asp:DropDownList>
                        &nbsp;
                    <asp:ImageButton runat="server" ID="btnPesquisar" Style="background-color: lightgrey; height: 30px; border-radius: 9px;" OnClick="btnPesquisar_Click" ImageUrl="~/img/ProcurarIcone.png"></asp:ImageButton>
                    </div>
                    <br />
                    <asp:RadioButton runat="server" ID="rbArtistaFixo" OnCheckedChanged="rb_CheckedChanged" Text="Artista(s) Fixo" AutoPostBack="True" GroupName="Art" />&nbsp; &nbsp;
                    <asp:RadioButton runat="server" ID="rbTodos" Checked="True" OnCheckedChanged="rb_CheckedChanged" Text="Todos" AutoPostBack="True" Font-Bold="True" GroupName="Art" />&nbsp; &nbsp;
                    <asp:RadioButton runat="server" ID="rbArtista" OnCheckedChanged="rb_CheckedChanged" Text="Artista(s)" AutoPostBack="True" GroupName="Art" />
                    <br />
                    <br />
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

    <div class="container">
        <asp:UpdatePanel runat="server" ID="UpdatePanel2">
            <ContentTemplate>
                <div class="container" id="cont2">
                    <asp:ListView ID="dtArtistas" runat="server" OnItemCommand="dtArtistas_ItemCommand" OnItemDataBound="dtArtistas_ItemDataBound" GroupItemCount="3" GroupPlaceholderID="groupPlaceHolder1" ItemPlaceholderID="itemPlaceHolder1">
                        <GroupTemplate>
                            <div class="row text-center">
                                <asp:PlaceHolder runat="server" ID="itemPlaceHolder1"></asp:PlaceHolder>
                            </div>
                        </GroupTemplate>
                        <ItemTemplate>
                            <%--<div class="row" style="background-color:forestgreen">--%>
                            <div class="col-lg-4 col-md-6 mb-4">
                                <div class="card  h-100" style="box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(59, 37, 37, 0.19);">
                                          <div class="zoom">
                                    <asp:Image runat="server" class="card-img-top" Width="100%" ID="imgArtista" ImageUrl='<%# Eval("URL_IMG") %>' />
                                         <div class="img_description" style=" -webkit-text-stroke-width: 0.5px; /* largura da borda */
    -webkit-text-stroke-color: #000; /* cor da borda */">
                                            <i class="fa fa-calendar-check"></i>
                                             <asp:Label runat="server" Text='<%# Eval("QTDE_EV")+" Evento(s)" %>'></asp:Label>
                                        </div>
                                    </div>
                                    <div class="card-body">
                                        <h4 class="card-title">
                                            <asp:HyperLink runat="server" Text='<%# Eval("NOME") %>'></asp:HyperLink>
                                        </h4>
                                    </div>
                                    <div class="card-footer">
                                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("ID_ARTISTA_GERAL") +";"+Eval("TIPO_PESSOA")%>' CommandName="verMais" CssClass="linkMais" ForeColor="White" Font-Bold="True">Ver Mais</asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
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
</asp:Content>
