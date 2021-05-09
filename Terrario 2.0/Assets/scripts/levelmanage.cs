using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class levelmanage : MonoBehaviour
{
    public static levelmanage instance;
    public GameObject playerPrefab;
    public Transform respawnPoint;

    public CinemachineVirtualCameraBase cam;

    [Header("Currency")]
    public int currency = 0;
    public Text currencyUI;

    [Header("cherries")]
    public int cherry = 0;
    public Text cherryUI;


    private void Awake()
    {
        instance = this;
    }

    public void Respawn()
    {
        GameObject player = Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
        cam.Follow = player.transform;
    }

    public void IncreaseCurrency(int amount)
    {
        currency += amount;
        currencyUI.text = "$" + currency;
    }


    public void IncreaseCherry(int cherryamount)
    {
        cherry += cherryamount;
        cherryUI.text =  "" + cherry;
    }
}
