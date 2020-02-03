using EminentTest.Abstraction.DataAccess;
using EminentTest.Abstraction.Service.Data;
using EminentTest.DB.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EminentTest.Abstraction.Repository
{
    public class EquipmentRepository : IEquipmentDataService
    {
        private readonly EminentTestContext _context;
        public EquipmentRepository(EminentTestContext context)
        {
            _context = context;
        }
        public async Task<Guid> AddEquipment(Equipment model)
        {
            Guid id = Guid.Empty;
            try
            {
                model.Id = Guid.NewGuid();
                await _context.AddAsync<Equipment>(model);
                await _context.SaveChangesAsync();
                id = model.Id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return id;
        }

        public async Task DeleteEquipment(Guid id)
        {
            var equipment = await _context.Equipments.FindAsync(id);
            if (equipment != null)
            {
                _context.Equipments.Remove(equipment);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Equipment> GetEquipment(Guid id)
        {
            var equipment = await _context.Equipments.FindAsync(id);
            return equipment;
        }

        public async Task<IEnumerable<Equipment>> GetEquipments()
        {
            var result = await _context.Equipments.ToListAsync();
            return result;
        }

        public async Task<IEnumerable<Equipment>> SearchEquipment(string name, int status, int type)
        {
            try
            {
                var result = await  _context.Equipments.Where(x =>
               (name == String.Empty || x.Name.Contains(name)) && 
               (status == 0 || status == x.Status) &&
               (type == 0 || type == x.Type)).ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Guid> UpdateEquipment(Equipment model)
        {
            var equipment = await _context.Equipments.FindAsync(model.Id);
            if (equipment != null)
            {
                equipment.Name = model.Name;
                equipment.Status = model.Status;
                equipment.StatusName = model.StatusName;
                equipment.Type = model.Type;
                equipment.TypeName = model.TypeName;

                _context.Equipments.Update(equipment);
                await _context.SaveChangesAsync();
            }
            return equipment.Id;
        }
    }
}
