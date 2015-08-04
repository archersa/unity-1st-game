using UnityEngine;
using System.Collections;

public class DistroyByBoundry : MonoBehaviour
{
	void OnTriggerExit(Collider other) {
		Destroy(other.gameObject);
}
}