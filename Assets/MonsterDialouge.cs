using UnityEngine;
using TMPro;

public class MonsterDialogue : MonoBehaviour
{
    public GameObject dialogueUI;          // диалог
    public TextMeshProUGUI dialogueText;   // Текст монстра

    private string[] lines = {
        "Привет",
        "кто ты?",
        " "
    };

    private int index = 0;

    public void StartDialogue()
    {
        dialogueUI.SetActive(true);
        index = 0;
        dialogueText.text = lines[index];
    }

    public void NextLine()
    {
        index++;

        if (index < lines.Length)
        {
            dialogueText.text = lines[index];
        }
        else
        {
            dialogueUI.SetActive(false);  // конец диалога
        }
    }
}