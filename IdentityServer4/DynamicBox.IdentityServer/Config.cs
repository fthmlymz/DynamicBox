using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace DynamicBox.IdentityServer
{
    public static class Config
    {
        #region ApiResources
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>() {
                //new ApiResource("resource_purchasing"){Scopes= {"purchasing.create", "purchasing.read", "purchasing.update", "purchasing.delete"}},
                new ApiResource("resource_purchasing"){Scopes= {"purchasing.create", "purchasing.read", "purchasing.update", "purchasing.delete"} },
                new ApiResource("api1", "My API", new[] { JwtClaimTypes.Subject, JwtClaimTypes.Email, JwtClaimTypes.PhoneNumber })
                //new ApiResource("resource_purchasing", "My Roles", new[] { "role" }),
            };
        }
        #endregion


        #region Identity Resource
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>()
            {
                new IdentityResources.OpenId(), //subject id, kullanıcının id numarası
                new IdentityResources.Email(),
                new IdentityResources.Profile(),
                new IdentityResources.Phone(),
                new IdentityResources.Address(),
                //   new IdentityResource("roles", new[] { "role" })
                new IdentityResource()
                {
                    Name="roles",
                    DisplayName="Roles",
                    Description= "Kullanıcı rolleri",
                    UserClaims=new[]{"role"}
                }
            };
        }
        #endregion





        #region Scopes
        public static IEnumerable<ApiScope> GetApiScope()
        {
            return new List<ApiScope>()
            {
                #region Purchasing Management Permissions
                new ApiScope("purchasing.create", "Satın Alma uygulaması yazma izni"),
                new ApiScope("purchasing.read", "Satın Alma uygulaması okuma izni"),
                new ApiScope("purchasing.update", "Satın Alma uygulaması güncelleme izni"),
                new ApiScope("purchasing.delete", "Satın Alma uygulaması silme izni")
	            #endregion
            };
        }
        #endregion





        #region Clients
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>()
            {
                new Client()
                {
                    ClientId = "PurchasingClient",
                    ClientSecrets = new[] { new Secret("secret".Sha256())},
                    ClientName = "Purchasing Management",
                    AllowedGrantTypes= GrantTypes.ResourceOwnerPassword,

                    Enabled = true,
                    AccessTokenType = AccessTokenType.Jwt,
                    AlwaysSendClientClaims = true,
                    UpdateAccessTokenClaimsOnRefresh = true,
                    AlwaysIncludeUserClaimsInIdToken = true,
                    AllowAccessTokensViaBrowser = true,
                    IncludeJwtId = true,

                    RedirectUris = new List<string>{$"https://localhost:2003/signin-oidc"},
                    PostLogoutRedirectUris = new List<string>{$"https://localhost:2003/signout-callback-oidc"},//IdentityServer üzerinde logout olduğunda nereye yönlendirilecekse

                     AllowedScopes = {
                        IdentityServerConstants.LocalApi.ScopeName,
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Phone,
                        IdentityServerConstants.StandardScopes.Address,
                        IdentityServerConstants.StandardScopes.OfflineAccess, //refresh token üretebilmek için
                        "roles",

                        "purchasing.create",
                        "purchasing.read",
                        "purchasing.update",
                        "purchasing.delete"
                    },

                    AllowOfflineAccess=true, //refresh token yayınlanması için
                    AccessTokenLifetime= 4*60*60, //3600, //1*60*60,  //3600 1 saate tekamul ediyor
                    //Absolute kesin verilen süre sonunda ömrü biter,
                    //Sliding=Standartı 15 gündür, 15 gün içinde istek yapılırsa refresh token süresini 15 gün daha uzatır.
                    RefreshTokenExpiration=TokenExpiration.Absolute,


                    AbsoluteRefreshTokenLifetime=(int)(DateTime.Now.AddDays(60)-DateTime.Now).TotalSeconds,

                    //OneTimeOnly sadece bir kere kullanılabilir,
                    //ReUse = ömrü boyunca kullanabilir
                    RefreshTokenUsage = TokenUsage.ReUse  
                }
            };
        }
        #endregion
    }
}


