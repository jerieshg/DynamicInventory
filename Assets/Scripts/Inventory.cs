using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{

	InventorySlot[] slots = new InventorySlot[32];

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

		}

		if (Input.GetMouseButtonDown (0)) {
			/*RaycastHit hit = new RaycastHit ();
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			GameObject something = GameObject.FindWithTag (ItemType.PickableItem.ToString ());
			if (Physics.Raycast (ray, out hit, 100f)) {
			}*/
		}
	}

	public void addItem (Item item)
	{
		//Add Restrictions
		InventorySlot slot = new InventorySlot ();
		slot.addItem (item);
		//slots.Add (slot);
	}

	private void drawInventory ()
	{
		foreach (InventorySlot slot in slots) {
			GameObject cube =
				Instantiate (Resources.Load ("Cube"),
					new Vector2 (1, 1),
					Quaternion.identity) as GameObject;

			if (slot != null && slot.getItem () != null) {
				cube.GetComponent <ItemPreview> ().setItem (slot.getItem ());
			}
			cube.transform.parent = gameObject.transform;
		}
	}

}
