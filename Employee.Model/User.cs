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
	public class User
	{
		/// <summary>
		/// UserId
		/// </summary>
		[Required]
		[MaxLength(50)]
		public string UserId { get; set; }
		/// <summary>
		/// Password
		/// </summary>
		[Required]
		[MaxLength(50)]
		public string Password { get; set; }

		/// <summary>
		/// UserRole
		/// </summary> 
		public string Role { get; set; }
	}
}
