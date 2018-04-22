using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Valve.VR.InteractionSystem
{
	//-------------------------------------------------------------------------
	[RequireComponent( typeof( Interactable ) )]
	public class hold : MonoBehaviour
	{
		public UnityEvent onTriggerDown;
		public UnityEvent onTriggerUp;
		public UnityEvent onGripDown;
		public UnityEvent onGripUp;
		public UnityEvent onTouchpadDown;
		public UnityEvent onTouchpadUp;
		public UnityEvent onTouchpadTouch;
		public UnityEvent onTouchpadRelease;
		public GameObject bulletPrefab;
		public Transform bulletspawn;

		//-------------------------------------------------
		void Update()
		{
			for ( int i = 0; i < Player.instance.handCount; i++ )
			{
				Hand hand = Player.instance.GetHand( i );

				if ( hand.controller != null )
				{
					if ( hand.controller.GetPressDown( Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger ) )
					{
						Fire();
					}
				}
			}
		}

		void Fire()
		{
			var bullet = (GameObject)Instantiate (bulletPrefab, bulletspawn.position, bulletspawn.rotation);
			bullet.GetComponent<Rigidbody> ().velocity = bullet.transform.forward * 6;
			Destroy (bullet, 2.0f);
		}
	}
}