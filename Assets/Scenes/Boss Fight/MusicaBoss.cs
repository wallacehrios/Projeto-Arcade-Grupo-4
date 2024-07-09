using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaBoss : MonoBehaviour
{
    public AudioSource[] Musicas;
    void Start()
    {
        Musica();
    }
    void Musica()
    {
        StartCoroutine(Musicaboss());
    }
    IEnumerator Musicaboss()
    {
        foreach(AudioSource audio in Musicas)
        {
            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
        }
        
        yield return new WaitForSeconds(5);

        foreach(AudioSource audio in Musicas)
        {
            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
        }
    }
}
