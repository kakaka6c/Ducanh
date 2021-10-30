namespace DanToProject
{
    public class DNBreadStore:BreadStore
    {
        protected override Bread Createbread(string type)
        {
            switch (type)
            {
                case "mixed":
                    return new DNMixedBread();
                case "pate":
                    return new DNPateBread();
                case "garlic":
                    return new DNGarlicBread();
                default:
                    return null;
            }
        }
    }
}