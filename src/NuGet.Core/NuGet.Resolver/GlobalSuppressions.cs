﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Build", "CA1000:Do not declare static members on generic types", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Resolver.CombinationSolver`1.FindSolution(System.Collections.Generic.IEnumerable{System.Collections.Generic.IEnumerable{`0}},System.Collections.Generic.IComparer{`0},System.Func{`0,`0,System.Boolean},System.Action{System.Collections.Generic.IEnumerable{`0}})~System.Collections.Generic.IEnumerable{`0}")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object)' could vary based on the current user's locale settings. Replace this call in 'PackageResolver.Resolve(PackageResolverContext, CancellationToken)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Resolver.PackageResolver.Resolve(NuGet.Resolver.PackageResolverContext,System.Threading.CancellationToken)~System.Collections.Generic.IEnumerable{NuGet.Packaging.Core.PackageIdentity}")]
[assembly: SuppressMessage("Build", "CA1822:Member Resolve does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Resolver.PackageResolver.Resolve(NuGet.Resolver.PackageResolverContext,System.Threading.CancellationToken)~System.Collections.Generic.IEnumerable{NuGet.Packaging.Core.PackageIdentity}")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'ResolverComparer.ResolverComparer(DependencyBehavior dependencyBehavior, HashSet<PackageIdentity> preferredVersions, HashSet<string> targetIds)', validate parameter 'preferredVersions' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Resolver.ResolverComparer.#ctor(NuGet.Resolver.DependencyBehavior,System.Collections.Generic.HashSet{NuGet.Packaging.Core.PackageIdentity},System.Collections.Generic.HashSet{System.String})")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'int ResolverComparer.Compare(ResolverPackage x, ResolverPackage y)', validate parameter 'y' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Resolver.ResolverComparer.Compare(NuGet.Resolver.ResolverPackage,NuGet.Resolver.ResolverPackage)~System.Int32")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'List<List<ResolverPackage>> ResolverInputSort.TreeFlatten(List<List<ResolverPackage>> grouped, PackageResolverContext context)', validate parameter 'grouped' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Resolver.ResolverInputSort.TreeFlatten(System.Collections.Generic.List{System.Collections.Generic.List{NuGet.Resolver.ResolverPackage}},NuGet.Resolver.PackageResolverContext)~System.Collections.Generic.List{System.Collections.Generic.List{NuGet.Resolver.ResolverPackage}}")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'ResolverPackage.ResolverPackage(PackageDependencyInfo info, bool listed, bool absent)', validate parameter 'info' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Resolver.ResolverPackage.#ctor(NuGet.Packaging.Core.PackageDependencyInfo,System.Boolean,System.Boolean)")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object, object, object)' could vary based on the current user's locale settings. Replace this call in 'ResolverPackage.ResolverPackage(string, NuGetVersion, IEnumerable<PackageDependency>, bool, bool)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Resolver.ResolverPackage.#ctor(System.String,NuGet.Versioning.NuGetVersion,System.Collections.Generic.IEnumerable{NuGet.Packaging.Core.PackageDependency},System.Boolean,System.Boolean)")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'IEnumerable<ResolverPackage> ResolverUtility.FindFirstCircularDependency(IEnumerable<ResolverPackage> solution)', validate parameter 'solution' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Resolver.ResolverUtility.FindFirstCircularDependency(System.Collections.Generic.IEnumerable{NuGet.Resolver.ResolverPackage})~System.Collections.Generic.IEnumerable{NuGet.Resolver.ResolverPackage}")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'bool ResolverUtility.IsDependencySatisfied(PackageDependency dependency, PackageIdentity package)', validate parameter 'dependency' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Resolver.ResolverUtility.IsDependencySatisfied(NuGet.Packaging.Core.PackageDependency,NuGet.Packaging.Core.PackageIdentity)~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1032:Add the following constructor to NuGetResolverConstraintException: public NuGetResolverConstraintException().", Justification = "<Pending>", Scope = "type", Target = "~T:NuGet.Resolver.NuGetResolverConstraintException")]
[assembly: SuppressMessage("Build", "CA1032:Add the following constructor to NuGetResolverException: public NuGetResolverException(string message, Exception innerException).", Justification = "<Pending>", Scope = "type", Target = "~T:NuGet.Resolver.NuGetResolverException")]
[assembly: SuppressMessage("Build", "CA2237:Add [Serializable] to NuGetResolverException as this type implements ISerializable", Justification = "<Pending>", Scope = "type", Target = "~T:NuGet.Resolver.NuGetResolverException")]
[assembly: SuppressMessage("Build", "CA1032:Add the following constructor to NuGetResolverInputException: public NuGetResolverInputException().", Justification = "<Pending>", Scope = "type", Target = "~T:NuGet.Resolver.NuGetResolverInputException")]
