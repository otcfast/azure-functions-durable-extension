﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Microsoft.Azure.WebJobs
{
    /// <summary>
    /// Information about the current status of an operation executing on an actor.
    /// Excludes potentially large data (such as the operation input content) so it can be read with low latency.
    /// </summary>
    public class ActorCurrentOperationStatus
    {
        /// <summary>
        /// The name of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "op", Required = Required.Always)]
        public string Operation { get; set; }

        /// <summary>
        /// The unique identifier for this operation.
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.Always)]
        public Guid Id { get; set; }

        /// <summary>
        /// The parent instance that called this operation.
        /// </summary>
        [JsonProperty(PropertyName = "parent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ParentInstanceId { get; set; }

        /// <summary>
        /// The UTC time at which the actor started processing this operation.
        /// </summary>
        [JsonProperty(PropertyName = "startTime", Required = Required.Always)]
        public DateTime StartTime { get; set; }
    }
}