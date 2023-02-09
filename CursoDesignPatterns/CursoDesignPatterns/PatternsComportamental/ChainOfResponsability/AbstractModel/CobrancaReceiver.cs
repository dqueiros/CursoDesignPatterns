
using System.ComponentModel.Design;

namespace CursoDesignPatterns.PatternsComportamental.ChainOfResponsability.AbstractModel
{
    public abstract class CobrancaReceiver
    {
        public CobrancaReceiver Next = null;

        public CobrancaReceiver AddNext(CobrancaReceiver next)
        {
            this.Next = next; 
            return next;
        }

        public virtual Checkout ExecutarCobrancaServicos(Checkout checkout)
        {
            if (this.Next != null)
                return this.Next.ExecutarCobrancaServicos(checkout);

            return null;
        }
    }
}
