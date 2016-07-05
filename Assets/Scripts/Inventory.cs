using UnityEngine;
using System.Collections;
using System.Security.Principal;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	public List<GameObject> slots = new List<GameObject>();
	public List<Item> items = new List<Item>();
	public GameObject slotPrefab;
	public GameObject toolTip;
	public GameObject draggedItemPrefab;
	public bool isDragging;

	private ItemDatabase itemDatabase;
	private int x = 35;
	private int y = 150;

	void Start () {

		itemDatabase = GameObject.FindGameObjectWithTag ("ItemDatabase").GetComponent <ItemDatabase> ();

		for (int i = 0; i < 6; i++) {
			for (int j = 0; j < 6; j++) {
				
				GameObject slot = (GameObject) Instantiate (slotPrefab);
				slot.GetComponent <InventorySlot>().slotNumber = slots.Count;
				slot.transform.SetParent (this.gameObject.transform);
				slot.name = "Slot " + ((i+1) +"."+ (j+1));
				slot.tag = "Placeholder";
				slot.GetComponent<RectTransform>().localPosition = new Vector3(x,y,0);
				slots.Add (slot);
				items.Add (new Item());
				x += 55;
				if (j == 5) {
					x = 35;
					y -= 55;
				}
			}
		}

		addItem (1);
		addItem (2);
	}

	void Update(){
	
		if (isDragging) {
			Vector3 position = (Input.mousePosition - GameObject.FindGameObjectWithTag ("Canvas").GetComponent<RectTransform> ().localPosition);
			draggedItemPrefab.GetComponent<RectTransform> ().localPosition = new Vector3(position.x + 15, position.y - 15, position.z);
		}
	}

	public void addItem(int id){
		foreach (Item item in itemDatabase.items) {
			if (item.id == id) {
				addItem (item);
				break;
			}
		}
	}

	public void addItem(Item item){
		for(int i = 0;i<items.Count;i++){
			if (items[i].name == null) {
				items [i] = item;
				break;
			}
		}
	}

//	public void showToolTip(Vector3 position, Item item){
//		toolTip.SetActive (true);
//		toolTip.GetComponent <RectTransform>().localPosition = new Vector3(position.x - 445, position.y, position.z);
//	}
}
