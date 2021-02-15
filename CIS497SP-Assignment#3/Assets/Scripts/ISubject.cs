/* 
 * John Mordi
 * ISubject.cs
 * Assignment 3
 * Framework for a subject using the observer pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}
