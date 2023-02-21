using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] allitems;
    private int whichitem;
    private int xPos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawntimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawntimer()
    {
        yield return new WaitForSeconds(6);
        whichitem = Random.Range(0, 4);
        xPos = Random.Range(-5, -3) * 5;
        Destroy(Instantiate(allitems[whichitem], new Vector3(xPos, 1f, -0.75f), allitems[whichitem].transform.rotation), 5f);
        StartCoroutine(spawntimer());
    }
}
