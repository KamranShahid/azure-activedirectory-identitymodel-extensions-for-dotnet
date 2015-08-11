﻿//-----------------------------------------------------------------------
// Copyright (c) Microsoft Open Technologies, Inc.
// All Rights Reserved
// Apache License 2.0
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//-----------------------------------------------------------------------

namespace System.IdentityModel.Tokens.Saml2
{
    public class Saml2SecurityToken : SecurityToken
    {
        public override string Id
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override SecurityKey SecurityKey
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override DateTime ValidFrom
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override DateTime ValidTo
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Saml2Conditions Conditions { get; }

        public override SecurityKey SigningKey
        {
            get;
            set;
        }

        public override string Issuer { get; }
    }
}