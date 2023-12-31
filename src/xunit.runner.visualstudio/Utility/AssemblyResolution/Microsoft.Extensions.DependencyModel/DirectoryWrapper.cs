#nullable disable

// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if NETFRAMEWORK || NETCOREAPP

using System.IO;

namespace Internal.Microsoft.Extensions.DependencyModel
{
	internal class DirectoryWrapper : IDirectory
	{
		public bool Exists(string path)
		{
			return Directory.Exists(path);
		}
	}
}

#endif
