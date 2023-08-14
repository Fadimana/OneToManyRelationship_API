using DataAcess.Layer.Entity;
using DataAcess.Layer.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Layer.Contrete
{
    public class DepartmanRepository : IDepartmanRepository

    {
        private readonly SirketDB _context;

        public DepartmanRepository(SirketDB context)
        {
            _context = context;
        }
        public async Task<Departman> CreateDepartman(string DNAME,string CNAME)
        {
            //Departman departman1 = new Departman();
            //Calisan calisan1 = new Calisan();
            //departman1.DepartmanName = departman.DepartmanName;
            //departman1.Calisanlar.Add(new() { CalisanName = calisan1.CalisanName });

            //await _context.AddAsync(departman1);
            //await _context.SaveChangesAsync();
            //return departman1;  

            Departman departman1 = new()
            {
                DepartmanName = DNAME,
                Calisanlar = new HashSet<Calisan>() { new() { CalisanName= CNAME} }

            };
            await _context.AddAsync(departman1);
            await _context.SaveChangesAsync();

            return departman1;
        }

        public async Task DeleteDepartman(int DID, int CID)
        {
           Departman dep2=await _context.Departmanlar.Include(c=>c.Calisanlar)
                .FirstOrDefaultAsync(b=>b.Id==DID);
            Calisan calisan=dep2.Calisanlar.FirstOrDefault(b=>b.Id==CID);
            _context.Calisanlar.Remove(calisan);
            await _context.SaveChangesAsync();
            
        }

        public async Task<List<Departman>> GetAllDepartman()
        {
            //  return await _context.Departmanlar.Include(x=>x.Calisan).ToListAsync()
            var departman =await  _context.Departmanlar.Include(c=>c.Calisanlar).ToListAsync();
            return departman;

        }

        public async Task<Departman> GetDepartman(int id)
        {
          // return await _context.Departmanlar.Include(c => c.Calisanlar).FirstOrDefaultAsync(x => x.Id == id); BÖYLE ÇALIŞMIYOR
            return await _context.Departmanlar.Include(c => c.Calisanlar).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Departman> UpdateDepartman(int DID,int CID,string name)
        {
            Departman dep=await _context.Departmanlar.Include(b=>b.Calisanlar)
                .FirstOrDefaultAsync(b=>b.Id==DID);

            Calisan calisan1=dep.Calisanlar.FirstOrDefault(x=>x.Id==CID);
            _context.Calisanlar.Remove(calisan1);
            dep.Calisanlar.Add(new() { CalisanName = name });

            await _context.SaveChangesAsync();

            return dep;


        }
    }
}
