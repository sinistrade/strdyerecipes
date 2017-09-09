using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace strdyerecipes
{
	class strdyerecipes : Mod
	{
		public strdyerecipes()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
		
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Strange Plant", new int[]
			{
				3385,
				3386,
				3387,
				3388
			});
			RecipeGroup.RegisterGroup("strdyerecipes:StrangePlants", group);
			
			group = new RecipeGroup(() => Lang.misc[37] + " Copper Bar", new int[]
			{
				20,
				703
			});
			RecipeGroup.RegisterGroup("strdyerecipes:CopperBars", group);
			
			group = new RecipeGroup(() => Lang.misc[37] + " Silver Bar", new int[]
			{
				21,
				705
			});
			RecipeGroup.RegisterGroup("strdyerecipes:SilverBars", group);
			
			group = new RecipeGroup(() => Lang.misc[37] + " Gold Bar", new int[]
			{
				19,
				706
			});
			RecipeGroup.RegisterGroup("strdyerecipes:GoldBars", group);
			
			group = new RecipeGroup(() => Lang.misc[37] + " Cursed Flame", new int[]
			{
				522,
				1332
			});
			RecipeGroup.RegisterGroup("strdyerecipes:CursedFlame", group);
			
			group = new RecipeGroup(() => Lang.misc[37] + " Cobalt Bar", new int[]
			{
				381,
				1184
			});
			RecipeGroup.RegisterGroup("strdyerecipes:CobaltBar", group);
		}
	}
}
