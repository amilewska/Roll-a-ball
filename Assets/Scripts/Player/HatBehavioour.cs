using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatBehavioour : MonoBehaviour
{
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y+0.17f, player.transform.position.z);
        //transform.rotation = Quaternion.Euler(player.transform.rotation.y, player.transform.rotation.y, player.transform.rotation.y);
    }
}
