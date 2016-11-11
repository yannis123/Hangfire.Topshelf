﻿using System;
using System.Collections.Generic;

namespace Hangfire.Topshelf.Core
{
	public interface IRecurringJobBuilder
	{
		/// <summary>
		/// Build(Create) RecurringJob automatically.
		/// </summary>
		/// <param name="typesProvider"></param>
		void Build(Func<IEnumerable<Type>> typesProvider);
	}
}