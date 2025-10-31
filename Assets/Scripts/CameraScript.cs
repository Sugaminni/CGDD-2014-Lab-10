using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public GameObject startingBox;

	// Use this for initialization
	void Start () { // Prints out the total weight of the starting box including its contents
		Debug.Log(startingBox.GetComponent<WeightScript>().CalculateWeight());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
