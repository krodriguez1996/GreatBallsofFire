using UnityEngine;
using System.Collections;

public class DestroybyContact : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider c)
	{
		Destroy (c.gameObject);
	}
}
