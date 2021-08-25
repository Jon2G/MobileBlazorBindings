// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Kit.Sql.Attributes;
using System.IO;

[assembly: Preserve()]

namespace Microsoft.MobileBlazorBindings.Hosting
{
    public static class BlazorAssets
    {
        public static Stream GetBlazorDesktopJS()
        {
            return typeof(BlazorAssets).Assembly.GetManifestResourceStream("Microsoft.MobileBlazorBindings.Hosting.blazor.desktop.js");
        }
    }
}