using util;

namespace entities{

    class Options{

        private string[] optionsArray = new string [3];
        public Options(){

            optionsArray[0] = "[1] Withdrawl";
            optionsArray[1] = "[2] Deposit";
            optionsArray[2] = "[0] Exit";

        }

        public void seeOptions(){

            for(int i = 0; i < optionsArray.Length; i++){
                Console.WriteLine(optionsArray[i]);
            }
        }

        public bool validateOption(String option){

            try{

                int optionNum = int.Parse(option);

                if(optionNum >= 0 && optionNum <= optionsArray.Length - 1){
                    return true;
                }
                else{
                    Console.WriteLine("Error: Option is Invalid");
                    Console.Write("Press Enter to continue...");
                    Console.ReadKey();
                    return false;
                }

            }catch(FormatException e){
                
                Console.WriteLine("Error: Option is Invalid");
                Console.Write("Press Enter to continue...");
                Console.ReadKey();
                return false;
            }
        }

        public void selectOption(int option, Account account){

            double value;
            switch(option){

                case 0:
                Console.Write("Close program? S/N ");
                char closeOption = ValidateInformation.validateOption();

                if (closeOption.Equals('S')){
                    Environment.Exit(0);
                }
                else {
                    return;
                }
                
                break;

                case 1:
                Console.Clear();
                Console.WriteLine($"-- Note: We charge ${account.GetRate()} for each withdrawl --\n");
                Console.WriteLine($"Balance: {account.GetBalance()}");
                Console.Write("Amount to Withdraw: ");
                value = ValidateInformation.validateValue();
                
                if (value >= 0){
                    account.withdrawl(value);
                }
                else{
                    return;
                }
                
                break;

                case 2:
                Console.Clear();
                Console.Write("Amount to Deposit: ");
                value = ValidateInformation.validateValue();
                
                if (value >= 0){
                    account.deposit(value);
                }
                else{
                    return;
                }
                break;
            }
        }
    }
}