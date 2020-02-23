using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

namespace BLL
{

    public enum Operacao : byte
    {
        Inclusao,        //0
        Alteracao,       //1
        Exclusao,        //2
        ExclusaoFisica,  //3
        ExclusaoLogica,  //4   Alterar status/setar valor
        Consulta,        //5
        ListagemCompleta,//6
        Reativar,        //7
        Desativar        //8
    }
    public enum NivelDeAcesso : byte
    {
        Administrador, //0
        Supervisor,    //1
        Usuario        //2
    }
    public enum LocalBanco : byte
    {
        MicroPessoal,  //0
        EstacaoLab,    //1
        ServidorLab,   //2
        ServidorWeb,   //3
        NuvemAzure,    //4
        NuvemAmazon    //5
    }
    public enum TipoBancoDados : byte
    {
        Access97,       //0
        Access2013,     //1
        SqlServer2008,  //2
        Oracle11g,      //3
        OracleXe,       //4
        MySql           //5
    }

}
