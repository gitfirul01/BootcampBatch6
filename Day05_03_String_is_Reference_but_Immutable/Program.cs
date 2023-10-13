/* 
 * String is Reference, but? Immutable
 * Immutable: membuat address baru di stack memory dan value baru di heap memory
 */
class Program
{
    static void Main()
    {
        string a = "3"; // a_address = *address1    | address1_memory_value = "3" 
        string b = a;   // b_address = *address1    | address1_memory_value = "3" 

        b = "5";        // b.value = "5" -> CREATE NEW ADDRESS FOR b (karena string immutable)
                        // b_address = *address2    | address2_memory_value = "5"
        
        Console.WriteLine(a);   // "3"
        Console.WriteLine(b);   // "5"
        
        string myString = "hello";
        myString = "World";
        myString += "!";         // myString = myString + "!"
        Console.WriteLine(myString);
    }
}