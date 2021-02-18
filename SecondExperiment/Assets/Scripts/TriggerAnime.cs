using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TriggerAnime : MonoBehaviour
{

    Animation anime;
    void Start()
    {
        anime = GetComponent<Animation>();
        anime.Play("MoveForwardMeta");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "wall")
        {
            anime.Stop("MoveForwardMeta");
            anime.Play("Scene");
        }

        if (anime.isPlaying)
        {
          Debug.Log("help meeee");
            StartCoroutine(ZaWarudo());
           
        }
    }
    IEnumerator ZaWarudo()
    {
        Debug.Log("time stopped");
        yield return new WaitForSeconds(4);
        Destroy(gameObject);

    }

}
