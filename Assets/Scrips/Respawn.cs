using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;


    void OnTriggerEnter(Collider other)
    {
        player.transform.position = new Vector3(3.32f, 15.12f, 53.66f);
    }
}
