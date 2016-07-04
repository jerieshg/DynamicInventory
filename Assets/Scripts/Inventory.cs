using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
	private Rect inventoryWindow;
	InventorySlot[] slots = new InventorySlot[32];
	bool openInventory;

	public void Start ()
	{
		/*Item item = new Item ();
		item.setId (1);
		item.setName ("Test Item");
		item.setDescription ("This is an item to test");
		addItem (item);*/
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.I)) {
			openInventory = !openInventory;
		}
	}

	void OnGUI(){
		if (openInventory) {
			GUI.Window (1, inventoryWindow,DrawInventoryWindow, "Inventory"); 
		}
	}

	public void addItem (Item item)
	{
		//Add Restrictions
		InventorySlot slot = new InventorySlot ();
//		slot.addItem (item);
		//slots.Add (slot);
	}

	private void DrawInventoryWindow (int windowID)
	{
//		foreach (InventorySlot slot in slots) {
//			GameObject cube =
//				Instantiate (Resources.Load ("Cube"),
//					new Vector2 (1, 1),
//					Quaternion.identity) as GameObject;
//
//			if (slot != null && slot.getItem () != null) {
//				cube.GetComponent <ItemPreview> ().setItem (slot.getItem ());
//			}
//			cube.transform.parent = gameObject.transform;
//		}
	}

}
