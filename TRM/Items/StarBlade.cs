using Terraria.ID;
using Terraria.ModLoader;

namespace TRM.Items
{
	public class StarBlade: ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("StarBlade");
			Tooltip.SetDefault("Calls Stars from the gods" + "'Made from the souls of Mechanical Amalgamations'");
		}

		public override void SetDefaults()
		{
			item.shoot = ProjectileID.HallowStar;
			item.shoot = ProjectileID.Starfury;
			item.shootSpeed = 20;
			item.damage = 72;
			item.melee = true;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 5;
            item.value = 10001;
			item.rare = ItemRarityID.LightRed;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.width = 40;
			item.height = 40;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Starfury, 1);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddIngredient(ItemID.SoulofFright, 5);
			recipe.AddIngredient(ItemID.SoulofMight, 10);
			recipe.AddIngredient(ItemID.SoulofSight, 5);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		

	}
}
