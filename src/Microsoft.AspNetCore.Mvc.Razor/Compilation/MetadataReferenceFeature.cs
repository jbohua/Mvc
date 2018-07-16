﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace Microsoft.AspNetCore.Mvc.Razor.Compilation
{
    /// <summary>
    /// Specifies the list of <see cref="MetadataReference"/> used in Razor compilation.
    /// </summary>
    [Obsolete("This type is obsolete and will be removed in a future version.")]
    public class MetadataReferenceFeature
    {
        /// <summary>
        /// Gets the <see cref="MetadataReference"/> instances.
        /// </summary>
        public IList<MetadataReference> MetadataReferences { get; } = new List<MetadataReference>();
    }
}
