using System;
using System.Runtime.Serialization;

namespace Forservices.MOUSEY.Model
{
	/// <summary>
	/// This is the setup to pickup all services for notifications.
	/// Plus the settings like pull interval (heart beat of the company)
	/// </summary>
	[Serializable]
	[DataContract]
	public class Service
	{
		[DataMember(IsRequired = true)]
		public string CronExpression { get; set; }

		[DataMember(IsRequired = true)]
		public bool Enabled { get; set; }

		[DataMember]
		public DateTime LastRunDate { get; set; }

		[DataMember]
		public DateTime? NextRunDate { get; set; }

		[DataMember]
		public int RunAtMinutes { get; set; }

		public bool Running { get; set; }

		[DataMember(IsRequired = true)]
		public string Url { get; set; }

		public Service()
		{
			this.Running = false;
		}
	}
}
