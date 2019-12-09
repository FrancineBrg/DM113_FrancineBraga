﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EstoqueProduto {

    // Service contract describing the operations provided by the WCF service
    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/01", Name = "IServicoEstoque")]
    public interface IServicoEstoque {
        [OperationContract]
        List<Produto> ListarProdutos();
        [OperationContract]
        bool IncluirProduto(Produto produto);
        [OperationContract]
        bool RemoverProduto(string numeroProduto);
        [OperationContract]
        int ConsultarEstoque(string numeroProduto);
        [OperationContract]
        int AdicionarEstoque(string numeroProduto, int quantidade);
        [OperationContract]
        int RemoverEstoque(string numeroProduto, int quantidade);
        [OperationContract]
        Produto verProduto(string numeroProduto);
    }


    [ServiceContract(Namespace = "http://projetoavaliativo.dm113/02", Name = "IServicoEstoqueV2")]
    public interface IServicoEstoqueV2 {
        [OperationContract]
        int AdicionarEstoque(string numeroProduto, int quantidade);
        [OperationContract]
        int RemoverEstoque(string numeroProduto, int quantidade);
        [OperationContract]
        int ConsultarEstoque(string numeroProduto);
    }



    // Data contract describing the details of a product passed to client applications
    [DataContract]
    public class Produto {
        [DataMember(Order = 0)]
        public string NumeroProduto;
        [DataMember(Order = 1)]
        public string NomeProduto;
        [DataMember(Order = 2)]
        public string DescricaoProduto;
        [DataMember(Order = 3)]
        public int EstoqueProduto;
    }
}