using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void Home_Click()
    {
        SceneManager.LoadScene("LJA");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Btn_LCH()
    {
        SceneManager.LoadScene("LCH");
    }
    public void Btn_ZTS()
    {
        SceneManager.LoadScene("ZTS");
    }
    public void Btn_Lijiaao()
    {
        SceneManager.LoadScene("Game");
    }
}
