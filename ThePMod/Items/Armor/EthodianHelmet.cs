using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ThePMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class EthodianHelmet : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Ethodian Helm");
			Tooltip.SetDefault("Behold, the godly helmet." 
				+ "\n+Shine and 10% increased damage" 
				+ "\n+20 max mana and +5 max minions");
		}

		public override void SetDefaults() {
			Item.width = 18;
			Item.height = 18;
			Item.value = 12000;
			Item.rare = 11;
			Item.defense = 120;
		}

		public override void UpdateArmorSet(Player player) {
			player.AddBuff(BuffID.Shine, 0);
			player.AddBuff(BuffID.Wrath, 0);
			player.statManaMax2 += 20;
			player.maxMinions += 5;
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 12000);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}