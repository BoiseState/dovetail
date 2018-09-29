using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dovetail
{
    /// <summary>
    /// A Dovetail user/employee
    /// </summary>
    public class DovetailUser
    {
        /// <summary>
        /// Username of Ashby's Cabinetry employee
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Password of Ashby's Cabinetry employee
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// First name of Ashby's Cabinetry employee
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name of Ashby's Cabinetry employee
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email address of Ashby's Cabinetry employee
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// User type of Ashby's Cabinetry employee (admin/employee)
        /// </summary>
        public string UserType { get; set; }
        /// <summary>
        /// Whether Ashby's Cabinetry employee has access to Dovetail software (true/false)
        /// </summary>
        public bool HasAccess { get; set; }

        /// <summary>
        /// Create a new Dovetail user/employee
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="userType"></param>
        /// <param name="hasAccess"></param>
        public DovetailUser(string username, string password, string firstName, string lastName, string email, string userType, bool hasAccess)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UserType = userType;
            HasAccess = hasAccess;
        }

        /// <summary>
        /// Create a new Dovetail user/employee with basic login info
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public DovetailUser(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
