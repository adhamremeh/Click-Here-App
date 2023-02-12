using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Thanks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(thanks());
    }

    IEnumerator thanks()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(2);
    }
}
