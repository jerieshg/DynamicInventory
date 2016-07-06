using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {

	public List<Item> items = new List<Item>();

	// Use this for initialization
	void Start () {
		Item item1 = new Item ("Megaman Helmet");
		item1.id = 1;
		item1.description = "Helmet used by Megaman.";
		item1.itemType = ItemType.Head;
		item1.itemValue = 1;
		items.Add (item1);

		Item item2 = new Item ("Leather Armor");
		item2.id = 2;
		item2.description = "Leather Armor worn by the Vikings.";
		item2.itemType = ItemType.Chest;
		item2.itemValue = 1;
		items.Add (item2);

		Item item3 = new Item ("Pepperup Potion");
		item3.id = 3;
		item3.description = "Potion used by Harry Potter";
		item3.itemType = ItemType.Consumable;
		item3.itemValue = 1;
		items.Add (item3);
	}
}
