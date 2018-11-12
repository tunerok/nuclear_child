using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class little_menu : MonoBehaviour {

	#region Singleton

	public static little_menu instance;

	void Awake ()
	{
		instance = this;
	}

	#endregion

	public delegate void OnItemChanged();
	public OnItemChanged onItemChangedCallback;

	public int space = 10;	// Amount of item spaces

	// Our current list of items in the inventory
	public List<Item> items = new List<Item>();

	// Add a new item if enough room
	public void Add (Item item, string act)
	{
		if (range) {
			if (items.Count >= space) {
				Debug.Log ("Not enough room.");
				return;
			}

			items.Add (act, item);

			if (onItemChangedCallback != null)
				onItemChangedCallback.Invoke ();
		}
	}
	
	public UpdateUi()//slow update
	{
		items.clear();
		items.SearchNear();
	}
	
	public void SearchNear(){
		string action;
		for (i; player_coord)
		{
			if (game_object.x^2, game_object.y^2 < 10)
			{
				
				switch (item.type)
					case 1:
						action = 'Использовать';
					case 2:
						action = 'Подобрать';
					case 3:
						action = 'Схватить';
					Add(game_object.name, action);
			}
		}
	}

	// Remove an item
	public void Remove (Item item)
	{
		items.Remove(item);

		if (onItemChangedCallback != null)
			onItemChangedCallback.Invoke();
	}
	
	public void click_item(Item item)
	{
		switch (item.type) 
		{
			case 1:		//door and single iteraction with closing
				item.instatinate();
				close this;
			case 2:		//take to player's inventory 
				Add_to_main_item(item);
				Destroy(item);
			case 3:
				item.grab();
		}
		
		
	}

}