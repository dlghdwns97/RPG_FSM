using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject.Find("ClearWindow").transform.Find("Clear").gameObject.SetActive(true);
            other.transform.position = new Vector3(0, 0, 0);    // ??
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3.0f);
        GameObject.Find("ClearWindow").transform.Find("Clear").gameObject.SetActive(false);
    }
}
