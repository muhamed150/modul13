using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class User:IdentityUser<string>
    {
        public User()  { }

        public User(User user)
        {
            this.Id = user.Id;
            this.UserName = user.UserName;
            this.PasswordHash = user.PasswordHash;
            this.isAdmin = user.isAdmin;
            this.EGN = user.EGN;
            this.IsActive = user.IsActive;
            this.FirstName = user.FirstName;
            this.MiddleName = user.MiddleName;
            this.LastName = user.LastName;
            this.PhoneNumber = user.PhoneNumber;
            this.HireDate = user.HireDate;
            this.FiredDate = this.FiredDate;
        }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EGN { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? FiredDate { get; set; }
        public bool isAdmin { get; set; }
    }
}
