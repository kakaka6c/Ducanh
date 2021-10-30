namespace DanToProject
{
    public class HueBreadStore:BreadStore
    {
        protected override Bread Createbread(string type)
        {
            switch (type)
            {
                case "mixed":
                    return new HueMixedBread();
                case "pate":
                    return new HuePateBread();
                case "garlic":
                    return new HueGarlicBread();
                default:
                    return null;
            }
        }
    }
}