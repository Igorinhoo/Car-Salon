﻿using CarSalon.Web.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CarSalon.Web.Data.Repositories
{
    public interface IEquipmentRepository
    {
        ICollection<EquipmentEntity> All(int modelId);
        ICollection<EquipmentEntity> All();
        int Count();
        EquipmentEntity One(int id);
        bool Add(EquipmentEntity entity);
        EquipmentEntity Edit(EquipmentEntity entity);
        bool Delete(int id);

    }

    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EquipmentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public EquipmentEntity One(int id)
        {
            return _dbContext.Equipment.FirstOrDefault(n => n.Id == id) ?? new EquipmentEntity();
        }
        public bool Add(EquipmentEntity entity)
        {
            _dbContext.Equipment.Add(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public ICollection<EquipmentEntity> All(int modelId)
        {
            return _dbContext.Model_Equipment.Where(p => p.ModelId == modelId).Select(n => n.equipment).ToList();
        }

        public int Count()
        {
            return _dbContext.Equipment.Count();
        }

        public ICollection<EquipmentEntity> All()
        {
            return _dbContext.Equipment.Select(n => n).ToList();
        }

        public EquipmentEntity Edit(EquipmentEntity entity)
        {
            var dbEntity = One(entity.Id);

            dbEntity.Name = entity.Name;

            _dbContext.Equipment.Update(dbEntity);
            _dbContext.SaveChanges();

            return dbEntity;
        }

        public bool Delete(int id)
        {
            var entity = One(id);
            _dbContext.Equipment.Remove(entity);

            return _dbContext.SaveChanges() > 0;
        }
    }
}
