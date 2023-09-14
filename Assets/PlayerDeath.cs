using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject respawnPoint;
    public GameObject Player;
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player")) {
            if (Input.GetKeyDown(KeyCode.F)) {
                Enemy.SetActive(false);
            } else {
                Player.transform.position = respawnPoint.transform.position;
            }
        }
    }
}
