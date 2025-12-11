# 💾 SavesRecap
<p align="center">
  <img src="ico_png.png" alt="Diagram" />
</p>

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![Platform](https://img.shields.io/badge/Platform-Windows-0078D6?logo=windows)](https://www.microsoft.com/windows)
[![WPF](https://img.shields.io/badge/UI-WPF-68217A)](https://docs.microsoft.com/en-us/dotnet/desktop/wpf/)
[![C#](https://img.shields.io/badge/Language-C%23-239120?logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)

A app used to make sure that Elden Ring Saves are safe!
---

## 📋 Table of Contents

- [About](#about)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Technologies](#technologies)
- [Building](#building)
- [Contributing](#contributing)
- [License](#license)

---

## 🎯 About

**SavesRecap** is a Windows Presentation Foundation (WPF) application designed to provide an intuitive interface for managing and organizing saved data. Built on the latest .NET 8.0 framework, it leverages modern C# features and WPF capabilities to deliver a seamless user experience.

---

## ✨ Features

- 🎨 **Simple WPF Interface** - Clean and intuitive user interface
- ⚡ **Built on .NET 8.0** - Leverages the latest .NET features
- 🪟 **Windows Native** - Optimized for Windows desktop environment
- 🔧 **Extensible Architecture** - Easy to customize and extend

---

## 📦 Prerequisites

Before running SavesRecap, ensure you have the following installed:

- **Operating System**: Windows 10/11 (x64)
- **.NET SDK**: [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or later
- **IDE** (Optional but recommended):
  - [Visual Studio 2022](https://visualstudio.microsoft.com/) (Community, Professional, or Enterprise)
  - [Visual Studio Code](https://code.visualstudio.com/) with C# extension
  - [JetBrains Rider](https://www.jetbrains.com/rider/)

---

## 🚀 Installation

### Option 1: Clone the Repository

```bash
git clone https://github.com/D1xer231/SavesRecap.git
cd SavesRecap
```

### Option 2: Download ZIP

Download the latest release from the [Releases](https://github.com/D1xer231/SavesRecap/releases) page and extract it.

---

## 💻 Usage

### Running the Application

#### Using Visual Studio:
1. Open `SavesRecap.slnx` in Visual Studio 2022 (version 17.6 or later)
2. Press `F5` or click the "Start" button to build and run

#### Using .NET CLI:
```bash
cd SavesRecap
dotnet restore
dotnet run --project SavesRecap/SavesRecap.csproj
```

---

## 📁 Project Structure

```
SavesRecap/
├── SavesRecap/                 # Main application project
│   ├── App.xaml               # Application definition
│   ├── App.xaml.cs            # Application code-behind
│   ├── MainWindow.xaml        # Main window UI
│   ├── MainWindow.xaml.cs     # Main window code-behind
│   ├── AssemblyInfo.cs        # Assembly metadata
│   └── SavesRecap.csproj      # Project file
├── SavesRecap.slnx            # Solution file
├── LICENSE.txt                # MIT License
├── .gitignore                 # Git ignore rules
├── ico_png.png                # App icon
└── README.md                  # This file
```

---

## 🛠️ Technologies

This project is built with:

- **[.NET 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)** - Modern, cross-platform framework
- **[C# 12](https://docs.microsoft.com/en-us/dotnet/csharp/)** - Primary programming language
- **[WPF](https://docs.microsoft.com/en-us/dotnet/desktop/wpf/)** - Windows Presentation Foundation for UI
- **[XAML](https://docs.microsoft.com/en-us/dotnet/desktop/wpf/xaml/)** - Declarative markup language for UI

### Key Features Used:
- ✅ Nullable reference types enabled
- ✅ Implicit usings enabled
- ✅ .NET 8.0 Windows targeting

---

## 🔨 Building

### Debug Build
```bash
dotnet build --configuration Debug
```

### Release Build
```bash
dotnet build --configuration Release
```

### Clean Build
```bash
dotnet clean
dotnet build
```

### Create Publish Package
```bash
dotnet publish -c Release -r win-x64 --self-contained true
```

---

## 🤝 Contributing

Contributions are welcome! Here's how you can help:

1. **Fork** the repository
2. **Create** a feature branch (`git checkout -b feature/AmazingFeature`)
3. **Commit** your changes (`git commit -m 'Add some AmazingFeature'`)
4. **Push** to the branch (`git push origin feature/AmazingFeature`)
5. **Open** a Pull Request

### Guidelines:
- Follow C# coding conventions
- Write clear commit messages
- Add comments for complex logic
- Update documentation as needed

---

## 📄 License

This project is licensed under the **MIT License** - see the [LICENSE.txt](LICENSE.txt) file for details.

```
MIT License - Copyright (c) 2025 D1xer231

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files...
```

---

## 👤 Author

**D1xer231**

- GitHub: [@D1xer231](https://github.com/D1xer231)
- Repository: [SavesRecap](https://github.com/D1xer231/SavesRecap)

---

## 🙏 Acknowledgments

- Built with [.NET](https://dotnet.microsoft.com/)
- Inspired by modern desktop application design
- Thanks to the open-source community

---

## 📞 Support

If you encounter any issues or have questions:

1. Check the [Issues](https://github.com/D1xer231/SavesRecap/issues) page
2. Create a new issue with detailed information
3. Contact the maintainer

---

<div align="center">

### ⭐ Star this repository if you find it helpful!

**Made with ❤️ using C# and WPF**

</div>
