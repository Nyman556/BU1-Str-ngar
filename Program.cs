using System.Globalization;
using System.Security.Cryptography;

namespace strängar;

class Program
{
    static void Main(string[] args) {


    // Övning1();
    // Övning2();
    // Övning3();
    // Övning4();
    // Övning5();
    // Övning6();
    // Övning7();
    // Övning8();
    // Övning9();

    /* 
    string a = "Hej, jag gillar glass. Vad gillar du?";
    string b = "Jag brukar programmera. Är du en programmerare också?";
    string c = "Du måste handla mat medans jag städar huset.";

    Console.WriteLine(Övning10(c)); 
    */

    // Console.WriteLine(Övning11(5));

    // Console.WriteLine(Övning12("fan va godis är gott!"));

    // Console.WriteLine(Övning13("Glass är gott.", "är"));
    
    // Console.WriteLine(Övning14("Glass Är Gott."));

    /*
    if (Övning15("500", out int result))
    {
        Console.WriteLine("Parsed: " + result);
    }
    else
    {
        Console.WriteLine("Could not parse.");
    }
    */

    Console.WriteLine(Övning16("hej1jag2gillar43glass."));


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
        string? input = Console.ReadLine();
        char[] possibleSeporators = {',', '.', ' ', '!', '!'};
        int result = 0;
        string[] ageArr = Array.Empty<string>();
        foreach(char seporator in possibleSeporators) {
            if(input.Contains(seporator)) {
                ageArr = input.Split(seporator);
            } 
        }
        foreach(string age in ageArr) {
            result += Convert.ToInt32(age);
        }
        Console.WriteLine($"resultat: {result}");
    }

    static void Övning3() {
        string desc = "Hämta in en sträng med Console.ReadLine(). Skriv ut samma text men i uppercase. Hämta in en sträng med Console.ReadLine(). Skriv ut samma text men i lowercase.";
        Console.WriteLine($"desc: {desc}");
        string? input = Console.ReadLine().ToUpper();
        string? input2 = Console.ReadLine().ToLower();
        Console.WriteLine(input);
        Console.WriteLine(input2);
    }

    static void Övning4() {
        string desc = "Hämta in en sträng med Console.ReadLine(). Skriv ut det första tecknet i strängen.";
        Console.WriteLine($"desc: {desc}");
        string input = Console.ReadLine();
        char[] inputArr = input.ToCharArray();
        Console.WriteLine(inputArr[0]);
    }

    static void Övning5() {
        string desc = "Hämta in en sträng med Console.ReadLine(). Skriv ut antalet gången tecknet a förekommer i strängen. Hämta in en sträng med Console.ReadLine(). Skriv ut index på alla a-tecken som förekommer i strängen.";
        Console.WriteLine($"desc: {desc}");
        char check = 'a';
        int count = 0;
        string? input = Console.ReadLine();
        char[] inputArr = input.ToCharArray();
        List<int> indexes = new List<int>();
        for(int i = 0; i < inputArr.Length; i++) {
            if(inputArr[i] == check){
                count++;
                indexes.Add(i);
            }
        }
        Console.WriteLine(count);
        foreach(int i in indexes) {
            Console.WriteLine($"found at idx: {i}");
        }

    }

    static void Övning6() {
        string desc = "Hämta in en sträng med Console.ReadLine(). Skriv ut det sista ordet i strängen (ord definieras är som text som separeras av mellanslag).";
        Console.WriteLine($"desc: {desc}");
        string? input = Console.ReadLine();
        string[] inputArr = input.Split(" ");
        Console.WriteLine(inputArr[inputArr.Length - 1]);
    }

    static void Övning7() {
        string desc = "Hämta in en sträng med Console.ReadLine(). Skriv ut följande: Jag sade nyss '<input>'. ... där input representerar det du skrev in till Console.ReadLine(). skall ingå i strängen.";
        Console.WriteLine($"desc: {desc}");
        string? input = Console.ReadLine();
        Console.WriteLine($"Jag sade nyss \"{input}\"");
    }

    static void Övning8() {
        string br = Environment.NewLine;
        string desc = "Skriv ut följande med en enda Console.WriteLine():" + br + "Jag" + br + "gillar" + br + "glass.";
        Console.WriteLine($"desc: {desc}");
    }

