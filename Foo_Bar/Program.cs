class Program {
    static void Main() {
        string nStr;
        int nInt;
        Console.WriteLine("n: ");
        nStr = Console.ReadLine();
        nInt = Int32.Parse(nStr);

        for (int i=0; i<=nInt; i++) {
            if ( (i==0) || ( (i%3!=0)&&(i%5!=0) ) ){
                Console.WriteLine(i);
            } else {
                string output = "";
                if (i%3==0){
                    output += "foo";
                }
                if (i%5==0){
                    output += "bar";
                }
                Console.WriteLine(output);
            }
        }
    }

}