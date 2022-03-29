
using System;

class Homework6 {
    
    static void Main() {
        
        // test ShowCharacter method     
        string s = "New York"; // initialize a string
        
        Console.Write("ShowCharacter(\"New York\", 2): ");
        ShowCharacter(ref s, 2);
        
        Console.Write("ShowCharacter(\"New York\", 7): ");
        ShowCharacter(ref s, 7);
        
        // test CalculateRetail method 
        Console.WriteLine("\nCalculateRetail(5.00, 100): "+CalculateRetail(5.00, 100).ToString("0.00")); 
        Console.WriteLine("CalculateRetail(5.00, 50): "+CalculateRetail(5.00, 50).ToString("0.00"));
        

        Console.WriteLine("\nFahrenheit\tCelsius");
        for(int f=80;f<=100;f++)
            Console.WriteLine(f + "\t\t" + Celsius(f).ToString("#.###"));
            
        // test IsPrime method
        Console.WriteLine("\nIsPrime(31): " + IsPrime(31));
        Console.WriteLine("IsPrime(27): " + IsPrime(27));
        Console.WriteLine("IsPrime(4): " + IsPrime(4));
        Console.WriteLine("IsPrime(5): " + IsPrime(5));
        Console.WriteLine("IsPrime(2): " + IsPrime(2));
    }
    

    static void ShowCharacter(ref string s, int position)
    {
        if(position >= 1 && position <= s.Length)
            Console.WriteLine(s[position-1]); 
    }
    

    static double CalculateRetail(double wholesaleCost, int markUpPct)
    {
        return wholesaleCost + (markUpPct * wholesaleCost/100);
    }
    
   
    static double Celsius(double fahrenheit)
    {
        return (5*(fahrenheit - 32))/9;
    }
    
   
    static bool IsPrime(int number)
    {
      
        for(int i=2;i<=number/2;i++)
        {
            if(number%i == 0) 
                return false;
        }
        
        return true; 
    }
}
