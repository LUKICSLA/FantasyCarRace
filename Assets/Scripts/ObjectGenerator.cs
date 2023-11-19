using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    [SerializeField] List<GameObject> BonusPrefab;
    [SerializeField] bool looping = false;

    IEnumerator Start()
    {
        do
        {
            yield return StartCoroutine(SpawnObject());
        } while (looping);
    }

    private IEnumerator SpawnObject()
    {
        for(; ;)
        {
            //string nameOfPoint = "Point (" + Random.Range(1, GameObject.Find("PointsOfBonus").transform.childCount).ToString() + ")";
            //var newObject = Instantiate(BonusPrefab[Random.Range(0,2)], GameObject.Find(nameOfPoint).transform.position,  Quaternion.identity);
            yield return new WaitForSeconds(15f);
        }
    }
}
