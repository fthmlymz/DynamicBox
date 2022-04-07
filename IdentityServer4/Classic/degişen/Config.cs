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
                new ApiResource("resource_purchasing"){Scopes= {"purchasing.create", "purchasing.read", "purchasing.update", "purchasing.delete"}},
                new ApiResource("resource_api2")
            };
        }


        /*public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
            new ApiResource("resource_elsaserver"){Scopes={ "elsa_server_fullpermission" } },
            new ApiResource("resource_documentmanagement"){Scopes={ "documentmanagement_fullpermission" } },
            new ApiResource("resource_purchasingmanagement"){Scopes={"purchasing_management_fullpermission"}},
            new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
        };*/
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
                new IdentityResource()
                {
                    Name="roles",
                    DisplayName="Roles",
                    Description= "Kullanıcı rolleri",
                    UserClaims=new[]{"role"}
                }
            };
        }
        public static IEnumerable<TestUser> GetTestUsers()
        {
            return new List<TestUser>()
            {
                new TestUser{ SubjectId = "1", Username="canselmalyemez", Password="canselmalyemez", Claims=new List<Claim>(){
                    new Claim("given_name", "Cansel"),
                    new Claim("family_name", "Malyemez"),
                    new Claim("role", "admin")}
                },
                new TestUser{ SubjectId = "2", Username="erdemmalyemez", Password="erdemmalyemez", Claims=new List<Claim>(){
                    new Claim("given_name", "Erdem"),
                    new Claim("family_name", "Malyemez"),
                    new Claim("role", "standart-user")}
                },
                new TestUser{ SubjectId = "3", Username="tahamalyemez", Password="tahamalyemez", Claims=new List<Claim>(){
                    new Claim("given_name", "Taha"),
                    new Claim("family_name", "Malyemez"),
                    new Claim("role", "ust-user")}
                }
            };
        }

        /*public static IEnumerable<IdentityResource> IdentityResources =>
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
                   };*/
        #endregion





        #region Scopes
        public static IEnumerable<ApiScope> GetApiScope()
        {
            return new List<ApiScope>()
            {
                #region Purchasing Management Permissions
                new ApiScope("purchasing.create", "Satın Alma uygulaması okuma izni"),
                new ApiScope("purchasing.read", "Satın Alma uygulaması yazma izni"),
                new ApiScope("purchasing.update", "Satın Alma uygulaması güncelleme izni"),
                new ApiScope("purchasing.delete", "Satın Alma uygulaması silme izni")
	            #endregion
                

            };
        }


        /*public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
            new ApiScope("elsa_server_fullpermission", "Elsa Server için full erişim"),
            new ApiScope("documentmanagement_fullpermission",  "Döküman yonetim için tam yetki"),
            new ApiScope("purchasing_management_fullpermission", "Satın alma yönetim uygulaması tam yetki"),
            new ApiScope(IdentityServerConstants.LocalApi.ScopeName)
            };*/
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

                    AllowOfflineAccess=true,

                     AllowedScopes = {
                        IdentityServerConstants.LocalApi.ScopeName,
                        IdentityServerConstants.StandardScopes.Email,
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Phone,
                        IdentityServerConstants.StandardScopes.Address,
                        IdentityServerConstants.StandardScopes.OfflineAccess, //refrash token üretebilmek için
                        "roles",

                        "purchasing.create",
                        "purchasing.read",
                        "purchasing.update",
                        "purchasing.delete"
                    },
                    AccessTokenLifetime=3600, //1*60*60,
                    RefreshTokenExpiration=TokenExpiration.Absolute,
                    AbsoluteRefreshTokenLifetime=(int)(DateTime.Now.AddDays(60)-DateTime.Now).TotalSeconds,
                    RefreshTokenUsage = TokenUsage.ReUse
                }
            };
        }

        /*public static IEnumerable<Client> Clients =>
            new Client[] {
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

                    ClientName = "Ldap",
                    ClientId = "Ldap",
                    AllowOfflineAccess=true,
                    ClientSecrets = {new Secret("secret".Sha256())},
                    AllowedGrantTypes= GrantTypes.ResourceOwnerPassword,
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

            };*/
        #endregion
    }
}


