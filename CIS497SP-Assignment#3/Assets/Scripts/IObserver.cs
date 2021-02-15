/* 
 * John Mordi
 * IObserver.cs
 * Assignment 3
 * Framework for an observer using the observer pattern
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserver
{
    void UpdateData(int tSpeed, int tWidth, float tSize);
}
