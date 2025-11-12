using UnityEngine;
using TMPro;

public class MonsterDialogue : MonoBehaviour
{
    
private MonsterDialogueType _monsterDialogueType;
public MonsterDialogueType MonsterDialogueType { get { return _monsterDialogueType; } private set { } }
[SerializeField] GameObject dialogueUI;
[SerializeField] TextMeshProUGUI dialogueText;


private string[] helloDialogueMTP = {
    "Привет",
    "кто ты?",
    "А я монстр"
};

private string[] helloDialoguePTM = {
    "Привет",
    "Player",
    "OK"
};

private int index = 0;

public void Skip()
{
    dialogueUI.SetActive(false);
}

public void StartDialogue()
{
    switch (_monsterDialogueType)
    {
        case MonsterDialogueType.hello:

            break;
        case MonsterDialogueType.problem:
            break;
        case MonsterDialogueType.problemBranching1:
            break;
        case MonsterDialogueType.problemBranching2:
            break;
        case MonsterDialogueType.problemBranching3:
            break;
        case MonsterDialogueType.ending1:
            break;
        case MonsterDialogueType.ending2:
            break;
        case MonsterDialogueType.ending3:
            break;
        default:
            break;
    }
    dialogueUI.SetActive(true);
    index = 0;
    dialogueText.text = helloDialogueMTP[index];
}

public void ChangeMonsterDialogueType()
{

}

public void NextLine()
{
    index++;

    if (index < helloDialogueMTP.Length)
    {
        dialogueText.text = helloDialogueMTP[index];
    }
    else
    {
        dialogueUI.SetActive(false);
    }
}

}