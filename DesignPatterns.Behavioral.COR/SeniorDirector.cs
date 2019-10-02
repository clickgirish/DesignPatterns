namespace DesignPatterns.Behavioral.COR
{
    public class SeniorDirector : Approver
    {
        public override string ApproveBill(decimal amount)
        {
            if (amount <= 50000)
            {
                return "Your bill is approved by Senior Director";
            }
            else if (Next != null)
                return Next.ApproveBill(amount);
            else
                return "Your bill can not approve";

        }
    }
}

