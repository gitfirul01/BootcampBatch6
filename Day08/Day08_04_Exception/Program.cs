﻿//Exception
class Program {
    static void Main()
    {
        void Caller() {
            Caller();
        }
        //int a = 10;
        //int b = 0;
        //int result = a/b;

        //int[] array = new int[] {1,2,3};
        //int resultA = array[0];
        //int resultB = array[4];
        
        Caller();
    }
}