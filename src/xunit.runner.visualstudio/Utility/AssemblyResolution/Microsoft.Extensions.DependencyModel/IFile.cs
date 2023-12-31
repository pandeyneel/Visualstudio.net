#nullable disable

// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if NETFRAMEWORK || NETCOREAPP

using System.IO;

namespace Internal.Microsoft.Extensions.DependencyModel
{
	internal interface IFile
	{
		bool Exists(string path);

		string ReadAllText(string path);

		Stream OpenRead(string path);

		Stream OpenFile(
			string path,
			FileMode fileMode,
			FileAccess fileAccess,
			FileShare fileShare,
			int bufferSize,
			FileOptions fileOptions);

		void CreateEmptyFile(string path);
	}
}

#endif
