
using UnityEngine;

public class Collison : MonoBehaviour { 

    public playerMovement movement;


    void OnCollisionEnter(Collision smack)
    {
        if(smack.collider.tag == "tree")
        {
            movement.enabled = false;
            
        }
    }
}