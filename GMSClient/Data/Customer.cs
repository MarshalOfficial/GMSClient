using System;
namespace GMSClient.Data
{
    public class Customer
    {
        public long ID { get; set; }

        public long AccountTypeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? Birthdate { get; set; }

        public bool Gender { get; set; }

        public DateTime CreateDate { get; set; }

        public string Mobile { get; set; }

        public string Tel { get; set; }

        public string PostalCode { get; set; }

        public string Email { get; set; }

        public string Telegram { get; set; }

        public string Instagram { get; set; }

        public string Address { get; set; }

        public DateTime? JoinDate { get; set; }

        public long? MembershipJoinTypeID { get; set; }

        public long? Referral { get; set; }

        public long? JobID { get; set; }

        public long? VisitorID { get; set; }

        public string FullName { get; set; }

        public bool IsDeleted { get; set; }

        public string JobTitle { get; set; }

        public string MembershipJoinTypeTitle { get; set; }

        public string ReferralFullName { get; set; }

        public string VisitorFullName { get; set; }

        public string CreateDateFa { get; set; }

        public string JoinDateFa { get; set; }

        public string GenderFa { get { return Gender ? "مرد" : "زن"; } }
    }
}
