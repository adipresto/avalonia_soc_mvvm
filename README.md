# AvaloniaUI MVVM with SoC (Separation of Concerns)
This repository is inspired by [edwinbernadus/starter-template-avalonia](https://github.com/edwinbernadus/starter-template-avalonia), with the goal of applying Separation of Concerns (SoC) principles in AvaloniaUI projects.

## Motivation
I once ran into a small issue: a coworker using macOS wanted to contribute to a .NET application, but the original repository didn’t include a `.sln` file. Since I develop on Windows, this repository is intended to serve as a starter template for Windows-based AvaloniaUI development with built-in SoC support.

## Why a New Repository?
The original repo by [edwinbernadus](https://github.com/edwinbernadus/starter-template-frontend-framework) is designed as a copy-pasteable starter template, not a package or library meant to be extended or pull-requested. As they mentioned in their frontend framework template, the intention is for developers to fork or copy it for their own needs.

# Features
1. MainWindowViewModel.cs registered as a transient service
2. More structured viewmodel-service separation (coming soon)
3. Platform-agnostic setup for better cross-platform development

# Getting Started
1. Clone this repository
2. Open the .sln file in Visual Studio
3. Run the project — AvaloniaUI will launch with a basic MVVM + DI setup
