using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarFollow : MonoBehaviour
{
    Transform playerTran;
    [SerializeField]
     Vector3 offset = new Vector3(0, 1, 0);
    // Start is called before the first frame update
    void Start()
    {
        playerTran = GameObject.Find("hero").transform ;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTran.position + offset;
    }
}
