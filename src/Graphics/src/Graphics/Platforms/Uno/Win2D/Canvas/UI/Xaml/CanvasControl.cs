using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Microsoft.UI.Xaml.Controls;
using WinRT;

namespace Microsoft.Graphics.Canvas.UI.Xaml;

public sealed class CanvasControl : UserControl, ICanvasResourceCreatorWithDpi, ICanvasResourceCreator, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasControl>
{
    public CanvasDevice Device { get; }
    public float Dpi { get; }

    public int ConvertDipsToPixels(float dips, CanvasDpiRounding dpiRounding)
    {
        throw new NotImplementedException();
    }

    public CustomQueryInterfaceResult GetInterface(ref Guid iid, out IntPtr ppv)
    {
        throw new NotImplementedException();
    }

    public bool IsInterfaceImplemented(RuntimeTypeHandle interfaceType, bool throwIfNotImplemented)
    {
        throw new NotImplementedException();
    }

    public RuntimeTypeHandle GetInterfaceImplementation(RuntimeTypeHandle interfaceType)
    {
        throw new NotImplementedException();
    }

    public bool Equals(CanvasControl other)
    {
        throw new NotImplementedException();
    }
    
    public event TypedEventHandler<CanvasControl, CanvasDrawEventArgs> Draw
    {
        add
        {
            throw new NotImplementedException();
        }
        remove
        {
            throw new NotImplementedException();
        }
    }
    
    public void Invalidate()
    {
        throw new NotImplementedException();
    }

    public void RemoveFromVisualTree()
    {
        throw new NotImplementedException();
    }

    public float ConvertPixelsToDips(int pixels)
    {
        throw new NotImplementedException();
    }
}