namespace DesignPatterns.Behavioral.COR
{
    public class VP : Approver
    {
        public override string ApproveBill(decimal amount)
        {
            if (amount >= 100000)
            {
                return "Your bill can not approve";
            }
            else
                return "Your bill is approved by VP";
        }
    }
}

