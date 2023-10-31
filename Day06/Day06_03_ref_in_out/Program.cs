/* 
    Pass reference: akan mem-passing address dari variabel value type
    - berfungsi untuk pempersingkat proses: daripada mengalokasikan memori baru, 
      lebih baik langsung mengubah nilai variabel langsung dari alamatnya
    - macam:Ref, Out, In
        1. ref: 
        2. in : 
        3. out: 
*/
class Program {
    static void Main() {
        // Ref = pass reference, harus diassign sebelum method dipanggil
        void  MultiplyByTwoRef(ref int input) {
            // input = 4; // jika begini, nilai argumen input akan di-replace
            input *= 2;
        }

        //Out = pass reference, harus diassign didalam method sebelum methodnya exit
        void MultiplyByTwoOut(out int input)
        {
            input = 4; // proses assign
            input = input * 2;
        }

        //In = pass reference, harus diassign, tapi readonly
        void MultiplyByTwoIn(in int input)
        {
            // input = 4 // tidak bisa diubah karena ini readonly
            int result = input * 4;
        }


        //Ref
        int myInt = 2;
        MultiplyByTwoRef(ref myInt);
        Console.WriteLine(myInt);       // 4
        
        //Out
        MultiplyByTwoOut(out int myIntOut);
        Console.WriteLine(myIntOut);    // 8
        
        //In
        int myIntIn = 4;
        MultiplyByTwoIn(in myIntIn);
    }
}
