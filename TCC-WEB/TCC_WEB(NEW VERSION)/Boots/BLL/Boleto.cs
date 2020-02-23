using System;
using System.Text;
using System.IO;

namespace dotnetraptors.Brazil.Boleto
{

	/// <summary>
	/// Gera boletos em formato HTML.
	/// <p>Histórico: <br>
	///     - Autor: Reinaldo M. R. Alves (maio de 2005). Foi utilizado as rotinas criadas por Marlon Sergio da Silva
	///     em VB.NET. Basicamente foi feito: <br>
	///     1) Conversão do código para C#; <br>
	///     2) As rotinas originais não se utilizavam de conceitos de OOP;<br>
	///     3) As rotinas originais estavam vinculadas a ASP.NET. Esta implementação possibilita a utilização em 
	///     ASP.NET, para envio de email, e até em aplicações Windows Forms.<br>
	///     4) Alterado o nome de algumas variáveis (que foram convertidas para propriedades), creio que ficou
	///     mais sugestivo. <br>
	///     
	///		ATENÇÃO: Ainda não realizei testes práticos. O que implica imprimir as boletas e verificar se
	///		tudo está OK. Isto deve ser feito individualmente para cada banco.
	///     </p>
	/// </summary>
	public class HTMLBoleto
	{
		public HTMLBoleto()
		{
			MontaInicioArquivo();
		}

		private string _ImagesFolder = @"imgBoleto";
		/// <summary>
		/// Indica em qual pasta se encontra os arquivos de imagem de logotipo
		/// dos bancos.
		/// </summary>
		public string ImagesFolder
		{
			get { return _ImagesFolder; }
			set { _ImagesFolder = value; }
		}

		public void SaveToFile( string lFileName)
		{
			byte[] lBuffer = System.Text.Encoding.Default.GetBytes( ToString());
			FileStream fs = new FileStream( lFileName, FileMode.Create, FileAccess.Write, FileShare.None);
			fs.Write( lBuffer, 0, lBuffer.Length);
			fs.Close();
		}

		/// <summary>
		/// Finaliza a montagem do(s) boleto(s) no formato HTML.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			if( !_Encerrado)
			{
				_Encerrado = true;
				MontaFimArquivo();
			}
			return _Buffer.ToString();
		}

