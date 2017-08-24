using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject playerSpawnPoints;
    // Use this for initialization
    void Start()
    {
        playerSpawnPoints = GameObject.FindGameObjectWithTag("PlayerSpawnPoints");

    }

    // Update is called once per frame

    Transform pickRandomSpawn()
    {
        Debug.Log("Childcount is" + playerSpawnPoints.transform.childCount);

        return playerSpawnPoints.transform.GetChild(Random.Range(0, playerSpawnPoints.transform.childCount));

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            transform.position = pickRandomSpawn().transform.position;

        }
    }
}
