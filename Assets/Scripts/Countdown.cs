using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public int CountdownTime;
    public TMPro.TextMeshProUGUI counter;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(countDown()); 
    }

    // Update is called once per frame
    IEnumerator countDown()
    {
        while (CountdownTime>0)
        {
            counter.text = CountdownTime.ToString();
            yield return new WaitForSeconds(1f);
            CountdownTime--;
        }
        counter.text = "GO!";
        yield return new WaitForSeconds(1f);
        PlayerPrefs.SetInt("go",  1);
        counter.gameObject.SetActive(false);
    }
}
