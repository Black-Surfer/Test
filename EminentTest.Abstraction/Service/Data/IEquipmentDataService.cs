using EminentTest.DB.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EminentTest.Abstraction.Service.Data
{
    public interface IEquipmentDataService
    {
        Task<Guid> AddEquipment(Equipment model);
         Task<IEnumerable<Equipment>> GetEquipments();
         Task<IEnumerable<Equipment>> SearchEquipment(string name, int status, int type);
         Task<Equipment> GetEquipment(Guid id);
         Task<Guid> UpdateEquipment(Equipment model);
         Task DeleteEquipment(Guid id);

    }
}
