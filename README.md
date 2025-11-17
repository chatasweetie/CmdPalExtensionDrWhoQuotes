# Doctor Who Quotes - Command Palette Extension

A delightful Command Palette extension that brings the wisdom, wit, and wonder of Doctor Who to your fingertips. Get inspired with random quotes from all incarnations of the Doctor, from the First Doctor through the War Doctor, Ninth, and Tenth Doctors.

![Doctor Who Quotes Extension](Assets/StoreLogo.png)

## 🎯 Features

- **Random Doctor Who Quotes**: Get a random quote from ~180+ memorable Doctor Who quotes every time you open the extension
- **Markdown Display**: Quotes are elegantly formatted with proper attribution
- **All Classic Doctors**: Includes quotes from:
  - First Doctor through Tenth Doctor
  - The War Doctor
  - Classic and Modern Era quotes
- **Easy Access**: Quick access through Windows Command Palette (Ctrl+Space)
- **Instant Inspiration**: Perfect for Doctor Who fans looking for a moment of Time Lord wisdom

## 📦 Installation

### From Microsoft Store
*Coming soon!*



## 🏗️ Project Structure

```
CmdPalExtensionDrWhoQuotes/
├── Assets/                     # Extension icons and images
├── Data/                       # Quote data storage
│   └── QuotesRepository.cs     # All Doctor Who quotes
├── Models/                     # Data models
│   └── DrWhoQuote.cs           # Quote model
├── Pages/                      # UI pages
│   └── CmdPalExtensionDrWhoQuotesPage.cs
├── Publication/                # Publishing scripts and tools
└── CmdPalExtensionDrWhoQuotesCommandsProvider.cs
```

## 📝 Adding More Quotes

Want to contribute more Doctor Who quotes? Here's how:

1. Open `Data/QuotesRepository.cs`
2. Add new quotes to the array in `GetAllQuotes()`:
   ```csharp
   new DrWhoQuote { 
       Quote = "Your quote here", 
     Doctor = "The Eleventh Doctor" 
   }
   ```
3. For long quotes, use verbatim strings with natural line breaks:
   ```csharp
   new DrWhoQuote { 
    Quote = @"This is a long quote
   that spans multiple lines
   for better readability", 
       Doctor = "The Tenth Doctor" 
   }
   ```
4. Build and test!

## 🤝 Contributing

Contributions are welcome! Here are some ways you can help:

- **Add More Quotes**: Contribute quotes from Eleventh, Twelfth, Thirteenth, and Fourteenth Doctors
- **Improve UI**: Enhance the markdown display or add new features
- **Bug Fixes**: Report and fix any issues you find
- **Documentation**: Improve this README or add code documentation

### How to Contribute

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- **Doctor Who**: Copyright © BBC
- All quotes are from the BBC television series "Doctor Who"
- Built using the [Windows Command Palette Extension SDK](https://learn.microsoft.com/windows/powertoys/command-palette/)
- Extension template and guidance from Microsoft

## 🌟 Show Your Support

If you enjoy this extension, please:
- ⭐ Star this repository
- 🐦 Share it on social media
- 🐛 Report bugs or suggest features
- 🤝 Contribute quotes or code improvements

---

**"Allons-y!"** - The Tenth Doctor

Made with ❤️ by Whovians, for Whovians


## License

This project is licensed under the MIT License. See individual extension directories for specific license information.

## Author

[Jessica Dene Earley-Cha](htthttps://www.jessicadeneearley-cha.com/)  |  [https://github.com/chatasweetie](https://github.com/chatasweetie)
