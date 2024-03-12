using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text scoreDisplay;
    public Animator scoreAnimator;
    public int nextLevel = 0;
 
    public void EndLevel()
    {
        Cannon cannon = FindObjectOfType<Cannon>();
        if (cannon)
        {
            int numProjectiles = cannon.numProjectiles;

            if (numProjectiles == 1)
            {
                print("Three Stars");
                scoreDisplay.text = "Three Stars!";
                scoreAnimator.SetInteger("Stars", 3);
            }
            else if (numProjectiles == 2)
            {
                print("Two Stars");
                scoreDisplay.text = "Two Stars!";
                scoreAnimator.SetInteger("Stars", 2);
            }
            else
            {
                print("One Star");
                scoreDisplay.text = "One Star.";
                scoreAnimator.SetInteger("Stars", 1);
            } 

            Invoke("NextLevel", 2);
        }
    }

    void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
