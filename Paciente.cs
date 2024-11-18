using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_adv
{
    public class Paciente
    {
        // Atributos
        private string nome;
        private int idade;
        private List<string> historicoConsultas;

        // Construtor
        public Paciente(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            this.historicoConsultas = new List<string>();
        }

        // Método para adicionar uma consulta ao histórico
        public void AdicionarConsulta(string descricao)
        {
            historicoConsultas.Add(descricao);
        }

        // Método para exibir o histórico de consultas
        public string ExibirConsultas()
        {
            if (historicoConsultas.Count == 0)
            {
                return "O histórico de consultas está vazio.";
            }

            string resultado = "Histórico de Consultas:\n";
            for (int i = 0; i < historicoConsultas.Count; i++)
            {
                resultado += (i + 1) + ". " + historicoConsultas[i] + "\n";
            }
            return resultado;
        }

        // Método para exibir os dados do paciente
        public string ExibirDados()
        {
            return "Paciente: " + nome + "\nIdade: " + idade + " anos";
        }
    }
}
