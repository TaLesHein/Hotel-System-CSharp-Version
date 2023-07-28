namespace util{

    class ValidateInformation{

        public static double validateValue(){

            try{
                    double value = double.Parse(Console.ReadLine() ?? "0.00");
                    return value;
                }catch(FormatException e){

                    Console.WriteLine("\nError: The entered value is invalid.");
                    Console.Write("Press Enter to continue...");
                    Console.ReadKey();
                    return -1;
                }
        }

        public static char validateOption(){

            char option = char.Parse(Console.ReadLine() ?? "DefaultInfo");

            StringComparison ordinalIgnoreCase = StringComparison.OrdinalIgnoreCase;

            if (option.ToString().Equals("S", ordinalIgnoreCase) || 
                option.ToString().Equals("N", ordinalIgnoreCase)){

                    return Char.ToUpper(option);
            }
            else{
                    Console.WriteLine("\nError: The entered value is invalid.");
                    Console.Write("Press Enter to continue...");
                    Console.ReadKey();

                    return 'F';
                    
            }
        }
    }
}