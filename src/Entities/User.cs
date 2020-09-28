using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Poc
{
    [Table("USERS")]
    public class User
    {
        public byte[] BLOB { get; set; }
        public List<Car> CARS { get; set; }
        public bool DELETED { get; set; }
        public int ID { get; set; }
        public string NAME { get; set; }
        public DateTime? UPDATED_AT { get; set; }
    }
}