// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using CmdPalExtensionDrWhoQuotes.Data;
using Microsoft.CommandPalette.Extensions;
using Microsoft.CommandPalette.Extensions.Toolkit;
using System;
using System.Text;

namespace CmdPalExtensionDrWhoQuotes;

internal sealed partial class CmdPalExtensionDrWhoQuotesPage : ContentPage
{
    public CmdPalExtensionDrWhoQuotesPage()
    {
        Icon = new("\uE8F2"); // Message
        Title = "Doctor Who Quotes";
        Name = "Press Enter for Quotes";

         Commands = [
             new CommandContextItem(new AnonymousCommand(() => { }) { Result = CommandResult.GoBack() }) { Title = "Back" },
         ];
    }

    public override IContent[] GetContent()
    {
        var quotes = QuotesRepository.GetAllQuotes();
 
        // Get a random quote
        var random = new Random();
        var randomQuote = quotes[random.Next(quotes.Length)];

        var doctor = !string.IsNullOrEmpty(randomQuote.Doctor) ? randomQuote.Doctor
            : !string.IsNullOrEmpty(randomQuote.Speaker) ? randomQuote.Speaker
            : "The Doctor";

        var markdown = new StringBuilder();
        markdown.AppendLine("# Doctor Who Quote");
        markdown.AppendLine();
        markdown.AppendLine($"> {randomQuote.Quote}");
        markdown.AppendLine();
        markdown.AppendLine($"**— {doctor}**");

  return [
    new MarkdownContent(markdown.ToString()),
  ];
    }
}
