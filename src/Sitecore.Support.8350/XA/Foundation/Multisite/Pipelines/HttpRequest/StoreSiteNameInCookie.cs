namespace Sitecore.Support.XA.Foundation.Multisite.Pipelines.HttpRequest
{
    using Sitecore.Pipelines.HttpRequest;

    public class StoreSiteNameInCookie : Sitecore.XA.Foundation.Multisite.Pipelines.HttpRequest.StoreSiteNameInCookie
    {
        public override void Process(HttpRequestArgs args)
        {
          if (!args.Context.Response.HeadersWritten)
           {
            base.Process(args);
           }

        }
    }
}