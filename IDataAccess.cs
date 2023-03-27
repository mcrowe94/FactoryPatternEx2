using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEx2
{
    public interface IDataAccess
    {
        public List<Product> LoadData();

        public void SaveData();
    }
}
