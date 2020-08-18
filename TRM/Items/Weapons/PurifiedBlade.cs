using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TRM.Items.Weapons
{
    public class PurifiedBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Made from the purest form of essences.");
        }
        public override void SetDefaults()
        {
            item.shoot = ProjectileID.PurificationPowder;
            item.damage = 70;
            item.useTime = 15;
            item.melee = true;
            item.width = 20;
            item.height = 20;
            item.useAnimation = 15;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 1;
            item.value = 10000;
            item.rare = ItemRarityID.Orange;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Daybloom, 5);
            recipe.AddIngredient(ItemID.SoulofLight, 10);
            recipe.AddIngredient(ItemID.PurificationPowder, 5);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
