using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    class DeletedAccount : Account
    {
        private string _deletionReason;

        public string DeletionReason
        {
            get { return _deletionReason; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Deletion reason cannot be empty or whitespace.");
                }
                _deletionReason = value;
            }
        }

        public DeletedAccount(int id, string email, string login, string pass, DateTime registrationDate, string deletionReason)
            : base(id, email, login, pass, registrationDate)
        {
            DeletionReason = deletionReason;
        }

        public override string PrintInfo()
        {
            return base.PrintInfo() + $", Deletion reason: {DeletionReason}";
        }
    }
}
