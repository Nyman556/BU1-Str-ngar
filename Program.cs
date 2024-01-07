namespace strängar;

class Program
{
    static void Main(string[] args) {


    Övning1();
    // Övning2();
    // Övning3();
    // Övning4();
    // Övning5();
    // Övning6();
    // Övning7();
    // Övning11();
    // Övning12();
    // övning13();



    static void Övning1() {
        string desc = "Hämta in två strängar med Console.ReadLine(). Programmet skall skriva De är samma om strängarna är samma (innehåller exakt samma text) och De är inte samma om de inte innehåller exakt samma text.";
        Console.WriteLine($"desc: {desc}");
        string input = Console.ReadLine();
        string input2 = Console.ReadLine();
        if(input == input2) {
            Console.WriteLine("De är samma");
        } else {
            Console.WriteLine("De är inte samma");
        }
    }
    
    static void Övning2() {
        string desc = "Hämta in en massa nummer som representerar åldrar genom en Console.ReadLine(). Det skall finnas endast en Console.ReadLine(). Addera alla åldrar och skriv ut summan med Console.WriteLine().";
        Console.WriteLine($"desc: {desc}");

    }


    }
}
