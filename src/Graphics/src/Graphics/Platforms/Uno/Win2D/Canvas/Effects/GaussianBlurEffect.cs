using System.Numerics;
using System.Runtime.InteropServices;
using Windows.Graphics.Effects;
using Microsoft.Maui.Graphics;
using WinRT;
using Rect = Windows.Foundation.Rect;
using Size = Windows.Foundation.Size;

namespace Microsoft.Graphics.Canvas.Effects;

public sealed class GaussianBlurEffect : ICanvasEffect, IGraphicsEffect, IGraphicsEffectSource, ICanvasImage, IDisposable, ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<GaussianBlurEffect>
{
    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public Rect GetBounds(ICanvasResourceCreator resourceCreator)
    {
        throw new NotImplementedException();
    }

    public Rect GetBounds(ICanvasResourceCreator resourceCreator, Matrix3x2 transform)
    {
        throw new NotImplementedException();
    }

    public void InvalidateSourceRectangle(ICanvasResourceCreatorWithDpi resourceCreator, uint sourceIndex, Rect invalidRectangle)
    {
        throw new NotImplementedException();
    }

    public Rect[] GetInvalidRectangles(ICanvasResourceCreatorWithDpi resourceCreator)
    {
        throw new NotImplementedException();
    }

    public Rect GetRequiredSourceRectangle(ICanvasResourceCreatorWithDpi resourceCreator, Rect outputRectangle, ICanvasEffect sourceEffect, uint sourceIndex, Rect sourceBounds)
    {
        throw new NotImplementedException();
    }

    public Rect[] GetRequiredSourceRectangles(ICanvasResourceCreatorWithDpi resourceCreator, Rect outputRectangle, ICanvasEffect[] sourceEffects, uint[] sourceIndices, Rect[] sourceBounds)
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

    public bool Equals(GaussianBlurEffect other)
    {
        throw new NotImplementedException();
    }
    
    
    public float BlurAmount
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public EffectBorderMode BorderMode
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CanvasBufferPrecision? BufferPrecision
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public bool CacheOutput
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public string Name
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public EffectOptimization Optimization
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public IGraphicsEffectSource Source
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}