// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// Do not manually edit this autogenerated file:
// instead modify the neighboring .tt file (text template) and/or NuGet.CommandLine.Xplat\Commands\Commands.xml (data file),
// then re-execute the text template via "run custom tool" on VS context menu for .tt file, or via dotnet-t4 global tool.

using System;
using System.Threading.Tasks;
using NuGet.Common;

namespace NuGet.Commands
{
    public partial class AddSourceArgs
    {
        public string Source { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool StorePasswordInClearText { get; set; }
        public string ValidAuthenticationTypes { get; set; }
        public string Configfile { get; set; }
    }

    public partial class DisableSourceArgs
    {
        public string Name { get; set; }
        public string Configfile { get; set; }
    }

    public partial class EnableSourceArgs
    {
        public string Name { get; set; }
        public string Configfile { get; set; }
    }

    public partial class ListSourceArgs
    {
        public string Format { get; set; }
        public string Configfile { get; set; }
    }

    public partial class RemoveSourceArgs
    {
        public string Name { get; set; }
        public string Configfile { get; set; }
    }

    public partial class UpdateSourceArgs
    {
        public string Name { get; set; }
        public string Source { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool StorePasswordInClearText { get; set; }
        public string ValidAuthenticationTypes { get; set; }
        public string Configfile { get; set; }
    }

}
