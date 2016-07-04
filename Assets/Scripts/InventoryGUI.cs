using UnityEngine;
using System.Collections;
using System.Security.Principal;
using System.Collections.Generic;

public class InventoryGUI : MonoBehaviour {

	public List<GameObject> slots = new List<GameObject>();
	public List<Item> items = new List<Item>();
	public GameObject slotPrefab;
	private int x = 35;
	private int y = 150;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 6; i++) {
			for (int j = 0; j < 6; j++) {
				
				GameObject slot = (GameObject) Instantiate (slotPrefab);
				slots.Add (slot);
				items.Add (new Item());
				slot.transform.parent = this.gameObject.transform;
				slot.name = "Slot " + ((i+1) +"."+ (j+1));
				slot.tag = "Placeholder";
				slot.GetComponent<RectTransform>().localPosition = new Vector3(x,y,0);
				x += 55;
				if (j == 5) {
					x = 35;
					y -= 55;
				}
			}
		}
	}

	public void addItem(){
	}
	
}
