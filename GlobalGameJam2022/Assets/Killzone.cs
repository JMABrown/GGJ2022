using System.Collections;
using System.Collections.Generic;
using Gamekit2D;
using UnityEngine;

public class Killzone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<PlayerCharacter>(out PlayerCharacter playerCharacter)) {
            playerCharacter.OnDieInstant();
        }
    }
}
