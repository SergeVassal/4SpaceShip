using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float speed;   

    private Rigidbody2D rBody;
    private Transform playerTransform;


    private void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    public void SetPlayerTransform(Transform transform)
    {
        playerTransform = transform;
    }

    private void FixedUpdate()
    {
        float z = Mathf.Atan2((transform.position.y - playerTransform.position.y),
            (transform.position.x - playerTransform.position.x)) * Mathf.Rad2Deg+90;
        transform.eulerAngles = new Vector3(0, 0, z);

        rBody.AddForce(transform.up * speed);
    }


}
