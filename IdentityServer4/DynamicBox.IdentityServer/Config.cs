using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;

namespace DynamicBox.IdentityServer
{
    public static class Config
    {
        //Api resource tanımlama
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
            new ApiResource("resource_elsaserver"){Scopes={ "elsa_server_fullpermission" } },
            new ApiResource("resource_documentmanagement"){Scopes={ "documentmanagement_fullpermission" } },
            new ApiResource("resource_purchasingmanagement"){Scopes={"purchasing_management_fullpermission"}},
            new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
        };
        public static IEnumerable<IdentityResource> IdentityResources =>
                   new IdentityResource[]
                   {
                       new IdentityResources.Email(),
                       new IdentityResources.OpenId(),
                       new IdentityResources.Profile(),
                       new IdentityResources.Phone(),
                       new IdentityResources.Address(),
                       new IdentityResource(){
                           Name="roles",
                           DisplayName="Roles",
                           Description= "Kullanıcı rolleri",
                           UserClaims=new[]{"role"} }
                   };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
            new ApiScope("elsa_server_fullpermission", "Elsa Server için full erişim"),
            new ApiScope("documentmanagement_fullpermission",  "Döküman yonetim için tam yetki"),
            new ApiScope("purchasing_management_fullpermission", "Satın alma yönetim uygulaması tam yetki"),
            new ApiScope(IdentityServerConstants.LocalApi.ScopeName)
            };

        public static IEnumerable<Client> Clients =>
            new Client[] {
                //new Client
                //{
                //    ClientName = "DynamicBox Workflow IdentityServer",
                //    ClientId = "DynamicBoxWorkflow",
                //    ClientSecrets = {new Secret("6E7179457315DB81CBFB9BFAA3C8BB729B".Sha256())},
                //    AllowedGrantTypes= GrantTypes.ClientCredentials,
                //    AllowedScopes =
                //    {
                //        "elsa_server_fullpermission",
                //        "documentmanagement_fullpermission",
                //        "purchasing_management_fullpermission",
                //        IdentityServerConstants.LocalApi.ScopeName
                //    }
                //},

                //new Client
                //{
                //    ClientName = "DynamicBox Workflow IdentityServer",
                //    ClientId = "DynamicBoxWorkflowForUser",
                //    AllowOfflineAccess=true,
                //    ClientSecrets = {new Secret("6E7179457315DB81CBFB9BFAA3C8BB729B".Sha256())},
                //    AllowedGrantTypes= GrantTypes.ResourceOwnerPassword,
                //    AllowedScopes = {
                //        IdentityServerConstants.LocalApi.ScopeName,
                //        IdentityServerConstants.StandardScopes.Email,
                //        IdentityServerConstants.StandardScopes.OpenId,
                //        IdentityServerConstants.StandardScopes.Profile,
                //        IdentityServerConstants.StandardScopes.Phone,
                //        IdentityServerConstants.StandardScopes.Address,
                //        IdentityServerConstants.StandardScopes.OfflineAccess, //refresh token üretebilmek için
                //        "roles",

                //        "elsa_server_fullpermission",
                //        "documentmanagement_fullpermission",
                //        "purchasing_management_fullpermission",
                //    },
                //    AccessTokenLifetime=3600, //1*60*60,
                //    RefreshTokenExpiration=TokenExpiration.Absolute,
                //    AbsoluteRefreshTokenLifetime=(int)(DateTime.Now.AddDays(60)-DateTime.Now).TotalSeconds,
                //    RefreshTokenUsage = TokenUsage.ReUse
                //},



                //LDAP
                 new Client
                {
                    Enabled = true,
                    AccessTokenType = AccessTokenType.Jwt,
                    AlwaysSendClientClaims = true,
                    UpdateAccessTokenClaimsOnRefresh = true,
                    AlwaysIncludeUserClaimsInIdToken = true,
                    AllowAccessTokensViaBrowser = true,
                    IncludeJwtId = true,

                    ClientName = "DynamicBox Workflow IdentityServer - Ldap",
                    ClientId = "DynamicBoxWorkflowLdap",
                    AllowOfflineAccess=true,
                    ClientSecrets = {new Secret("6E7179457315DB81CBFB9BFAA3C8BB729B".Sha256())},
                    AllowedGrantTypes= GrantTypes.ClientCredentials,
                    AllowedScopes = {
                        IdentityServerConstants.LocalApi.ScopeName,
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Phone,
                        IdentityServerConstants.StandardScopes.Address,
                        IdentityServerConstants.StandardScopes.OfflineAccess, //refrash token üretebilmek için
                        "roles",

                        "elsa_server_fullpermission",
                        "documentmanagement_fullpermission",
                        "purchasing_management_fullpermission",
                    },
                    AccessTokenLifetime=3600, //1*60*60,
                    RefreshTokenExpiration=TokenExpiration.Absolute,
                    AbsoluteRefreshTokenLifetime=(int)(DateTime.Now.AddDays(60)-DateTime.Now).TotalSeconds,
                    RefreshTokenUsage = TokenUsage.ReUse
                }

            };
    }
}


