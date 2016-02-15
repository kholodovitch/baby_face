using System;

namespace winforms
{
	public abstract class UnmanagedObject : DisposableObject 
	{
		protected IntPtr _ptr;

		public IntPtr Ptr
		{
			get
			{
				return _ptr;
			}
		}

		public static implicit operator IntPtr(UnmanagedObject obj)
		{
			return obj == null ? IntPtr.Zero : obj._ptr;
		}
	}
}