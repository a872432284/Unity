using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnEffectScripts : MonoBehaviour
{
    public GameObject imgeffect;
    void Start()
    {
        imgeffect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(DeyleShowEffect());
        }
    }

    IEnumerator DeyleShowEffect()
    {
        imgeffect.transform.position = Input.mousePosition;
        imgeffect.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        imgeffect.SetActive(false);
    }
}
