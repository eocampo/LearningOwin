using System;

namespace SharedResourceNamespace
{
    internal class LoaderResources
    {
        internal static string AssemblyNotFound {
            get {
                return "For the app startup parameter value '{0}', the assembly '{1}' was not found.";
            }
        }

        internal static string ClassNotFoundInAssembly {
            get {
                return "For the app startup parameter value '{0}', the class '{1}' was not found in assembly '{2}'.";
            }
        }

        internal static string Exception_AttributeNameConflict {
            get {
                return "The OwinStartup attribute discovered in assembly '{0}' referencing startup type '{1}' conflicts with the attribute in assembly '{2}' referencing startup type '{3}' because they have the same FriendlyName '{4}'. Remove or rename one of the attributes, or reference the desired type directly.";
            }
        }

        internal static string Exception_StartupTypeConflict {
            get {
                return "The discovered startup type '{0}' conflicts with the type '{1}'. Remove or rename one of the types, or reference the desired type directly.";
            }
        }

        internal static string FriendlyNameMismatch {
            get {
                return "The OwinStartupAttribute.FriendlyName value '{0}' does not match the given value '{1}' in Assembly '{2}'.";
            }
        }

        internal static string MethodNotFoundInClass {
            get {
                return "No '{0}' method was found in class '{1}'.";
            }
        }

        internal static string NoAssemblyWithStartupClass {
            get {
                return "No assembly found containing a Startup or [AssemblyName].Startup class.";
            }
        }

        internal static string NoOwinStartupAttribute {
            get {
                return "No assembly found containing an OwinStartupAttribute.";
            }
        }

        internal static string StartupTypePropertyEmpty {
            get {
                return "The OwinStartupAttribute.StartupType value is empty in Assembly '{0}'.";
            }
        }

        internal static string StartupTypePropertyMissing {
            get {
                return "The type '{0}' referenced from assembly '{1}' does not define a property 'StartupType' of type 'Type'.";
            }
        }

        internal static string TypeOrMethodNotFound {
            get {
                return "The given type or method '{0}' was not found. Try specifying the Assembly.";
            }
        }

        internal static string UnexpectedMethodSignature {
            get {
                return "The '{0}' method on class '{1}' does not have the expected signature 'void {0}(IAppBuilder)'.";
            }
        }
    }
}