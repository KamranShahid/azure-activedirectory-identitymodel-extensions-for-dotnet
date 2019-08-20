//------------------------------------------------------------------------------
//
// Copyright (c) Microsoft Corporation.
// All rights reserved.
//
// This code is licensed under the MIT License.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files(the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and / or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions :
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
//------------------------------------------------------------------------------

namespace System.IdentityModel.Tokens.Jwt
{
    /// <summary>
    /// List of registered claims from different sources
    /// http://tools.ietf.org/html/rfc7519#section-4
    /// http://openid.net/specs/openid-connect-core-1_0.html#IDToken
    /// </summary>
    public struct JwtRegisteredClaimNames
    {
        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string Actort = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Actort;

        /// <summary>
        /// http://openid.net/specs/openid-connect-core-1_0.html#IDToken
        /// </summary>
        public static string Acr = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Acr;

        /// <summary>
        /// http://openid.net/specs/openid-connect-core-1_0.html#IDToken
        /// </summary>
        public static string Amr = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Amr;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string Aud = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Aud;

        /// <summary>
        /// http://openid.net/specs/openid-connect-core-1_0.html#IDToken
        /// </summary>
        public static string AuthTime = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.AuthTime;

        /// <summary>
        /// http://openid.net/specs/openid-connect-core-1_0.html#IDToken
        /// </summary>
        public static string Azp = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Azp;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string Birthdate = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Birthdate;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string CHash = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.CHash;

        /// <summary>
        /// http://openid.net/specs/openid-connect-core-1_0.html#CodeIDToken
        /// </summary>
        public static string AtHash = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.AtHash;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string Email = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Email;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string Exp = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Exp;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string Gender = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Gender;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string FamilyName = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.FamilyName;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string GivenName = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.GivenName;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string Iat = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Iat;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string Iss = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Iss;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string Jti = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Jti;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string NameId = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.NameId;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string Nonce = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Nonce;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string Nbf = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Nbf;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string Prn = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Prn;

        /// <summary>
        /// http://openid.net/specs/openid-connect-frontchannel-1_0.html#OPLogout
        /// </summary>
        public static string Sid = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Sid;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string Sub = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Sub;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string Typ = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Typ;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string UniqueName = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.UniqueName;

        /// <summary>
        /// http://tools.ietf.org/html/rfc7519#section-4
        /// </summary>
        public static string Website = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames.Website;
    }
}
