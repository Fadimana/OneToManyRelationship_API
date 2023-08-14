using Business.Layer.Interface;
using DataAcess.Layer.Entity;
using DataAcess.Layer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.Contrete
{
    public class DepartmanBusiness : IDepartmanBusiness
    {
        private readonly IDepartmanRepository _departmanRepository;
        public DepartmanBusiness(IDepartmanRepository departmanRepository)
        {
            _departmanRepository = departmanRepository;
        }

        public async Task<Departman> CreateDepartman(string DNAME, string CNAME)
        {
            if (DNAME != null)
            {
                return await _departmanRepository.CreateDepartman(DNAME,CNAME);
            }
            throw new NotImplementedException();
        }

        public Task DeleteDepartman(int DID, int CID)
        {
            var delete=  _departmanRepository.DeleteDepartman(DID, CID);
            if (DID>=0 && CID>=0)
            {
                return delete;   
            }throw new NotImplementedException("Geçersiz ");
        }

        public async Task<List<Departman>> GetAllDepartman()
        {
            return await _departmanRepository.GetAllDepartman();
        }

        public async Task<Departman> GetDepartman(int id)
        {
            return await _departmanRepository.GetDepartman(id);
        }

        public async Task<Departman> UpdateDepartman(int dID, int CId, string name)
        {
            if(name !=null)
            {
                return await _departmanRepository.UpdateDepartman(dID, CId, name);
            }
            throw new NotImplementedException("Geçersiz");
            
        }
    }
}
