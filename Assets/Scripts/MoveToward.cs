using UnityEngine;
using System.Collections;

public class MoveToward : MonoBehaviour {

	public GameObject target;
	public float speed = 1.0f;

	// Use this for initialization
	void Start () {
		if (target == null)
			target = GameObject.FindWithTag("Player");
	}

	// Update is called once per frame
	void Update () {
		// Vector from here to target
		Vector3 toward = target.transform.position - transform.position;
		toward.Normalize ();

		// Look toward target
		transform.rotation = Quaternion.LookRotation (toward);

		// Move a bit towards target
		transform.position += toward * (speed * Time.deltaTime);
	}
}
