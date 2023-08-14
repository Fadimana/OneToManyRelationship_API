using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Layer.Entity
{
    public class Calisan //Dependent
    {
        public int Id { get; set; }
        public string? CalisanName { get; set; }

        public Departman Departman { get; set; }
    }
}
