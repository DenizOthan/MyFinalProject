using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    internal class ErrorDataResult<T> : IDataResult<List<Product>>
    {
        private object maintenanceTime;

        public ErrorDataResult(object maintenanceTime)
        {
            this.maintenanceTime = maintenanceTime;
        }
    }
}