		/// <summary>
		/// Adiciona um novo boleto.
		/// </summary>
		/// <param name="lBoleto">Informe os dados do boleto.</param>
		public void AddBoleto( Boleto lBoleto)
		{
			if( _Encerrado) 
				throw new Exception( "Após ter obtido o(s) boleto(s) montados pelo método ToString não é permitido adicionar novos boletos.");

			string lNossoNumero, lLinhaDigitavel, lCodigoBarras;
			lBoleto.MontaCodigos( out lNossoNumero, out lLinhaDigitavel, out lCodigoBarras);

			lLinhaDigitavel = lLinhaDigitavel.Replace( " ", "&nbsp;&nbsp;");

            string sImgBarra = _ImagesFolder + @"/barra.gif";
            string sImgCorte = _ImagesFolder + @"/corte.gif";
			string Codiodebarras = CodigoBarras25I( lCodigoBarras);

			_Counter++;
			if( _Counter>=2)
				_Buffer.Append("<p class=SaltoDePagina></p>");

			//Comprovante de entrega
			_Buffer.Append("<table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td width=150><img src=\"" + _ImagesFolder + @"\" + lBoleto.BancoLogoTipo + "\"></td>");
			_Buffer.Append("<td vAlign=bottom width=2><IMG src=\"" + sImgBarra + "\" height=22 width=2 border=0 ></td>");
			_Buffer.Append("<td vAlign=bottom align=center width=75><span id=nb1 class=\"nbanco\">" + lBoleto.BancoCodigoCompleto() + "</span></td>");
			_Buffer.Append("<td vAlign=bottom width=2><IMG height=22 src=\"" + sImgBarra + "\" width=2 border=0 ></td>");
			_Buffer.Append("<td class=ld vAlign=bottom align=\"right\">&nbsp;Comprovante de Entrega&nbsp;</td></tr></table>");
			_Buffer.Append("<table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td vAlign=top width=\"100%\">");
			_Buffer.Append("<table borderColor=#000000 cellSpacing=0 cellPadding=0 width=\"100%\" border=1>");
			_Buffer.Append("<TR><TD class=linha vAlign=top>");
			_Buffer.Append("<table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Cedente</td><td class='ct border-left border-dark'>&nbsp;CPF/CNPJ</td></tr>");
			_Buffer.Append("<tr><td class=ld>&nbsp;<span id=Cedente1>" + lBoleto.CedenteNome + "</spam></td><td class='ld border-left border-dark'>&nbsp;<span id=Cedente1>" + lBoleto.CedenteDocumento + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top width=140>");
			_Buffer.Append("<table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct vAlign=top>&nbsp;Agência / Código do Cedente</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center><spam id=CodCedente1>" + lBoleto.AgenciaCedente() + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top width=140><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Nosso Número</td></tr>");
			_Buffer.Append("<tr><TD class=ld align=center><spam id=NossoNumero1>" + lNossoNumero + "</Label></TD></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top width=140 rowSpan=4><TABLE cellSpacing=0 cellPadding=0 align=center border=0>");
			_Buffer.Append("<TR><TD class=ct>&nbsp;(&nbsp; &nbsp;) Mudou - se</TD></TR>");
			_Buffer.Append("<TR><TD class=ct>&nbsp;(&nbsp; &nbsp;) Ausente</TD></TR>");
			_Buffer.Append("<TR><TD class=ct>&nbsp;(&nbsp; &nbsp;) Não existe n° indicado</TD></TR>");
			_Buffer.Append("<TR><TD class=ct>&nbsp;(&nbsp; &nbsp;) Recusado</TD></TR>");
			_Buffer.Append("<TR><TD class=ct>&nbsp;(&nbsp; &nbsp;) Não Procurado</TD></TR>");
			_Buffer.Append("<TR><TD class=ct>&nbsp;(&nbsp; &nbsp;) Endereço Insuficiente</TD></TR>");
			_Buffer.Append("<TR><TD class=ct>&nbsp;(&nbsp; &nbsp;) Desconhecido</TD></TR>");
			_Buffer.Append("<TR><TD class=ct>&nbsp;(&nbsp; &nbsp;) Falecido</TD></TR>");
			_Buffer.Append("<TR><TD class=ct>&nbsp;(&nbsp; &nbsp;) Outros</TD></TR></TABLE></TD></TR>");
			_Buffer.Append("<TR><TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Sacado</td></tr>");
			_Buffer.Append("<tr><td class=ld>&nbsp;<spam id=sacado1 >" + lBoleto.SacadoNome + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top width=140><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<TR><TD class=ct>&nbsp;Vencimento</TD></TR>");
			_Buffer.Append("<TR><TD class=ld align=center><spam id=vencto1>" + lBoleto.DtVencimento.ToString( Boleto.DATEFORMAT) + "</span></TD></TR></table></TD>");
			_Buffer.Append("<TD vAlign=top width=140><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct colSpan=2>&nbsp;Valor do Documento</td></tr>");
			_Buffer.Append("<tr><td class=ld width=30>&nbsp;R$</td><td class=ld align=right><spam id=volordoc1>" + lBoleto.Valor.ToString(Boleto.VALORFORMAT) + "</spam>&nbsp;</td></tr></table></TD></TR>");
			_Buffer.Append("<TR><td class=ld rowSpan=2>&nbsp;Recebi(emos) o bloqueto/título<br>&nbsp;com as características acima </td>");
			_Buffer.Append("<td vAlign=top width=140><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Data de Emissão</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center><spam id=dtaemissao1>" + lBoleto.DtEmissao.ToString(Boleto.DATEFORMAT) + "</spam></td></tr></table></td>");
			_Buffer.Append("<TD vAlign=top width=140><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Assinatura</td></tr>");
			_Buffer.Append("<tr><td class=ld>&nbsp;</td></tr></table></TD></TR>");
			_Buffer.Append("<TR><TD vAlign=top width=140>");
			_Buffer.Append("<table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Data de Entrega</td></tr>");
			_Buffer.Append("<tr><td class=ld>&nbsp;</td></tr></table></TD><TD vAlign=top width=140>");
			_Buffer.Append("<table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Entregador</td></tr>");
			_Buffer.Append("<tr><td class=ld>&nbsp;</td></tr></table></TD></TR></TABLE></td></tr>");
			_Buffer.Append("<tr><td class=cp align=right><spam id=numerodoc1>" + lBoleto.Documento + "</spam></td></tr></table>");
            _Buffer.Append("<br>");
            _Buffer.Append("<div align=center><img src=\"" + sImgCorte + "\"></div>");
            _Buffer.Append("<br>");
            //Recibo do Sacado
            _Buffer.Append("<table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td width=150><img src=\"" + _ImagesFolder + @"\" + lBoleto.BancoLogoTipo + "\"></td>");
			_Buffer.Append("<td vAlign=bottom width=2><IMG src=\"" + sImgBarra + "\" height=22 width=2 border=0 ></td>");
			_Buffer.Append("<td vAlign=bottom align=center width=75 class=\"nbanco\"><spam id=nb2>" + lBoleto.BancoCodigoCompleto() + "</spam></td>");
			_Buffer.Append("<td vAlign=bottom width=2><IMG height=22 src=\"" + sImgBarra + "\" width=2 border=0 ></td>");
			_Buffer.Append("<td class=ld vAlign=bottom align=right>&nbsp;Recibo do Sacado&nbsp;</td></tr></table>");
			_Buffer.Append("<table borderColor=#000000 cellSpacing=0 cellPadding=0 width=\"100%\" border=1>");
			_Buffer.Append("<TR><TD vAlign=top colSpan=5><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Local de Pagamento</td></tr>");
			_Buffer.AppendFormat("<tr><td class=cp>&nbsp;{0}</td></tr></table></TD>", lBoleto.LocalPagamento);
			_Buffer.Append("<TD vAlign=top width=140 bgColor=#cccccc><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Vencimento</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center><spam id=dtavencto2>" + lBoleto.DtVencimento.ToString( Boleto.DATEFORMAT) + "</spam></td></tr></table></TD></TR>");
			_Buffer.Append("<TR><TD vAlign=top colSpan=5><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Cedente</td><td class='ct border-left border-dark'>&nbsp;CPF/CNPJ</td></tr>");
			_Buffer.Append("<tr><td class=ld>&nbsp;<spam id=Cedente2>" + lBoleto.CedenteNome + "</spam></td><td class='ld border-left border-dark'>&nbsp;<spam id=Cedente2>" + lBoleto.CedenteDocumento + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top width=140><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Agência / Código do Cedente</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center><Spam id=CodCedente2 >" + lBoleto.AgenciaCedente() + "</spam></td></tr></table></TD></TR>");
			_Buffer.Append("<TR><TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Data Documento</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center><spam id=dtadocumento2 >" + lBoleto.DtDocumento.ToString( Boleto.DATEFORMAT) + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Número Documento</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center><spam id=numerodocumento2 >" + lBoleto.Documento + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Espécie Doc.</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center><aspam id=especiedocumento2 >" + lBoleto.pEspecieDoc + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Aceite</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center><spam id=aceite2>" + lBoleto.Aceite + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Data Processamento</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center><spam id=dtaprocess2 >" + lBoleto.DtProcessamento.ToString( Boleto.DATEFORMAT) + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top width=140><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Nosso Número</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center><spam id=nossonumero12>" + lNossoNumero + "</spam></td></tr></table></TD></TR>");
			_Buffer.Append("<TR><TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Uso da Empresa</td></tr>");
			_Buffer.Append("<tr><td class=ld>&nbsp;</td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Carteira</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center><spam id=carteira2 >" + lBoleto.Carteira + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Espécie</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center><spam id=especie2>" + lBoleto.Especie + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Quantidade</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center><spam id=quantidade2>" + lBoleto.Quantidade + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Valor</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center><spam id=valor2 >" + lBoleto.Valor.ToString(Boleto.VALORFORMAT) + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top width=140 bgColor=#cccccc><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct colSpan=2>&nbsp;(=) Valor do Documento</td></tr>");
			_Buffer.Append("<tr><td class=ld width=30>&nbsp;R$</td><td class=ld align=right><spam id=valordocumento2 >" + lBoleto.Valor.ToString(Boleto.VALORFORMAT) + "</spam>&nbsp;</td></tr></table></TD></TR>");
			_Buffer.Append("<TR><TD vAlign=top colSpan=5 rowSpan=5><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Instruções</td></tr>");
			_Buffer.Append("<tr><td class=ld>&nbsp;<spam id=Instrucao12 >" + lBoleto.Instrucao1 + "</spam></td></tr>");
			_Buffer.Append("<tr><td class=ld>&nbsp;<spam id=instrucao22 >" + lBoleto.Instrucao2 + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top width=140><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;(-) Desconto / Abatimento</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center>&nbsp;</td></tr></table></TD></TR>");
			_Buffer.Append("<TR><TD vAlign=top width=140><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;(-) Outras Deduções</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center>&nbsp;</td></tr></table></TD></TR>");
			_Buffer.Append("<TR><TD vAlign=top width=140><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;(+) Mora / Multa</td></tr><tr>");
			_Buffer.Append("<td class=ld align=center>&nbsp;</td></tr></table></TD></TR><TR>");
			_Buffer.Append("<TD vAlign=top width=140><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;(+) Outros Acréscimos</td></tr><tr>");
			_Buffer.Append("<td class=ld align=center>&nbsp;</td></tr></table></TD></TR>");
			_Buffer.Append("<TR><TD vAlign=top width=140 bgColor=#cccccc>");
			_Buffer.Append("<table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;(=) Valor Cobrado</td></tr><tr><td class=ld align=center>&nbsp;</td></tr></table></TD></TR><TR>");
			_Buffer.Append("<TD vAlign=top colSpan=6><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr>");
			_Buffer.Append("<td class=ct width=50>&nbsp;Sacado</td><td class=ld><spam id=Sacado2>" + lBoleto.SacadoNome + "</spam>&nbsp;</td>");
			_Buffer.Append("<td class=ld width=\"35%\"><spam id=CPFCNPJSacado2  >" + lBoleto.SacadoCPF_CNPJ + "</spam>&nbsp;</td></tr><tr>");
			_Buffer.Append("<td class=ct></td><td class=ld><spam id=EnderecoSacado2  >" + SacadoEnderecoLinha1( lBoleto) + "</spam></td>");
			_Buffer.Append("<td class=ld><spam id=nossonumero22>" + lNossoNumero + "</spam></td></tr><tr>");
			_Buffer.Append("<td class=ct></td><td class=ld><spam id=Cidate2>" + SacadoEnderecoLinha2(lBoleto) + "</spam></td><td class=ld></td></tr>");
			_Buffer.Append("<TR><TD class=ct vAlign=top colSpan=3>&nbsp;Sacador / Avalista</TD></TR></table></TD></TR></table>");
			_Buffer.Append("<table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr><td class=ct>&nbsp;Recebi através do cheque n°");
			_Buffer.Append("<BR>&nbsp;do banco:<BR>&nbsp;Esta quitação só terá validade após pagamento do cheque pelo Banco sacado. </td>");
			_Buffer.Append("<td class=ct vAlign=top align=center width=150>Autenticação Mecânica</td></tr></table>");
            _Buffer.Append("<br>");
            _Buffer.Append("<div align=center><img src=" + sImgCorte + "></div>");
            _Buffer.Append("<br>");
            //Parte do Banco
            _Buffer.Append("<table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr>");
			_Buffer.Append("<td width=150><img src=" + _ImagesFolder + @"\" + lBoleto.BancoLogoTipo + "></td>");
			_Buffer.Append("<td vAlign=bottom width=2><IMG height=22 src=" + sImgBarra + " width=2 border=0 ></td>");
			_Buffer.Append("<td vAlign=bottom align=center width=75 class=\"nbanco\"><spam id=nb3>" + lBoleto.BancoCodigoCompleto() + "</spam>&nbsp;</td>");
			_Buffer.Append("<td vAlign=bottom width=1><IMG height=22 src=" + sImgBarra + " width=2 border=0 ></td>");
			_Buffer.Append("<td class=lLinhaDigitavel vAlign=bottom align=right><spam id=numerograde  >" + lLinhaDigitavel + "</spam></td></tr></table>");
			_Buffer.Append("<table borderColor=#000000 cellSpacing=0 cellPadding=0 width=\"100%\" border=1>");
			_Buffer.Append("<TR><TD vAlign=top colSpan=5><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Local de Pagamento</td></tr>");
			_Buffer.AppendFormat( "<tr><td class=ld>&nbsp;{0}</td></tr></table></TD><TD vAlign=top width=140 bgColor=#cccccc><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>", lBoleto.LocalPagamento);
			_Buffer.Append("<tr><td class=ct>&nbsp;Vencimento</td></tr><tr><td class=ld align=center>&nbsp;<spam id=dtavencto3>" + lBoleto.DtVencimento.ToString( Boleto.DATEFORMAT) + "</spam>");
			_Buffer.Append("</td></tr></table></TD></TR><TR><TD vAlign=top colSpan=5>");
			_Buffer.Append("<table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr><td class=ct>&nbsp;Cedente</td><td class='ct border-left border-dark'>&nbsp;CPF/CNPJ</td></tr><tr>");
			_Buffer.Append("<td class=ld>&nbsp;<spam id=cedente3>" + lBoleto.CedenteNome + "</spam></td><td class='ld border-left border-dark'>&nbsp;<spam id=cedente3>" + lBoleto.CedenteDocumento + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top width=140><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Agência / Código do Cedente</td></tr><tr>");
			_Buffer.Append("<td class=ld align=center>&nbsp;<aps:label id=codigocedente3>" + lBoleto.AgenciaCedente() + "</spam></td></tr></table></TD></TR>");
			_Buffer.Append("<TR><TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Data Documento</td></tr><tr><td class=ld align=center>&nbsp;");
			_Buffer.Append("<spam id=Dtadocumento3>" + lBoleto.DtDocumento.ToString( Boleto.DATEFORMAT) + "</spam></td></tr></table></TD><TD vAlign=top>");
			_Buffer.Append("<table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr><td class=ct>&nbsp;Número Documento</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center>&nbsp;<spam id=numerodocumento3>" + lBoleto.Documento + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr><td class=ct>&nbsp;Espécie Doc.</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center>&nbsp;<spam id=especiedocumento3>" + lBoleto.pEspecieDoc + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr><td class=ct>&nbsp;Aceite</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center CssClass=\"ld\">&nbsp;<spam id=aceite3>" + lBoleto.Aceite + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr><td class=ct>&nbsp;Data Processamento</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center>&nbsp;<spam id=dtaprocess3>" + lBoleto.DtProcessamento.ToString( Boleto.DATEFORMAT) + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top width=140><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr>");
			_Buffer.Append("<td class=ct>&nbsp;Nosso Número</td></tr><tr>");
			_Buffer.Append("<td class=ld align=center>&nbsp;<spam id=nossonumero13>" + lNossoNumero + "</spam></td></tr></table></TD></TR>");
			_Buffer.Append("<TR><TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Uso da Empresa</td></tr><tr><td class=ld align=center>&nbsp;</td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr>");
			_Buffer.Append("<td class=ct>&nbsp;Carteira</td></tr><tr><td class=ld align=center>&nbsp;<spam id=carteira3>" + lBoleto.Carteira + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr>");
			_Buffer.Append("<td class=ct>&nbsp;Espécie</td></tr><tr><td class=ld align=center>&nbsp;<spam id=especie3>" + lBoleto.Especie + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr><td class=ct>&nbsp;Quantidade</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center>&nbsp;<spam id=quantidade3>" + lBoleto.Quantidade + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr><td class=ct>&nbsp;Valor</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center>&nbsp;<spam id=valor3>" + lBoleto.Valor.ToString(Boleto.VALORFORMAT) + "</spam></td></tr></table></TD>");
			_Buffer.Append("<TD vAlign=top width=140 bgColor=#cccccc><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr>");
			_Buffer.Append("<td class=ct>&nbsp;(=) Valor do Documento</td></tr><tr><td class=ld align=center>&nbsp;<spam id=valordocumento3>" + lBoleto.Valor.ToString(Boleto.VALORFORMAT) + "</spam></td></tr></table></TD></TR>");
			_Buffer.Append("<TR><td vAlign=top colSpan=5 rowSpan=5><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0>");
			_Buffer.Append("<tr><td class=ct>&nbsp;Instruções</td></tr><tr><td class=ld>&nbsp;<spam id=instrucao13>" + lBoleto.Instrucao1 + "</spam></td></tr>");
			_Buffer.Append("<tr><td class=ld>&nbsp;<spam id=instrucao23  >" + lBoleto.Instrucao2 + "</spam></td></tr></table></td>");
			_Buffer.Append("<TD vAlign=top width=140><table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr><td class=ct>&nbsp;(-) Desconto / ");
			_Buffer.Append("Abatimento</td></tr><tr><td class=ld align=center>&nbsp;</td></tr></table></TD></TR><TR><TD vAlign=top width=140>");
			_Buffer.Append("<table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr><td class=ct>&nbsp;(-) Outras Deduções</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center>&nbsp;</td></tr></table></TD></TR><TR><TD vAlign=top width=140>");
			_Buffer.Append("<table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr><td class=ct>&nbsp;(+) Mora / Multa</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center>&nbsp;</td></tr></table></TD></TR><TR><TD vAlign=top width=140>");
			_Buffer.Append("<table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr><td class=ct>&nbsp;(+) Outros Acréscimos</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center>&nbsp;</td></tr></table></TD></TR><TR><TD vAlign=top width=140 bgColor=#cccccc>");
			_Buffer.Append("<table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr><td class=ct>&nbsp;(=) Valor Cobrado</td></tr>");
			_Buffer.Append("<tr><td class=ld align=center>&nbsp;</td></tr></table></TD></TR><TR><TD vAlign=top colSpan=6>");
			_Buffer.Append("<table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr><td class=ct width=50>&nbsp;Sacado</td>");
			_Buffer.Append("<td class=ld><spam id=sacado3>" + lBoleto.SacadoNome + "</spam></td>");
			_Buffer.Append("<td class=ld width=\"35%\"><spam id=CPFCNPJSacado3  >" + lBoleto.SacadoCPF_CNPJ + "</spam></td></tr>");
			_Buffer.Append("<tr><td class=ct>&nbsp;</td><td class=ld><spam id=EnderecoSacado3  >" + SacadoEnderecoLinha1( lBoleto) + "</spam></td>");
			_Buffer.Append("<td class=ld><spam id=nossonumero23  >" + lNossoNumero + "</spam></td></tr><tr>");
			_Buffer.Append("<td class=ct>&nbsp;</td><td class=ld><spam id=cidade3  >" + SacadoEnderecoLinha2( lBoleto) + "</spam></td>");
			_Buffer.Append("<td class=ld></td></tr><tr><td class=ct colSpan=3>&nbsp;Sacador / Avalista</td></tr></table></TD></TR></table>");
			_Buffer.Append("<table cellSpacing=0 cellPadding=0 width=\"100%\" border=0><tr><td class=ct>&nbsp;</td>");
			_Buffer.Append("<td class=ct vAlign=top align=center width=150>&nbsp;Autenticação Mecânica</td></tr><tr>");
			_Buffer.Append("<td><BR><spam id=CodBarras>" + Codiodebarras + "</spam></td>");
			_Buffer.Append("<td class=cp vAlign=bottom align=right>&nbsp;Ficha de Compensação&nbsp;</td></tr></table>");
            _Buffer.Append("<br>");
            _Buffer.Append("<div align=center><img src=" + sImgCorte + "></div>");
            _Buffer.Append("<br>");
        }

		/// <summary>
		/// Monta o início do arquivo HTML. Exemplo: abertura da tag HTML e BODY.
		/// </summary>
		private void MontaInicioArquivo()
		{
			_Buffer.Append("<HTML>");
			_Buffer.Append("<HEAD>");
			_Buffer.Append("<title>WebForm1</title>");
			_Buffer.Append("<style type=text/css>.ti { FONT: 9px arial, helvetica, sans-serif }");
			_Buffer.Append(".ct { FONT: 9px arial narrow; COLOR: #000000 }");
			_Buffer.Append(".cn { FONT: 9px arial; COLOR: #000000 }");
			_Buffer.Append(".cp { FONT: bold 11px arial; COLOR: #000000 }");
			_Buffer.Append(".ld { FONT: bold 11px arial; COLOR: #000000 }");
			_Buffer.Append(".bc { FONT: bold 18px arial; COLOR: #000000 }");
			_Buffer.Append(".lLinhaDigitavel { FONT: bold 15px arial; COLOR: #000000 }");
			_Buffer.Append(".SaltoDePagina { PAGE-BREAK-AFTER:always }");
			_Buffer.Append(".nbanco { FONT: bold 25px arial }");
			_Buffer.Append("</style>");
			_Buffer.Append("</HEAD>");
			_Buffer.Append("<body>");
		}

		/// <summary>
		/// Monta o fim do arquivo HTML. Exemplo: fechamento da tag HTML e BODY.
		/// </summary>
		private void MontaFimArquivo()
		{
			_Buffer.Append("</body>");
			_Buffer.Append("</html>");
		}	

		protected string SacadoEnderecoLinha1( Boleto lBoleto)
		{
			return lBoleto.SacadoEndereco + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + lBoleto.SacadoBairro;
		}

		protected string SacadoEnderecoLinha2( Boleto lBoleto)
		{
			return lBoleto.SacadoCEP + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + lBoleto.SacadoCidade + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + lBoleto.SacadoUF;
		}

		/// <summary>
		/// Monta o código de barras.
		/// </summary>
		/// <param name="Valor"></param>
		/// <returns></returns>
		private string CodigoBarras25I( string Valor)
		{
			int f, f1, f2, i;
			string s;
			string texto;
			int fino = 1;
			int largo = 3;
			int altura = 50;
			string[] BarCodes= new string[100];
			StringBuilder Codbarras = new System.Text.StringBuilder();

			BarCodes[0] = "00110";
			BarCodes[1] = "10001";
			BarCodes[2] = "01001";
			BarCodes[3] = "11000";
			BarCodes[4] = "00101";
			BarCodes[5] = "10100";
			BarCodes[6] = "01100";
			BarCodes[7] = "00011";
			BarCodes[8] = "10010";
			BarCodes[9] = "01010";
			for( f1=9; f1>=0; f1--)
				for( f2=9; f2>=0; f2--)
				{
					f = f1 * 10 + f2;
					texto = "";
					for( i=0; i<=4; i++)
						texto += BarCodes[f1].Substring( i, 1) + BarCodes[f2].Substring( i, 1);
					BarCodes[f] = texto;
				}

			texto = Valor;
			if( (texto.Length % 2)!=0)
				texto = "0" + texto;

			//draw da guarda inicial
			Codbarras.Append("<img src=\"" + _ImagesFolder + "/p.gif\" width=\"" + fino.ToString() + "\" height=\"" + altura.ToString() + "\" border=0>");
			Codbarras.Append("<img src=\"" + _ImagesFolder + "/b.gif\" width=\"" + fino.ToString() + "\" height=\"" + altura.ToString() + "\" border=0>");
			Codbarras.Append("<img src=\"" + _ImagesFolder + "/p.gif\" width=\"" + fino.ToString() + "\" height=\"" + altura.ToString() + "\" border=0>");
			Codbarras.Append("<img src=\"" + _ImagesFolder + "/b.gif\" width=\"" + fino.ToString() + "\" height=\"" + altura.ToString() + "\" border=0>");

			// Draw dos dados
			while( texto.Length>0)
			{
				i = Convert.ToInt32( texto.Substring(0, 2));
				texto = texto.Remove( 0, 2);

				s = BarCodes[i];

				for( i=0; i<=9; i+=2)
				{
					if( s[i]=='0') f1 = fino;
					else f1 = largo;

					Codbarras.Append( "<img src=\"" + _ImagesFolder + "/p.gif\" width=\"" + f1.ToString() + "\" height=\"" + altura.ToString() + "\" border=0>");

					if( s[ i+1]=='0') f2 = fino;
					else f2 = largo;

					Codbarras.Append( "<img src=\"" + _ImagesFolder + "/b.gif\" width=\"" + f2.ToString() + "\" height=\"" + altura.ToString() + "\" border=0>");
				}
			}

			// draw da guarda final
			Codbarras.Append("<img src=\"" + _ImagesFolder + "/p.gif\" width=\"" + largo.ToString() + "\" height=\"" + altura.ToString() + "\" border=0>");
			Codbarras.Append("<img src=\"" + _ImagesFolder + "/b.gif\" width=\"" + fino.ToString() + "\" height=\"" + altura.ToString() + "\" border=0>");
			Codbarras.Append("<img src=\"" + _ImagesFolder + "/p.gif\" width=\"" + fino.ToString() + "\" height=\"" + altura.ToString() + "\" border=0>");

			return Codbarras.ToString();
		}

		private StringBuilder _Buffer = new StringBuilder();
		private bool _Encerrado = false;
		private int _Counter = 0;
	}


	/// <summary>
	/// Classe abstrata representando um boleto. 
	/// </summary>
	public abstract class Boleto
	{
		public Boleto()
		{
		}

		/// <summary>
		/// Utilizando os valores informados nas propriedes monta os valores de nosso
		/// número, linha digitável e código de barras.
		/// </summary>
		/// <param name="lNossoNumero">Retorna o nosso número.</param>
		/// <param name="lLinhaDigitavel">Retorna a linha digitável.</param>
		/// <param name="lCodigoBarras">Retorna o código de barras.</param>
		public abstract void MontaCodigos( out string lNossoNumero, out string lLinhaDigitavel, out string lCodigoBarras);

		protected string _BancoLogoTipo;
		/// <summary>
		/// Nome do arquivo com o logotipo do banco.
		/// </summary>
		public string BancoLogoTipo
		{
			get { return _BancoLogoTipo; }
		}

		protected int _BancoCodigo;
		/// <summary>
		/// Número do banco na câmara de compensação Ex: Banco Brasil = 001
		/// </summary>
		public int BancoCodigo
		{
			get { return _BancoCodigo; }
		}

		protected char _BancoCodigoDV;
		/// <summary>
		/// Dígito verificador do número do banco na câmara de compensação
		/// </summary>
		public char BancoCodigoDV
		{
			get { return _BancoCodigoDV; }
		}

		/// <summary>
		/// Monta o código do banco contendo dígito.
		/// </summary>
		public string BancoCodigoCompleto()
		{
			return _BancoCodigo.ToString( "000") + "-" + _BancoCodigoDV; 
		}

		/// <summary>
		/// Formata o código do banco com três dígitos.
		/// </summary>
		public string BancoCodigoFormatado()
		{
			return _BancoCodigo.ToString( "000");
		}

		protected int _Contrato;
		/// <summary>
		/// Sequencial de cobrança do boleto usado para gerar o "nosso número"
		/// </summary>
		public int Contrato
		{
			get { return _Contrato; }
			set { _Contrato = value; }
		}
		
		protected int _Sequencial;
		/// <summary>
		/// Número sequencial utilizado para montar o nosso número. Cada boleta deve receber um valor
		/// único neste campo.
		/// </summary>
		public int Sequencial
		{
			get { return _Sequencial; }
			set { _Sequencial = value; }
		}

		protected string _CedenteNome;
		/// <summary>
		/// Nome do cedente
		/// </summary>
		public string CedenteNome
		{
			get { return _CedenteNome; }
			set { _CedenteNome = value; }
		}

        protected string _CedenteDocumento;
        /// <summary>
        /// Nome do cedente
        /// </summary>
        public string CedenteDocumento
        {
            get { return _CedenteDocumento; }
            set { _CedenteDocumento = value; }
        }

        protected string _CedenteAgencia;
		/// <summary>
		/// Agência do cedente sem DV
		/// </summary>
		public string CedenteAgencia
		{
			get { return _CedenteAgencia; }
			set { _CedenteAgencia = value; }
		}

		/// <summary>
		/// Monta a conta completa do cliente contendo Agência/Conta-DV.
		/// </summary>
		public virtual string AgenciaCedente()
		{
			return _CedenteAgencia + "/" + _CedenteConta + "-" + _CedenteContaDV;
		}

		protected string _CedenteConta;
		/// <summary>
		/// Conta corrente do cedente sem DV
		/// </summary>
		public string CedenteConta
		{
			get { return _CedenteConta; }
			set { _CedenteConta = value; }
		}
						 
		protected string _CedenteContaDV;
		/// <summary>
		/// DV da conta corrente do cedente
		/// </summary>
		public string CedenteContaDV
		{
			get { return _CedenteContaDV; }
			set { _CedenteContaDV = value; }
		}

		protected string _SacadoNome;
		/// <summary>
		/// Nome do sacado
		/// </summary>
		public string SacadoNome
		{
			get { return _SacadoNome; }
			set { _SacadoNome = value; }
		}

		protected string _LocalPagamento = "ATÉ O VENCIMENTO PAGÁVEL EM QUALQUER BANCO";
		public string LocalPagamento
		{
			get { return _LocalPagamento; }
			set { _LocalPagamento = value; }
		}

		protected DateTime _DtVencimento;
		/// <summary>
		/// Data de vencimento do título
		/// </summary>
		public DateTime DtVencimento
		{
			get { return _DtVencimento; }
			set { _DtVencimento = value; }
		}

		protected float _Valor;
		/// <summary>
		/// Valor do título
		/// </summary>
		public float Valor
		{
			get { return _Valor; }
			set { _Valor = value; }
		}

		protected DateTime _DtEmissao;
		/// <summary>
		/// Data de emissão do título
		/// </summary>
		public DateTime DtEmissao
		{
			get { return _DtEmissao; }
			set { _DtEmissao = value; }
		}
					  
		protected string _Documento;
		/// <summary>
		/// Número do título
		/// </summary>
		public string Documento
		{
			get { return _Documento; }
			set { _Documento = value; }
		}
			
		protected DateTime _DtDocumento;
		/// <summary>
		/// Data do título
		/// </summary>
		public DateTime DtDocumento
		{
			get { return _DtDocumento; }
			set { _DtDocumento = value; }
		}
			
		protected bool _Aceite;
		/// <summary>
		/// Aceite
		/// </summary>
		public bool Aceite
		{
			get { return _Aceite; }
			set { _Aceite = value; }
		}
					  
		protected string _SequNossNume;
		/// <summary>
		/// Sequencial lNossoNumero obs: Esse sequencial quem fornece é o Itaú
		/// </summary>
		public string SequNossNume
		{
			get { return _SequNossNume; }
			set { _SequNossNume = value; }
		}

		protected DateTime _DtProcessamento;
		/// <summary>
		/// Data de processamento do título
		/// </summary>
		public DateTime DtProcessamento
		{
			get { return _DtProcessamento; }
			set { _DtProcessamento = value; }
		}

		protected int _Carteira;
		/// <summary>
		/// Carteira
		/// </summary>
		public int Carteira
		{
			get { return _Carteira; }
			set { _Carteira = value; }
		}

		protected int _Quantidade = 1;
		/// <summary>
		/// Quantidade
		/// </summary>
		public int Quantidade
		{
			get { return _Quantidade; }
			set { _Quantidade = value; }
		}

		protected string _Instrucao1;
		/// <summary>
		/// Primeira linha da instrução
		/// </summary>
		public string Instrucao1
		{
			get { return _Instrucao1; }
			set { _Instrucao1 = value; }
		}

		protected string _Instrucao2;
		/// <summary>
		/// Segunda linha da instrução
		/// </summary>
		public string Instrucao2
		{
			get { return _Instrucao2; }
			set { _Instrucao2 = value; }
		}
		
		protected string _SacadoCPF_CNPJ;
		/// <summary>
		/// CPF ou CNPJ do sacado
		/// </summary>
		public string SacadoCPF_CNPJ
		{
			get { return _SacadoCPF_CNPJ; }
			set { _SacadoCPF_CNPJ = value; }
		}

		protected string _SacadoEndereco;
		/// <summary>
		/// Endereço do sacado
		/// </summary>
		public string SacadoEndereco
		{
			get { return _SacadoEndereco; }
			set { _SacadoEndereco = value; }
		}
						   
		protected string _SacadoBairro;
		/// <summary>
		/// Bairro do sacado
		/// </summary>
		public string SacadoBairro
		{
			get { return _SacadoBairro; }
			set { _SacadoBairro = value; }
		}

		protected string _SacadoCidade;
		/// <summary>
		/// Cidade do sacado
		/// </summary>
		public string SacadoCidade
		{
			get { return _SacadoCidade; }
			set { _SacadoCidade = value; }
		}

		protected string _SacadoUF;
		/// <summary>
		/// Estado do sacado
		/// </summary>
		public string SacadoUF
		{
			get { return _SacadoUF; }
			set { _SacadoUF = value; }
		}

		protected string _SacadoCEP;
		/// <summary>
		/// CEP do sacado
		/// </summary>
		public string SacadoCEP
		{
			get { return _SacadoCEP; }
			set { _SacadoCEP = value; }
		}

		protected string _Especie = "R$";
		/// <summary>
		/// Espécie
		/// </summary>
		public string Especie
		{
			get { return _Especie; }
			set { _Especie = value; }
		}
			
		protected string _pEspecieDoc = "DP";
		public string pEspecieDoc
		{
			get { return _pEspecieDoc; }
			set { _pEspecieDoc = value; }
		}

		/// <summary>
		/// Instancia um boleto de acordo com o banco requisitado.
		/// </summary>
		/// <param name="lBancoCodigo">Especifica o código do banco desejado. Gera uma exceção se não existe
		/// implementação para o banco informado.</param>
		/// <returns>Retorna uma instância </returns>
		public static Boleto CreateBoleto( int lBancoCodigo)
		{
			Boleto lResult;
			switch( lBancoCodigo)
			{
				case( 1):
					lResult = new BoletoBrasil();
					break;
				case( 104):
					lResult = new BoletoCEF();
					break;
				case( 237): 
					lResult = new BoletoBradesco();
					break;
				case( 341):
					lResult = new BoletoItau();
					break;
				case( 399):
					lResult = new BoletoHSBC();
					break;
				default:
					throw new Exception( "Banco desconhecido.");
			}
			return lResult;
		}

		protected string Left( string lValue, int lLength)
		{
			if( lValue.Length>lLength) return lValue.Substring( 0, lLength);
			else return lValue;
		}

		protected string FatorVencimento( DateTime lDtVencimento)
		{
			string sFatorVencto;
			TimeSpan lTimeSpan = _DtVencimento.Subtract( new DateTime( 1997, 10, 7));
			sFatorVencto = lTimeSpan.Days.ToString();
			sFatorVencto = sFatorVencto.PadLeft(4, '0');
			if( sFatorVencto.StartsWith( "0")) return "0000";
			else return sFatorVencto;
		}

		protected string Mod_dig07( string cVariavel)
		{
			int nSoma = 0, nMult = 2, nIndice;

			for( nIndice=cVariavel.Length-1; nIndice>=0; nIndice--)
			{
				nSoma += (Convert.ToByte(cVariavel[ nIndice]) - 48) * nMult;
				if( nMult==7) nMult = 2;
				else nMult++;
			}
			
			nSoma = nSoma % 11;
			if( nSoma>1) nSoma = 11 - nSoma;
			
			return nSoma.ToString();
		}

		protected string Mod_dig10( string cVariavel)
		{
			int nSoma = 0, nMult = 2, nIndice, nProd;

			for( nIndice=cVariavel.Length-1; nIndice>=0; nIndice--)
			{
				nProd = (Convert.ToByte(cVariavel[ nIndice]) - 48) * nMult;

				if( nProd>9) nSoma += nProd - 9;
				else nSoma += nProd;

				if( nMult==2) nMult = 1;
				else nMult = 2;
			}

			nSoma = nSoma % 10;
			if( nSoma>0) nSoma = 10 - nSoma;
			return nSoma.ToString();
		}

		protected string Mod_dig11( string cVariavel)
		{
			string lRetorno = "0";
			int nSoma = 0, nMult = 2, nIndice;

			for( nIndice=cVariavel.Length-1; nIndice>=0; nIndice--)
			{
				nSoma += (Convert.ToByte(cVariavel[ nIndice]) - 48) * nMult;
				if( nMult==9) nMult = 2;
				else nMult++;
			}

			nSoma = nSoma * 10;
			nSoma = nSoma % 11;
			if((nSoma>9) || (nSoma<2)) lRetorno = "1";
			else lRetorno = nSoma.ToString(); 

			return lRetorno;
		}

		public const string DATEFORMAT = "dd/MM/yyyy";
		public const string VALORFORMAT = "#,0.00";
	}

	public class BoletoBradesco: Boleto
	{
		public BoletoBradesco()
		{
			_BancoCodigo = 237;
			_BancoCodigoDV = '2';
			_BancoLogoTipo = @"BradescoLogo.gif";
		}

		/// <summary>
		/// Utilizando os valores informados nas propriedes monta os valores de nosso
		/// número, linha digitável e código de barras.
		/// </summary>
		/// <param name="lNossoNumero">Retorna o nosso número.</param>
		/// <param name="lLinhaDigitavel">Retorna a linha digitável.</param>
		/// <param name="lCodigoBarras">Retorna o código de barras.</param>
		public override void MontaCodigos( out string lNossoNumero, out string lLinhaDigitavel, out string lCodigoBarras)
		{
			string sCampo1, sCampo2, sCampo3;
			string sCampoLivre, sValor, sbarra;

			sValor = Convert.ToInt32( _Valor*100).ToString();
			
			//**************************************************************************************
			//Código de Barras
			//**************************************************************************************
			lNossoNumero = _Contrato.ToString( "000000") + _Sequencial.ToString().PadLeft(5, '0');
			lNossoNumero += Mod_dig11(lNossoNumero);

			sValor = sValor.PadLeft(10, '0');
			sValor = FatorVencimento( _DtVencimento) + sValor;

			sCampoLivre = Left( _CedenteAgencia, 4).PadLeft(4, '0') + _Carteira.ToString( "00").PadLeft(2, '0') + 
				Left(lNossoNumero, 11).PadLeft(11, '0') + Left( _CedenteConta, 7).PadLeft(7, '0') + 
				"0";
			sbarra = BancoCodigoFormatado() + "9" + sValor + sCampoLivre;
			lCodigoBarras = BancoCodigoFormatado() + "9" + Mod_dig11(sbarra) + sValor + sCampoLivre;
			//**************************************************************************************

			//**************************************************************************************
			//Linha digitável
			//**************************************************************************************
			sCampo1 = BancoCodigoFormatado() + "9" + Left(sCampoLivre, 5);
			sCampo1 = sCampo1 + Mod_dig10(sCampo1);

			sCampo2 = sCampoLivre.Substring( 5, 10);
			sCampo2 = sCampo2 + Mod_dig10(sCampo2);

			sCampo3 = sCampoLivre.Substring( 15, 10);
			sCampo3 = sCampo3 + Mod_dig10(sCampo3);

			lLinhaDigitavel = Left(sCampo1, 5) + "." + sCampo1.Substring( 5, 5) + "  " + 
				Left(sCampo2, 5) + "." + sCampo2.Substring( 5, 6) + "  " + 
				Left(sCampo3, 5) + "." + sCampo3.Substring( 5, 6) + "  " + 
				Mod_dig11(sbarra) + "  " + sValor;
			//**************************************************************************************
                
			lNossoNumero = lNossoNumero.Substring(0, lNossoNumero.Length - 1) + "-" + lNossoNumero.Substring( lNossoNumero.Length - 1, 1);
		}
	}

	public class BoletoItau: Boleto
	{
		public BoletoItau()
		{
			_BancoCodigo = 341;
			_BancoCodigoDV = '7';
			_BancoLogoTipo = @"ItauLogo.gif";
		}

		/// <summary>
		/// Utilizando os valores informados nas propriedes monta os valores de nosso
		/// número, linha digitável e código de barras.
		/// </summary>
		/// <param name="lNossoNumero">Retorna o nosso número.</param>
		/// <param name="lLinhaDigitavel">Retorna a linha digitável.</param>
		/// <param name="lCodigoBarras">Retorna o código de barras.</param>
		public override void MontaCodigos( out string lNossoNumero, out string lLinhaDigitavel, out string lCodigoBarras)
		{
			string sCampo1, sCampo2, sCampo3, sCampo4, sCampo5;
			string sCampoLivre, sValor, sbarra;

			sValor = Convert.ToInt32( _Valor*100).ToString();

			//**************************************************************************************
			//Código de Barras
			//**************************************************************************************
			sValor = sValor.PadLeft(10, '0') + FatorVencimento(_DtVencimento).PadLeft(4, '0');

			lNossoNumero = _SequNossNume.PadLeft(7, '0');
			lNossoNumero += Mod_dig11( lNossoNumero);

			sCampoLivre = _Carteira.ToString( "000") + lNossoNumero;
			sCampoLivre += Mod_dig10( _CedenteAgencia + _CedenteConta + _Carteira + lNossoNumero);
			sCampoLivre += _CedenteAgencia.PadLeft(4, '0') + _CedenteConta.PadLeft(5, '0');
			sCampoLivre += Mod_dig10( _CedenteAgencia + _CedenteConta) + "000";

			sbarra = BancoCodigoFormatado() + "9" + sValor + sCampoLivre;
            
			lCodigoBarras = BancoCodigoFormatado() + "9" + Mod_dig11(sbarra) + sValor + sCampoLivre;
			//**************************************************************************************

			//**************************************************************************************
			//Linha Digitável
			//**************************************************************************************
			sCampo1 = BancoCodigoFormatado() + "9" + _Carteira.ToString( "000") + lNossoNumero.Substring(0, 2);
			sCampo1 += Mod_dig10(sCampo1);

			sCampo2 = lNossoNumero.Substring(2, 6) + Mod_dig10(_CedenteAgencia + _CedenteConta + _Carteira + lNossoNumero);
			sCampo2 += _CedenteAgencia.Substring(0, 3);
			sCampo2 += Mod_dig10(sCampo2);

			sCampo3 = _CedenteAgencia.Substring(3, 1) + _CedenteConta.Substring(0, 5);
			sCampo3 += _CedenteContaDV + "000";
			sCampo3 += Mod_dig10(sCampo3);

			sCampo4 = Mod_dig11(sbarra);

			sCampo5 = sValor;

			lLinhaDigitavel = sCampo1.Substring(0, 5) + "." + sCampo1.Substring(5, 5) + " ";
			lLinhaDigitavel += sCampo2.Substring(0, 5) + "." + sCampo2.Substring(5, 6) + " ";
			lLinhaDigitavel += sCampo3.Substring(0, 5) + "." + sCampo2.Substring(5, 6) + " ";
			lLinhaDigitavel += sCampo4 + " ";
			lLinhaDigitavel += sCampo5;

			lNossoNumero = lNossoNumero.Substring(0, lNossoNumero.Length - 1) + "-" + lNossoNumero.Substring(lNossoNumero.Length - 1, 1);
		}
	}

	public class BoletoBrasil: Boleto
	{
		public BoletoBrasil()
		{
			_BancoCodigo = 1;
			_BancoCodigoDV = '9';
			_BancoLogoTipo = @"BBLogo.gif";
		}

		/// <summary>
		/// Utilizando os valores informados nas propriedes monta os valores de nosso
		/// número, linha digitável e código de barras. ATENÇÃO: Foi implementado o convênio com seis
		/// </summary>
		/// <param name="lNossoNumero">Retorna o nosso número.</param>
		/// <param name="lLinhaDigitavel">Retorna a linha digitável.</param>
		/// <param name="lCodigoBarras">Retorna o código de barras.</param>
		public override void MontaCodigos( out string lNossoNumero, out string lLinhaDigitavel, out string lCodigoBarras)
		{
			string sCampo1, sCampo2, sCampo3;
			string sCampoLivre, sValor, sbarra;

			sValor = Convert.ToInt32( _Valor*100).ToString();

			//**************************************************************************************
			//Código de Barras
			//**************************************************************************************
			lNossoNumero = _Contrato.ToString( "000000") + _Sequencial.ToString().PadLeft(5, '0');

			sValor = sValor.PadLeft(10, '0');
			sValor = FatorVencimento(_DtVencimento) + sValor;

			sCampoLivre = lNossoNumero + _CedenteAgencia.PadLeft(4, '0') + _CedenteConta.PadLeft(8, '0') + _Carteira.ToString( "00");

			sbarra = BancoCodigoFormatado() + "9" + sValor + sCampoLivre;
			lCodigoBarras = BancoCodigoFormatado() + "9" + Mod_dig11(sbarra) + sValor + sCampoLivre;

			//**************************************************************************************

			//**************************************************************************************
			//Linha Digitável
			//**************************************************************************************
			sCampo1 = BancoCodigoFormatado() + "9" + Left(sCampoLivre, 5);
			sCampo1 += Mod_dig10(sCampo1);

			sCampo2 = sCampoLivre.Substring( 5, 10);
			sCampo2 += Mod_dig10(sCampo2);

			sCampo3 = sCampoLivre.Substring( 15, 10);
			sCampo3 += Mod_dig10(sCampo3);

			while(sValor[0]=='0')
				sValor = sValor.Remove( 0, 1);

			lLinhaDigitavel = Left(sCampo1, 5) + "." + sCampo1.Substring( 5, 5) + " " + 
				Left(sCampo2, 5) + "." + sCampo2.Substring( 5, 6) + " " + 
				Left(sCampo3, 5) + "." + sCampo3.Substring( 5, 6) + " " + 
				Mod_dig11(sbarra) + " " + sValor.PadRight(13, ' ');

			//**************************************************************************************

			lNossoNumero += "-" + Mod_dig11(lNossoNumero); //Mostra o nosso numero com DV
		}
	}

	public class BoletoHSBC: Boleto
	{
		public BoletoHSBC()
		{
			_BancoCodigo = 399;
			_BancoCodigoDV = '9';
			_BancoLogoTipo = @"HSBCLogo.gif";
		}

		/// <summary>
		/// Utilizando os valores informados nas propriedes monta os valores de nosso
		/// número, linha digitável e código de barras. 
		/// posições.
		/// </summary>
		/// <param name="lNossoNumero">Retorna o nosso número.</param>
		/// <param name="lLinhaDigitavel">Retorna a linha digitável.</param>
		/// <param name="lCodigoBarras">Retorna o código de barras.</param>
		public override void MontaCodigos( out string lNossoNumero, out string lLinhaDigitavel, out string lCodigoBarras)
		{
			string sCampo1, sCampo2, sCampo3, sCampo4, sCampo5;
			string sCampoLivre, sValor, sbarra;

			sValor = Convert.ToInt32( _Valor*100).ToString();

			//**************************************************************************************
			//Código de Barras
			//**************************************************************************************
			lNossoNumero = _Contrato.ToString( "000000") + _Sequencial.ToString().PadLeft(5, '0');

			sValor = sValor.PadLeft(10, '0');
			sValor = FatorVencimento(_DtVencimento) + sValor;

			sCampoLivre = lNossoNumero + _CedenteAgencia.PadLeft(4, '0') + _CedenteConta.PadLeft(7, '0') + _Carteira + "1";

			sbarra = BancoCodigoFormatado() + "9" + sValor + sCampoLivre;
			lCodigoBarras = BancoCodigoFormatado() + "9" + Mod_dig11(sbarra) + sValor + sCampoLivre;

			//**************************************************************************************

			//**************************************************************************************
			//Linha Digitável
			//**************************************************************************************
			sCampo1 = "399" + "9" + lNossoNumero.Substring(0, 5);
			sCampo1 += Mod_dig10(sCampo1);

			sCampo2 = lNossoNumero.Substring(5, 6) + _CedenteAgencia.PadLeft(4, '0');
			sCampo2 += Mod_dig10(sCampo2);

			sCampo3 = _CedenteConta.PadLeft(7, '0') + _Carteira + "1";
			sCampo3 += Mod_dig10(sCampo3);

			sCampo4 = Mod_dig11(sbarra);

			sCampo5 = sValor;

			lLinhaDigitavel = sCampo1.Substring(0, 5) + "." + sCampo1.Substring(5, 5) + " ";
			lLinhaDigitavel += sCampo2.Substring(0, 5) + "." + sCampo2.Substring(5, 5) + " ";
			lLinhaDigitavel += sCampo3.Substring(0, 6) + "." + sCampo2.Substring(6, 5) + " ";
			lLinhaDigitavel += sCampo4;
			lLinhaDigitavel += sCampo5;

			//**************************************************************************************
			lNossoNumero += "-" + Mod_dig11(lNossoNumero);
		}
	}

	public class BoletoCEF: Boleto
	{
		public BoletoCEF()
		{
			_BancoCodigo = 104;
			_BancoCodigoDV = '0';
			_BancoLogoTipo = @"CEFLogo.gif";
			_LocalPagamento = "Pagável em qualquer banco até o vencimento preferencialmente na CAIXA e casas lotéricas.";
		}

		private string DVCampoLivre( string cVariavel)
		{
			int nSoma = 0, nMult = 2, nIndice;

			for( nIndice=cVariavel.Length-1; nIndice>=0; nIndice--)
			{
				nSoma += (Convert.ToByte(cVariavel[ nIndice]) - 48) * nMult;
				if( nMult==9) nMult = 2;
				else nMult++;
			}

			nSoma = 11 - nSoma % 11;
			if (nSoma>9) nSoma = 0;
			return nSoma.ToString();
		}

		public override string AgenciaCedente()
		{
			string lAgencia = _CedenteAgencia.PadLeft( 4, '0');
			string lContrato = _Contrato.ToString().PadLeft( 6, '0');
			return lAgencia + "/" + lContrato + "-" + DVCampoLivre(lAgencia + lContrato);
		}

		/// <summary>
		/// Utilizando os valores informados nas propriedes monta os valores de nosso
		/// número, linha digitável e código de barras.
		/// </summary>
		/// <param name="lNossoNumero">Retorna o nosso número.</param>
		/// <param name="lLinhaDigitavel">Retorna a linha digitável.</param>
		/// <param name="lCodigoBarras">Retorna o código de barras.</param>
		public override void MontaCodigos( out string lNossoNumero, out string lLinhaDigitavel, out string lCodigoBarras)
		{
			string sCampo1, sCampo2, sCampo3;
			string sCampoLivre, sValor, sbarra;

			sValor = Convert.ToInt32( _Valor*100).ToString();
			
			//**************************************************************************************
			//Código de Barras
			//**************************************************************************************
			lNossoNumero = "99" + _Sequencial.ToString().PadLeft( 16, '0');
			lNossoNumero += "-" + DVCampoLivre(lNossoNumero);

			sValor = sValor.PadLeft(10, '0');
			sValor = FatorVencimento( _DtVencimento) + sValor;

			sCampoLivre = "1" + Left( _Contrato.ToString(), 6).PadLeft( 6, '0') + "99" + _Sequencial.ToString().PadLeft( 16, '0') ;
				
			sbarra = BancoCodigoFormatado() + "9" + sValor + sCampoLivre;
			lCodigoBarras = BancoCodigoFormatado() + "9" + Mod_dig11(sbarra) + sValor + sCampoLivre;
			//**************************************************************************************

			//**************************************************************************************
			//Linha digitável
			//**************************************************************************************
			sCampo1 = BancoCodigoFormatado() + "9" + Left(sCampoLivre, 5);
			sCampo1 += Mod_dig10(sCampo1);

			sCampo2 = sCampoLivre.Substring( 5, 10);
			sCampo2 += Mod_dig10(sCampo2);

			sCampo3 = sCampoLivre.Substring( 15, 10);
			sCampo3 += Mod_dig10(sCampo3);

			lLinhaDigitavel = Left(sCampo1, 5) + "." + sCampo1.Substring( 5, 5) + "  " + 
				Left(sCampo2, 5) + "." + sCampo2.Substring( 5, 6) + "  " + 
				Left(sCampo3, 5) + "." + sCampo3.Substring( 5, 6) + "  " + 
				Mod_dig11(sbarra) + "  " + sValor;
			//**************************************************************************************
                
		}
	}
	
}
