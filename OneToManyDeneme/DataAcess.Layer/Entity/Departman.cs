using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Layer.Entity
{
    public class Departman //Principal
    {
        public Departman() {
            Calisanlar = new HashSet<Calisan>();
        }

        public int Id { get; set; }

        public string? DepartmanName { get; set; }

        public ICollection<Calisan> Calisanlar { get; set; }

    }
}
