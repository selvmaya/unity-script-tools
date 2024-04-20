using UnityEngine;

namespace Tools.Types
{
	public interface IToggleLogged
	{
		// the only implemented
		protected internal bool EnableLog { get; }
		protected Object Context => this as Object; // override full context

		private string UpperTypeName => GetType().Name.ToUpper();

		public void Log(string msg)
		{
			if (EnableLog)
			{
				Debug.Log($"{UpperTypeName}: {msg}", Context);
			}
		}

		public void LogWarning(string msg)
		{
			if (EnableLog)
			{
				Debug.LogWarning($"{UpperTypeName}: {msg}", Context);
			}
		}

		public void LogError(string msg)
		{
			if (EnableLog)
			{
				Debug.LogError($"{UpperTypeName}: {msg}", Context);
			}
		}
	}
}