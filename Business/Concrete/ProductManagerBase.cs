namespace Business.Concrete
{
    public class ProductManagerBase
    {

        public SuccesDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccesDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice <= min && p.UnitPrice <= max));
        }
    }
}