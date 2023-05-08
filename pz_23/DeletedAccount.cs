using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    public class DeletedAccount : Account
    {
        public string DeletionReason { get; set; }

        public DeletedAccount(int id, string email, string login, string pass, DateTime registrationDate, string deletionReason)
            : base(id, email, login, pass, registrationDate)
        {
            DeletionReason = deletionReason;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Deletion reason: {DeletionReason}");
        }
    }
}
