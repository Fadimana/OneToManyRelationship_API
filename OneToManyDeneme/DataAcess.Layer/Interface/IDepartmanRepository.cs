using DataAcess.Layer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Layer.Interface
{
    public interface IDepartmanRepository
    {
        Task<Departman> CreateDepartman(string DNAME,string CNAME);
        Task<List<Departman>> GetAllDepartman();

        Task<Departman> GetDepartman(int id);

        Task<Departman> UpdateDepartman(int DID,int CID,string name);

        Task  DeleteDepartman(int DID, int CID);
    }

}
