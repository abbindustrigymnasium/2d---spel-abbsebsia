using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelmanage : MonoBehaviour
{
    public static levelmanage instance;
    public GameObject playerPrefab;
    public Transform respawnPoint;

    private void Awake()
    {
        instance = this;
    }

    public void Respawn()
    {
        Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
    }
}
