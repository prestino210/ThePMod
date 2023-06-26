using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThePMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class NightShadeHood : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("NightShade Hood");
			Tooltip.SetDefault("Hidden from the light you are" 
				+ "\nIncreased mana regeneration");
		}

		public override void SetDefaults() {
			Item.width = 18;
			Item.height = 18;
			Item.value = 10000;
			Item.rare = 10;
			Item.defense = 35;
		}

		public override void UpdateArmorSet(Player player) {
		
			player.AddBuff(BuffID.ManaRegeneration, 0);
			
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10000);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}