using System;

namespace winforms
{
	public abstract class DisposableObject : IDisposable
	{
		private bool _disposed;

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		private void Dispose(bool disposing)
		{
			if (_disposed)
				return;
			_disposed = true;

			if (disposing)
				ReleaseManagedResources();

			DisposeObject();
		}

		protected virtual void ReleaseManagedResources()
		{
		}

		protected abstract void DisposeObject();

		~DisposableObject()
		{
			Dispose(false);
		}
	}
}