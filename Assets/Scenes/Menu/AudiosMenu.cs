using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class AudiosMenu : MonoBehaviour
{
    public AudioSource[] audioSource;
    void Start()
    {
        Test();
    }
    void Test()
    {
        StartCoroutine(MusicaMenu());
    }
    IEnumerator MusicaMenu()
    {
        int song1 = Random.Range(1,6);
        audioSource[song1].Play();
        yield return new WaitForSeconds(audioSource[song1].clip.length);

        int song2 = Random.Range(1,6);
        audioSource[song2].Play();
        yield return new WaitForSeconds(audioSource[song2].clip.length);

        int song3 = Random.Range(1,6);
        audioSource[song3].Play();
        yield return new WaitForSeconds(audioSource[song3].clip.length);

        int song4 = Random.Range(1,6);
        audioSource[song4].Play();
        yield return new WaitForSeconds(audioSource[song4].clip.length);

        int song5 = Random.Range(1,6);
        audioSource[song5].Play();
        yield return new WaitForSeconds(audioSource[song5].clip.length);

        int song6 = Random.Range(1,6);
        audioSource[song6].Play();
        yield return new WaitForSeconds(audioSource[song6].clip.length);
    }
}
