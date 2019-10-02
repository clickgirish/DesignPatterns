using System;

namespace DesignPatterns.Behavioral.COR
{
    public abstract class Approver
    {
        public Approver Next { get; set; }

        public abstract string ApproveBill(decimal amount);
    }
}
