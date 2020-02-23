<%@ Page Title="Home" Language="C#" MasterPageFile="~/ModeloOn.Master" AutoEventWireup="true" CodeBehind="HomeOn.aspx.cs" Inherits="Boots.ComLogin.HomeOn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/jquery-3.3.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <br />
    <br />
    <br />
    
    <div class="container" style="text-align:center">
        <br />
        <h1>Últimas Novidades</h1>
    </div>

    <div class="container" style="text-align:center;">
      <%--  <div id="carouselExampleIndicators" class="carousel slide my-4" data-ride="carousel">
            
            <div class="carousel-inner" role="listbox" style="text-align:center; border: solid 2px rgb(145,0,0)"">--%>
                <asp:ListView runat="server" ID="lvNovidades" ItemPlaceholderID="itemPlaceHolder1" DataSourceID="SqlDataSource1" OnItemDataBound="lvNovidades_ItemDataBound">
                    <LayoutTemplate>
                        <div id="carouselExampleIndicators" class="carousel slide my-4" data-ride="carousel">
                         <div class="carousel-inner" role="listbox" style="text-align:center; border: solid 2px rgb(145,0,0)"">
                              <asp:PlaceHolder runat="server" ID="itemPlaceHolder1"></asp:PlaceHolder>
                              <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
              <span class="carousel-control-prev-icon" aria-hidden="true"></span>
              <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
              <span class="carousel-control-next-icon" aria-hidden="true"></span>
              <span class="sr-only">Next</span>
            </a>
                         </div>
                            </div>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div class="carousel-item" id="divBanner" runat="server" style="text-align:center">
                    <asp:Image runat="server" ID="imgBanner" CssClass="d-block w-100 h-25 img-fluid" ImageUrl='<%# Eval("URL_IMG") %>' />
                    <%--<img class="d-block w-100 h-100 img-fluid" src="../img/ban1.jpg" alt="Second slide">--%>
                </div>
                    </ItemTemplate>
                </asp:ListView>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TCCSHOWConnectionString %>" SelectCommand="SELECT * FROM TB_BANNER WHERE ATIVO=1 ORDER BY INDEX_BANNER;"></asp:SqlDataSource>
               <%-- <div class="carousel-item active" style="text-align:center">
                    <asp:Image runat="server" CssClass="d-block w-100 h-25 img-fluid" ImageUrl="~/img/BannerProibidoMenor.jpeg" />
              <img class="" src="" alt="First slide">
                </div>
                <div class="carousel-item" style="text-align:center">
                    <asp:Image runat="server" CssClass="d-block w-100 h-25 img-fluid" ImageUrl="../img/ban1.jpg" />
                   <img class="d-block w-100 h-100 img-fluid" src="../img/ban1.jpg" alt="Second slide">
                </div>
                <div class="carousel-item" style="text-align:center">
                    <asp:Image runat="server" CssClass="d-block w-100 h-25 img-fluid" ImageUrl="../img/ban4.jpg" />
              <img class="d-block w-100 h-100 img-fluid" src="../img/ban4.jpg" alt="Third slide">
                </div>
                <div class="carousel-item" style="text-align:center">
                    <asp:Image runat="server" CssClass="d-block w-100 h-25 img-fluid" ImageUrl="~/img/ban3.jpeg" />
                    <%--<img class="d-block w-100 h-100 img-fluid" src="../img/ban4.jpg" alt="Third slide">
                </div>
                <div class="carousel-item" style="text-align:center">
                    <asp:Image runat="server" CssClass="d-block w-100 h-25 img-fluid" ImageUrl="../img/ban2.jpg" />
                    <%--<img class="d-block w-100 h-100 img-fluid" src="../img/ban4.jpg" alt="Third slide">
                </div>
                <div class="carousel-item" style="text-align:center">
                    <asp:Image runat="server" CssClass="d-block w-100 h-25 img-fluid" ImageUrl="~/img/bklanche.jpg" />
                    <%--<img class="d-block w-100 h-100 img-fluid" src="../img/ban4.jpg" alt="Third slide">
                </div>
                <div class="carousel-item" style="text-align:center">
                    <asp:Image runat="server" CssClass="d-block w-100 h-25 img-fluid" ImageUrl="~/img/burger_king1.jpg" />
                    <img class="d-block w-100 h-100 img-fluid" src="../img/ban4.jpg" alt="Third slide">
                </div>
                <div class="carousel-item" style="text-align:center">
                    <asp:Image runat="server" CssClass="d-block w-100 h-25 img-fluid" ImageUrl="~/img/burger_king2.jpg" />
                    <img class="d-block w-100 h-100 img-fluid" src="../img/ban4.jpg" alt="Third slide">
                </div>
                <div class="carousel-item" style="text-align:center">
                    <asp:Image runat="server" CssClass="d-block w-100 h-25 img-fluid" ImageUrl="~/img/burger_king3.jpg" />
                    <img class="d-block w-100 h-100 img-fluid" src="../img/ban4.jpg" alt="Third slide">
                </div>
                <div class="carousel-item" style="text-align:center">
                    <asp:Image runat="server" CssClass="d-block w-100 h-25 img-fluid" ImageUrl="~/img/CH1.jpg" />
                   <img class="d-block w-100 h-100 img-fluid" src="../img/ban4.jpg" alt="Third slide">
                </div>
          <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
              <span class="carousel-control-prev-icon" aria-hidden="true"></span>
              <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
              <span class="carousel-control-next-icon" aria-hidden="true"></span>
              <span class="sr-only">Next</span>
            </a>
            </div>
        </div>
    </div>--%>

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    </div>

  
    </asp:Content>
