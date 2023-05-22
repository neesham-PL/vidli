using System;
using System.ComponentModel.DataAnnotations;

namespace vidli.Dto
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MemberShipTypeId { get; set; }

        public MembershipTypeDTO MembershipType { get; set; }

        //        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}




