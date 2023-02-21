using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRev : MonoBehaviour
{
    public GameObject[] allitems;
    private int whichitem;
    private int xPos;
    public GameObject spawnPoint;

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
        whichitem = Random.Range(0, 4);;
        Destroy(Instantiate(allitems[whichitem], spawnPoint.transform.position , allitems[whichitem].transform.rotation), 15f);
        StartCoroutine(spawntimer());
    }
}
