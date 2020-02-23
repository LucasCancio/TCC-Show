<%@ Page Title="Pagamento" Language="C#" MasterPageFile="~/Modelos/Modelos_Cliente/Padrão.Master" AutoEventWireup="true" CodeBehind="Pagamento.aspx.cs" Inherits="TCC_Oficial.Telas.Cliente.Pagamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1{
            margin-bottom: 9%;
        }
        .auto-style3, .auto-style4 {
            width: 15%;
        }
        #titulo{
            font-size: 200%;
            text-align: center;
        }
        #gpboxEsqueceu1{
            text-align: center;
            background-color: #050000;
        }
        #tbIng{
            width: 100%;
        }
        #dados1{
            text-align: right;
            width: 50%;
            padding-right: 1%;
        }
        #dados2{
            padding-left: 1%;
            text-align: left;
        }
        .lblBoleto:hover{
            color: red;
        }
        .listaCartao_pag{
            font-family: Quicksand;
            font-size: large;
        }
        #divDebito, #divBoleto{
            display: none;
        }
    </style>
    <script>
        function Iniciar() {
            //document.getElementById("divBoleto").style.display = "none";
            //document.getElementById("divCartao").style.display = "none";
        }
        function Credito() {
            document.getElementById("rbBoleto").checked = false;
            document.getElementById("rbDebito").checked = false;
            document.getElementById("divBoleto").style.display = "none";
            document.getElementById("divDebito").style.display = "none";
            document.getElementById("divCredito").style.display = "inline";
        }
        function Boleto() {
            document.getElementById("rbCredito").checked = false;
            document.getElementById("rbDebito").checked = false;
            document.getElementById("divBoleto").style.display = "inline";
            document.getElementById("divCredito").style.display = "none";
            document.getElementById("divDebito").style.display = "none";
        }
        function Debito() {
            document.getElementById("rbBoleto").checked = false;
            document.getElementById("rbCredito").checked = false;
            document.getElementById("divBoleto").style.display = "none";
            document.getElementById("divCredito").style.display = "none";
            document.getElementById("divDebito").style.display = "inline";
        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 id="titulo">Meu Carrinho</h1>
    <table class="auto-style1">
        <tr>
            <td class="auto-style3"></td>
            <td>
                <fieldset id="gpboxEsqueceu1" style="border-color: Red; border-width:2px;">
                    <table id="tbIng">
                        <tr>
                            <td id="dados1">
                                <br />
                                <asp:Label ID="Label1" runat="server" Text="Ingressos Selec.:" Font-Size="Large"></asp:Label>
                                <asp:TextBox ID="txtNumIngressos" Font-Size="Large" Enabled="false" runat="server" Font-Names="Quicksand" Width="60" Font-Bold="true"></asp:TextBox><br /><br />
                                <asp:Label ID="Label4" runat="server" Font-Size="Large" Text="Voucher p/ Desconto: "></asp:Label>
                                <asp:TextBox ID="txtVoucher" runat="server" Font-Size="Large" Font-Names="Quicksand" Font-Bold="true"></asp:TextBox><%--<asp:ImageButton ID="ImageButton1" runat="server" Height="22px" ImageUrl="~/img/icons8_Checked_48px_2.png" />--%><br /><br />
                                <asp:Label ID="Label5" runat="server" Font-Size="Large" Enabled="false" Text="Desconto Total: (%)"></asp:Label>
                                <asp:TextBox ID="TextBox1" runat="server" Font-Size="Large" Font-Names="Quicksand" Width="60" Enabled="false" Font-Bold="true"></asp:TextBox><br /><br />
                                <asp:Label ID="Label3" runat="server" Font-Size="Large" Text="Valor Total: R$ "></asp:Label>
                                <asp:TextBox ID="txtValorTotal" Enabled="false" runat="server" Font-Size="Large" Width="100" Font-Names="Quicksand" Font-Bold="true"></asp:TextBox><br /><br />
                                <asp:Label ID="Label2" runat="server"  Font-Size="Large" Text="Pagamento via:"></asp:Label>
                                <asp:DropDownList ID="DropDownList4" runat="server" CssClass="listaCartao_pag" Visible="true">
                                    <asp:ListItem>Cartão (Crédito)</asp:ListItem>
                                    <asp:ListItem>Cartão (Débito)</asp:ListItem>
                                    <asp:ListItem>Boleto</asp:ListItem>                                    
                                </asp:DropDownList><br /><br />
                            </td>
                            <td id="dados2">
                                <div id="divCredito">
                                    <asp:Label ID="Label11" Visible="true" runat="server" Text="Bandeira:" Font-Size="Large"></asp:Label>
                                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="listaCartao_pag" Visible="true" Font-Size="Large">
                                        <asp:ListItem> </asp:ListItem>
                                        <asp:ListItem>Visa</asp:ListItem>
                                        <asp:ListItem>MasterCard</asp:ListItem>
                                    </asp:DropDownList><br /><br />
                                    <asp:Label ID="lblNumeroCredito" Visible="true" runat="server" Text="Nº Cartão:" Font-Size="Large"></asp:Label>
                                    <asp:TextBox ID="txtNumeroCredito" Visible="true" runat="server" Font-Size="Large" Font-Names="Quicksand" Font-Bold="true"></asp:TextBox><br /><br />
                                    <asp:Label ID="Label6" Visible="true" runat="server" Text="Cód. Segurança:" Font-Size="Large"></asp:Label>
                                    <asp:TextBox ID="TextBox2" Visible="true" runat="server" Font-Size="Large" Font-Names="Quicksand" Width="40" MaxLength="3" Font-Bold="true"></asp:TextBox><br /><br />
                                    <asp:Label ID="lblParcelas" Visible="true" runat="server" Text="Nº de Parcelas:" Font-Size="Large"></asp:Label>
                                    <asp:DropDownList ID="listaCartao" runat="server" CssClass="listaCartao_pag" Visible="true" Font-Size="Large">
                                        <asp:ListItem>1x</asp:ListItem>
                                        <asp:ListItem>2x</asp:ListItem>
                                        <asp:ListItem>3x</asp:ListItem>
                                    </asp:DropDownList><br /><br />
                                    <asp:Label ID="Label8" Visible="true" runat="server" Text="Custo/Mês: R$" Font-Size="Large"></asp:Label>
                                    <asp:TextBox ID="TextBox5" Visible="true" runat="server" Font-Size="Large" Font-Names="Quicksand" Width="150" Enabled="false" Font-Bold="true"></asp:TextBox>
                                    <%--<asp:Label ID="Label9" Visible="true" runat="server" Text="Quantia: R$" Font-Size="Large"></asp:Label>
                                    <asp:TextBox ID="TextBox2" Visible="true" runat="server" Font-Size="Large" Font-Names="Quicksand" Font-Bold="true" Width="150"></asp:TextBox>--%>
                                </div>

                                <div id="divDebito">
                                    <asp:Label ID="Label10" Visible="true" runat="server" Text="Bandeira:" Font-Size="Large"></asp:Label>
                                    <asp:DropDownList ID="DropDownList2" runat="server" CssClass="listaCartao_pag" Visible="true">
                                        <asp:ListItem> </asp:ListItem>
                                        <asp:ListItem>Visa</asp:ListItem>
                                        <asp:ListItem>MasterCard</asp:ListItem>
                                    </asp:DropDownList><br /><br />
                                    <asp:Label ID="Label12" Visible="true" runat="server" Text="Nº Cartão:" Font-Size="Large"></asp:Label>
                                    <asp:TextBox ID="TextBox3" Visible="true" runat="server" Font-Size="Large" Font-Names="Quicksand" Font-Bold="true"></asp:TextBox><br /><br />
                                     <asp:Label ID="Label7" Visible="true" runat="server" Text="Cód. Segurança:" Font-Size="Large"></asp:Label>
                                    <asp:TextBox ID="TextBox4" Visible="true" runat="server" Font-Size="Large" Font-Names="Quicksand" Width="40" MaxLength="3" Font-Bold="true"></asp:TextBox><br /><br />
                                    <asp:Label ID="Label13" Visible="true" runat="server" Text="Nº de Parcelas:" Font-Size="Large"></asp:Label>
                                    <asp:DropDownList ID="DropDownList3" runat="server" CssClass="listaCartao_pag" Visible="true">
                                        <asp:ListItem>1x</asp:ListItem>
                                        <asp:ListItem>2x</asp:ListItem>
                                        <asp:ListItem>3x</asp:ListItem>
                                    </asp:DropDownList><br /><br />                                    
                                    <%--<asp:Label ID="Label14" Visible="true" runat="server" Text="Quantia: R$" Font-Size="Large"></asp:Label>
                                    <asp:TextBox ID="TextBox4" Visible="true" runat="server" Font-Size="Large" Font-Names="Quicksand" Font-Bold="true" Width="150"></asp:TextBox><br />--%>
                                </div>

                                <div id="divBoleto">
                                    <asp:Button ID="Button1" CssClass="btAvancarTela" Font-Bold="true" Font-Names="Quicksand" runat="server" Text="Imprimir Boleto" /><br />
                                </div>
                            </td>
                        </tr>
                    </table>
                    <br />
                    <asp:Button ID="btnAvancarTela" CssClass="btAvancarTela" Font-Bold="true" Font-Names="Quicksand" runat="server" Text="Finalizar Compra" OnClick="btnAvancarTela_Click" /><br />
                </fieldset>
            </td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td></td>
            <td class="auto-style4"></td>
        </tr>
    </table>
    
</asp:Content>
