using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAbstractJan242017
{
    class Checking: Account
    {

        public override void CheckBalance()
        {
            Console.WriteLine("Thank you for using HumbleBank Free Checking");
            base.CheckBalance();
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
    }
}
