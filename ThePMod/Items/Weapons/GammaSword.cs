using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;


namespace ThePMod.Items.Weapons
{
	public class GammaSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gamma Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Speed over damage.");
		}

		public override void SetDefaults()
		{
			Item.damage = 95;
			Item.DamageType = DamageClass.Melee;
			Item.width = 49;
			Item.height = 49;
			Item.useTime = 6;
			Item.useAnimation = 6;
			Item.useStyle = 1;
			Item.knockBack = 15;
			Item.value = 12000;
			Item.rare = 10;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
            Item.crit = 35; 
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 120000);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}

                public override void MeleeEffects(Player player, Rectangle hitbox) {
			if (Main.rand.NextBool(3)) {
				//Emit dusts when the sword is swung
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ModContent.DustType<Dusts.Radiate>());
			}
		}

		 
	}
}