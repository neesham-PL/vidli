using System.Collections.Generic;

namespace vidli.Dto
{
    public class NewRentalDTO
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}