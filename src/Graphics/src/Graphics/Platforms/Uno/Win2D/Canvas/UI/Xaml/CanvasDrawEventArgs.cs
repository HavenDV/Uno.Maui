using System.Runtime.InteropServices;
using Windows.Foundation;
using Microsoft.UI.Xaml.Controls;
using WinRT;

namespace Microsoft.Graphics.Canvas.UI.Xaml;

public sealed class CanvasDrawEventArgs : ICustomQueryInterface, IWinRTObject, IDynamicInterfaceCastable, IEquatable<CanvasDrawEventArgs>
{
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

    public bool Equals(CanvasDrawEventArgs other)
    {
        throw new NotImplementedException();
    }
    
    public CanvasDrawingSession DrawingSession => throw new NotImplementedException();
}