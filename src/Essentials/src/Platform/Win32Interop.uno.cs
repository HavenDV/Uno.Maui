using System;
using System.Runtime.InteropServices;

namespace Microsoft.UI;

/// <summary>
/// 
/// </summary>
public class Win32Interop
{
    [DllImport("Microsoft.Internal.FrameworkUdk.dll")]
    private static extern int Windowing_GetWindowIdFromWindow(IntPtr hwnd, out WindowId windowId);

    [DllImport("Microsoft.Internal.FrameworkUdk.dll")]
    private static extern int Windowing_GetWindowFromWindowId(WindowId windowId, out IntPtr hwnd);

    [DllImport("Microsoft.Internal.FrameworkUdk.dll")]
    private static extern int Windowing_GetDisplayIdFromMonitor(IntPtr hmonitor, out DisplayId displayId);

    [DllImport("Microsoft.Internal.FrameworkUdk.dll")]
    private static extern int Windowing_GetMonitorFromDisplayId(DisplayId displayId, out IntPtr hmonitor);

    [DllImport("Microsoft.Internal.FrameworkUdk.dll")]
    private static extern int Windowing_GetIconIdFromIcon(IntPtr hicon, out IconId iconId);

    [DllImport("Microsoft.Internal.FrameworkUdk.dll")]
    private static extern int Windowing_GetIconFromIconId(IconId iconId, out IntPtr hicon);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="hwnd"></param>
    /// <returns></returns>
    public static WindowId GetWindowIdFromWindow(IntPtr hwnd)
    {
        Marshal.ThrowExceptionForHR(Windowing_GetWindowIdFromWindow(hwnd, out var windowId));
        return windowId;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="windowId"></param>
    /// <returns></returns>
    public static IntPtr GetWindowFromWindowId(WindowId windowId)
    {
        Marshal.ThrowExceptionForHR(Windowing_GetWindowFromWindowId(windowId, out var hwnd));
        return hwnd;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="hmonitor"></param>
    /// <returns></returns>
    public static DisplayId GetDisplayIdFromMonitor(IntPtr hmonitor)
    {
        Marshal.ThrowExceptionForHR(Windowing_GetDisplayIdFromMonitor(hmonitor, out var displayId));
        return displayId;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="displayId"></param>
    /// <returns></returns>
    public static IntPtr GetMonitorFromDisplayId(DisplayId displayId)
    {
        Marshal.ThrowExceptionForHR(Windowing_GetMonitorFromDisplayId(displayId, out var hmonitor));
        return hmonitor;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="hicon"></param>
    /// <returns></returns>
    public static IconId GetIconIdFromIcon(IntPtr hicon)
    {
        Marshal.ThrowExceptionForHR(Windowing_GetIconIdFromIcon(hicon, out var iconId));
        return iconId;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="iconId"></param>
    /// <returns></returns>
    public static IntPtr GetIconFromIconId(IconId iconId)
    {
        Marshal.ThrowExceptionForHR(Windowing_GetIconFromIconId(iconId, out var hicon));
        return hicon;
    }
}