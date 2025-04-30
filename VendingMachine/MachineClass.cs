using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class MachineClass

    {
        private int _currentBalance;

        private int _setAmount
        { 
            get { return _currentBalance; }
            set => _currentBalance = value is 20 or 50 or 100 or 200  ? value : throw new Exception("The acceptable coins are  20,50, 100 or 200");
        }

        private chosenMenu machineState;
        public MachineClass(int inputAmount)
        {
            _setAmount = inputAmount;
        }

        public void printMoney()
        {
            Console.WriteLine($"Current Money: {_currentBalance}");
        }
        public void addMoney(int amount)
        {
            _setAmount += amount;
        }
        public void withdraw(int amount)
        {
            _setAmount -= amount;
        }
        public void BuyItem(int price)
        {
            withdraw(price);
        }
        internal enum chosenMenu
        {
            addMoney = 1,
            buyItem,
            withdraw,
            showBalance,

        }
    }

}
    

