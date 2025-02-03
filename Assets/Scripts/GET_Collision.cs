using UnityEngine;

public class GET_Collision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        // If the object that collided with this object has the tag "Player"
        if (other.CompareTag("Player")) // Assuming "Player" is the tag of the player
        {
            // Destroy this coin object when the player collides with it
            Destroy(gameObject);

            // Show trigger feedback in Console Window
            print("Player picked up coin");
        }
    }

    void OnTriggerStay(Collider other)
    {
        // If the object that collided with this object has the tag "Player"
        if (other.CompareTag("Player")) // Assuming "Player" is the tag of the player
        {
            // You can add additional logic here if needed for continuous triggers
            print("Player counting coin");
        }
    }

    void OnTriggerExit(Collider other)
    {
        // If the object that collided with this object has the tag "Player"
        if (other.CompareTag("Player")) // Assuming "Player" is the tag of the player
        {
            // You can add logic here if you want to do something when the player leaves the coin area
            print("Player looking for more coins");
        }
    }
}
