namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pizza", "OrderRule_Id", "dbo.OrderRule");
            DropForeignKey("dbo.Pizza", "PizzaIngredient_Id", "dbo.Pizza_Ingredient");
            DropIndex("dbo.Pizza", new[] { "OrderRule_Id" });
            DropIndex("dbo.Pizza", new[] { "PizzaIngredient_Id" });
            AddColumn("dbo.Pizza_Ingredient", "PizzaIngredient_Id", c => c.Guid(nullable: false));
            AddColumn("dbo.Pizza", "OrderRuleId", c => c.Guid(nullable: false));
            CreateIndex("dbo.OrderRule", "OrderId");
            CreateIndex("dbo.Pizza_Ingredient", "PizzaIngredient_Id");
            AddForeignKey("dbo.OrderRule", "OrderId", "dbo.Order", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Pizza_Ingredient", "PizzaIngredient_Id", "dbo.Pizza", "Id", cascadeDelete: true);
            DropColumn("dbo.Bottom", "PizzaId");
            DropColumn("dbo.Order", "OrderRuleId");
            DropColumn("dbo.Pizza_Ingredient", "PizzaId");
            DropColumn("dbo.Pizza", "OrderRule_Id");
            DropColumn("dbo.Pizza", "PizzaIngredient_Id");
            DropColumn("dbo.Sauce", "BottomId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sauce", "BottomId", c => c.Guid(nullable: false));
            AddColumn("dbo.Pizza", "PizzaIngredient_Id", c => c.Guid());
            AddColumn("dbo.Pizza", "OrderRule_Id", c => c.Guid());
            AddColumn("dbo.Pizza_Ingredient", "PizzaId", c => c.Guid(nullable: false));
            AddColumn("dbo.Order", "OrderRuleId", c => c.Guid(nullable: false));
            AddColumn("dbo.Bottom", "PizzaId", c => c.Guid(nullable: false));
            DropForeignKey("dbo.Pizza_Ingredient", "PizzaIngredient_Id", "dbo.Pizza");
            DropForeignKey("dbo.OrderRule", "OrderId", "dbo.Order");
            DropIndex("dbo.Pizza_Ingredient", new[] { "PizzaIngredient_Id" });
            DropIndex("dbo.OrderRule", new[] { "OrderId" });
            DropColumn("dbo.Pizza", "OrderRuleId");
            DropColumn("dbo.Pizza_Ingredient", "PizzaIngredient_Id");
            CreateIndex("dbo.Pizza", "PizzaIngredient_Id");
            CreateIndex("dbo.Pizza", "OrderRule_Id");
            AddForeignKey("dbo.Pizza", "PizzaIngredient_Id", "dbo.Pizza_Ingredient", "Id");
            AddForeignKey("dbo.Pizza", "OrderRule_Id", "dbo.OrderRule", "Id");
        }
    }
}
