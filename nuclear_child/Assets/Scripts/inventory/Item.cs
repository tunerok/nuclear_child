using UnityEngine;

/* The base item class. All items should derive from this. */

//[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject {

	new public string name = "New Item";	// Name of the item
	public Sprite world_sprite = null;				// Item sprite pn ground
	public bool showInInventory = true;
	public int type = '0'; 							// type of item

	// Called when the item is pressed in the inventory
	public virtual void Use ()
	{
		// Use the item
		// Something may happen
	}
	
	public virtual void Use ()
	{
		//Touch item, when it on ground
	}
	

	// Call this method to remove the item from inventory
	public void RemoveFromInventory ()
	{
		Inventory.instance.Remove(this);
	}

}