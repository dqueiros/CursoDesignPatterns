using CursoDesignPatterns.PatternsEstrutural.Composite.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.PatternsEstrutural.Composite
{
    public class ProductLeaf : ComponentModel
    {
        private string _nome;
        private double _valor;

        public ProductLeaf(string nome, double valor)
        {
            _nome = nome;
            _valor = valor;
        }

        public override void Add(params ComponentModel[] components)
        {
            Console.WriteLine("Não é possivel adicionar itens em um objeto do tipo Leaf");
        }

        public override ComponentModel GetChild(int index)
        {
            Console.WriteLine("Não é possivel obter itens em um objeto do tipo Leaf");
            return null;
        }

        public override double Operation()
        {
            Console.WriteLine($"produto: {_nome}\nValor: {_valor.ToString("C")}");
            Console.WriteLine(new String('-',40));
            return _valor;
        }

        public override void Remove(ComponentModel component)
        {
            Console.WriteLine("Não é possivel remover itens em um objeto do tipo Leaf");
        }
    }
}
