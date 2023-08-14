using DataAcess.Layer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Layer.Interface
{
    public interface IDepartmanBusiness
    {
        Task<Departman> CreateDepartman(string DNAME,string CNAME);
        Task<List<Departman>> GetAllDepartman();
        Task<Departman> UpdateDepartman(int dID, int CId,string name);
        Task DeleteDepartman(int DID, int CID);
        Task<Departman> GetDepartman(int id);

    }
}
