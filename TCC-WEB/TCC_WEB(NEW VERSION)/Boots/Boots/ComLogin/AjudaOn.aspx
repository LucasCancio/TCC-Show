<%@ Page Title="Ajuda" Language="C#" MasterPageFile="~/ModeloOn.Master" AutoEventWireup="true" CodeBehind="AjudaOn.aspx.cs" Inherits="Boots.ComLogin.AjudaOn" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        *,
        ::before,
        ::after {
            box-sizing: border-box;
        }

        #fundoAjuda {
            /*background-color: white;
            border-radius: 10px;*/
        }

            #fundoAjuda a {
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

        details:hover summary {
            color: dodgerblue;
        }
    </style>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#bt1').click(function () {
                $('#fr1').attr('action',
                    'mailto:comedyhouseoficial@gmail.com?subject=' +
                    $('#txtNome').val()+ $('#txtFone').val()+ $('#txtEmail').val()  + '&body=' + $('#txtMsg').val());
                $('#fr1').submit();
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />

    <div class="container" id="cont">
        <br />
        <h1>Dúvidas mais frequentes</h1>
        <br />
    </div>

    <%--</form>--%>

    <div class="container">
        <details>
            <summary>Como se dá o valor de um ingresso?</summary>
            <p>Depende do tipo do assento selecionado, do setor e do peso do Evento.</p>
        </details>

        <details>
            <summary>Menores de idade podem assistir a um show?</summary>
            <p>Sim, desde que acompanhados por um responsável.</p>
        </details>

        <details>
            <summary>Qual a duração de um show?</summary>
            <p>As apresentações não tem duração fixa, podendo ser de 5 minutos até 2 horas, por exemplo.</p>
        </details>

        <details>
            <summary> Quantos ingressos posso comprar?</summary>
            <p>Você pode adquirir quantos ingressos desejar, sem limites ☺ .</p>
        </details>

        <details>
            <summary>Comprei meu ingresso online, onde retiro?</summary>
            <p>Imprima o comprovante e leve pelo menos 30min antes da apresentação, assim você retirará já no local.</p>
        </details>

        <details>
            <summary>Sobre o preço dos ingressos...</summary>
            <p>Todos os Eventos possuem um valor base, e este valor será atribuído ao setor Bronze. Os assentos dos setores Ouro e Prata sofrerão um acréscimo dado por um percentual. Os assentos especiais não sofrerão esse acréscimo.</p>
        </details>

        <details>
            <summary>Em quantas vezes posso parcelar o pagamento?</summary>
            <p>O máximo de parcelas é de 3x.</p>
            <%--<ul>
        <li>MDN: <a href="https://developer.mozilla.org/en-US/docs/Web/HTML/Element/details" target="_blank" rel="noopener">details</a>, <a href="https://developer.mozilla.org/en-US/docs/Web/HTML/Element/summary" target="_blank" rel="noopener">summary</a></li>
        <li><a href="http://html5 doctor.com/the-details-and-summary-elements/" target="_blank" rel="noopener">HTML5Doctor</a></li>
        <li><a href="https://www.scottohara.me/blog/2018/09/03/details-and-summary.html" target="_blank" rel="noopener">Scott O'Hara</a></li>
        <li><a href="https://blog.teamtreehouse.com/use-details-summary-elements" target="_blank" rel="noopener">Treehouse Blog</a></li>
        <li><a href="https://webdesign.tutsplus.com/tutorials/explaining-the-details-and-summary-elements--cms-21999" target="_blank" rel="noopener">Envato Tuts+</a></li>
        <li><a href="https://caniuse.com/#feat=details" target="_blank" rel="noopener">caniuse table for <code>details</code></a></li>
      </ul>--%>
        </details>

        <details>
            <summary>Como me alimento na Comedy House?</summary>
            <p>Nossa alimentação é 100% exclusiva do Burger King™!</p>
        </details>

        <details>
            <summary>Não consegui imprimir meu comprovante, o que faço?</summary>
            <p>Através do app, você pode utilizar o QRCode como ingresso virtual na casa. Assim, não precisará se preocupar com a papelada e ainda evitará filas!</p>
        </details>
    </div>

    <div class="container" id="cont2">
        <br />
        <h2>Não tirou sua dúvida?</h2>
        <br />
    </div>

    <div class="container" id="cont2">
        <p>Mande-nos uma mensagem ou contate-nos via Celular/Telefone:</p>
        <p><b>comedy.house.oficial@gmail.com</b>, (11)2392-2899 e (11)8976-3200</p>
    </div>

    <div class="container contact-form">
        <form method="post">
            <div class="row">
                <div class="col-lg-6" style="margin:auto">
                    <div class="row">
                        <div class="col-lg-6 ">
                        <div class="form-group">
                            <label>Nome (obrigatório)</label>
                            <input type="text" name="txtNome" class="form-control" placeholder="Seu Nome*" value="" />
                        </div>
                        <div class="form-group">
                            <label>Email (obrigatório)</label>
                            <input type="text" name="txtEmail" class="form-control" placeholder="Seu Email*" value="" />
                        </div>
                        <div class="form-group">
                            <label>Telefone (obrigatório)</label>
                            <input type="text" name="txtFone" class="form-control" placeholder="Seu Telefone/Celular*" value="" />
                        </div>

                    </div>
                    <div class="col-lg-6">
                    <div class="form-group">
                        <label>Mensagem (obrigatório)</label>
                        <textarea name="txtMsg" class="form-control" rows="8" placeholder="Sua Mensagem*" style="width: 100%; "></textarea>
                    </div>
                </div>
                    </div>
                    
                </div>
            </div>
            <div class="row">

                <div class="mx-auto">
                    <asp:Button runat="server" ID="btnSubmit"  Text="Enviar" CssClass="btn btn-primary"  />
                </div>

            </div>
        </form>
    </div>


    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
