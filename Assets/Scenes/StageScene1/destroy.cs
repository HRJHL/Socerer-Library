using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collider){
        Destroy(collider.gameObject);
    }
}
