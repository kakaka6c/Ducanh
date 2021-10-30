using System;
namespace DanToProject
{
    public class SGBreadStore:BreadStore
    {
        protected override Bread Createbread(string type)
        {
            switch (type)
            {
                case "mixed":
                    return new SGMixedBread();
                case "pate":
                    return new SGPateBread();
                case "garlic":
                    return new SGGarlicBread();
                default:
                    return null;
            }
        }
    }
}