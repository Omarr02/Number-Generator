using System;
using UnityEngine;

public class FunnySentenceGenerator : MonoBehaviour
{
    void Start()
    {
        String [ ] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree",   "Monkey", "Ball", "Bird" };
        string sentence = "";
        System.Random random = new System.Random();
        int count = 0;
       while (count < 7)
        {
            int index = random.Next(words.Length); 
           sentence += words[index] + " "; 
            count++;
        }
        Debug.Log(sentence.Trim()); 
    }
}
