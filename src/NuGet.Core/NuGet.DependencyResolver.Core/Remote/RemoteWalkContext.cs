// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using NuGet.Common;
using NuGet.Frameworks;
using NuGet.LibraryModel;
using NuGet.Protocol.Core.Types;

namespace NuGet.DependencyResolver
{
    public class RemoteWalkContext
    {
        public RemoteWalkContext(SourceCacheContext cacheContext, ILogger logger)
        {
            CacheContext = cacheContext ?? throw new ArgumentNullException(nameof(cacheContext));
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));

            ProjectLibraryProviders = new List<IDependencyProvider>();
            LocalLibraryProviders = new List<IRemoteDependencyProvider>();
            RemoteLibraryProviders = new List<IRemoteDependencyProvider>();

            FindLibraryEntryCache = new ConcurrentDictionary<LibraryRangeCacheKey, Task<GraphItem<RemoteResolveResult>>>();

            LockFileLibraries = new Dictionary<LockFileCacheKey, IList<LibraryIdentity>>();

            CentralPackageVersions = new Dictionary<NuGetFramework, Dictionary<string, CentralPackageVersion>>();
        }

        public SourceCacheContext CacheContext { get; }
        public ILogger Logger { get; }

        public IList<IDependencyProvider> ProjectLibraryProviders { get; }
        public IList<IRemoteDependencyProvider> LocalLibraryProviders { get; }
        public IList<IRemoteDependencyProvider> RemoteLibraryProviders { get; }

        /// <summary>
        /// Packages lock file libraries to be used while generating restore graph.
        /// </summary>
        public IDictionary<LockFileCacheKey, IList<LibraryIdentity>> LockFileLibraries { get; }

        /// <summary>
        /// Library entry cache.
        /// </summary>
        public ConcurrentDictionary<LibraryRangeCacheKey, Task<GraphItem<RemoteResolveResult>>> FindLibraryEntryCache { get; }

        /// <summary>
        /// True if this is a csproj or similar project. Xproj should be false.
        /// </summary>
        public bool IsMsBuildBased { get; set; }

        /// <summary>
        /// The collection of central package versions.
        /// </summary>
        public Dictionary<NuGetFramework, Dictionary<string, CentralPackageVersion>> CentralPackageVersions { get; }
    }
}
