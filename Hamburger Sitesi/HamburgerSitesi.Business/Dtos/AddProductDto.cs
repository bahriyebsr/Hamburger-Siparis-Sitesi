﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerSitesi.Business.Dtos
{
	public class AddProductDto
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal? UnitPrice { get; set; }
		public int UnitsInStock { get; set; }
		public int CategoryId { get; set; }
		public string ImagePath { get; set; }
	}
}
