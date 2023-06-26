using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ThePMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class EthodianLeggings : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Ethodian Leggins");

			Tooltip.SetDefault("Dont step in anything bad"
				+ "\n7% increased movement speed");
		}

		public override void SetDefaults() {
			Item.width = 18;
			Item.height = 18;
			Item.value = 9000;
			Item.rare = 10;
			Item.defense = 55;
		}

		public override void UpdateEquip(Player player) {
			player.moveSpeed += 0.07f;
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 9000);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}