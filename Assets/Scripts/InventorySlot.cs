using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler,IPointerExitHandler, IDragHandler {

	public Item item;
	public int slotNumber;
	private Image itemImage;
	private Inventory inventory;

	void Start(){
		itemImage = gameObject.transform.GetChild (0).GetComponent <Image> ();
		inventory = GameObject.FindGameObjectWithTag ("Inventory").GetComponent <Inventory> ();
	}

	void Update(){
		item = inventory.items [slotNumber];
		if (item.name != null) {
			itemImage.enabled = true;
			itemImage.sprite = item.icon;
		} else {
			itemImage.enabled = false;
		}
	}

	public void OnPointerDown(PointerEventData data){
		if (item.name == null && inventory.isDragging) {
			Item draggedItem = inventory.draggedItemPrefab.GetComponent<DragItem> ().draggedItem;
			inventory.items [slotNumber] = draggedItem;

			closeDraggedItem ();
		} else if (inventory.isDragging && item.name != null) {
			DragItem draggedItem = inventory.draggedItemPrefab.GetComponent<DragItem> ();
			inventory.items [draggedItem.index] = inventory.items [slotNumber];
			inventory.items [slotNumber] = draggedItem.draggedItem;
			closeDraggedItem();
		}
	}

	public void OnPointerEnter(PointerEventData data){
		if (item.name != null && !inventory.isDragging) {
			Vector3 currentPosition = inventory.slots [slotNumber].GetComponent <RectTransform> ().localPosition;
			inventory.toolTip.SetActive (true);
			inventory.toolTip.GetComponent <RectTransform>().localPosition = new Vector3(currentPosition.x - 445, currentPosition.y, currentPosition.z);
			inventory.toolTip.transform.GetChild (0).GetComponent <Text>().text = item.name;
			inventory.toolTip.transform.GetChild (1).GetComponent <Text>().text = item.description;
		}
	}

	public void OnPointerExit(PointerEventData data){
		if (item.name != null) {
			inventory.toolTip.SetActive (false);
		}
	}

	public void OnDrag(PointerEventData data){
		if (item.name != null) {
			inventory.draggedItemPrefab.SetActive (true);
			inventory.draggedItemPrefab.GetComponent <Image>().sprite = item.icon;
			inventory.draggedItemPrefab.GetComponent <DragItem> ().draggedItem = item;
			inventory.draggedItemPrefab.GetComponent <DragItem> ().index = slotNumber;
			inventory.items [slotNumber] = new Item ();
			inventory.toolTip.SetActive (false);
			inventory.isDragging = true;
		}
	}

	private void closeDraggedItem(){
		inventory.isDragging = false;
		inventory.draggedItemPrefab.SetActive (false);
	}
}
