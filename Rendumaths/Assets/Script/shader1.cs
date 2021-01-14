using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shader1 : MonoBehaviour
{
    public AudioSource source_son;
    public Material shader_cible;
    //public int curseur_sample; 

    void Update()
    {
        AudioClip my_sound = source_son.clip;

        float[] my_samples = new float[my_sound.samples * my_sound.channels]; my_sound.GetData(my_samples, 0);

        //choisir un sample 
        //float sample_choisi = my_samples[curseur_sample*2]; 
        float sample_choisi = my_samples[Mathf.FloorToInt(Time.time * my_sound.frequency * my_sound.channels)];

        //alimenter le shader 
        shader_cible.SetFloat("mon_input", sample_choisi);
    }
}

