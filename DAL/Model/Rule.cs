using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    //inicio da classse Rule
    public class Rule
    {
        //atributos
        public int Id { get; set; }
        public string name { get; set; }
        public IsAtivo Active { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Modified_at { get; set; }

    } // fim classe Rule
}
