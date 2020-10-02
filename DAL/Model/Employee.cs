using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public int Id_rule { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Sexo Gender { get; set; }
        public IsAtivo Active { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Modified_at { get; set; }
    }
}
