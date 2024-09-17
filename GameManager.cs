using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public bool win;
    public int indexOfLevel;
    public int lives;
    public bool hitCheckpoint;
    public bool iCTRolling = false;
    public bool hitGhost = false;
    public Text livestext;
    
    // Start is called before the first frame update
    void Start()
    {
        indexOfLevel = 0;
        win = false;
        lives = 3;
        hitCheckpoint = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        livestext.text = "lives: " + lives;
        if (win == true)
        {
            Debug.Log("win");
            indexOfLevel ++;
            Application.LoadLevel(indexOfLevel);
            lives = 3;
            win = false;
        }

        if (lives == 0)
        {
           
            Application.LoadLevel(0);
            lives = 3;
          
        }

       
    }
}
