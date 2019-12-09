using EstoqueProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using EstoqueEntityModel;
using System.ServiceModel.Activation;

namespace ServicoEstoque {

    // WCF service that implements the service contract
    // This implementation performs minimal error checking and exception handling
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicoEstoque : IServicoEstoque, IServicoEstoqueV2 {
        public int AdicionarEstoque(string numeroProduto, int quantidade) {
            throw new NotImplementedException();
        }

        public int ConsultarEstoque(string numeroProduto) {
            throw new NotImplementedException();
        }

        public bool IncluirProduto(Produto produto) {
            throw new NotImplementedException();
        }

        public List<Produto> ListarProdutos() {
            throw new NotImplementedException();
        }

        public int RemoverEstoque(string numeroProduto, int quantidade) {
            throw new NotImplementedException();
        }

        public bool RemoverProduto(string numeroProduto) {
            throw new NotImplementedException();
        }

        public Produto verProduto(string numeroProduto) {
            throw new NotImplementedException();
        }
    }

}
