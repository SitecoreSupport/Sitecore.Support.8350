namespace Sitecore.Support.XA.Foundation.Multisite.Pipelines.HttpRequest
{
    using Sitecore.Pipelines.HttpRequest;

    public class StoreSiteNameInCookie : Sitecore.XA.Foundation.Multisite.Pipelines.HttpRequest.StoreSiteNameInCookie
    {
        public override void Process(HttpRequestArgs args)
        {
            if (args.Context.Request.UrlReferrer == null || !args.Context.Request.UrlReferrer.Query.Contains("xmlcontrol=")) // don't change cookies if the request comes from an XML control
            {
                base.Process(args);
            }
        }
    }
}