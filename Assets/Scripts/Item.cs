using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
public class Item : MonoBehaviour
{

	private int id;
	private string name;
	private string description;

	public int getId ()
	{
		return id;
	}

	public void setId (int id)
	{
		this.id = id;
	}

	public string getName ()
	{
		return name;
	}

	public void setName (string name)
	{
		this.name = name;
	}

	public string getDescription ()
	{
		return description;
	}

	public void setDescription (string description)
	{
		this.description = description;
	}
}
