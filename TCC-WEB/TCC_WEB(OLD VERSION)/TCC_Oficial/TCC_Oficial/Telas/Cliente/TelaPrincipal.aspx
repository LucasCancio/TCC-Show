<%@ Page Title="Home" Language="C#" MasterPageFile="~/Modelos/Modelos_Cliente/Padrão.Master" AutoEventWireup="true" CodeBehind="TelaPrincipal.aspx.cs" Inherits="TCC_Oficial.Telas.Cliente.Modelo" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 9%;
        }

        .auto-style10, .auto-style7 {
            width: 15%;
        }

        #gpboxEvento1 {
            background-color: #050000;
        }

        .tudo {
            margin-top: 1%;
            margin-bottom: 1.5%;
            width: 100%;
        }

        .tudo2 {
            width: 40%;
        }

        .radios {
            width: 69%;
            margin-top: 2px;
            position: absolute;
        }

        #geral {
            width: 100%;
            background-color: green;
            display: inline-flex;
        }

        #video {
            position: sticky;
            text-align: center;
            border: double 1px red;
            width: 60%;
            background-color: #050000;
            padding: 1%;
        }

        .textovideo {
            font-size: 140%;
            margin-bottom: 0.5%;
        }

        #textos {
            border-right: double 1px red;
            border-top: double 1px red;
            border-bottom: double 1px red;
            width: 40%;
            text-align: center;
            background-color: #050000;
            padding: 1%;
        }

        .textos {
            width: 100%;
            height: 100%;
        }

        .texto1 {
            font-size: 140%;
        }

        .SetaDireita {
            text-align: right;
            width: 5%;
            height: 5%;
            margin-top: 2px;
        }

        /*.LabelMeio {
            padding-left: 42%;
            padding-right: 42%;
            padding-bottom: 2px;
        }*/

        .SetaEsquerda {
            width: 5%;
            height: 5%;
            margin-top: 2px;
        }

        

        .auto-style11 {
            /*font-size: small;
            height: 579px;*/
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style10"></td>
            <td class="auto-style11">

                <asp:Image ID="banner" runat="server" CssClass="img_banner" ImageUrl="~/img/bklanche.jpg" Width="100%" Height="100%" BorderColor="Red" BorderWidth="2px" />
                <br />
                <asp:FileUpload ID="FileImgSave" runat="server" Visible="False" />
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
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
            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style3"></td>
            <td class="auto-style7">
                <asp:Timer ID="timerNovidade" runat="server" Enabled="False" Interval="5000" OnTick="timerNovidade_Tick">
                </asp:Timer>
            </td>
        </tr>
    </table>
</asp:Content>


<%--<div id="botoes">
				   <a href="javascript:void(0);" id="banner_img_1" class="hover" onclick="mudaImg('0');">1</a>
				   <a href="javascript:void(0);" id="banner_img_2" onclick="mudaImg('1');">2</a>
				   <a href="javascript:void(0);" id="banner_img_3" onclick="mudaImg('2');">3</a>
				   <a href="javascript:void(0);" id="banner_img_4" onclick="mudaImg('3');">4</a>
			   </div>--%>