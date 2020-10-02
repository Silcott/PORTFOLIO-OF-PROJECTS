using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.DTOs
{
    //a data transfer object (DTO) is an object that carries data between processes.
    //The motivation for its use is that communication between processes is usually
    //done resorting to remote interfaces (e.g., web services), where each call is
    //an expensive operation
    public class AuthorDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }

        public virtual IList<BookDTO> Books { get; set; }
    }
}
