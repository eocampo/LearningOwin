// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Web;
using Microsoft.Owin.Host.SystemWeb;
using Microsoft.Owin.Host.SystemWeb.Infrastructure;

[assembly: PreApplicationStartMethod(typeof(PreApplicationStart), "Initialize")]

namespace Microsoft.Owin.Host.SystemWeb
{
    /// <summary>
    /// Registers the OWIN request processing module at application startup.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class PreApplicationStart
    {
        private const string TraceName = "Microsoft.Owin.Host.SystemWeb.PreApplicationStart";

        /// <summary>
        /// Registers the OWIN request processing module.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes",
            Justification = "Initialize must never throw on server startup path")]
        public static void Initialize() {
            try {
                if (OwinBuilder.IsAutomaticAppStartupEnabled) {
                    HttpApplication.RegisterModule(typeof(OwinHttpModule));
                }                
            }
            catch (Exception ex) {
                ex.ToString();
                ITrace trace = TraceFactory.Create(TraceName);
                trace.WriteError("Failed to register the OWIN module: ", ex);
                throw;
            }
        }
    }
}