using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_24
{
    public class DeletedAccount : Account, ICloneable
    {
        public string ReasonForDeletion { get; set; }

        public DeletedAccount(int id, string email, string login, string pass, DateTime registrationDate, string reasonForDeletion)
            : base(id, email, login, pass, registrationDate)
        {
            ReasonForDeletion = reasonForDeletion;
        }

        public DeletedAccount(Account account, string reasonForDeletion)
            : base(account.Id, account.Email, account.Login, account.Pass, account.RegistrationDate)
        {
            ReasonForDeletion = reasonForDeletion;
        }

        public object Clone()
        {
            return new DeletedAccount(base.Clone() as Account, ReasonForDeletion);
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Reason for deletion: {ReasonForDeletion}");
        }
    }
}
