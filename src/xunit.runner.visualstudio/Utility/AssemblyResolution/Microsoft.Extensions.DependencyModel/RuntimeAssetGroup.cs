#nullable disable

// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if NETFRAMEWORK || NETCOREAPP

using System.Collections.Generic;
using System.Linq;

namespace Internal.Microsoft.Extensions.DependencyModel
{
	internal class RuntimeAssetGroup
	{
		public RuntimeAssetGroup(string runtime, params string[] assetPaths) : this(runtime, (IEnumerable<string>)assetPaths) { }

		public RuntimeAssetGroup(string runtime, IEnumerable<string> assetPaths)
		{
			Runtime = runtime;
			AssetPaths = assetPaths.ToArray();
		}

		/// <summary>
		/// The runtime ID associated with this group (may be empty if the group is runtime-agnostic)
		/// </summary>
		public string Runtime { get; }

		/// <summary>
		/// Gets a list of assets provided in this runtime group
		/// </summary>
		public IReadOnlyList<string> AssetPaths { get; }
	}
}

#endif
