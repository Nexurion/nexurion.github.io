using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_debug : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 15f;
    [SerializeField] float _backwardSpeed = 12f;
    [SerializeField] float _jumpForce;
    [SerializeField] float _limitPosLeft = -3.54f;
    [SerializeField] float _limitPosRight = 3.54f;
    [SerializeField] float _limitRotationLeft = -20;
    [SerializeField] float _limitRotationRight = 20;
    [SerializeField] float _rotationSpeed;
    [SerializeField] float _mouseSense = 1f;
    
    [SerializeField] Animator _animator;

    float _oldMousePosX;
    float _eulerY;

    void FixedUpdate()
    {
        Mouse_Control();
        Keyboard_Control();
        /*Animator();

        var rotangle = transform.rotation.eulerAngles;

        float mouseX = Input.GetAxis("Mouse X") * Time.fixedDeltaTime * mouseSense;
        rotangle.y += Time.fixedDeltaTime * _rotationSpeed;
        //transform.rotation = Quaternion.Euler(rotangle);*/
    }

    void Mouse_Control()
    {
        var rotangle = transform.rotation.eulerAngles;
        //Передвижение.

        if (Input.GetMouseButtonDown(0))
        {
            _oldMousePosX = Input.mousePosition.x;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 newPosition = transform.position + transform.forward * Time.fixedDeltaTime * _moveSpeed;
            newPosition.x = Mathf.Clamp(newPosition.x, _limitPosLeft, _limitPosRight);
            transform.position = newPosition;

            if (Input.mousePosition.x > 0)
            {
                float deltaX = Input.mousePosition.x - _oldMousePosX;
                _oldMousePosX = Input.mousePosition.x;

                _eulerY += deltaX;
                _eulerY = Mathf.Clamp(_eulerY, _limitRotationLeft, _limitRotationRight);
                transform.eulerAngles = new Vector3(0, _eulerY, 0);
                //transform.rotation = Quaternion.Euler(rotangle);

            }
        }
        if (Input.GetMouseButton(1))
        {
            transform.position -= transform.forward * Time.fixedDeltaTime * _backwardSpeed;
        }

        
    }

    void Keyboard_Control()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(new Vector3(strafe, 0, forwardMove) * _moveSpeed * Time.deltaTime);
            transform.position += transform.forward * Time.deltaTime * _moveSpeed;
        }
    }

    void Animator()
    {

        return;
    }
}
