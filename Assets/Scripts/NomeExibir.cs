using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class NomeExibir : MonoBehaviour
{
    public TMP_Text texto;

    private void Awake()
    {
        texto = GetComponent<TMP_Text>();


    }

    void Update()
    {
        texto.text = PlayerPrefs.GetString("Username");
    }






}
