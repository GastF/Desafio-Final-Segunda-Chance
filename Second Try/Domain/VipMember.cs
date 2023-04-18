using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class VipMember : Member
    {
        private decimal monthlyInstallment;

        public VipMember(string name, string lastName, int id, decimal monthlyInstallment)
            : base(name, lastName, id, true)
        {
            this.monthlyInstallment = monthlyInstallment;
        }

        
    }
}
