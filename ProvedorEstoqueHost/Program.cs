using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using EstoqueProduto;


namespace ProvedorEstoqueHost {
    class Program {
        static void Main(string[] args) {
            ServiceHost servicoEstoqueHost = new ServiceHost(typeof(ServicoEstoque));
            servicoEstoqueHost.Open();
            Console.WriteLine("Serviço Ativado");
            Console.ReadLine();
            Console.WriteLine("Desativando Serviço");
            servicoEstoqueHost.Close();
        }
    }
}
