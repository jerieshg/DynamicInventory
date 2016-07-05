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
		items.Add (item1);

		Item item2 = new Item ("Leather Armor");
		item2.id = 2;
		item2.description = "Leather Armor worn by the Vikings.";
		item2.itemType = ItemType.Chest;
		items.Add (item2);
	}
}
