namespace DesignPatterns.Behavioral.COR
{
    public class Manager : Approver
    {
        public override string ApproveBill(decimal amount)
        {
            if (amount <= 5000)
            {
                return "Your bill is approved by manager";
            }
            else if (Next != null)
                return Next.ApproveBill(amount);
            else
                return "Your bill can not approve";
        }
    }
}

