using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using Repository.Users;
using Repository.Entities.Pizza_Components;
using Repository.Entities.Connections;
using Repository.Entities.Pizza_Components.IngredientTypes;
using Repository.Entities.Pizza_Components.BottomType;

namespace Repository.DBCon
{
	public class PizzariaDB : DbContext
	{
		public PizzariaDB() : base("dbi433786")
		{
			Database.SetInitializer<PizzariaDB>(null);
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.HasDefaultSchema("dbo");
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Order> Order { get; set; }
		public DbSet<OrderRule> OrderRule { get; set; }
		public DbSet<Pizza> Pizzas { get; set; }
		public DbSet<Pizza_Ingredient> PizzaIngredient { get; set; }
		public DbSet<Ingredients> Ingredient { get; set; }
		public DbSet<Bottom> Bottom { get; set; }
		public DbSet<Sauce> Sauce { get; set; }
	}
}
