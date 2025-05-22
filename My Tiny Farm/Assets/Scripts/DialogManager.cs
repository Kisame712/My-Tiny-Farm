using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DialogManager : MonoBehaviour
{
    [SerializeField] float typeSpeed;

    public string[] sentences;
    public TMP_Text textArea;
    public GameObject continueButton;
    public GameObject startGameButton;
    private int index;


    void Start()
    {
        StartCoroutine(Type());
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textArea.text += letter;
            yield return new WaitForSeconds(typeSpeed);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textArea.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textArea.text = "";
            continueButton.SetActive(false);
        }

    }
    void Update()
    {
        if (textArea.text == sentences[index] && index != sentences.Length - 1)
        {
            continueButton.SetActive(true);
        }
        else if (textArea.text == sentences[index] && index == sentences.Length - 1)
        {
            startGameButton.SetActive(true);
        }
    }


}
