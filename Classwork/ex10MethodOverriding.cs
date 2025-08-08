//
using System.Runtime.InteropServices;

namespace SampleConApp
{

    enum PaymentType
    {
        Cash,
        Cheque,
        Card,
        UPI
    }
    class Parent
    {
        public void display()
        {
            Console.WriteLine("WElcome to payment gateway");
        }
        public virtual void MakePayment(double amt, PaymentType type)
        {
            if (PaymentType.Cash == type)
            {
                Console.WriteLine($" the {amt} is accepted through Cash");
            }
            else if (PaymentType.Cheque == type)
            {
                Console.WriteLine($" the {amt} is accepted through Cheque");
            }
            else
            {
                Console.WriteLine("Invalid mode of payment");
            }
        }

    }

    class Son : Parent
    {
        public override void MakePayment(double amt, PaymentType type)
        {

            if (PaymentType.Cash == type)
            {
                Console.WriteLine($" the {amt} is accepted through the Cash");
            }
            else if (PaymentType.Card == type)
            {
                Console.WriteLine($" the {amt} is accepted through the card");
            }
            else if (PaymentType.UPI == type)
            {
                Console.WriteLine($" the {amt} is accepted through the upi");
            }
            else
            {
                Console.WriteLine("invalid mode of payment");
            }
        }

        public void Show()
        {
            Console.WriteLine("hi i am a independent method of son");
        }
    }

    class Gson: Son
    {

    }
    internal class ex10MethodOverriding
    {

        static Parent CreateObject()
        {
            Console.WriteLine("Enter the type of the object U want to create, Press P for Parent and S for Son");
            string choice = Console.ReadLine();
            if (choice.ToUpper() == "P")
            {
                return new Parent(); //Returning ParentClass object
            }
            else if (choice.ToUpper() == "S")
            {
                return new Son(); //Returning SonClass object
            }
            else
            {
                Console.WriteLine("Invalid choice, No object is created");
                return null;
            }
        }
        static void Main(string[] args)
        {
            //Parent parent = CreateObject();
            Parent parent = new Son();

            // Downcasting : Only methods that are defined in the parentclass can be called on parent object. if u want to call methods that are defined in the son class the we hace to downcast it using the 'as' keyworld or the direct typecasting
            if(parent == null)
            {
                Console.WriteLine("no object is created");
            }
            parent.display();
            if(parent is Son)
            {
                Son son = parent as Son; // downcasting
                son.Show();
            }
            parent.MakePayment(100, PaymentType.Cash);
            parent.MakePayment(200, PaymentType.Cheque);
            parent.MakePayment(200, PaymentType.Card);
            parent.MakePayment(200, PaymentType.UPI);
        }
    }
}
