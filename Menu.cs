
using entities;

class Menu{

    public static void homePage(Account account){

        Options options = new Options();
        
        bool close = false;
        while(close == false){

            Console.Clear();
            Console.WriteLine($" \n {account.toString()} \n ");
            Console.WriteLine($"Note: We charge ${account.GetRate()} for each withdrawl \n");

            options.seeOptions();

            Console.Write("\nSelect option: ");
            string option = Console.ReadLine() ?? "DefaultOption";

            if (options.validateOption(option)){

                int optionNum = int.Parse(option);
                options.selectOption(optionNum, account);
            }
            else{
                continue;
            }
            
        }
    }
}