using System;

namespace Patron_Compoosition
{
    class Program
    {
        static void Main(string[] args)
        {
         
            var action = Results();
            action.Counten.Increment();
            Console.WriteLine(action.Counten.get());
            action.Actions.Add(1);
        }
        public static ((Action Increment, Action SubStract, Func<int> get) Counten, (Action<int> Add, Action<int> Update, Action<int> Delete) Actions) Results()
        {
            return (
                Counten(),
                Actions()
                ) ;

        }

        public static (Action Increment, Action SubStract, Func<int> get) Counten()
        {
            //Control variable
            int i = 0;
            //Actions
            Action Increment = () => i++;
            Action SubStract = () => i--;
            Func<int> get = () => i;
            //Data return 
            return (Increment, SubStract, get);

        }

        public static (Action<int> Add, Action<int> Update, Action<int> Delete) Actions()
        {
            return
                (
                    (num) => Console.WriteLine("Agregar" + num),
                    (num) => Console.WriteLine("Edfitar" + num),
                    (num) => Console.WriteLine("Eliminar" + num)
                );
        }
    

    }
}
