﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class City
	{
		[Key]
		public int CityId { get; set; }
		public string CityName { get; set; }

        
    }
}
