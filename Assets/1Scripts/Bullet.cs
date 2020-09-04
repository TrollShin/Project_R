using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private SpriteRenderer BulletSprite;
    private Collider2D Collider;

    private Coroutine coroutine;

    private Vector3 Direction;
    private float Damage;
    private float BulletSpeed;
    private int AttackerLayer;

    public bool isActive;

    private void Start()
    {
        BulletSprite = GetComponent<SpriteRenderer>();
        Collider = GetComponent<Collider2D>();

        BulletSprite.enabled = false;
        Collider.enabled = false;

        isActive = false;
    }

    public virtual void Fire(Vector3 _Direction, float _Damage, float _BulletSpeed, int _AttackerLayer)
    {
        Direction = _Direction;
        Damage = _Damage;
        BulletSpeed = _BulletSpeed;

        isActive = true;

        BulletSprite.enabled = true;
        Collider.enabled = true;

        StartCoroutine(MoveBullet());
    }

    IEnumerator MoveBullet()
    {
        transform.Translate(Direction * BulletSpeed * 0.01f);

        yield return Yielders.WaitForFixedUpdate;

        coroutine = StartCoroutine(MoveBullet());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == AttackerLayer)
        {
            return;
        }

        collision.gameObject.GetComponent<UnitEntity>().GetDamaged(Damage);

        StopCoroutine(coroutine);

        BulletSprite.enabled = false;
        Collider.enabled = false;

        isActive = false;
    }
}