using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface IRollingStock
    {        
/// <returns>Возвращает максимально допустимую скорость для подвижного состава</returns>
        int GetMaxSpeed(); 


 /// <returns>Возвращает вес подвижного состава в тоннах</returns>
        float GetWeight();
    }
}
