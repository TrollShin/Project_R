using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SOMove : ScriptableObject, IMove
{
    public abstract void Move(Vector3 _Direction, float _Speed, GameObject _Unit);
}
