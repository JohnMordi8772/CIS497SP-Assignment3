/* 
 * John Mordi
 * EnemyAdjustment.cs
 * Assignment 3
 * Adjusts enemy/observer stats based on player input,
 * acts as subject
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAdjustment : MonoBehaviour, ISubject
{
    List<IObserver> enemies = new List<IObserver>();

    int speed = 10, width = 5 /* positive z boundary */;
    float size = 1;

    public void NotifyObservers()
    {
        foreach(IObserver observer in enemies)
            observer.UpdateData(speed, width, size);
    }

    public void RegisterObserver(IObserver observer)
    {
        enemies.Add(observer);

        observer.UpdateData(speed, width, size);
    }

    public void RemoveObserver(IObserver observer)
    {
        enemies.Remove(observer);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            speed += 5;
            NotifyObservers();
        }
        if (Input.GetKeyDown(KeyCode.S) && speed > 5)
        {
            speed -= 5;
            NotifyObservers();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            width += 1;
            NotifyObservers();
        }
        if (Input.GetKeyDown(KeyCode.A) && width > 5)
        {
            width -= 1;
            NotifyObservers();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            size += 0.25f;
            NotifyObservers();
        }
        if(Input.GetKeyDown(KeyCode.D) && size > 0.5)
        {
            size -= 0.25f;
            NotifyObservers();
        }
    }
}
