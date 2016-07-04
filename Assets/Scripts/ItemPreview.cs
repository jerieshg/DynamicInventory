using UnityEngine;
using System.Collections;

public class ItemPreview : MonoBehaviour
{

	private Item item;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnMouseEnter ()
	{
//		print (item.getName ());
	}

	public void setItem (Item item)
	{
		this.item = item;
	}

	public Item getItem ()
	{
		return item;
	}
}
