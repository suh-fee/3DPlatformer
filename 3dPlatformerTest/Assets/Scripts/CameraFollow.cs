using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private Transform player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = Camera.main.transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Camera.main.transform.position = player.transform.position + offset;
    }
}
