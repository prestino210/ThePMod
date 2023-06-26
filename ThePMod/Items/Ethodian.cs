using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace ThePMod.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class Ethodian : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("Ethodian Shield");
			Tooltip.SetDefault("This item carries a soul within it...");
		}

		public override void SetDefaults() {
			Item.width = 24;
			Item.height = 28;
			Item.value = 10000;
			Item.rare = 11;
			Item.accessory = true;
			Item.defense = 2000;
			Item.lifeRegen = 30;
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10000);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}