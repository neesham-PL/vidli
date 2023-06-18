using System.Collections.Generic;
using vidli.Models;

namespace vidli.ViewModel
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        //we can also use List but we don't need all the functionalities add,remove, only iteration to be used in new customer page
        public Customer Customer { get; set; }

        public string Title
        {
            get
            {
                if (Customer != null && Customer.Id != 0)
                    return "Edit Customer";
                return "New Customer";

            }
        }
    }
}


