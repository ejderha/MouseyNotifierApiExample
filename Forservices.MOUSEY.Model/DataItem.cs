using System;
using System.Runtime.Serialization;

namespace Forservices.MOUSEY.Model
{
	/// <summary>
	/// This is a single dataitem object containing the needed data for performing a single notify action in Mousey.
	/// </summary>
	[Serializable]
	[DataContract]
	public class DataItem
	{
		/// <summary>
		/// Indicates whether the command should be executed when received.
		/// </summary>
		[DataMember(IsRequired = true)]
		public bool AutoPopup { get; set; }

		/// <summary>
		/// Indicates whether the command should be executed on a given date/time.
		/// </summary>
		[DataMember(IsRequired = false)]
		public DateTime? ExecuteDate { get; set; }

		/// <summary>
		/// Gets or sets a note of the notification. The note is displayed to the user what to do with the notification.
		/// </summary>
		[DataMember(IsRequired = false)]
		public string Note { get; set; }

		/// <summary>
		/// Indicates the creation date of this data item object.
		/// </summary>
		[DataMember(IsRequired = true)]
		public DateTime RecordDate { get; set; }

		/// <summary>
		/// Gets or sets the reference id of the notification.
		/// </summary>
		[DataMember(IsRequired = false)]
		public string Reference { get; set; }

		/// <summary>
		/// Gets or sets the userid to whom this dataitem belongs to.
		/// The filtering is done on the api side (you can deside if you want to use this functionality). 
		/// </summary>
		[DataMember(IsRequired = false)]
		public string UserId { get; set; }

		/// <summary>
		/// Indicates which application provided this notification.
		/// </summary>
		[DataMember(IsRequired = false)]
		public string Source { get; set; }

		/// <summary>
		/// Gets or sets the command which should be performed on Mousey.
		/// This action is depended on the type of search which is enabled on Mousey.
		/// 
		/// When the windows search is enabled/checked cortana will be provided with the command data,
		/// Contana can make suggestions for completing the command.
		/// 
		/// When the windows search is disabled, windows cmd can be performed or a web browser can be started with the given data
		/// like performing a search or send in a complete url for opening the desired page.
		/// Keep in mind that url landing features should be present in the opening page.
		/// With auto login/impersionation features.
		/// </summary>
		[DataMember(IsRequired = true)]
		public string Command { get; set; }

		[IgnoreDataMember]
		public bool Send { get; set; }

		public DataItem()
		{
			this.RecordDate = DateTime.Now;
		}
	}
}
