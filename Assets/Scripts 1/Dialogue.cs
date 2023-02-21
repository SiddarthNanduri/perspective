using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Dialogue : MonoBehaviour
{
    public Text name;
    public Text dialogue;
    public Text option1;
    public Text option2;
    private int numIteration = -1;

    private bool called911;
    
    public void Start()
    {
        name.text = "";
        dialogue.text = "Call 911?";
        option1.text = "Call 911";
        option2.text = "Don't call, just act";
        numIteration = -1;
    }

    public void Update()
    {

    }

    public void Option1()
    {
        if (numIteration == 10)
        {
            if(called911 == true)
            {
                SceneManager.LoadScene(4);
            }
            if (called911 == false)
            {
                SceneManager.LoadScene(5);
            }
        }
        if (numIteration == 9)
        {
            SceneManager.LoadScene(3);
        }
        if (numIteration == 8)
        {
            SceneManager.LoadScene(2);
        }
        if (numIteration == 7)
        {
            name.text = "Jodie";
            dialogue.text = "I don't need to hear your compliments";
            option1.text = "Continue";
            option2.text = "";
            numIteration = 9;
        }
        if (numIteration == 6)
        {
            option1.text = "Continue";
            option2.text = "";
            name.text = "";
            dialogue.text = "You leave them alone";
            //screen fades to black as you hear a splash
            numIteration = 9;
        }
        if (numIteration == 5)
        {
            option1.text = "Continue";
            option2.text = "";
            name.text = "Stranger";
            dialogue.text = "You don't know how I feel! I said leave me alone!";
            //screen fades to black as you hear a splash
            numIteration = 9;
        }
        if (numIteration == 4)
        {
            name.text = "Jodie";
            dialogue.text = "My name? Well I suppose I have nothing to lose... I'm Jodie";
            option1.text = "Tell them their name sounds nice";
            option2.text = "Ask them to have a drink with you";
            numIteration = 7;
        }
        if (numIteration == 3)
        {
            name.text = "Stranger";
            dialogue.text = "Why do you care! I said leave me alone! You don't know me!";
            option1.text = "tell them you understand";
            option2.text = "tell them you don't know";
            numIteration = 5;
        }
        if (numIteration == 2)
        {
            name.text = "";
            option1.text = "Continue";
            option2.text = "";
            dialogue.text = "You let go of the stranger's body...";
            //screen fades to black as you hear a splash
            numIteration = 8;
        }
        if (numIteration == 1)
        {
            name.text = "Stranger";
            dialogue.text = "Please leave me alone...";
            option1.text = "Talk about how they shouldn't die";
            option2.text = "Talk to the stranger about the starry sky";
            numIteration = 3;
        }
        if (numIteration == 0)
        {
            
            name.text = "Stranger";
            dialogue.text = "...";
            option1.text = "Talk to stranger about how their family would feel";
            option2.text = "Talk to stranger about the starry sky";
            numIteration = 1;
        }
        if (numIteration == -1)
        {
            dialogue.text = "You call 911 and the Suicide Prevention Hotline";
            option1.text = "Approach Stranger";
            option2.text = "Try and restrain Stranger";
            numIteration = 0;
            called911 = true;
        }
    }

    public void Option2()
    {
        if (numIteration == 7)
        { 
            name.text = "Jodie";
            dialogue.text = "Sure that sounds nice";
            option1.text = "Continue";
            option2.text = "";
            numIteration = 10;
        }
        if (numIteration == 6)
        {
            name.text = "Stranger";
            option1.text = "Continue";
            option2.text = "";
            dialogue.text = "I asked you to leave me alone!";
            //screen fades to black as you hear a splash
            numIteration = 9;
        }
        if (numIteration == 5)
        {
            name.text = "Stranger";
            option1.text = "Continue";
            option2.text = "";
            dialogue.text = "Then don't talk to me...";
            numIteration = 9;
        }
        if (numIteration == 4)
        {
            name.text = "Stranger";
            dialogue.text = "Please leave me be";
            option1.text = "Leave them alone";
            option2.text = "Ask them their name";
            numIteration = 6;
        }
        if (numIteration == 3)
        {
            numIteration = 1;
        }
        if (numIteration == 2)
        {
            name.text = "";
            option1.text = "Continue";
            option2.text = "";
            dialogue.text = "You don't let go of the stranger's body and fall off with them...";
            //screen fades to black as you hear a splash
            numIteration = 8;
        }
        if (numIteration == 1)
        {
            dialogue.text = "The Stranger appears to look up in agreement";
            option1.text = "Ask the Stranger their name";
            option2.text = "Ask them why they are sitting up there";
            numIteration = 4;
        }
        if (numIteration == 0)
        {
            name.text = "Stranger";
            dialogue.text = "Who are you! Let go of me!";
            option1.text = "Let Go";
            option2.text = "Don't Let Go";
            numIteration = 2;
        }
        if (numIteration == -1)
        {
            dialogue.text = "You don't call 911";
            option1.text = "Approach Stranger";
            option2.text = "Try and restrain Stranger";
            called911 = false;
            numIteration = 0;
        }
    }
}
