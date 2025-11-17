// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace CmdPalExtensionDrWhoQuotes.Models;

/// <summary>
/// Represents a quote from Doctor Who.
/// </summary>
internal sealed class DrWhoQuote
{
    public required string Quote { get; init; }
    public string? Speaker { get; init; }
    public string? Doctor { get; init; }

    public override string ToString() => Quote;
}
