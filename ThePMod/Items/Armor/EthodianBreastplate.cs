using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThePMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class EthodianBreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Holy Ethodian Breastplate");
			Tooltip.SetDefault("Weld great power over your chest"
				+ "\nImmunity to 'On Fire!' and +Shine"
				+ "\n+20 max mana and +5 max minions");
		}

		public override void SetDefaults() {
			Item.width = 18;
			Item.height = 18;
			Item.value = 10000;
			Item.rare = 11;
			Item.defense = 112;
		}

		public override void UpdateEquip(Player player) {
			player.buffImmune[BuffID.OnFire] = true;
			player.AddBuff(BuffID.Shine, 0);
			player.statManaMax2 += 20;
			player.maxMinions += 5;
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10000);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}