using System;

namespace entities{

    class Account{

        private int accountNumber; //Número da conta
        private string holderName; // Nome do titular da conta
        private double balance; // Saldo da conta

        private double rate = 5.00; // Taxa por transação

        public Account(int accountNumber, string holderName, double balance){

            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = balance;
        }

        public Account(int accountNumber, string holderName){

            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = 0;

        }

        public void deposit (double valueDeposit){

            if (valueDeposit <= 0){
                Console.WriteLine("Error: Value Invalid");
                Console.Write("\nPress Enter to continue...");
                Console.ReadKey();
                return;
            }

            // Text 1
            Console.WriteLine("Successful deposit");
            Console.Write($"Update balance: {GetBalance()} + {valueDeposit} = ");

            SetBalance(GetBalance() + valueDeposit); // Depósito 

            // Text 1.5
            Console.WriteLine(GetBalance());

            Console.Write("\n\nPress Enter to continue...");
            Console.ReadKey();
        }

        public void withdrawl(double valueWithdrawl){

            if(valueWithdrawl <= 0){
                Console.WriteLine("Error: Value Invalid");
                Console.Write("\nPress Enter to continue...");
                Console.ReadKey();
                return;
            }
            else if((GetBalance() <= 0) || ((GetBalance() - valueWithdrawl) - rate) < 0){
                Console.WriteLine("Error: You dont't have enough balance");
                Console.Write("\nPress Enter to continue...");
                Console.ReadKey();
                return;
            }
            else{

                // Text 1
                Console.WriteLine("\nSuccessful withdrawl");
                Console.Write($"Update balance: {GetBalance()} - {valueWithdrawl} - {GetRate()} = ");

                SetBalance((GetBalance() - valueWithdrawl) - rate); // Saque e Cobrança da Taxa
                
                // Text 1.5
                Console.WriteLine(GetBalance());

                Console.Write("\nPress Enter to continue...");
                Console.ReadKey();
            }
        }

        public String toString(){
            return "Account Data: "
                + "\nAccount Number: " + GetAccountNumber()
                + ", Holder Name: " + GetHolderName()
                + ", Balance: $ " + GetBalance();
        }
        
        public String GetHolderName(){
            return this.holderName;
        }

        public void SetHolderName(String newName){
            this.holderName = newName;
        }

        public int GetAccountNumber(){
            return this.accountNumber;
        }

        private void SetAccountNumber(int newNumber){
            this.accountNumber = newNumber;
        }


        
        public double GetBalance(){
            return this.balance;
        }

        public void SetBalance(double value){
            this.balance = value;
        }

        public double GetRate(){
            return this.rate;
        }

    }
}