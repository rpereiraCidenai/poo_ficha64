namespace poo_adv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criar um novo paciente
            Paciente paciente = new Paciente("João Silva", 35);

            // Adicionar consultas ao histórico
            paciente.AdicionarConsulta("Consulta de rotina - 10/01/2023");
            paciente.AdicionarConsulta("Exame de sangue - 15/02/2023");
            paciente.AdicionarConsulta("Revisão geral - 20/03/2023");

            // Exibir dados do paciente
            Console.WriteLine(paciente.ExibirDados());

            // Exibir histórico de consultas
            Console.WriteLine(paciente.ExibirConsultas());
        }
    }
}