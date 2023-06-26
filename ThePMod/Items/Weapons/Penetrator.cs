using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ModLoader.IO;
using Terraria.Audio;


namespace ThePMod.Items.Weapons
{
	public class Penetrator : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("The Penetrator");
			Tooltip.SetDefault("The Penetrator. Blast through and absolutely DISINTEGRATE your enemies guts.");
		}

		public override void SetDefaults() {
			Item.damage = 850; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			Item.DamageType = DamageClass.Ranged;
			Item.width = 40; // hitbox width of the item
			Item.height = 20; // hitbox height of the item
			Item.UseSound = SoundID.Item11;
			Item.useTime = 25; // The item's use time in ticks (60 ticks == 1 second.)
			Item.useAnimation = 25; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			Item.useStyle = 5; // how you use the item (swinging, holding out, etc)
			Item.noMelee = true; //so the item's animation doesn't do damage
			Item.knockBack = 15; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			Item.value = 30000; // how much the item sells for (measured in copper)
			Item.rare = 13; // the color that the item's name will be in-game
			Item.autoReuse = false; // if you can hold click to automatically use it again
			Item.shoot = 1; //idk why but all the guns in the vanilla source have this
			Item.shootSpeed = 10; // the speed of the projectile (measured in pixels per frame)
			Item.useAmmo = AmmoID.Bullet; // The "ammo Id" of the ammo item that this weapon uses. Note that this is not an item Id, but just a magic value.
			Item.crit = 45;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 300000);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}

		

		
	}
}