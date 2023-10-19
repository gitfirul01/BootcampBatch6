class Program {
    static void Main(){
        int n;

        Console.Write("n: ");
        n = Int32.Parse(Console.ReadLine());

        for (int i=0; i<=n; i++) {
            if ((i == 0) || ((i%3 != 0) && (i%5 != 0))) {
                Console.Write(i);
            }
            else {
                if (i % 3 == 0) {
                    Console.Write("Foo");
                }
                if (i % 5 == 0) {
                    Console.Write("Bar");
                }
            }

            if (i != n) {
                Console.Write(", ");
            }
        }
    }
}

/* or */
// class Program {
//     static void Main(){
//         int n;
//         string output = "";

//         Console.Write("n: ");
//         n = Int32.Parse(Console.ReadLine());

//         for (int i=0; i<=n; i++) {
//             if ((i == 0) || ((i%3 != 0) && (i%5 != 0))) {
//                 output += i.ToString();
//             }
//             else {
//                 if (i % 3 == 0) {
//                     output += "Foo";
//                 }
//                 if (i % 5 == 0) {
//                     output += "Bar";
//                 }
//             }

//             if (i != n) {
//                 output += ", ";
//             }
//         }
//         Console.WriteLine(output);
//     }
// }


/* C++ CODE */
// #include <iostream>
// using namespace std;

// int main() {
//     int n;
//     cout << "n: " << endl;
//     cin >> n;

//     for(int i=0; i <= n; i++) {
//         if ((i == 0) || ((i % 3 != 0) && (i % 5 != 0))) {
//             cout << i << ", ";
//         }
//         else {
//             string output = "";
//             if (i % 3 == 0) {
//                 output += "foo";
//             }
//             if (i % 5 == 0) {
//                 output += "bar";
//             }
//             cout << output << ", ";
//         }
//     }

//     return 0;
// }