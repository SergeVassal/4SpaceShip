using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Camera cam;

    private Rigidbody2D rBody;



    private void Awake()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        ApplyVerticalMovement(GetVerticalInput());
        ApplyRotation(GetRotation());
    }

    private float GetVerticalInput()
    {
        var vertInput = Input.GetAxis("Vertical");

        return vertInput;
    }

    private void ApplyVerticalMovement(float vertInput)
    {
        rBody.AddForce(transform.up * vertInput * speed);
    }

    private Quaternion GetRotation()
    {
        var mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rotation = Quaternion.LookRotation(transform.position - mousePosition, Vector3.forward);

        return rotation;
    }

    private void ApplyRotation(Quaternion targetRotation)
    {
        transform.rotation = targetRotation;
        transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
        rBody.angularVelocity = 0f;
    }


}
