// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.Owin.Host.SystemWeb.Infrastructure;
using Owin;
using Owin.Loader;

namespace Microsoft.Owin.Host.SystemWeb
{
    internal static class OwinBuilder
    {
        internal static bool IsAutomaticAppStartupEnabled {
            get {
                string autoAppStartup = ConfigurationManager.AppSettings[Constants.OwinAutomaticAppStartup];
                return string.IsNullOrWhiteSpace(autoAppStartup)
                    || string.Equals("true", autoAppStartup, StringComparison.OrdinalIgnoreCase);
            }
        }

        internal static Action<IAppBuilder> GetAppStartup() {
            string appStartup = ConfigurationManager.AppSettings[Constants.OwinAppStartup];

            var loader = new DefaultLoader(new ReferencedAssembliesWrapper());
            IList<string> errors = new List<string>();
            Action<IAppBuilder> startup = loader.Load(appStartup ?? string.Empty, errors);

            if (startup == null) {
                throw new EntryPointNotFoundException("The following errors occurred while attempting to load the app."
                    + Environment.NewLine + " - " + string.Join(Environment.NewLine + " - ", errors)
                    + (IsAutomaticAppStartupEnabled ? Environment.NewLine + "To disable OWIN startup discovery, add the appSetting owin:AutomaticAppStartup with a value of \"false\" in your web.config." : string.Empty)
                    + Environment.NewLine + "To specify the OWIN startup Assembly, Class, or Method, add the appSetting owin:AppStartup with the fully qualified startup class or configuration method name in your web.config.");
            }
            return startup;
        }

        internal static OwinAppContext Build() {
            Action<IAppBuilder> startup = GetAppStartup();
            return Build(startup);
        }

        internal static OwinAppContext Build(Func<IDictionary<string, object>, Task> app) {
            return Build(builder => builder.Use(new Func<object, object>(_ => app)));
        }

        internal static OwinAppContext Build(Action<IAppBuilder> startup) {
            if (startup == null) {
                throw new ArgumentNullException("startup");
            }

            var appContext = new OwinAppContext();
            appContext.Initialize(startup);
            return appContext;
        }
    }
}