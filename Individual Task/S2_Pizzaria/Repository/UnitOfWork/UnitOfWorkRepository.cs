using Repository.DBCon;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UnitOfWork
{
	public class UnitOfWorkRepository
	{
		private PizzariaDB context;
		private UserRepository userRepository;
		private OrderRepository orderRepository;
		private PizzaRepository pizzaRepository;
		private IngredientRepository ingredientRepository;
		private BottomRepository bottomRepository;
		private SauceRepository sauceRepository;
		private Pizza_IngredientRepository pizzaIngredientRepository;
		private OrderRuleRepository orderRuleRepository;

		public UnitOfWorkRepository()
		{
			context = new PizzariaDB();
		}

		public UserRepository UserRepository
		{
			get
			{
				if(userRepository == null)
				{
					userRepository = new UserRepository(context);
				}
				return userRepository;
			}
		}

		public OrderRepository OrderRepository
		{
			get
			{
				if (orderRepository == null)
				{
					orderRepository = new OrderRepository(context);
				}
				return orderRepository;
			}
		}

		public PizzaRepository PizzaRepository
		{
			get
			{
				if (pizzaRepository == null)
				{
					pizzaRepository = new PizzaRepository(context);
				}
				return pizzaRepository;
			}
		}

		public IngredientRepository IngredientRepository
		{
			get
			{
				if (ingredientRepository == null)
				{
					ingredientRepository = new IngredientRepository(context);
				}
				return ingredientRepository;
			}
		}

		public BottomRepository BottomRepository
		{
			get
			{
				if (bottomRepository == null)
				{
					bottomRepository = new BottomRepository(context);
				}
				return bottomRepository;
			}
		}

		public SauceRepository SauceRepository
		{
			get
			{
				if (sauceRepository == null)
				{
					sauceRepository = new SauceRepository(context);
				}
				return sauceRepository;
			}
		}

		public Pizza_IngredientRepository PizzaIngredientRepository
		{
			get
			{
				if (pizzaIngredientRepository == null)
				{
					pizzaIngredientRepository = new Pizza_IngredientRepository(context);
				}
				return pizzaIngredientRepository;
			}
		}

		public OrderRuleRepository OrderRuleRepository
		{
			get
			{
				if (orderRuleRepository == null)
				{
					orderRuleRepository = new OrderRuleRepository(context);
				}
				return orderRuleRepository;
			}
		}
	}
}
