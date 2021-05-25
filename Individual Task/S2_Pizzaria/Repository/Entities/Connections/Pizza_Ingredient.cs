using Repository.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities.Connections
{
	public class Pizza_Ingredient : EntityModelBase
	{
		public Guid PizzaIngredient_Id { get; set; }
		public Guid IngriedientId { get; set; }
	}
}
