using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.PatternsEstrutural.Composite.Model
{
    public abstract class ComponentModel
    {
        public abstract double Operation();
        public abstract void Add(params ComponentModel[] components);
        public abstract void Remove(ComponentModel component);
        public abstract ComponentModel GetChild(int index);

    }
}
