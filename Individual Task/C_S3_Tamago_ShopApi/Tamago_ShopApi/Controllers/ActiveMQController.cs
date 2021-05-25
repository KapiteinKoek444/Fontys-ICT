using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shared.Extensions.ActiveMQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tamago_ShopApi.Models;

namespace Tamago_ShopApi.Controllers
{
	[ApiController]
	[Route("active")]
	public class ActiveMQController : Controller
	{
		private IMongoCollection<FoodDTO> _foodCollection;
		private readonly IActiveMqLog _activeMQLog;

		public ActiveMQController(IMongoClient client, IActiveMqLog activeMQLog)
		{
			var database = client.GetDatabase("Shop_Database");
			_foodCollection = database.GetCollection<FoodDTO>("CFood");
		}

	}
}
