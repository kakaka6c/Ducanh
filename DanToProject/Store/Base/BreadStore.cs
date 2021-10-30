namespace DanToProject
{
    public abstract class BreadStore
    {
        public void OrderPizza(string type)
        {
            Bread bread;
            bread = Createbread(type);

            bread.Prepare();
            bread.Bake();
            bread.Pack();
           
        }

        protected abstract Bread Createbread(string type);
    }
}