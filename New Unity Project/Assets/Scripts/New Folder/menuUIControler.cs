using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class menuUIControler : MonoBehaviour
{
    
    public Toggle tog_Sound = null;
    public AudioSource myAudio;
    public Animator panel_shezhimianban;
    public GameObject panel_buttons;
    public GameObject panel_handle;
    //public float TimeInterval = 1.0f;
    //private float TimeStart = 0;
    public GameObject panel_credits;
    public GameObject panel_menu;
    bool judge = false;
    //public GameObject panel_menu;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        //TimeStart += Time.deltaTime;
    }
    public void Play_Click()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Exit_Click()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    public void vol(float v)
    {
        myAudio.volume = v;
        tog_Sound.isOn = v == 0 ? true : false;

    }
    public void Settings_Click()
    {
       panel_menu.SetActive(false);
        panel_shezhimianban.enabled = true;
        panel_shezhimianban.SetBool("SlideIn", true);
        
    }
    public void panel_exit()
    {
        StartCoroutine(Test(1.5f));
    }
        IEnumerator Test(float waittime)
        {
             panel_shezhimianban.SetBool("SlideIn", false);
            yield return new WaitForSeconds(waittime);
            panel_menu.SetActive(true); 
        }
          
        
    
    public void Credits_Click()
    {
        panel_buttons.SetActive(false);
        panel_credits.SetActive(true);
    }
    public void handle_Click()
    {
        
        panel_handle.SetActive(!judge);
        judge = !judge;
    }
    public void creditsExit_Click()
    {
        panel_credits.SetActive(false);
        panel_buttons.SetActive(true);
       
    }
}
