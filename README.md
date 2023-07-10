
<img src="https://github.com/xamarin/Xamarin.Forms/blob/5.0.0/Assets/banner.png" alt="Xamarin.Forms banner" height="145" >

# Xamarin.Forms #

Xamarin.Forms provides a way to quickly build native apps for iOS, Android, Windows and macOS, completely in C#.

Read more about the platform at https://www.xamarin.com/forms.

# Support

Xamarin.Forms now has a successor which is .NET MAUI as part of .NET 6+ and follows the same support lifecycle as the [MAUI Support Lifecycle][maui-support-lifecycle].

Support for Xamarin.Forms will end on **May 1, 2024** as per the [Xamarin Support Policy][xamarin-support-policy]:

> Xamarin support will end on May 1, 2024 for all classic Xamarin SDKs.

[maui-support-lifecycle]: https://dotnet.microsoft.com/platform/support/policy/maui
[xamarin-support-policy]: https://dotnet.microsoft.com/platform/support/policy/xamarin

## Build Status ##

![Azure DevOps](https://devdiv.visualstudio.com/DevDiv/_apis/build/status/Xamarin/XamarinForms/Xamarin%20Forms?branchName=main "Azure Pipelines")

## Packages ##

Platform/Feature               | Package name                              | Stable      | Prerelease | Nightly Feed [Azure](https://aka.ms/xf-nightly/index.json)  (main branch)
-----------------------|-------------------------------------------|-----------------------------|------------------------- |-------------------------|
Core             | `Xamarin.Forms` | [![NuGet](https://img.shields.io/nuget/v/Xamarin.Forms.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms/) | [![NuGet](https://img.shields.io/nuget/vpre/Xamarin.Forms.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms/) |
AppLinks  | `Xamarin.Forms.AppLinks`  | [![NuGet](https://img.shields.io/nuget/v/Xamarin.Forms.AppLinks.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms.AppLinks/) | [![NuGet](https://img.shields.io/nuget/vpre/Xamarin.Forms.AppLinks.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms.AppLinks/) | 
Maps                 | `Xamarin.Forms.Maps`    | [![NuGet](https://img.shields.io/nuget/v/Xamarin.Forms.Maps.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms.Maps/) | [![NuGet](https://img.shields.io/nuget/vpre/Xamarin.Forms.Maps.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms.Maps/) |
Maps.GTK             | `Xamarin.Forms.Maps.GTK` | [![NuGet](https://img.shields.io/nuget/v/Xamarin.Forms.Maps.GTK.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms.Maps.GTK/) | [![NuGet](https://img.shields.io/nuget/vpre/Xamarin.Forms.Maps.GTK.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms.Maps.GTK/) |
Maps.WPF             | `Xamarin.Forms.Maps.WPF` | [![NuGet](https://img.shields.io/nuget/v/Xamarin.Forms.Maps.WPF.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms.Maps.WPF/) | [![NuGet](https://img.shields.io/nuget/vpre/Xamarin.Forms.Maps.WPF.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms.Maps.WPF/) |
Pages  | `Xamarin.Forms.Pages`  | [![NuGet](https://img.shields.io/nuget/v/Xamarin.Forms.Pages.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms.Pages/) | [![NuGet](https://img.shields.io/nuget/vpre/Xamarin.Forms.Pages.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms.Pages/) |
Pages.Azure  | `Xamarin.Forms.Pages.Azure`  | [![NuGet](https://img.shields.io/nuget/v/Xamarin.Forms.Pages.Azure.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms.Pages.Azure/) |[![NuGet](https://img.shields.io/nuget/vpre/Xamarin.Forms.Pages.Azure.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms.Pages.Azure/) |
Platform.GTK  | `Xamarin.Forms.Platform.GTK`  | [![NuGet](https://img.shields.io/nuget/v/Xamarin.Forms.Platform.GTK.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms.Platform.GTK/) |[![NuGet](https://img.shields.io/nuget/vpre/Xamarin.Forms.Platform.GTK.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms.Platform.GTK/) |
Platform.WPF  | `Xamarin.Forms.Platform.WPF`  | [![NuGet](https://img.shields.io/nuget/v/Xamarin.Forms.Platform.WPF.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms.Platform.WPF/) |[![NuGet](https://img.shields.io/nuget/vpre/Xamarin.Forms.Platform.WPF.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms.Platform.WPF/) |
Visual.Material  | `Xamarin.Forms.Visual.Material`  | [![NuGet](https://img.shields.io/nuget/v/Xamarin.Forms.Visual.Material.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms.Visual.Material/) | [![NuGet](https://img.shields.io/nuget/vpre/Xamarin.Forms.Visual.Material.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Xamarin.Forms.Visual.Material/) |

If you want to use the latest dev build then you should read [this blog post](https://devblogs.microsoft.com/xamarin/try-the-latest-in-xamarin-forms-with-nightly-builds):

- Add the nightly feed to your NuGet sources or add a NuGet.Config to your app (placing it in the same directory where your solution file is) with the following content:

  ```xml
  <?xml version="1.0" encoding="utf-8"?>
  <configuration>
    <packageSources>
      <clear />
      <add key="xamarin-ci" value="https://aka.ms/xf-nightly/index.json" />
      <add key="NuGet.org" value="https://api.nuget.org/v3/index.json" />
    </packageSources>
  </configuration>
  ```

  *NOTE: This NuGet.Config should be with your application unless you want nightly packages to potentially start being restored for other apps on the machine.*

- Change your application's dependencies to have a `*` to get the latest version.

## Getting Started ##

For both methods underneath you will have to add this [NuGet feed](https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet-eng/nuget/v3/index.json) for the build to succeed. See [this documentation page](https://docs.microsoft.com/azure/devops/artifacts/nuget/consume?view=azure-devops&tabs=windows#set-up-visual-studio) to find out how.

### Windows ###
##### Install Visual Studio 2019+ #####

VS 2019+ is required for developing Xamarin.Forms. If you do not already have it installed, you can download it [here](https://www.visualstudio.com/downloads/download-visual-studio-vs). VS 2019+ Community is completely free. If you are installing VS 2019+ for the first time, select the "Custom" installation type and select the following from the features list to install:

- .NET desktop development 
  - `Individual Components > .NET > .NET Framework 4.6.1 SDK, .NET Framework 4.6.1 targeting pack, .NET Framework 4.7.2 SDK, .NET Framework 4.7.2 targeting pack`.
- Universal Windows Platform Development  
  - `Individual Components > SDKs, libraries, and frameworks > Windows 10 SDK (10.0.19041.0), Windows 10 SDK (10.0.18362.0), Windows 10 SDK (10.0.16299.0)`.
  - Download and install 14393 from https://go.microsoft.com/fwlink/p/?LinkId=838916
- Mobile Development with .NET 
  - `Individual Components > Development Activities > Xamarin Remoted Simulator`
  - If you're not using Hyper-V `Individual Components > Emulators > Hyper-V Intel Hardware Accelerated Execution Manager (HAXM)`
- Most current SDK version of .NET Core
  - Or install the most current .NET Core SDK from here https://dotnet.microsoft.com/download

The Android 10.0 API 29 SDK and Android 9.0 API 28 SDK are required for developing Xamarin.Forms. They can be installed by using the [Xamarin Android SDK Manager](https://docs.microsoft.com/xamarin/android/get-started/installation/android-sdk).

We also recommend installing [Xamarin Android Device Manager](https://developer.xamarin.com/guides/android/getting_started/installation/android-emulator/xamarin-device-manager/). This will use the HAXM tools installed above and allow you to configure Android Virtual Devices (AVDs) that emulate Android devices.
If you already have VS 2019+ installed, you can verify that these features are installed by modifying the VS 2019+ installation via the Visual Studio Installer.
