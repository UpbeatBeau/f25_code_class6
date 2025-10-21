using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    //Variables
    public TextMeshProUGUI textstack;

    public TextMeshProUGUI textqueue;

    public InputActionReference interactstack;
    
    public InputActionReference interactqueue;

    private string[] food = new string[6] { "tomato", "rice", "beef", "banana", "apple", "pizza" };

    //Make a list that is empty and holds strings
    private List<string> foodlist = new List<string>();

    //Make a stack of strings
    //Stacks are LIFO (Last in First out)
    private Stack<string> foodstack = new Stack<string>();

    //make a second stack of strings for from list
    private Stack<string> liststack = new Stack<string>();

    //Make a queue of strings
    //Queue are FIFO (First in First out)
    private Queue<string> foodqueue = new Queue<string>();

    //Make a queue of strings for the from list
    private Queue<string> listqueue = new Queue<string>();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //add the strings in the array to the list
        foodlist.AddRange(food);

        //for loop created from an array
        for (int i = 0; i < food.Length; i++)
        {
            //add string from location of array to list
            foodstack.Push(food[i]);
        }

        //printing number of things in stack
        Debug.Log(foodstack.Count);

        //for loop adding strings from a list
        for(int i = 0;i < foodlist.Count; i++)
        { 
            //adding things to the stack based on the list location or count
            liststack.Push(foodlist[i]);
        }

        //printing number of things in stack
        Debug.Log(liststack.Count);
        //printing the first out of the stack
        Debug.Log(liststack.Pop());

        //foreach loop using the array to make a queue
        foreach (string s in food)
        {
            foodqueue.Enqueue(s);
        }
        //print the number of strings in the queue
        Debug.Log(foodqueue.Count);

        //foreach loop using the list to make a queue
        foreach (string s in foodlist)
        {
            listqueue.Enqueue(s);
        }

        //print the number of strings in the queue
        Debug.Log(listqueue.Count);
        //print the first out of the queu
        Debug.Log(listqueue.Dequeue());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
