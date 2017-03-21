using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAbstractJan242017
{
    abstract class Account
    {
        private string userName;
        private string password;
        public float balance;

        public float Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public abstract void ChangePassword();
 
        public virtual float Deposit(float depositAmount)
        {
            this.balance += depositAmount;
            return balance;
        }

        public virtual float Withdraw(float withdrawAmount)
        {
            this.balance -= withdrawAmount;
            return balance;
        }

        public virtual void CheckBalance()
        {
            Console.WriteLine("Your account balance is ${0}", balance);
        }
    }
}
