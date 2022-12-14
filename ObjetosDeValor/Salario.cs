using System;

namespace ObjetosDeValor
{
    public class Salario
    {
        public decimal Valor { get; private set; }

        public Salario(decimal valor)
        {
            if (valor < 0)
                throw new ArgumentException($"O valor do Salário não pode ser negativo");

            Valor = valor;
        }
        public static Salario Novo(decimal valor)
        {
            return new Salario(valor);
        }
    }
}