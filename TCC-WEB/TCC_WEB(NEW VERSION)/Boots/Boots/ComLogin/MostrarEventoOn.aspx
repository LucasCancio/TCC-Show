<%@ Page Title="" Language="C#" MasterPageFile="~/ModeloOn.Master" AutoEventWireup="true" CodeBehind="MostrarEventoOn.aspx.cs" Inherits="Boots.ComLogin.MostrarEventoOn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #fundoAgenda {
        }

            #fundoAgenda a {
                border-bottom: 4px solid white;
            }

        .card-body {
            text-align: center;
        }

        .linkMais:hover {
            color: red;
        }

        #cont3 {
            text-align: center;
            background-color: red;
        }

        .imgs {
            display: inline-block;
            text-align: center;
        }

        .card {
            border: solid 1px rgb(145,0,0);
        }

        #art {
            text-align: center;
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
                    <asp:Image runat="server" ID="imgEvento" CssClass="card-img-top" Width="100%" />
                </div>
            </div>
            <div class="col-lg-6">
                <div class="form-group">
                    <label for="exampleInputEmail1">Título</label>
                    <asp:TextBox ID="txtTitulo" CssClass="form-control" Enabled="false" runat="server" Font-Names="Quicksand"></asp:TextBox>
                    <br />
                    <label for="exampleInputEmail1">Data do Evento</label>
                    <asp:TextBox ID="txtDataEvento" CssClass="form-control" Enabled="false" runat="server" TextMode="Date" Font-Names="Quicksand"></asp:TextBox>
                    <br />
                    <label for="exampleInputEmail1">Horário</label>
                    <asp:TextBox ID="txtHorario" CssClass="form-control" Enabled="false" runat="server" Font-Names="Quicksand"></asp:TextBox>
                    <br />
                    <label for="exampleInputEmail1">Descrição</label>
                    <asp:TextBox ID="txtDescricao" CssClass="form-control" Rows="4" TextMode="MultiLine" Enabled="false" runat="server" Font-Names="Quicksand" MaxLength="360"></asp:TextBox>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12" id="art">
                <h3>Artistas</h3>
                <br />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TCCSHOWConnectionString %>" SelectCommand="SELECT TP.TIPO_PESSOA, AG.ID_ARTISTA_GERAL, AG.URL_IMG FROM TB_ARTISTA_GERAL AG  INNER JOIN TB_PESSOA P ON P.ID_PESSOA= AG.ID_PESSOA INNER JOIN TB_EVENTO_ARTISTA EA ON EA.ID_PESSOA = P.ID_PESSOA INNER JOIN TB_TIPO_PESSOA TP ON TP.ID_TIPO_PESSOA= P.ID_TIPO_PESSOA WHERE EA.ID_EVENTO= @ID_EVENTO  ORDER BY AG.ID_ARTISTA_GERAL">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="ID_EVENTO" QueryStringField="id" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:ListView ID="dtArtistas" runat="server" DataSourceID="SqlDataSource1" OnItemCommand="dtArtistas_ItemCommand" OnItemDataBound="dtArtistas_ItemDataBound" GroupItemCount="3" GroupPlaceholderID="groupPlaceHolder1" ItemPlaceholderID="itemPlaceHolder1">
                    <GroupTemplate>
                        <div class="row">
                            <div class="col-lg-12">
                                <asp:PlaceHolder runat="server" ID="itemPlaceHolder1"></asp:PlaceHolder>
                            </div>
                        </div>
                    </GroupTemplate>
                    <ItemTemplate>
                        <asp:ImageButton runat="server" class="card-img-top" Width="250px" ID="imgArtista" ImageUrl='<%# Eval("URL_IMG") %>' CommandArgument='<%#Eval("ID_ARTISTA_GERAL") +";"+Eval("TIPO_PESSOA")%>' CommandName="verArtista" />
                    </ItemTemplate>
                </asp:ListView>
            </div>
        </div>
    </div>

    <div class="container" style="text-align: center">
        <br />
        <br />
        <br />
<%--        <asp:Button runat="server" ID="Button1" CommandName="ComprarIngresso" CssClass="btn bg-primary" OnCommand="LinkButton1_Command" Text="Comprar Ingressos" />--%>
        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="ComprarIngresso" ForeColor="White" CssClass="btn bg-primary" Font-Bold="True" OnCommand="LinkButton1_Command">Comprar Ingressos</asp:LinkButton>
    </div>

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
