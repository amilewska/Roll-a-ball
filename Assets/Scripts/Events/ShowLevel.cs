using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLevel : MonoBehaviour
{
    [SerializeField] GameObject firstFloor;
    [SerializeField] GameObject secondFloor;
    [SerializeField] GameObject lightstart;
    bool isScaling;

    private void Update()
    {
        if (secondFloor.transform.localScale == Vector3.one)
        {
            StartCoroutine(ScaleOverTime(firstFloor.transform, Vector3.zero, 1));
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(ScaleOverTime(secondFloor.transform, Vector3.one, 1));
            lightstart.SetActive(false);
        }
    }

    IEnumerator ScaleOverTime(Transform objectToScale, Vector3 toScale, float duration)
    {
        //Make sure there is only one instance of this function running
        if (isScaling)
        {
            yield break; ///exit if this is still running
        }
        isScaling = true;

        float counter = 0;

        //Get the current scale of the object to be moved
        Vector3 startScaleSize = objectToScale.localScale;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            objectToScale.localScale = Vector3.Lerp(startScaleSize, toScale, counter / duration);
            yield return null;
        }

        isScaling = false;
    }
}
