﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by AsyncGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Collections;
using System.Collections.Generic;
using NHibernate.Engine;
using NHibernate.Engine.Query;
using NHibernate.Hql;
using NHibernate.Multi;
using NHibernate.Proxy;
using NHibernate.Transform;
using NHibernate.Type;
using NHibernate.Util;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace NHibernate.Impl
{
	public abstract partial class AbstractQueryImpl : IQuery
	{

		#region Execution methods

		public abstract Task<int> ExecuteUpdateAsync(CancellationToken cancellationToken = default(CancellationToken));
		public abstract Task<IEnumerable> EnumerableAsync(CancellationToken cancellationToken = default(CancellationToken));
		public abstract Task<IEnumerable<T>> EnumerableAsync<T>(CancellationToken cancellationToken = default(CancellationToken));
		public abstract Task<IList> ListAsync(CancellationToken cancellationToken = default(CancellationToken));
		public abstract Task ListAsync(IList results, CancellationToken cancellationToken = default(CancellationToken));
		public abstract Task<IList<T>> ListAsync<T>(CancellationToken cancellationToken = default(CancellationToken));
		public async Task<T> UniqueResultAsync<T>(CancellationToken cancellationToken = default(CancellationToken))
		{
			cancellationToken.ThrowIfCancellationRequested();
			object result = await (UniqueResultAsync(cancellationToken)).ConfigureAwait(false);
			if (result == null && typeof(T).IsValueType)
			{
				return default(T);
			}
			else
			{
				return (T)result;
			}
		}

		public async Task<object> UniqueResultAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			cancellationToken.ThrowIfCancellationRequested();
			return UniqueElement(await (ListAsync<object>(cancellationToken)).ConfigureAwait(false));
		}

		#endregion
	}
}
