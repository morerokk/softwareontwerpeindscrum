﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEindOpdrachtScrum.Scrum
{
	class ItemTodo : ItemState
	{
		public override ItemState Start()
		{
			return new ItemInProgress();
		}
	}
}
