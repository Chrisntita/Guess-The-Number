using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameLogic : MonoBehaviour
{
    public InputField userInput;
    public Text gameLabel;
    public int minValue;
    public int maxValue;
    public Button GameButton;
    private bool isGameWon = false;
    
    // declaring a veriable and intializing it
    // private is an access modifier - makes this variable only
    // accessible from this script
    private int randomNum;
    
    void Start()
    {
        resetGame();
    }

    private void resetGame()
    {
        if (isGameWon)
        {
            gameLabel.text = "You Won!!....Thats the end of the Game :)";
            isGameWon = false;
        }
        else 
        {
            gameLabel.text = "Guess a number between " + minValue + " And " + (maxValue - 1);
        }
        userInput.text = "";
        randomNum = GetRandomNumber(minValue, maxValue);
     

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {

        string userInputValue = userInput.text;
        if (userInputValue != "")
        {

            int answer = int.Parse(userInputValue);

            if(answer == randomNum)
            {
                gameLabel.text = "Correct!!!";
                Debug.Log("correct!");
                isGameWon = true;
                resetGame();
                
                // GameButton.interactable = false;

            }

            else if (answer > randomNum)
            {
                gameLabel.text = "Try Lower!!";
                Debug.Log("try Lower!");
            }
            else
            {
                gameLabel.text = "Try Higher!!";
                Debug.Log("Try Higher");
            }


        }
        
        
    }

    private int GetRandomNumber(int min, int max)
    {
        int random = Random.Range(min, max);

        return random;
    }
}
