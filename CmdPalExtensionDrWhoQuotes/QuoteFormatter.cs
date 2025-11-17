// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Text;

namespace CmdPalExtensionDrWhoQuotes;

/// <summary>
/// Helper utility to reformat quotes with line breaks.
/// INSTRUCTIONS: 
/// 1. Add a Main method temporarily to this class
/// 2. Call QuoteFormatter.GenerateFormattedQuoteCode()
/// 3. Copy the output and replace your QuotesRepository return array
/// 4. Remove the Main method
/// </summary>
internal static class QuoteFormatter
{
    // Uncomment this to run the formatter:
    // public static void Main() => GenerateFormattedQuoteCode();

 public static void GenerateFormattedQuoteCode()
    {
        var quotes = Data.QuotesRepository.GetAllQuotes();
     
        Console.WriteLine("return [");
        foreach (var quote in quotes)
        {
            var formattedQuote = FormatQuoteWithLineBreaks(quote.Quote, 90);
  Console.WriteLine($"    new DrWhoQuote {{ Quote = \"{EscapeForCSharp(formattedQuote)}\", Doctor = \"{quote.Doctor}\" }},");
      }
        Console.WriteLine("];");
    }

  private static string FormatQuoteWithLineBreaks(string quote, int maxLineLength)
    {
        if (string.IsNullOrEmpty(quote) || quote.Length <= maxLineLength)
   {
       return quote;
        }

        var result = new StringBuilder();
  var words = quote.Split(' ');
        var currentLine = new StringBuilder();

      foreach (var word in words)
        {
  // Check if adding this word would exceed the max length
     if (currentLine.Length + word.Length + 1 > maxLineLength && currentLine.Length > 0)
            {
 // Add the current line with \n
      if (result.Length > 0)
  {
               result.Append("\\n");
            }
      result.Append(currentLine.ToString().TrimEnd());
         currentLine.Clear();
       }

   // Add the word to the current line
if (currentLine.Length > 0)
            {
   currentLine.Append(' ');
       }
         currentLine.Append(word);
    }

        // Add any remaining text
        if (currentLine.Length > 0)
{
       if (result.Length > 0)
    {
       result.Append("\\n");
   }
        result.Append(currentLine.ToString());
     }

        return result.ToString();
  }

    private static string EscapeForCSharp(string text)
  {
        return text.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n");
}
}
