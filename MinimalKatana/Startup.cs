using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MinimalKatana
{
    using AppFunc = Func<IDictionary<string, object>, Task>;

    public class Startup
    {
        public AppFunc Configuration() {
            return async env => {
                var writer = new StreamWriter((Stream)env["owin.ResponseBody"]);
                await writer.WriteAsync("Hello World!");
                await writer.FlushAsync();
            };
        }
    }
}