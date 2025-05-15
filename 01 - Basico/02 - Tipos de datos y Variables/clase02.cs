// Ejercicios para el Tema
// Fácil: Declara una variable de tipo int y asígnale un valor. Luego muestra este valor en la consola.

// namespace HolaMundo
// { 
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             int variable = 36;
//             Console.WriteLine(variable);
//         }
//     }
// }


// Medio 1: Declara una variable de tipo float, asígnale un valor y muestra el valor en la consola.

namespace HolaMundo
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            float variableDos = 36.90f;
            Console.WriteLine(variableDos);
        }
    }
}


// Medio 2: Declara una variable de tipo string, asígnale tu nombre y muestra el valor en la consola.

namespace HolaMundo
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            string variableTres = "Aron";
            Console.WriteLine(variableTres);
        }
    }
}


// Difícil: Declara tres variables de diferentes tipos (int, double, string), asígnales valores y muestra todos los valores en 
//     una sola línea en la consola.

namespace HolaMundo
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int variableCuatro = 36;
            double variableCinco = 15.5;
            string variableSeis = "Aron";
            Console.WriteLine(variableCuatro + variableSeis + variableCinco);
        }
    }
}