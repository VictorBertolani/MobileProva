using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Login : MonoBehaviour
{
    public TMP_InputField txtUsuario;
    public TMP_Text txtError;

    public void login()
    {
        string nome = txtUsuario.text;
        PlayerPrefs.SetString("Username", nome);
        string user = PlayerPrefs.GetString("Username");

        Debug.Log(user);
    }

    public void TrocaCena()
    {
        SceneManager.LoadScene("PrincipalScene");
    }

    public void clicável()
    {

        if (Input.touchCount > 0)
        {
            SceneManager.LoadScene("PrincipalScene");
        }
    }
}
