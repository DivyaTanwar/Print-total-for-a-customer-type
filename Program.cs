namespace Practice
{
    internal class Program
    {
        public static void getInputs(out string customer, out double subTotal)
        {

            Console.Write("Enter Customer type: ");
            customer = Console.ReadLine();
            Console.Write("Enter subTotal ");
            subTotal = double.Parse(Console.ReadLine());
        }
        public static void netPayCalculate(string customer, double subTotal, out double discP, out double disAmt, out double totalAmt, out string choice)
        {
            discP = 0;
            choice = "y";

            if (customer == "R")
            {
                if (subTotal >= 250)
                {
                    discP = 0.25;

                }
                else if (subTotal >= 100 && subTotal < 250)
                {
                    discP = 0.1;

                }
                else
                {
                    discP = 0;
                }
            }

            if (customer == "C")
            {
                if (subTotal >= 250)
                {
                    discP = 0.3;


                }
                else
                {
                    discP = 0.2;

                }
            }

            disAmt = discP * subTotal;
            totalAmt = subTotal - disAmt;
        }

        static void Main(string[] args)
        {
            string choice = "y";
            double discP = 0.0;
            double disAmt = 0.0;
            double totalAmt = 0.0;
            double subTotal;
            string customer;
            while (choice == "y")
            {

                getInputs(out customer, out subTotal);


                netPayCalculate(customer, subTotal, out discP, out disAmt, out totalAmt, out choice);


                Console.WriteLine("The discounted amount is: " + disAmt.ToString("C"));
                Console.WriteLine("The total is: " + totalAmt.ToString("C"));
                Console.Write("Do you want to try again?(y/n): ");
                choice = Console.ReadLine();
            }


        }
    }
}
