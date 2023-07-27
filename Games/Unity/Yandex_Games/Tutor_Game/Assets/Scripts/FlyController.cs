using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 15.0f;

    // Update is called once per frame
    void Update()
    {
        float strafe = Input.GetAxis("Keyboard Horizontal") + Input.GetAxis("Mouse X");
        var forwardMove = Input.GetAxis("Fire1") + Input.GetAxis("Keyboard Vertical");
        var backwardMove = 1;

        if (Input.GetMouseButton(0))
        {
            transform.Translate(new Vector3(strafe, 0, forwardMove) * _moveSpeed * Time.deltaTime);
        }

        if (Input.GetMouseButton(1))
        {
            transform.Translate(new Vector3(strafe, 0, -1f) * _moveSpeed * Time.deltaTime);
        }

    }
}
