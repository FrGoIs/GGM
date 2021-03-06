using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public GameObject[] canvas;
    enum SCENES { Menu, Kitchen};
    private void Awake()
    {

        if (gameManager != null && gameManager != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            gameManager = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Empieza el Juego");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void StartGame()
    {
        Debug.Log("Click Recieved");
        SceneManager.LoadScene((int)SCENES.Kitchen);
        Debug.Log("Reached here");
    }
    public void Instructions()
    {
        canvas[0].SetActive(false);
        canvas[1].SetActive(true);
    }
}
