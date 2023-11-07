using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _rotation;
    private void Update()
    {
        _rotation = Input.GetAxis("Horizontal") * _rotateSpeed * Time.deltaTime;
    }
    private void LateUpdate()
    {
        transform.Rotate(0f, 0f, _rotation);
    }
}
