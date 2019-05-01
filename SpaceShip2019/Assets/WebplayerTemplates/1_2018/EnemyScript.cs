using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	private Transform player;
	private Rigidbody2D rBody;

	public float speed;

	void Start () {
		player = GameObject.FindWithTag ("Player").GetComponent<Transform>();	
		rBody = GetComponent<Rigidbody2D> ();
	}
	

	void FixedUpdate () {
		float z = Mathf.Atan2 ((transform.position.y - player.position.y),
			         (transform.position.x - player.position.x)) * Mathf.Rad2Deg+90;		
		transform.eulerAngles =new Vector3(0, 0, z);
		rBody.AddForce (transform.up * speed);	
	}
}
