using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whoOwesWho
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        //declare the fields joe and bob, a var bank, value 100

        public Form1()
        {
            InitializeComponent();

            joe = new Guy() { Cash = 50, Name = "Joe" };
            bob = new Guy() { Cash = 100, Name = "Bob" };
            //create an instance of Guy, assign it to var joe, and another, assign to var bob
            //set the name and cash properties of the objects joe and bob
        }

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            bankCashLabel.Text = "The Bank has $" + bank;
        }
        //this method updates the three labels on the form by setting their text property.

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank = bank - joe.ReceiveCash(10);
                UpdateForm();
            }
            //when the button is clicked, the ReceieveCash method is called on the object Guy, it passed the parameter amount of 10
            //so long as the bank has a value greater than 10. If the amount is value, it then also called updateform

            else
            {
                MessageBox.Show("The Bank is out of dollars!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank = bank + bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesBob_Click(object sender, EventArgs e)
        {
            if (joe.Cash >= 10)
            {
                joe.GiveCash(10);
                bob.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Joe's wallet is looking empty. He doesn't have enough dollars!");
            }
        }

        private void bobGivesJoe_Click(object sender, EventArgs e)
        {
            if (bob.Cash >= 5)
            {
                bob.GiveCash(5);
                joe.ReceiveCash(5);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bob's wallet is looking empty. He doesn't have enough dollars!");
            }
        }
    }
}
