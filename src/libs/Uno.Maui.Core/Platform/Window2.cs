// Decompiled with JetBrains decompiler
// Type: Microsoft.UI.Xaml.Window
// Assembly: Uno.UI, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null
// MVID: 604BD22A-9EBE-4B2A-A142-471BFEED8AE4
// Assembly location: /Users/havendv/.nuget/packages/uno.winui/4.10.26/lib/net7.0/Uno.UI.dll

using Microsoft.UI.Composition;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Media;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Uno;
using Uno.Disposables;
using Uno.Foundation.Logging;
using Uno.UI.Xaml.Core;
using Windows.ApplicationModel.DataTransfer.DragDrop.Core;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;
using Windows.UI.ViewManagement;


#nullable enable
namespace Microsoft.UI.Xaml
{
  public class Window2
  {
    private Window Window { get; set; }
    public Window UnoWindow => Window;
    private static Window StaticWindow { get; set; }
    
    [NotImplemented(new string[] {"__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__"})]
    public bool ExtendsContentIntoTitleBar
    {
      get => Window.ExtendsContentIntoTitleBar;
      set => Window.ExtendsContentIntoTitleBar = value;
    }

    [NotImplemented(new string[] {"__ANDROID__", "__IOS__", "NET461", "__WASM__", "__NETSTD_REFERENCE__", "__MACOS__"})]
    public Compositor Compositor => Window.Compositor;

    public DispatcherQueue DispatcherQueue => Window.DispatcherQueue;

    public Window2()
    {
      Window = new Window();
      StaticWindow = Window;
      Activated += (sender, args) => Activated?.Invoke(sender, args);
      Closed += (sender, args) => Closed?.Invoke(sender, args);
      SizeChanged += (sender, args) => SizeChanged?.Invoke(sender, args);
      VisibilityChanged += (sender, args) => VisibilityChanged?.Invoke(sender, args);
    }
    
    public event WindowActivatedEventHandler Activated;

    public event WindowClosedEventHandler Closed;

    public event WindowSizeChangedEventHandler SizeChanged;

    public event WindowVisibilityChangedEventHandler VisibilityChanged;

    public UIElement Content
    {
      get => Window.Content;
      set => Window.Content = value;
    }

    public Windows.Foundation.Rect Bounds => Window.Bounds;

    public CoreWindow CoreWindow => Window.CoreWindow;

    public CoreDispatcher Dispatcher => Window.Dispatcher;

    public bool Visible
    {
      get => Window.Visible;
      set => Window.Visible = value;
    }

    public static Window Current => StaticWindow;

    public void Activate() => Window.Activate();

    public void Close() => Window.Close();

    public void SetTitleBar(UIElement value) => Window.SetTitleBar(value);

    public 
    #nullable enable
    string Title
    {
      get => Window.Title;
      set => Window.Title = value;
    }
  }
}
