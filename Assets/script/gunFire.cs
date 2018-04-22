using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunFire : MonoBehaviour {
	public GameObject bulletPrefab;
	public Transform bulletspawn;

	public void Fire()
	{
		var bullet = (GameObject)Instantiate (bulletPrefab, bulletspawn.position, bulletspawn.rotation);
		bullet.GetComponent<Rigidbody> ().velocity = bullet.transform.forward * 90;
		Destroy (bullet, 2.0f);
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play ();

	}
}
