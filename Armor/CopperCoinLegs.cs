using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace StrangeThings.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class CopperCoinLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Copper Coin Greaves");
			Tooltip.SetDefault("A pair of greaves crafted out of money. \nYou feel richer while wearing it.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 100;
			item.defense = 3;
			item.value = Item.sellPrice(0, 0, 1, 25);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("CopperCoinChest") && legs.type == mod.ItemType("CopperCoinLegs");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.meleeDamage *= 1.0f;
			player.thrownDamage *= 1.0f;
			player.rangedDamage *= 1.0f;
			player.magicDamage *= 1.0f;
			player.minionDamage *= 1.0f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
	        recipe.AddIngredient(mod.GetItem("LargeCCoin"), 1);
			recipe.AddIngredient(mod.GetItem("CompressedCCoin"), 1);
		    recipe.AddIngredient(ItemID.CopperGreaves);
		    recipe.AddTile(TileID.Anvils);
		    recipe.SetResult(this);
		    recipe.AddRecipe();
		}
	}
}