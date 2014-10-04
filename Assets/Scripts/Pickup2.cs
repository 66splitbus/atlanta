using UnityEngine;
using System.Collections;

public class Pickup2 : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D col)
	{
		// If the player hits the trigger...
		if(col.gameObject.tag == "Player")
		
		{
			rigidbody2D.velocity = new Vector2( rigidbody2D.velocity.y , 100  );
		
		}

	}
}