    static void Övning9() {
        string desc = "Hämta in en sträng från konsolen. Skriv ut samma sträng men i flippad ordning. Exempel: Hej -> jeH | Glass -> ssalG";
        Console.WriteLine($"desc: {desc}");
        string? input = Console.ReadLine();
        char[] inputArr = input.ToCharArray();
        Array.Reverse(inputArr);
        string inputReversed = new string(inputArr);
        Console.WriteLine(inputReversed);
    }

        static string Övning10(string input) {
        string desc = "Skriv en funktion som byter plats på varje jag och du i en sträng. Använd följande strängar för att testa:";
        Console.WriteLine($"desc: {desc}");
        string[] inputArr = input.Split(" ");
        for(int i = 0; i < inputArr.Length; i++) {
            if(inputArr[i] == "du") {
                inputArr[i] = "jag";
            }else if (inputArr[i] == "Du") {
                inputArr[i] = "Jag";
            }else if (inputArr[i] == "du?") {
                inputArr[i] = "jag?";
            }else if(inputArr[i] == "jag") {
                inputArr[i] = "du";
            }else if(inputArr[i] == "Jag") {
                inputArr[i] = "Du";
            }else if(inputArr[i] == "jag?") {
                inputArr[i] = "jag?";
            }
        }
        string result = string.Join(" ", inputArr);
        return result;
    }

    static string Övning11(int input) {
        string desc = "Skriv en funktion som slumpar text på X tecken. Ta in antalet tecken som du ska slumpa med en parameter. Om man skickar in 4 så ska den slumpa 4 tecken, exempelvis: aueh.";
        Console.WriteLine($"desc: {desc}");
        string letters = "qwertyuiopåasdfghjklöäzxcvbnm";
        List<char> resultArr = new List<char>();
        Random random = new Random();

        for(int i = 0; i < input; i++) {
            resultArr.Add(letters[random.Next(0, letters.Length)]);
        }

        string result = new string(resultArr.ToArray());
        return result;
    }


    static string Övning12(string input) {
        string desc = "Skriv en funktion som byter ut svordomar och fula ord i en sträng mot finare ord.";
        Console.WriteLine($"desc: {desc}");
        var curseWords = new[]
        {
            new { Original = "fan", Replacement = "yay" },
            new { Original = "jävla", Replacement = "woohoo" }
        };

                foreach (var replacement in curseWords)
        {
            input = input.Replace(replacement.Original, replacement.Replacement, StringComparison.OrdinalIgnoreCase);
        }
        return input;
    }

    static int Övning13(string content, string sequence) {
        string desc = "Skriv en funktion som tar in två parametrar: en sträng (content) och en till sträng (sequence). Funktionen skall räkna ut och returnera hur många gånger sekvensen sequence förekommer i content.";
        Console.WriteLine($"desc: {desc}");
        int count = 0;
        string[] contentArr = content.Split(" ");

        foreach(string word in contentArr) {
            if(word == sequence) {
                count++;
            }
        }
        return count;
    }

    static int Övning14(string input) {
        string desc = "Skriv en funktion som tar in en parameter (en sträng). Funktionen skall returnera antalet stora bokstäver som finns i strängen.";
        Console.WriteLine($"desc: {desc}");

        int count = 0;
        char[] inputArr = input.ToCharArray();
        foreach (char letter in inputArr)
        {
            if (char.IsUpper(letter))
            {
                count++;
            }
        }
        return count;
    }

    static bool Övning15(string input, out int result) {
        string desc = "Skriv en egen enkel parsing funktion som gör om strängar till integers (inga decimaltal).";
        Console.WriteLine($"desc: {desc}");
        return int.TryParse(input, out result);
    }

    static int Övning16(string input) {
        string desc = "Skriv en funktion som tar in en sträng och returnerar summan av alla siffror som finns i strängen. Exempel: 'hej1jag2gillar43glass' -> 1 + 2 + 4 + 3 = 10";
        Console.WriteLine($"desc: {desc}");
        List<int> nummer = new List<int>();
        int result = 0;
        char[] inputArr = input.ToCharArray();

        foreach(char item in inputArr) {

            if (int.TryParse(item.ToString(), out int parseResult)) {
                nummer.Add(parseResult);
            }
        }

        foreach(int item in nummer) {
            result += item;
        }
        return result;
    }




    }
}
