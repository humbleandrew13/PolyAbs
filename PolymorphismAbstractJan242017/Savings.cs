using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAbstractJan242017
{
    class Savings: Account
    {
        const float interest = 0.016f;
        private float depositAmt;
        private float savingsBalance;

        public float SavingsBalance
        {
            get { return this.savingsBalance; }
            set { this.savingsBalance = depositAmt * interest; }
        }

        public override void ChangePassword()
        {
            string newPassword1;
            string newPassword2;

            while (true)
            {
                Console.WriteLine("Please enter a new password.");
                newPassword1 = Console.ReadLine();
                Console.WriteLine("Please reenter that password");
                newPassword2 = Console.ReadLine();

                if (newPassword1 == newPassword2)
                {
                    Password = newPassword1;
                    break;
                }
            }
        }

        public override void CheckBalance()
        {
            Console.WriteLine("Thank you for using HumbleBank Savings with 1.6% interest.");
            base.CheckBalance();
        }

    }
}
