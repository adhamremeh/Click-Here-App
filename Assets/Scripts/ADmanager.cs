using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class ADmanager : MonoBehaviour
{

    private string GoogleID = "3382447";
    public bool testMode;

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(GoogleID, testMode);
    }

    public void Ad()
    {
        StartCoroutine(ShowBannerWhenReady());
    }

    IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady("video"))
        {
            yield return new WaitForSeconds(0.1f);
        }
        Advertisement.Show("video");
    }

}