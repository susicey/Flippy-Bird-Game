using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlippyDeathZone : MonoBehaviour
{
    [SerializeField] private Vector3 respawnPosition;

    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.CompareTag("player"))
        {
            collison.transform.position = respawnPosition;
        }
    }
}
