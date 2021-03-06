﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Nemiro.OAuth;
using Nemiro.OAuth.Clients;
using System.Collections.Specialized;

namespace Test.CSharp.AspWebForms
{
  public class Global : System.Web.HttpApplication
  {
    protected void Application_Start(object sender, EventArgs e)
    {
      // OAuth clients registration
      // NOTE: Specify their own client IDs and secret keys
      OAuthManager.RegisterClient
      (
        "facebook",
        "1435890426686808",
        "c6057dfae399beee9e8dc46a4182e8fd"
      );

      OAuthManager.RegisterClient
      (
        new TwitterClient
        (
          "1Ayh2ZM2l9chloiFsmxNpi7Gg",
          "dbVXKWVIlH5fRuVI0FvE2ZDsZAbBg74UrGFYwW1kLSwc0ceJnJ"
        )
      );

      OAuthManager.RegisterClient
      (
        new VkontakteClient
        (
          "2419779",
          "31nnASa9T1eO150VCFgr"
        )
      );

      OAuthManager.RegisterClient
      (
        new MailRuClient
        (
          "722701",
          "d0622d3d9c9efc69e4ca42aa173b938a"
        )
      );

      OAuthManager.RegisterClient
      (
        new GoogleClient
        (
          "1058655871432-83b9micke7cll89jfmcno5nftha3e95o.apps.googleusercontent.com",
          "AeEbEGQqoKgOZb41JUVLvEJL"
        )
      );

      OAuthManager.RegisterClient
      (
        new YandexClient
        (
          "73f7c76efea245aba31da2a89feff1b7",
          "f516cd1aa00a4fc8a94ca67b5701f727"
        )
      );

      OAuthManager.RegisterClient
      (
        new LiveClient
        (
          "0000000040124265",
          "6ViSGIbw9N59s5Ndsfz-zaeezlBt62Ep"
        )
      );

      OAuthManager.RegisterClient
      (
        new AmazonClient
        (
          "amzn1.application-oa2-client.f0ffe4edc256488dae00dcaf96d75d1b",
          "764dcefe49b441c8c6244c93e5d5d04de54fda6dfdc83da9693bf346f4dc4515"
        ) { ReturnUrl = "http://localhost" }
      );

      OAuthManager.RegisterClient
      (
        new FoursquareClient
        (
          "LHYZN1KUXN50L141QCQFNNVOYBGUE3G3FCWFZ3EEZTOZHY5Q",
          "HWXYFLLSS2IUQ0H4XNCDAZEFZKIU3MZRP5G55TNBDHRPNOQT"
        )
      );
    }
  }
}