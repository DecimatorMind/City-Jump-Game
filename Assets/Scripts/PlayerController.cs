using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody player;
    public float jumpforce = 8;
    public bool isOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            player.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
