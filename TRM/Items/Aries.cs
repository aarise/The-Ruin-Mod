using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TRM.Items
{
	public class Aries : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Rains Multiple Stars from the sky, 'Forged with the blade of the gods.'");
		}

		public override void SetDefaults() 
		{
			item.shoot = ProjectileID.Starfury;
			item.shootSpeed = 15;
			item.damage = 26;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = ItemRarityID.Orange;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Starfury, 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddIngredient(ItemID.Feather, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}