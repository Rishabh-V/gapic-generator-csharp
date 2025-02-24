// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gpr = Google.Protobuf.Reflection;
using sys = System;
using scg = System.Collections.Generic;
using tp = Testing.PublishingSettings;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>Static class to provide extension methods to configure API clients.</summary>
    public static partial class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a singleton <see cref="tp::RenamedServiceNameClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddRenamedServiceNameClient(this IServiceCollection services, sys::Action<tp::RenamedServiceNameClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                tp::RenamedServiceNameClientBuilder builder = new tp::RenamedServiceNameClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="tp::ServiceWithHandwrittenSignaturesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddServiceWithHandwrittenSignaturesClient(this IServiceCollection services, sys::Action<tp::ServiceWithHandwrittenSignaturesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                tp::ServiceWithHandwrittenSignaturesClientBuilder builder = new tp::ServiceWithHandwrittenSignaturesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="tp::ServiceWithResourcesClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        public static IServiceCollection AddServiceWithResourcesClient(this IServiceCollection services, sys::Action<tp::ServiceWithResourcesClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                tp::ServiceWithResourcesClientBuilder builder = new tp::ServiceWithResourcesClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });
    }
}
