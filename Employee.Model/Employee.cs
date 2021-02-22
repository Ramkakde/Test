using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Model
{ 
	/// <summary>
   /// Model Employee.
   /// </summary>
	public class Employee
    {
		/// <summary>
		/// EmployeeId
		/// </summary>
		public int EmployeeId { get; set; }
		/// <summary>
		/// FirstName
		/// </summary>
		[Required]
		[MaxLength(50)]
		public string FirstName { get; set; }
		/// <summary>
		/// MiddleName
		/// </summary>
		[Required]
		[MaxLength(50)]
		public string MiddleName { get; set; }
		/// <summary>
		///  Surname
		/// </summary>
		[Required]
		[MaxLength(40)]
		public string Surname { get; set; }
		/// <summary>
		///  EmailAddress
		/// </summary>
		[Required]
		[MaxLength(100)]
		public string EmailAddress { get; set; }

		/// <summary>
		///  IsDeleted
		/// </summary>
		public bool IsDeleted { get; set; }

		
	}
}
