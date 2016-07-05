using UnityEngine;
using System.Collections;
using System;
using UnityEditor;

[System.Serializable]
public class Item
{

	public int id;
	public string name;
	public string description;
	public Sprite icon;
	public ItemType itemType;

	public Item(){
	}

	public Item(string name){
		this.name = name;
		icon = Resources.Load <Sprite> ("Sprites/"+name);
	}
}
