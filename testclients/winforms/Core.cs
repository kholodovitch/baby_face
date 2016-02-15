namespace winforms
{
	public class Core : UnmanagedObject 
	{
		private PInvoke.FrameCallback _callbackFrame;

		public Core()
		{
			_ptr = PInvoke.Core_New();
		}

		protected override void DisposeObject()
		{
			PInvoke.Core_Delete(ref _ptr);
		}

		public void SetCallbackFrame(PInvoke.FrameCallback callback)
		{
			_callbackFrame = callback;
			PInvoke.Core_SetCallbackFrame(_ptr, _callbackFrame);
		}

		public void StartStream()
		{
			PInvoke.Core_StartStream(_ptr);
		}
	}
}