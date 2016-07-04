using UnityEngine;
using System.Collections;

public class MouseDrag : MonoBehaviour
{
	private Vector3 originalPosition;
	private bool dragging;

	void Start ()
	{
		originalPosition = gameObject.transform.position;
	}

	void OnMouseDrag ()
	{
		dragging = true;
		float distance_to_screen = Camera.main.WorldToScreenPoint (gameObject.transform.position).z;
		transform.position = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));

	}

	void OnMouseUp ()
	{
		if (dragging) {
			RaycastHit hit = new RaycastHit ();
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			if (Physics.Raycast (ray, out hit, 100f)) {
				if (hit.collider.gameObject != null && hit.collider.gameObject.tag.Equals ("Placeholder")) {
					originalPosition = hit.collider.gameObject.transform.position;
				} else {
					gameObject.transform.position = originalPosition;
				}
			} else {
				gameObject.transform.position = originalPosition;
			}
		}
	}


}
