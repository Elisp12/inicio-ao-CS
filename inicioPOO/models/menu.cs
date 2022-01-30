using System;

namespace inicioPOO.models
{
    public class menu 
    {
        public string nomeMod {get; set;}
        public string cor {get; set;}
        public float vlcd {get; set;}
        public int tm {get; set;}
    
        public virtual void mostrar()
        {
            menu c1 = new menu();
            c1.cor ="Preto";
            menu c2 = new menu();
            c2.cor ="Cinza";
            Console.WriteLine($"Cor: {c1.cor}, {c2.cor}");
        }
    }
}