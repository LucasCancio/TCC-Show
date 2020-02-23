<%@ Page Title="Ajuda" Language="C#" MasterPageFile="~/Modelos/Modelos_Cliente/Padrão.Master" AutoEventWireup="true" CodeBehind="Ajuda.aspx.cs" Inherits="TCC_Oficial.Telas.Cliente.Ajuda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3, .auto-style5 {
            width: 15%;
        }
        .auto-style1 {
            margin-bottom: 9%;
        }
        #titulo{
            width: 100%;
            font-size: 200%;
            text-align: center;
        }
        #subtitulo, #subtitulo2, #subtitulo3{
            width: 100%;
            text-align: center;
        }   
        #gpboxAjuda{
            font-size: 120%;
            background-color: #050000;
        }
        .tblduvidas{
            width: 100%;
            border-top: solid 1px white;
        }
        #tb1 {
           width: 60%;
           margin-left: 20%;
        }
        #contato{
            text-align: center;
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <h1 id="titulo">Dúvidas Frequentes</h1>
            <td class="auto-style3"></td>
            <td class="auto-style4">
                <fieldset id="gpboxAjuda" style="border-color: Red; border-width:2px;">
                    <ul>
                        <li style="font-weight:bold">Menores de idade podem assistir a um show?</li>
                        <asp:Label ID="Label8" runat="server" Text="Sim, desde que acompanhados por um responsável."></asp:Label>
                        <li style="font-weight:bold">Qual a duração de um show?</li>
                        <asp:Label ID="Label2" runat="server" Text="As apresentações não tem duração fixa, podendo ser de 5 minutos até 2 horas, por exemplo."></asp:Label>
                        <li style="font-weight:bold">Quantos ingressos posso comprar?</li>
                        <asp:Label ID="Label6" runat="server" Text="Você pode adquirir quantos ingressos desejar, sem limites."></asp:Label>
                        <li style="font-weight:bold">Comprei meu ingresso online, onde retiro?</li>
                        <asp:Label ID="Label1" runat="server" Text="Imprima o comprovante e leve pelo menos 30min antes da apresentação, assim você retirará já no local."></asp:Label>
                        <li style="font-weight:bold">Sobre o preço dos ingressos:</li>
                        <asp:Label ID="Label3" runat="server" Text="Todos os Eventos possuem um valor base, e este valor será atribuído ao setor Bronze. Os assentos dos setores Ouro e Prata sofrerão um acréscimo dado por um percentual. Os assentos especiais não sofrerão esse acréscimo."></asp:Label>
                        <li style="font-weight:bold">Em quantas vezes posso parcelar o pagamento?</li>
                        <asp:Label ID="Label4" runat="server" Text="O máximo de parcelas é de 3x."></asp:Label>
                        <li style="font-weight:bold">Como me alimento na Comedy House?</li>
                        <asp:Label ID="Label5" runat="server" Text="Nossa alimentação é 100% exclusiva do Burger King™!"></asp:Label>
                    </ul>
                    <table class="tblduvidas">
                        <tr>
                            <td>
                                <h2 id="subtitulo">Deseja se apresentar?</h2>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="Se você gostaria de fazer uma apresentação na Comedy House, envie-nos seu nome, CPF e um vídeo seu fazendo uma demonstração para nosso e-mail, assim nós avaliaremos e terá uma resposta!"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <h3 id="subtitulo2">Atenção aos requisitos!</h3>
                                <asp:Label ID="Label13" runat="server" Text="01. Ser maior de <b>18</b> anos"></asp:Label>
                                <br />
                                <asp:Label ID="Label14" runat="server" Text="02. Duração do vídeo: <b>mínimo de 3 minutos</b> e <b>máximo de 7 minutos</b>"></asp:Label>
                                <br />
                                <asp:Label ID="Label15" runat="server" Text="03. Experiência <b>não</b> necessária"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <h2 id="subtitulo3">Seu problema não foi resolvido?</h2>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <div id="contato">
                                    <asp:Label ID="Label9" CssClass="texto1" runat="server" Text="Contate-nos via e-mail, telefone ou WhatsApp:"></asp:Label>
                                    <br />
                                    <asp:Label ID="Label10" CssClass="texto2" runat="server" Text="comedyh@gmail.com" Font-Bold="true"></asp:Label>
                                    <br />
                                    <asp:Label ID="Label11" CssClass="texto3" runat="server" Text="(11) 9 4134 7300" Font-Bold="true"></asp:Label>
                                    <br />
                                    <asp:Label ID="Label12" CssClass="texto4" runat="server" Text="(XX) 4020 9822" Font-Bold="true"></asp:Label>
                                </div>
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
        </tr>
    </table>
    
</asp:Content>
