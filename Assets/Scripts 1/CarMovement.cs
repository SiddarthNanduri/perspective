using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().transform.Translate(Vector3.right * 50f * Time.deltaTime);
    }
}
