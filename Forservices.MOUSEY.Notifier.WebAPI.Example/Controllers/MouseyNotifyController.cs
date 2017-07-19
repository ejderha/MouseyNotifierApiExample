using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using Forservices.MOUSEY.Model;

namespace Forservices.MOUSEY.Notifier.WebAPI.Example.Controllers
{
	[System.Web.Mvc.RoutePrefix("Mousey")]
	public class MouseyNotifyController : Controller
	{
		// GET api/values
		[System.Web.Mvc.Route("Notifications")]
		[System.Web.Mvc.HttpGet]
		public JsonResult Get(string username = null)
		{
			// You can get the DataItems from the DB/MessageQueue or any other desired location.

			// Your return result should be of type DataItem, this object contains all needed properties for executing a notify operation.
			// All the needed properties are explained in the following code lines.

			// Create a new result list from mapper or manually like the following line.
			List<MOUSEY.Model.DataItem> result = new List<DataItem>();

			// THIS IS MOCK/TEST DATA
			result.Add(new DataItem()
			{
				// Search features:
				// When the windows search is enabled/checked cortana will be provided with the command data,
				// Contana can make suggestions for completing the command.

				// Make a appointment with Hans.
				// Or send email to john@john.com
				// Or how is the weather :), or try this one, time to go home how is the traffic.
				
				// When the windows search is disabled, windows cmd can be performed or a web browser can be started with the given data
				// like performing a search or send in a complete url for opening the desired page.
				// Keep in mind that url landing features should be present in the opening page.
				// With auto login/impersionation features.
				
				Command = "Aex stock",

				// This indicates that the command will be executed directly, when received by mousey.
				// Set the "ExecuteDate" property when you set this property value to false.
				AutoPopup = true,

				// This indicates that the command will be executed when given date has passed.
				// You can leave this property value null, if you set "AutoPopup" property to true.
				ExecuteDate = null,

				// This property is used to give in a note for the user. The note will be visible at mouse location,
				// It's very handy to give some explaination what to do.
				Note = "Perform a search on google for AEX indices.",

				// This is the internal id of the dataitem. This is very handy when Mousey logs are available (future plan).
				Reference = Guid.NewGuid().ToString(),

				// This is the internal called id of the dataitem. This is very handy when Mousey logs are available (future plan).
				Source = "Mousey Notifier Test API",

				// This is the internal called creation date of the dataitem. This is very handy when Mousey logs are available (future plan).
				RecordDate = DateTime.Now,

				// This indicates that the data item is already send, very handy when fetching records fox example from the database.
				Send = false
			});

			// You can now filter the data by the userid which is provided from mousey, if you want.
			//return result.Where(i => i.Reference == userid).ToList();

			return Json(result.Where(i => !i.Send), JsonRequestBehavior.AllowGet);
		}
	}
}
