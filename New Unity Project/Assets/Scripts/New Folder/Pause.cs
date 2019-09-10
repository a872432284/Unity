using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public AudioClip pause_push;
    private eatDiamond eatDiamond = null;
    public Text Score;
    public GameObject Restart_Home;
    private bool paused = false;
    private bool restart = false;
    public GameObject txt_Pause;
    // Start is called before the first frame update
    void Start()
    {
        //mouse = GameObject.FindGameObjectWithTag("Mouse").GetComponent<MouseController>();
        eatDiamond = GameObject.FindGameObjectWithTag("diamond").GetComponent<eatDiamond>();
    }

    // Update is called once per frame
    void Update()
    {
        //Score.text = mouse.Count.ToString();
        Score.text = eatDiamond.Count.ToString();
    }
    public void PauseGame()
    {
        AudioSource.PlayClipAtPoint(pause_push, Camera.main.transform.position);
        paused = !paused;
        txt_Pause.SetActive(paused);
        Time.timeScale = paused ? 0 : 1;
        Restart_Home.SetActive(!restart);
        restart = !restart;
    }
    public void Home_Click()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Restart_Click()
    {
        SceneManager.LoadScene("Game");
    }
}
