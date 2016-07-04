using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler {

	public Item item;
	private Image itemImage;	



	void Start(){
		itemImage = gameObject.transform.GetChild (0).GetComponent <Image> ();
	}

	void Update(){
		if (item != null) {
			itemImage.enabled = true;
			itemImage.sprite = item.icon;
		} else {
			itemImage.enabled = false;
		}
	}

	public void OnPointerDown(PointerEventData data){
		print (gameObject.transform.name);
	}

	public void OnPointerEnter(PointerEventData data){
		print (gameObject.transform.name);
	}

}
