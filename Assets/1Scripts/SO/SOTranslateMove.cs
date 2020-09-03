using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SOTranslateMove", menuName = "SOMoveBehavior/SOTranslateMove")]
public class SOTranslateMove : SOMove
{
    public override void Move(Vector3 _Direction, float _Speed, GameObject _Unit)
    {        
        _Unit.transform.Translate(_Direction * _Speed * Time.deltaTime);

        if (_Direction.x < 0) _Unit.GetComponent<SpriteRenderer>().flipX = true;
        else _Unit.GetComponent<SpriteRenderer>().flipX = false;
    }
}
