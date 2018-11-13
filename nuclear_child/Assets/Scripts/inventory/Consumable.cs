using UnityEngine;

/* An Item that can be consumed. So far that just means regaining health */

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Consumable")]
public class Consumable : Item {

	public int healthGain;		// How much health?
	public int Radiation;
	public int kkal;
	public int sleeping;

	// This is called when pressed in the inventory
	public override void Use()
	{
		// Heal the player
		PlayerStats playerStats = Player.instance.playerStats;
		playerStats.Start_Heal(healthGain);

		Debug.Log(name + " consumed!");

		RemoveFromInventory();	// Remove the item after use
	}
	
	public override void Touch ()//when_it_on ground
	{
		EquipmentManager.instance.Add_to_inv(this);
		Remove_from_world(this);
	}


}