﻿using System;
using System.Collections.Specialized;

namespace WorldDomination.Web.Authentication
{
    public interface IAuthenticationService
    {
        void AddProvider(IAuthenticationProvider authenticationProvider);
        Uri RedirectToAuthenticationProvider(string providerKey, string state);
        IAuthenticatedClient CheckCallback(string providerKey, NameValueCollection requestParameters, string state);
    }
}