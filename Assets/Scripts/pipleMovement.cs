using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipleMovement : MonoBehaviour
{
    [SerializeField] private float pipleSpeed = 3f;
    private void Start()
    {
        Destroy(gameObject, 15f);
    }
    void Update()
    {
        transform.position += Vector3.left * pipleSpeed * Time.deltaTime;
    }
}