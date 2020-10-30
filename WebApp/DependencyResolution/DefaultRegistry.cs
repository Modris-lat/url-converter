// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultRegistry.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using Data.Library;
using Data.Library.Interfaces;
using NeuedaHomeTask;
using NeuedaHomeTask.Interfaces;
using NeuedaHomeTask.Services;
using NeuedaHomeTask.Services.GetCharactersForShortUrlCode;
using StructureMap;

namespace WebApp.DependencyResolution {
    using StructureMap.Configuration.DSL;
    using StructureMap.Graph;
	
    public class DefaultRegistry : Registry {
        #region Constructors and Destructors

        public DefaultRegistry()
        {
            Scan(
                scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                    scan.With(new ControllerConvention());
                });
            For<IDbService>().Use<DbService>();
            For<IUrlStorageDBContext>().Use<UrlStorageDBContext>().Transient();
            For<IConstructUserInput>().Use<ConstructUserUrlInput>();
            For<IConvertUrl>().Use<ConvertUrl>();
            For<IValidateUrl>().Use<ValidateUrl>();
            For<IStrategyList>().Use<StrategyList>();
            For<IGetChar>().Add<GetFirstCharacter>();
            For<IGetChar>().Add<GetSecondCharacter>();
            For<IGetChar>().Add<GetThirdCharacter>();
            For<IGetChar>().Add<GetFourthCharacter>();
            For<IGetChar>().Add<GetFifthCharacter>();
            For<IGetChar>().Add<GetSixthCharacter>();
            For<IContexts>().Use<Context>();
        }

        #endregion
    }
}