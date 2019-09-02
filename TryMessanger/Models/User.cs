using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TryMessanger.Models
{
    public class User
    {
        string Id { get; set; }
        string Name { get; set; }
        public User()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
