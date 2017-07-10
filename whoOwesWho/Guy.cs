using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whoOwesWho
{
    class Guy 
    {
        public string Name;
        public int Cash;
        //declare properties of a Guy object

        public int GiveCash(int amount)
        {
            if (amount <= Cash)
            {
                Cash = Cash - amount;
                return amount;
            }
        //the GiveCash method accepts one parameter, amount.
        //the statements within it determine whether the Guy object has enough cash. 
        //if it does (true) the amount is taken from the wallet and returns the value
       
            else
            {
                MessageBox.Show("I dont have enough cash to give you " + amount, Name + " says");
                return 0;
            }
        //if the Guy object does not have enough cash, the else statement will run.
        //this statement returns a message to say he does not have enough in the wallet.
        }
        //this is the first method of a Guy object, it used to check the wallet value
        //because it has a return type (int) it must include a return statement, which var type matches
        //public void would have no return value

        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash = Cash + amount;
                return amount;
            }
            //so long as the input amount is more than 0, it will be added to the value of Cash

            else
            {
                MessageBox.Show(amount + " isn't an amount I'll take ", Name + " says.");
                return 0;
            }
            //if the amount suggested is not more than 0, a message box appears on screen.
        }
        //this is the second method of a Guy object, it also accepts one parameter
        //it checks to make sure the amount is greater than 0 then add its to Cash.

    }
}
