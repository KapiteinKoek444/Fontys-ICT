using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tamago_InventoryApi.Models;

namespace Tamago_InventoryApi.Controllers
{
	[ApiController]
	[Route("rest")]
	public class RestController : Controller
	{
		private IMongoCollection<InventoryDTO> _inventoryCollection;

		public RestController(IMongoClient client)
		{
			var database = client.GetDatabase("Inventory_Database");
			_inventoryCollection = database.GetCollection<InventoryDTO>("CInventory");
		}

		[HttpGet]
		public IEnumerable<InventoryDTO> Get()
		{
			var data = _inventoryCollection.Find(Builders<InventoryDTO>.Filter.Empty).ToList();
			return data;
		}

		[HttpGet("{id}")]
		public InventoryDTO Get([FromRoute] Guid id)
		{
			var filter = Builders<InventoryDTO>.Filter.Eq("id", id);
			var data = _inventoryCollection.Find(filter).First();
			return data;
		}

		[HttpDelete("{id}")]
		[Route("remove")]
		public InventoryDTO Remove([FromRoute] Guid id)
		{
			var filter = Builders<InventoryDTO>.Filter.Eq("id", id);
			var data = _inventoryCollection.FindOneAndDelete(filter);
			return data;
		}

		[HttpPost]
		[Route("post")]
		public IActionResult Post([FromBody] InventoryDTO inv)
		{
			_inventoryCollection.InsertOne(inv);
			return StatusCode(StatusCodes.Status201Created, inv);
		}

		[HttpPost]
		[Route("new")]
		public IActionResult Post([FromRoute] Guid userid)
		{
			InventoryDTO inv = new InventoryDTO();
			inv.id = Guid.NewGuid();
			inv.userId = userid;
			inv.itemId = new List<string>();
			_inventoryCollection.InsertOne(inv);
			return StatusCode(StatusCodes.Status201Created, inv);
		}
	}
}
