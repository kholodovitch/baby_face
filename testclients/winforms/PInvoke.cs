using System;
using System.Runtime.InteropServices;

namespace winforms
{
	public static class PInvoke
	{
		public const string DllPath = @"Core.dll";

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr Core_New();

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void Core_Delete(ref IntPtr core);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
		public static extern void Core_StartStream(IntPtr core);

		[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
		public static extern void Core_SetCallbackFrame(IntPtr core, [MarshalAs(UnmanagedType.FunctionPtr)] FrameCallback callback);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate void FrameCallback(IntPtr data, int width, int height, int step);
	}
}