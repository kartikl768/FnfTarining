using System;
class ex02datatype {
    static void Main()
    {
        int ival = 20;
        byte byval = 1;
        long lval = 6360534933;
        char ch = 'K';
        bool flag=false;
        var a = 25;
       // Console.WriteLine("the value of int is {0}\n the value of byte is {1}\n the value of lval is {2}\n the value of char is {3}\n the value of var is {4}\n ", 
           // ival, byval, lval, ch,a);
        //Conversion();
        Typeconversion();
    }
    static void Conversion()
    {
        Console.WriteLine("eEnter the Name ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the DOB");
        int dob=int.Parse(Console.ReadLine());
        Console.WriteLine("enter the pincode:");
        long pc=long.Parse(Console.ReadLine());
        Console.WriteLine("Thank you");
        Console.WriteLine($"the name is: {name}\n the dob is {dob}\n the pincode is {pc}");
    }
    static void Typeconversion()
    {
        int iVal = 123;
        long lval = iVal; //Implicit conversion
        double dval = 123456.2589;
        long llval=Convert.ToInt64(dval);
        int ivl=Convert.ToInt32(llval);
        lval=(int)llval; //Explicit Conversion
        Console.WriteLine($" {llval}, {ivl}");
    }
}


/* NOTES
 * allthe data in c# is CTS(common type sys)
 * 2 types -> Primitive(value type) and Reference-> Arrays, normal classes that i create
 * int, float, etc
 * Casting is possible
 * H-L possible but L-h not posible
 */