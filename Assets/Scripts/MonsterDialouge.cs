using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class MonsterDialogue : MonoBehaviour
{
    
private MonsterDialogueType _monsterDialogueType;
public MonsterDialogueType MonsterDialogueT { get { return _monsterDialogueType; } private set { } }
[SerializeField] GameObject dialogueUI;
[SerializeField] TextMeshProUGUI dialogueText;
[SerializeField] Button skipButton;

[SerializeField] Button button1;
[SerializeField] TextMeshProUGUI buttonText1;
[SerializeField] Button button2;
[SerializeField] TextMeshProUGUI buttonText2;
[SerializeField] Button button3;
[SerializeField] TextMeshProUGUI buttonText3;

[Header("Hello Dialogue")]
[SerializeField] string helloDialogueMTP = "Привет, кто ты? я монстр";
[SerializeField] string answer1 = "Привет";
[SerializeField] string answer2 = "Пока";
[SerializeField] string answer3 = "На колени";

[Header("Problem Dialogue")]
[SerializeField] string problemDialogueMTP = "Ты нашёл мою игрушку?";
[SerializeField] string problemAnswer1 = "Да";
[SerializeField] string problemAnswer2 = "Пока нет";
[SerializeField] string problemAnswer3 = "Я её сломал";

private void Start()
{
    button1.onClick.AddListener(() => SetDialouge(42));  
}

public void Skip()
{
    dialogueUI.SetActive(false);
}
public void StartDialogue()
{
    switch (_monsterDialogueType)
    {
        case MonsterDialogueType.hello:
            dialogueText.text = helloDialogueMTP;
            buttonText1.text = answer1;
            buttonText2.text = answer2;
            buttonText3.text = answer3;
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
    dialogueText.text = helloDialogueMTP;
}
public void ChangeMonsterDialogueType(MonsterDialogueType type)
 {
     _monsterDialogueType = type;
 }

 public void SetDialouge(int example)
 {
        Debug.Log(example);

 }

}