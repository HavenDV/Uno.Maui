using System;
using System.Numerics;
using System.Runtime.InteropServices;
using WinRT;

namespace Microsoft.Graphics.Canvas.Brushes;

public interface ICanvasBrush : IDisposable
{
    CanvasDevice Device { get; }

    float Opacity { get; set; }

    Matrix3x2 Transform { get; set; }
}