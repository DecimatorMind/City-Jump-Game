using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    public GameObject[] prefabArray;
    public float score;
    public TMP_Text textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro.text = "Score: 0";
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle",startDelay,repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        textMeshPro.text = "Score: " + score;
    }

    void SpawnObstacle()
    {
        if(playerControllerScript.gameOver == false)
        {
            int index = Random.Range(0, prefabArray.Length);
            Instantiate(prefabArray[index], spawnPos, prefabArray[index].transform.rotation);
            score += (index + 1);
        }
    }
}
