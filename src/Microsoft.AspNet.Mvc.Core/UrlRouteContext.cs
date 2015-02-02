﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNet.Mvc
{
    /// <summary>
    /// Context object to be used for the URLs that <see cref="Mvc.IUrlHelper.RouteUrl(UrlRouteContext)"/> generates.
    /// </summary>
    public class UrlRouteContext
    {
        /// <summary>
        /// The name of the route that <see cref="Mvc.IUrlHelper.RouteUrl(UrlRouteContext)" uses to generate URLs.
        /// </summary>
        public string RouteName
        {
            get;
            set;
        }

        /// <summary>
        /// The object that contains the parameters for <see cref="RouteName"/>
        /// </summary>
        public object Values
        {
            get;
            set;
        }

        /// <summary>
        /// The protocol for the URLs that <see cref="Mvc.IUrlHelper.RouteUrl(UrlRouteContext)" generates
        /// such as "http" or "https"
        /// </summary>
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>
        /// The host name for the URLs that <see cref="Mvc.IUrlHelper.RouteUrl(UrlRouteContext)" generates.
        /// </summary>
        public string Host
        {
            get;
            set;
        }

        /// <summary>
        /// The fragment for the URLs that <see cref="Mvc.IUrlHelper.RouteUrl(UrlRouteContext)" generates.
        /// </summary>
        public string Fragment
        {
            get;
            set;
        }
    }
}