namespace Heranca
{
    public abstract class Funcionario
    {
        protected decimal Salario; //impede de a instanciação ocorrer
        public string? Nome { get; set; }
        
        public Funcionario()
        {
            
        }
        public Funcionario (string nome, decimal salario)
        {
            Nome = nome;
            Salario = salario;
        }


        public virtual void Trabalhar()
        {
            Console.WriteLine("Funcionário está trabalhando.");
        }

        public abstract decimal CalcularBonus();

        
    }
}