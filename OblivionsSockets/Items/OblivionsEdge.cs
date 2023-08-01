using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OblivionsSockets.Items
{
	public class OblivionsEdge : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.OblivionsSockets.hjson file.

		public override void SetDefaults()
		{
			Item.damage = 8;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 8;
			Item.useAnimation = 8;
			Item.useStyle = 1;
			Item.knockBack = 6000;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void ModifyHitPlayer( Player target, ref int damage, ref bool crit )
		{
			target.AddBuff( mod.BuffType( "Frozen" ), 240 );
		}
		public override void ModifyHitNPC( NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection )
		{
			target.AddBuff( mod.BuffType( "Frozen" ), 240 );
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}