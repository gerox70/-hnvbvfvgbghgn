using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int healt = 5;
    public int level = 1;
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        healt = healt + level;
        Debug.Log("lives: " + healt);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = this.transform.position;

        newPosition.z = newPosition.z + speed * Time.deltaTime;
        this.transform.position = newPosition;
    }
}
