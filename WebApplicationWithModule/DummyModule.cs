using System;
using System.IO;
using System.Web;

namespace WebApplicationWithModule
{
    public class DummyModule : IHttpModule
    {
        public void Init(HttpApplication app)
        {
            app.BeginRequest += OnBeginRequest;
            app.EndRequest += OnEndRequest;
        }

        private static void OnBeginRequest(object sender, EventArgs e)
        {
        }

        private static void OnEndRequest(object sender, EventArgs e)
        {
        }

        public void Dispose()
        {
        }
    }
}