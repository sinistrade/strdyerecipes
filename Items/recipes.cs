using Terraria.ID;
using Terraria.ModLoader;

namespace strdyerecipes.Items
{
	public class recipes : ModItem
	{	
		
		public override void AddRecipes()
		{
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddRecipeGroup("strdyerecipes:CopperBars", 20);//Copper bar
			recipe.AddTile(228);
			recipe.SetResult(3553, 3);//Reflective copper dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddRecipeGroup("IronBar", 20);//Iron bar
			recipe.AddTile(228);
			recipe.SetResult(3555, 3);//Reflective metal dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddRecipeGroup("strdyerecipes:SilverBars", 20);//Silver bar
			recipe.AddTile(228);
			recipe.SetResult(3026, 3);//Reflective silver dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddRecipeGroup("strdyerecipes:GoldBars", 20);//Silver bar
			recipe.AddTile(228);
			recipe.SetResult(3027, 3);//Reflective gold dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(173, 75);//Obsidian
			recipe.AddTile(228);
			recipe.SetResult(3554, 3);//Reflective obsidian dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(183, 75);//Glowing mushroom
			recipe.AddTile(228);
			recipe.SetResult(3041, 3);//Glowing mushroom dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(1011, 1);//Green Dye
			recipe.AddIngredient(209, 10);//Stinger
			recipe.AddIngredient(331, 15);//Jungle Spores
			recipe.AddTile(228);
			recipe.SetResult(3040, 3);//Acid dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(1015, 1);//Blue Dye
			recipe.AddIngredient(209, 10);//Stinger
			recipe.AddIngredient(331, 15);//Jungle Spores
			recipe.AddTile(228);
			recipe.SetResult(3028, 3);//Blue acid dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(1007, 1);//Red Dye
			recipe.AddIngredient(209, 10);//Stinger
			recipe.AddIngredient(331, 15);//Jungle Spores
			recipe.AddTile(228);
			recipe.SetResult(3560, 3);//Red acid dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(1016, 1);//Purple Dye
			recipe.AddIngredient(23, 75);//Gel
			recipe.AddTile(228);
			recipe.SetResult(3025, 3);//Purple ooze dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddRecipeGroup("strdyerecipes:CopperBars", 5);//Copper bar
			recipe.AddRecipeGroup("IronBar", 5);//Iron bar
			recipe.AddRecipeGroup("strdyerecipes:SilverBars", 5);//Silver bar
			recipe.AddRecipeGroup("strdyerecipes:GoldBars", 5);//Silver bar
			recipe.AddTile(228);
			recipe.SetResult(3190, 3);//Reflective dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(3380, 20);//Sturdy fossil
			recipe.AddTile(228);
			recipe.SetResult(3534, 3);//Mirage dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddRecipeGroup("strdyerecipes:CursedFlame", 10);//Cursed Flame
			recipe.AddIngredient(520, 6);//Soul of light
			recipe.AddTile(228);
			recipe.SetResult(3038, 3);//Hades dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddRecipeGroup("strdyerecipes:CursedFlame", 10);//Cursed Flame
			recipe.AddIngredient(521, 6);//Soul of Night
			recipe.AddTile(228);
			recipe.SetResult(3597, 3);//Burning hades dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddRecipeGroup("strdyerecipes:CursedFlame", 10);//Cursed Flame
			recipe.AddIngredient(520, 3);//Soul of light
			recipe.AddIngredient(521, 3);//Soul of Night
			recipe.AddTile(228);
			recipe.SetResult(3600, 3);//ShadowflameHades dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(528, 2);//Light shard
			recipe.AddIngredient(520, 6);//Soul of light
			recipe.AddTile(228);
			recipe.SetResult(3039, 3);//Twilight dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(527, 2);//Dark shard
			recipe.AddIngredient(521, 6);//Soul of night
			recipe.AddTile(228);
			recipe.SetResult(3598, 3);//Grim dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(528, 1);//Light shard
			recipe.AddIngredient(527, 1);//Dark shard
			recipe.AddIngredient(520, 3);//Soul of light
			recipe.AddIngredient(521, 3);//Soul of night
			recipe.AddTile(228);
			recipe.SetResult(3042, 3);//Phase dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddRecipeGroup("strdyerecipes:CobaltBar", 20);//Cobalt Bar
			recipe.AddIngredient(23, 125);//Gel
			recipe.AddTile(228);
			recipe.SetResult(3561, 3);//Gel dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddRecipeGroup("strdyerecipes:CobaltBar", 20);//Cobalt Bar
			recipe.AddIngredient(169, 125);//Sand block
			recipe.AddTile(228);
			recipe.SetResult(3533, 3);//Shifting sands dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(1033, 1);//Green flame dye
			recipe.AddIngredient(1225, 20);//Hallowed bar
			recipe.AddTile(228);
			recipe.SetResult(2883, 3);//Chlorophyte dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(1035, 1);//Blue flame dye
			recipe.AddIngredient(1225, 20);//Hallowed bar
			recipe.AddTile(228);
			recipe.SetResult(2873, 3);//Living ocean dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(1031, 1);//Flame dye
			recipe.AddIngredient(1225, 20);//Hallowed bar
			recipe.AddTile(228);
			recipe.SetResult(2869, 3);//Living Flame dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(1066, 1);//Rainbow dye
			recipe.AddIngredient(1225, 20);//Hallowed bar
			recipe.AddTile(228);
			recipe.SetResult(2870, 3);//Living rainbow dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(3261, 20);//Spectre bar
			recipe.AddIngredient(526, 3);//Unicorn horn
			recipe.AddTile(228);
			recipe.SetResult(2884, 3);//Unicorn Wisp dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(3261, 20);//Spectre bar
			recipe.AddIngredient(501, 25);//Pixie dust
			recipe.AddTile(228);
			recipe.SetResult(2879, 3);//Pixie dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(3261, 20);//Spectre bar
			recipe.AddIngredient(148, 3);//Water candle
			recipe.AddTile(228);
			recipe.SetResult(2878, 3);//Wisp dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(3261, 20);//Spectre bar
			recipe.AddIngredient(2701, 25);//Living fire block
			recipe.AddTile(228);
			recipe.SetResult(2885, 3);//Infernal Wisp dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(1044, 1);//Bright Cyan Dye
			recipe.AddIngredient(2860, 25);//Martian conduit plating
			recipe.AddTile(228);
			recipe.SetResult(2864, 3);//Martian dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(1067, 1);//Intense rainbow dye
			recipe.AddIngredient(2860, 25);//Martian conduit plating
			recipe.AddTile(228);
			recipe.SetResult(3556, 3);//Midnight rainbow dye
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("strdyerecipes:StrangePlants", 1);//Strange plant
			recipe.AddIngredient(126, 3);//Bottled water
			recipe.AddIngredient(3467, 20);//Luminite bar
			recipe.AddIngredient(3456, 10);//Vortex fragment
			recipe.AddIngredient(3457, 10);//Nebula fragment
			recipe.AddIngredient(3458, 10);//Solar fragment
			recipe.AddIngredient(3459, 10);//Stardust fragment
			recipe.AddTile(228);
			recipe.SetResult(3024, 3);//Skiphs' blood
			recipe.AddRecipe();
		}
	}
}
