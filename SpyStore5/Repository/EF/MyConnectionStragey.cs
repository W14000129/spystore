﻿using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Storage;

namespace Repository.EF
{
	public class MyExecutionStrategy : ExecutionStrategy
	{
		public MyExecutionStrategy(ExecutionStrategyDependencies context) :
			base(context, ExecutionStrategy.DefaultMaxRetryCount,
				ExecutionStrategy.DefaultMaxDelay)
		{

		}

		public MyExecutionStrategy(ExecutionStrategyDependencies context,
			int maxRetryCount,
			TimeSpan maxRetryDelay) : base(context, maxRetryCount, maxRetryDelay)
		{

		}
		protected override bool ShouldRetryOn(Exception exception)
		{
			return true;
		}
	}
}