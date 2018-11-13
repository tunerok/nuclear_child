using UnityEngine;

/* An Item that can be equipped to increase armor/damage. */

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Equipment")]
public class Equipment : Item {

	public EquipmentSlot equipSlot;		// What slot to equip it in
	public int armorModifier;
	public int damageModifier;
	public Sprite inv_picture;

	// Called when pressed in the inventory
	public override void Use ()
	{
		EquipmentManager.instance.Equip(this);	// Equip
		RemoveFromInventory();	// Remove from inventory
	}
	
	public override void Touch ()//when_it_on ground
	{
		EquipmentManager.instance.Add_to_inv(this);
		Remove_from_world(this);
	}

}