using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour {

    private void OnCollisionEnter(Collision col)
    {
        Debug.Log("We hit something!");
    }
}
