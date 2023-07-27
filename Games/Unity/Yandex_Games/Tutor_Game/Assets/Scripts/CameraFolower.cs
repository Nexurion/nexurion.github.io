using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolower : MonoBehaviour
{
    [SerializeField] Transform _target;

    void LateUpdate()
    {
        transform.position = _target.position;
    }
}
