using UnityEngine;
using System.Collections;

public class WeightScript : MonoBehaviour
{
    public bool isContainer = false;
    public float baseWeightKg = 0f;

	// Calculates the total weight of this object, including all nested child objects if it is a container
	public float CalculateWeight()
	{
		float total = baseWeightKg;

		if (isContainer)
		{
			foreach (Transform child in transform)
			{
				WeightScript ws = child.GetComponent<WeightScript>();
				if (ws != null)
				{
					total += ws.CalculateWeight();
				}
			}
		}

		return total;
	}
}
