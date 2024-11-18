using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class Basket
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int ProductId { get; set; }
        
    }
}
