// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Threading;
using Microsoft.VisualStudio.Workspace.VSIntegration.UI;

namespace NuGet.VisualStudio.OnlineEnvironments.Client
{
    /// <summary>
    /// Extends the Solution Explorer in cloud-connected scenarios by adding command
    /// handlers for nodes representing managed projects.
    /// </summary>
    [ExportNodeExtender(CloudEnvironment.LiveShareSolutionView)]
    internal sealed class ProjectNodeExtender : INodeExtender
    {
        /// <summary>
        /// The shared command handler for all nodes representing managed projects.
        /// </summary>
        private readonly IWorkspaceCommandHandler _commandHandler;

        [ImportingConstructor]
        public ProjectNodeExtender(
            JoinableTaskContext taskContext,
            [Import(typeof(SVsServiceProvider))] IServiceProvider serviceProvider)
        {
            _commandHandler = new ProjectNodeCommandHandler(taskContext, serviceProvider);
        }

        public IChildrenSource ProvideChildren(WorkspaceVisualNodeBase parentNode)
        {
            return null;
        }

        /// <summary>
        /// Provides our <see cref="IWorkspaceCommandHandler"/> for nodes representing
        /// managed projects.
        /// </summary>
        public IWorkspaceCommandHandler ProvideCommandHandler(WorkspaceVisualNodeBase parentNode)
        {
            return _commandHandler;

            //if (NodeRepresentsAManagedProject(parentNode))
            //{
            //    return _commandHandler;
            //}

            //return null;
        }

        /// <summary>
        /// <para>
        /// This is a bit of a hack. There currently isn't a good way to determine if the
        /// <paramref name="node"/> represents a project backed by the managed project
        /// system. In the interests of getting something working, here we check if the
        /// Solution Explorer thinks the node is a project and then check that it has a
        /// supported extension.
        /// </para>
        /// <para>
        /// The _right_ way to do this probably involves getting the project GUID from the
        /// node and then running that throught the Project API to determine if the project
        /// has the appropriate capabilities. At the moment there's no good way to
        /// achieve that first step, however.
        /// </para>
        /// </summary>
        private static bool NodeRepresentsAManagedProject(WorkspaceVisualNodeBase node)
        {
            return node != null
                && node.VSSelectionMoniker != null
                && node.VSSelectionKind == CloudEnvironment.SolutionViewProjectGuid
                && node.NodeMoniker != null;
        }
    }
}
