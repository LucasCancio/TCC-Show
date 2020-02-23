<%@ Page Title="" Language="C#" MasterPageFile="~/Telas/Cliente/Logado/Logado.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TCC_Oficial.Telas.Cliente.Logado.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style type="text/css">
        .auto-style1{
            margin-bottom: 9%;
        }
        .auto-style6, .auto-style7{
            width: 15%;
        }
        #gpboxEvento1{
            background-color: #050000;
        }
        .tudo{
            margin-top: 1%;
            margin-bottom: 1.5%;
            width: 100%;
        }
        .tudo2{
            width: 40%;
        }
        .radios{
            width: 100%;
            text-align: center;
            margin-bottom: 2%;
        }
        #geral{
            width: 100%;
            display: inline-flex;
        }
        #video{
            position: sticky;
            text-align: center;
            border: double 1px red;
            width: 60%;
            background-color: #050000;
            padding: 1%;
        }
        .textovideo{
            font-size: 140%;
            margin-bottom: 0.5%;
        }
        #textos{
            border-right: double 1px red;
            border-top: double 1px red;
            border-bottom: double 1px red;
            width: 40%;
            text-align: center;
            background-color: #050000;
            padding: 1%;
        }
        .textos{
            width: 100%;
            height: 100%;
        }
        .texto1{
            font-size: 140%;
        }
    </style>
    <script>
        function R1() {
            document.getElementById("Radio2").checked = false;
            document.getElementById("Radio3").checked = false;
            document.getElementById("Radio4").checked = false;
            document.getElementById("Radio5").checked = false;
            document.getElementById("Radio6").checked = false;
            document.getElementById("Radio7").checked = false;
            document.getElementById("Radio8").checked = false;
            document.getElementById("Radio9").checked = false;
            document.getElementById("Radio10").checked = false;
        }

        function R2() {
            document.getElementById("Radio1").checked = false;
            document.getElementById("Radio3").checked = false;
            document.getElementById("Radio4").checked = false;
            document.getElementById("Radio5").checked = false;
            document.getElementById("Radio6").checked = false;
            document.getElementById("Radio7").checked = false;
            document.getElementById("Radio8").checked = false;
            document.getElementById("Radio9").checked = false;
            document.getElementById("Radio10").checked = false;
        }

        function R3() {
            document.getElementById("Radio1").checked = false;
            document.getElementById("Radio2").checked = false;
            document.getElementById("Radio4").checked = false;
            document.getElementById("Radio5").checked = false;
            document.getElementById("Radio6").checked = false;
            document.getElementById("Radio7").checked = false;
            document.getElementById("Radio8").checked = false;
            document.getElementById("Radio9").checked = false;
            document.getElementById("Radio10").checked = false;
        }

        function R4() {
            document.getElementById("Radio1").checked = false;
            document.getElementById("Radio2").checked = false;
            document.getElementById("Radio3").checked = false;
            document.getElementById("Radio5").checked = false;
            document.getElementById("Radio6").checked = false;
            document.getElementById("Radio7").checked = false;
            document.getElementById("Radio8").checked = false;
            document.getElementById("Radio9").checked = false;
            document.getElementById("Radio10").checked = false;
        }

        function R5() {
            document.getElementById("Radio1").checked = false;
            document.getElementById("Radio2").checked = false;
            document.getElementById("Radio3").checked = false;
            document.getElementById("Radio4").checked = false;
            document.getElementById("Radio6").checked = false;
            document.getElementById("Radio7").checked = false;
            document.getElementById("Radio8").checked = false;
            document.getElementById("Radio9").checked = false;
            document.getElementById("Radio10").checked = false;
        }

        function R6() {
            document.getElementById("Radio1").checked = false;
            document.getElementById("Radio2").checked = false;
            document.getElementById("Radio3").checked = false;
            document.getElementById("Radio4").checked = false;
            document.getElementById("Radio5").checked = false;
            document.getElementById("Radio7").checked = false;
            document.getElementById("Radio8").checked = false;
            document.getElementById("Radio9").checked = false;
            document.getElementById("Radio10").checked = false;
        }

        function R7() {
            document.getElementById("Radio1").checked = false;
            document.getElementById("Radio2").checked = false;
            document.getElementById("Radio3").checked = false;
            document.getElementById("Radio4").checked = false;
            document.getElementById("Radio5").checked = false;
            document.getElementById("Radio6").checked = false;
            document.getElementById("Radio8").checked = false;
            document.getElementById("Radio9").checked = false;
            document.getElementById("Radio10").checked = false;
        }

        function R8() {
            document.getElementById("Radio1").checked = false;
            document.getElementById("Radio2").checked = false;
            document.getElementById("Radio3").checked = false;
            document.getElementById("Radio4").checked = false;
            document.getElementById("Radio5").checked = false;
            document.getElementById("Radio6").checked = false;
            document.getElementById("Radio7").checked = false;
            document.getElementById("Radio9").checked = false;
            document.getElementById("Radio10").checked = false;
        }

        function R9() {
            document.getElementById("Radio1").checked = false;
            document.getElementById("Radio2").checked = false;
            document.getElementById("Radio3").checked = false;
            document.getElementById("Radio4").checked = false;
            document.getElementById("Radio5").checked = false;
            document.getElementById("Radio6").checked = false;
            document.getElementById("Radio7").checked = false;
            document.getElementById("Radio8").checked = false;
            document.getElementById("Radio10").checked = false;
        }

        function R10() {
            document.getElementById("Radio1").checked = false;
            document.getElementById("Radio2").checked = false;
            document.getElementById("Radio3").checked = false;
            document.getElementById("Radio4").checked = false;
            document.getElementById("Radio5").checked = false;
            document.getElementById("Radio6").checked = false;
            document.getElementById("Radio7").checked = false;
            document.getElementById("Radio8").checked = false;
            document.getElementById("Radio9").checked = false;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style3">
                
                <asp:Image ID="banner" runat="server" CssClass="img_banner" ImageUrl="~/img/bklanche.jpg" Width="100%" Height="100%" BorderColor="Red" BorderWidth="2px" />
                <br />
                <div class="radios">
                    <input id="Radio1" type="radio" onclick="R1()" />
                    <input id="Radio2" type="radio" onclick="R2()" />
                    <input id="Radio3" type="radio" onclick="R3()" />
                    <input id="Radio4" type="radio" onclick="R4()" />
                    <input id="Radio5" type="radio" onclick="R5()" />
                    <input id="Radio6" type="radio" onclick="R6()" />
                    <input id="Radio7" type="radio" onclick="R7()" />
                    <input id="Radio8" type="radio" onclick="R8()" />
                    <input id="Radio9" type="radio" onclick="R9()" />
                    <input id="Radio10" type="radio" onclick="R10()" />
                </div>
                                  
             <%--                   
                <div id="geral">
                    <div id="video">
                        <asp:Label runat="server" CssClass="textovideo" Text="Não tem certeza se deseja assistir um show ou não? Assista e se divirta um pouco..."></asp:Label>
                        <video width="60%"  controls="controls">
                            <source src="../../img/wakeme.mp4" class="video" type="video/mp4" />
                        </video>
                    </div>
                    <div id="textos">
                        <table class="textos">
                            <tr>
                                <td>
                                    <asp:Label runat="server" CssClass="texto1" Font-Bold="true" Text="Funcionamento:"></asp:Label>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" CssClass="texto2" Font-Size="Large" Text="Das 18:00 às 00:00"></asp:Label>
                                    <br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" CssClass="texto2" Font-Size="Large" Text="Todos os dias"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" CssClass="texto2" Font-Size="Large" Text="Rua Augusta, 1100, Consolação, São Paulo - SP"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label runat="server" CssClass="texto2" Font-Italic="true" Font-Size="Large" Text="O lar da comédia em SP!"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div> --%>
            </td>
            <td class="auto-style7"></td>
        </tr>
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style3"></td>
            <td class="auto-style7"></td>
        </tr>
    </table>
</asp:Content>