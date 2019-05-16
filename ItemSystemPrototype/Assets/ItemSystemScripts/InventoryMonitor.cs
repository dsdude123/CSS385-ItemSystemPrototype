using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryMonitor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.Find ("Player");
		PlayerInventory p = player.GetComponent<PlayerInventory> ();
		if (p.items.Count < 1) {
			this.GetComponent<UnityEngine.UI.Text> ().text = "No items";
		} else {
			this.GetComponent<UnityEngine.UI.Text> ().text = "";
			foreach (Item i in p.items) {
				this.GetComponent<UnityEngine.UI.Text> ().text += i.name + " x" + i.count + "\n" ;
			}
		}

	}
}
