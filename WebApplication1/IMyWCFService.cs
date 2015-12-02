using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebApplication1
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IMyWCFService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IMyWCFService
    {
        [OperationContract]

        string CountryByCode(string isocode);
    }
}
