using System;
using System.Numerics;
using System.Runtime.InteropServices;
using Windows.Graphics.Effects;
using Microsoft.Maui.Graphics;
using WinRT;
using Rect = Windows.Foundation.Rect;
using Size = Windows.Foundation.Size;

namespace Microsoft.Graphics.Canvas;

public sealed class CanvasCommandList : ICanvasImage, IGraphicsEffectSource, IDisposable, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasCommandList>
{
    public CanvasCommandList(ICanvasResourceCreator resourceCreator)
    {
        throw new NotImplementedException();
    }
    
    public void Dispose()
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

    public bool Equals(CanvasCommandList other)
    {
        throw new NotImplementedException();
    }
    
    public CanvasDrawingSession CreateDrawingSession()
    {
        throw new NotImplementedException();
    }

    public Rect GetBounds(ICanvasResourceCreator resourceCreator)
    {
        throw new NotImplementedException();
    }

    Rect ICanvasImage.GetBounds(ICanvasResourceCreator resourceCreator)
    {
        return GetBounds(resourceCreator);
    }

    public Rect GetBounds(ICanvasResourceCreator resourceCreator, Matrix3x2 transform)
    {
        throw new NotImplementedException();
    }
}