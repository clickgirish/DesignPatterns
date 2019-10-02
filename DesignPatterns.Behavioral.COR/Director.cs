namespace DesignPatterns.Behavioral.COR
{
    public class Director : Approver
    {
        public override string ApproveBill(decimal amount)
        {
            if (amount <= 25000)
            {
                return "Your bill is approved by Director";
            }
            else if (Next != null)
              return  Next.ApproveBill(amount);
            else
                return "Your bill can not approve";
        }
    }
}

