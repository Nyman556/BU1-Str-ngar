﻿using System.Security.Cryptography;

namespace strängar;

class Program
{
    static void Main(string[] args) {


    // Övning1();
    // Övning2();
    // Övning3();
    // Övning4();
    // Övning5();
     Övning6();
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


    }
}
