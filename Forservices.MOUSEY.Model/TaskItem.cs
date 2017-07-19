using System;
using System.Runtime.Serialization;

namespace Forservices.MOUSEY.Model
{
	[DataContract]
	[Serializable]
	public class TaskItem
	{
		[DataMember]
		public IntPtr Handle { get; set; }

		[DataMember]
		public string Title { get; set; }

		[DataMember]
		public string FileName { get; set; }

		public int LastShowState { get; set; }

		public bool Added { get; set; }

		public bool Changed { get; set; }

		public DateTime LastUpdateDate { get; set; }

		[DataMember]
		public string Executable { get; set; }

		[DataMember]
		public string ProcessName { get; set; }

		[DataMember]
		public bool TumbGenerated { get; set; }

		public TaskItem()
		{
			Added = false;
			LastUpdateDate = DateTime.Now;
		}

		public override string ToString()
		{
			return Title ?? base.ToString();
		}
	}
}
