using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {

	public float otherDamage = 5.0f;
	public float selfDamage = 5.0f;
	
	void OnCollisionEnter(Collision collision) {
		float magnitude = collision.relativeVelocity.magnitude;
		collision.gameObject.SendMessage ("Damage", new HealthEvent (collision.gameObject, otherDamage * magnitude));
		gameObject.SendMessage ("Damage", new HealthEvent (gameObject, selfDamage * magnitude));
	}

}
