// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using Microsoft.Owin.Infrastructure;

namespace Microsoft.Owin
{
    /// <summary>
    /// This wraps OWIN environment dictionary and provides strongly typed accessors.
    /// </summary>
    public class OwinResponse : IOwinResponse
    {
        /// <summary>
        /// Create a new context with only request and response header collections.
        /// </summary>
        public OwinResponse() {
            IDictionary<string, object> environment = new Dictionary<string, object>(StringComparer.Ordinal);
            environment[OwinConstants.RequestHeaders] = new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase);
            environment[OwinConstants.ResponseHeaders] = new Dictionary<string, string[]>(StringComparer.OrdinalIgnoreCase);
            Environment = environment;
        }

        /// <summary>
        /// Creates a new environment wrapper exposing response properties.
        /// </summary>
        /// <param name="environment">OWIN environment dictionary which stores state information about the request, response and relevant server state.</param>
        public OwinResponse(IDictionary<string, object> environment) {
            if (environment == null) {
                throw new ArgumentNullException("environment");
            }

            Environment = environment;
        }

        /// <summary>
        /// Gets the OWIN environment.
        /// </summary>
        /// <returns>The OWIN environment.</returns>
        public virtual IDictionary<string, object> Environment { get; private set; }

        /// <summary>
        /// Gets the request context.
        /// </summary>
        /// <returns>The request context.</returns>
        public virtual IOwinContext Context {
            get { return new OwinContext(Environment); }
        }

        public int StatusCode {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public string ReasonPhrase {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public string Protocol {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public long? ContentLength {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public string ContentType {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public DateTimeOffset? Expires {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public string ETag {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public Stream Body {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public void OnSendingHeaders(Action<object> callback, object state) {
            throw new NotImplementedException();
        }

        public void Redirect(string location) {
            throw new NotImplementedException();
        }

        public void Write(string text) {
            throw new NotImplementedException();
        }

        public void Write(byte[] data) {
            throw new NotImplementedException();
        }

        public void Write(byte[] data, int offset, int count) {
            throw new NotImplementedException();
        }

        public Task WriteAsync(string text) {
            throw new NotImplementedException();
        }

        public Task WriteAsync(string text, CancellationToken token) {
            throw new NotImplementedException();
        }

        public Task WriteAsync(byte[] data) {
            throw new NotImplementedException();
        }

        public Task WriteAsync(byte[] data, CancellationToken token) {
            throw new NotImplementedException();
        }

        public Task WriteAsync(byte[] data, int offset, int count, CancellationToken token) {
            throw new NotImplementedException();
        }

        public T Get<T>(string key) {
            throw new NotImplementedException();
        }

        public IOwinResponse Set<T>(string key, T value) {
            throw new NotImplementedException();
        }
    }
}