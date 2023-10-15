using System.Runtime.CompilerServices;

using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;

[assembly: InternalsVisibleTo("Uno.Maui.Controls.Xaml.UnitTests")]
[assembly: InternalsVisibleTo("Uno.Maui.Controls.Build.Tasks")]
[assembly: InternalsVisibleTo("Uno.Maui.Controls.Xaml.Design")]
[assembly: InternalsVisibleTo("Uno.Maui.Controls.Loader")]// Microsoft.Maui.Controls.Loader.dll Microsoft.Maui.Controls.Xaml.XamlLoader.Load(object, string), kzu@microsoft.com
[assembly: InternalsVisibleTo("Uno.Maui.Controls.HotReload.Forms")]
[assembly: InternalsVisibleTo("Uno.Maui.Controls.HotReload.UnitTests")]
[assembly: InternalsVisibleTo("Uno.Maui.Controls.SourceGen")]
[assembly: InternalsVisibleTo("Uno.Maui.Controls.Compatibility")]
[assembly: InternalsVisibleTo("CommunityToolkit.Maui")]
[assembly: InternalsVisibleTo("CommunityToolkit.Maui.Core")]
[assembly: InternalsVisibleTo("CommunityToolkit.Maui.UnitTests")]
[assembly: InternalsVisibleTo("CommunityToolkit.Maui.Markup")]
[assembly: InternalsVisibleTo("CommunityToolkit.Maui.Markup.UnitTests")]
[assembly: InternalsVisibleTo("Uno.Maui.Controls.DeviceTests")]
[assembly: Preserve]

[assembly: XmlnsDefinition(Microsoft.Maui.Controls.Xaml.XamlParser.MauiUri, "Microsoft.Maui.Controls.Xaml")]
[assembly: XmlnsDefinition(Microsoft.Maui.Controls.Xaml.XamlParser.MauiDesignUri, "Microsoft.Maui.Controls.Xaml")]
[assembly: XmlnsDefinition(Microsoft.Maui.Controls.Xaml.XamlParser.X2006Uri, "Microsoft.Maui.Controls.Xaml")]
[assembly: XmlnsDefinition(Microsoft.Maui.Controls.Xaml.XamlParser.X2006Uri, "System", AssemblyName = "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
[assembly: XmlnsDefinition(Microsoft.Maui.Controls.Xaml.XamlParser.X2006Uri, "System", AssemblyName = "System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
[assembly: XmlnsDefinition(Microsoft.Maui.Controls.Xaml.XamlParser.X2009Uri, "Microsoft.Maui.Controls.Xaml")]
[assembly: XmlnsDefinition(Microsoft.Maui.Controls.Xaml.XamlParser.X2009Uri, "System", AssemblyName = "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
[assembly: XmlnsDefinition(Microsoft.Maui.Controls.Xaml.XamlParser.X2009Uri, "System", AssemblyName = "System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]