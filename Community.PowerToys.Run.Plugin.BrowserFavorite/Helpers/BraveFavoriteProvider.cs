﻿// Copyright (c) Davide Giacometti. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace Community.PowerToys.Run.Plugin.BrowserFavorite.Helpers;

public class BraveFavoriteProvider : ChromiumFavoriteProvider
{
    private static readonly string Path =
        Environment.ExpandEnvironmentVariables(
            @"%LOCALAPPDATA%\BraveSoftware\Brave-Browser\User Data\Default\Bookmarks");

    public BraveFavoriteProvider()
        : base(Path)
    {
    }
}
