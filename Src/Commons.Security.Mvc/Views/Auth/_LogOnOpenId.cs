﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BoC.Security.Mvc.Views.Auth
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Collections;
    using System.Collections.Specialized;
    using System.ComponentModel.DataAnnotations;
    using System.Configuration;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Web.Caching;
    using System.Web.DynamicData;
    using System.Web.SessionState;
    using System.Web.Profile;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    using System.Xml.Linq;
    using DotNetOpenAuth.Mvc;
    using DotNetOpenAuth.OpenId.RelyingParty;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MvcRazorClassGenerator", "1.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Auth/_LogOnOpenId.cshtml")]
    public class _Page_Views_Auth__LogOnOpenId_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
#line hidden

        public _Page_Views_Auth__LogOnOpenId_cshtml()
        {
        }
        protected System.Web.HttpApplication ApplicationInstance
        {
            get
            {
                return ((System.Web.HttpApplication)(Context.ApplicationInstance));
            }
        }
        public override void Execute()
        {



WriteLiteral("\n    <div>\n        <fieldset>\n            <legend>Login using an account you alre" +
"ady use.</legend>\n");


 using (Html.BeginForm("OpenId", "Auth")) {
    
Write(Html.Hidden("ReturnUrl", Request.QueryString["ReturnUrl"], new { id = "ReturnUrl" }));

                                                                                         
    
Write(Html.Hidden("openid_openidAuthData"));

                                         

WriteLiteral("    <div>\n    ");


Write(MvcHtmlString.Create(Html.OpenIdSelector(new SelectorButton[] {
        new SelectorProviderButton("http://www.hyves.nl/", Url.Content("~/Content/images/hyves.gif")),
	    new SelectorProviderButton("https://me.yahoo.com/", Url.Content("~/Content/images/yahoo.gif")),
	    new SelectorProviderButton("https://www.google.com/accounts/o8/id", Url.Content("~/Content/images/google.gif")),
	    new SelectorOpenIdButton(Url.Content("~/Content/images/openid.png")),
    })));

WriteLiteral(@"

	    <div class=""helpDoc"">
		    <p>
			    If you have logged in previously, click the same button you did last time!!
		    </p>
		    <p>
			    If you don't have an account with any of these services, just pick Google. They'll
			    help you set up an account.
		    </p>
	    </div>

    </div>
");


}

WriteLiteral("        </fieldset>\n    </div>\n");


  
    var options = new OpenIdAjaxOptions
    {
        PreloadedDiscoveryResults = (string)this.ViewData["PreloadedDiscoveryResults"],
    };
    Html.ScriptManager()
      .ScriptInclude("~/Scripts/jquery.cookie.js")
      .Script("openidselectorscripts_opener", "</script>")
      .Script("openidselectorscripts", Html.OpenIdSelectorScripts(new OpenIdSelector{DownloadYahooUILibrary = false}, options))
      .Script("openidselectorscripts_closer", "<script>");


        }
    }
}