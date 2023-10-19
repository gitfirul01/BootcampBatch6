/* Array */
class Program {
    static void Main() {
        // making array
        int[] myArray = {1,2,4};
        char[] myChar = new char[4];
        string[] myStrings = new string[] {"1","2","3"};
        Console.WriteLine(myStrings); // ?
        
        // accessing array
        int result = myArray[2]; 
        myArray[2] = 6;
        Console.WriteLine(result); // 4

        
        // return array length
        int length = myArray.Length;
        Console.WriteLine(length); // 3
    }
}