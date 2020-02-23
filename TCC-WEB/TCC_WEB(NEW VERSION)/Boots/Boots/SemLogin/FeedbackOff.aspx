<%@ Page Title="Feedbacks" Language="C#" MasterPageFile="~/ModeloOff.Master" AutoEventWireup="true" CodeBehind="FeedbackOff.aspx.cs" Inherits="Boots.SemLogin.FeedbackOff" %>

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

        #fundoFeedBack {
            /*background-color: white;
            border-radius: 10px;*/
        }

            #fundoFeedBack a {
                border-bottom: 4px solid white;
                /*color: black;*/
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



                    <p class="text-center"><asp:LinkButton runat="server" OnClick="Unnamed_Click" style="color: blue; font-weight: bold;" >Faça Login</asp:LinkButton> para deixar uma mensagem</p>
                </section>
                <!--Section: Contact v.2-->
            </div>
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
                            <asp:Label runat="server" CssClass="alert-heading" Font-Size="X-Large" Font-Bold="true" ID="TituloAlerta" Text='<%#Eval("TITULO") %>'></asp:Label>
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
