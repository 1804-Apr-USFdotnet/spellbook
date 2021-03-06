﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spellbook.Models
{
	public class User
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int UserId { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]	// add some constraints here later
		public string Password { get; set; }

		public int? Phone { get; set; }

		public string Email { get; set; }
	}
}
