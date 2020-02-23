<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BoletoBancario.aspx.cs" Inherits="Boots.BoletoBancario" %>

<!DOCTYPE html5>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="icon" href="img/mic.png" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/jquery.maskedinput.min.js"></script>
    <link rel="stylesheet" href="css/all.min.css">
    <!-- Plugin JavaScript -->
    <%-- <script src="vendor/jquery-easing/jquery.easing.min.js"></script>--%>

    <!-- Custom scripts for this template -->
    <%-- <script src="js/new-age.min.js"></script>--%>
    <style type="text/css">
        .Textinho {
            font-size: 0.8rem;
        }

        .italico {
            font-style: italic;
        }
    </style>

    <script type="text/javascript">
        function CallPrint(strid) {
            var prtContent = document.getElementById(strid);
            var WinPrint =
                window.open('', '', 'letf=0,top=0,width=1,height=1,toolbar=0,scrollbars=0,sta­tus=0');
            WinPrint.document.write(prtContent.innerHTML);
            WinPrint.document.close();
            WinPrint.focus();
            WinPrint.print();
            WinPrint.close();
            prtContent.innerHTML = strOldOne;


        }
    </script>
    <title>Comedy House</title>
    <link rel="shortcut icon" href="~/img/favicon.ico" />

</head>
<body>

    <form id="form1" runat="server">

        <b>Instruções:</b>

        <div class="Textinho">
            1- Imprima em impressora jato de tinta(ink jet) ou a laser em qualidade normal ou alta.Não use modo econômico.
        </div>

        <div class="Textinho">
            2- Utilize folha A4 (210x297mm) ou carta (216x279mm) e margens mínimas a esquerda e a direita do formulário
        </div>

        <div class="Textinho">
            3- Corte na linha indicada. Não rasure, risque, fure ou dobre a região onde se encontra o código de barras.
        </div>

        <br />
        <div class="row">
            <div class="col-lg-4">
                <asp:Button runat="server" ID="btnImprirmir" OnClientClick="javascript:window.print();" Text="Imprimir Boleto" />

            </div>
            <div class="col-lg-6">
                <b style="color: red" class="text-center">Verifique as dicas de segurança nos balões abaixo</b>
            </div>
        </div>
        <br />
        <div class="row">
            <asp:Image ID="Image1" Style="width: 80%; margin-left: 10%" ImageUrl="~/imgBoleto/corte.gif" runat="server" />
        </div>
        <br />
        <br />
        <div class="container">
            <asp:Label ID="lblBoletoInfo" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
