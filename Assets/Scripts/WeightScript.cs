using UnityEngine;
using System.Collections;

public class WeightScript : MonoBehaviour {

	// The weight of this item (by itself)
	public float weight;
	// Whether or not this is a container/crate
	public bool isContainer;

	// Recursively calculate the weight of the object
	public float CalculateWeight() {

		// If this is NOT a container, just return your weight

		// Otherwise 
		//  1) Print out your name "this.name"
		//  2) create a "totalWeight" variable and assign it your weight
		//  3) Loop through all the (child) transforms for this object
		//     3.1) call the child's CalculateWeight() method and add it to the totalWeight
		//     3.2) It's a good idea to print out the name of this object as well as the weight
		//  4) return the totalWeight

		// Remove the line below - it's just there to compile
		return this.weight;
	}
}
