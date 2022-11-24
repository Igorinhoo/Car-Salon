﻿using Microsoft.EntityFrameworkCore;

namespace CarSalon.Web.Data.Repositories
{
    public interface IBrandRepository
    {
        ICollection<BrandEntity> All();
        int Count();
        BrandEntity One(int id);
        bool Add(BrandEntity entity);

    }

    public class BrandRepository : IBrandRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public BrandRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public BrandEntity One(int id)
        {
            return _dbContext.Brands.Include(n => n.Models).FirstOrDefault(n => n.Id == id) ?? new BrandEntity();
        }
        public bool Add(BrandEntity entity)
        {
            _dbContext.Brands.Add(entity);

            return _dbContext.SaveChanges() > 0;
        }

        public ICollection<BrandEntity> All()
        {
            return _dbContext.Brands
                .Include(n => n.Models)
                .Select(n => n)
                .ToList();
        }

        public int Count()
        {
            return _dbContext.Brands.Count();
        }

    }
}