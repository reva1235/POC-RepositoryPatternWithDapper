using System.ComponentModel.DataAnnotations.Schema;

namespace Poc
{
    public enum StatusCar
    {
        Inactive = 0,

        Active = 1,

        Deleted = -1
    }

    [Table("Cars")]
    public class Car
    {
        public byte[] Data { get; set; }
        public int Id { get; set; }

        public string Name { get; set; }
        public StatusCar Status { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}