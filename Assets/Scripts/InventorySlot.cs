using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventorySlot : MonoBehaviour {

	private Item item;

	public void addItem(Item item){
		this.item = item;
	}

	public Item getItem(){
		return item;
	}


}
