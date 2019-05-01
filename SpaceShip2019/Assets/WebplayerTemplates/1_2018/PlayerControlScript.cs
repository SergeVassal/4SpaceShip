using UnityEngine;
using System.Collections;

public class PlayerControlScript : MonoBehaviour {

	private Rigidbody2D rBody;
	private Animator anim;

	public float speed;

	void Start () {
		rBody = GetComponent<Rigidbody2D> ();	
		anim = GetComponent<Animator> ();
	}

	void Update(){
		if (Input.GetMouseButtonDown (0)) {
			anim.SetBool ("Attack", true);
		} else {
			anim.SetBool ("Attack", false);
		}
	}
	

	void FixedUpdate(){
		
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition, Vector3.forward);
		transform.rotation = rot;
		transform.eulerAngles = new Vector3 (0, 0, transform.eulerAngles.z);
		rBody.angularVelocity = 0f;

		float input = Input.GetAxis ("Vertical");
		rBody.AddForce (transform.up * speed * input);
	}
}
