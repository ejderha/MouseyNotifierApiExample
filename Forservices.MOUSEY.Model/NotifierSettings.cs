using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Forservices.MOUSEY.Model
{
	[Serializable]
	[DataContract]
	public class NotifierSettings
	{
		[DataMember(IsRequired = true)]
		public string User { get; set; }

		[DataMember]
		public string Password { get; set; }

		[DataMember]
		public List<Service> Services { get; set; }

		public NotifierSettings()
		{
			this.Services = new List<Service>();
		}
	}
}
