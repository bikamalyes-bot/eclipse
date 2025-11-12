using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  [SerializeField] GameObject _player;
private PlayerMove _playerMove;
private PlayerCamera _playerCamera;
[SerializeField] GameObject _monster;
private MonsterDialogue _monsterDialogue;
private MonsterInteraction _monsterInteraction;
[SerializeField] GameObject _dialogueMenu;
private GameMode _gameMode;
public GameMode GameMode { get { return _gameMode;} private set { } }

private void Start()
{
    _playerMove = _player.GetComponent<PlayerMove>();
    _playerCamera = _player.GetComponent<PlayerCamera>();
    _monsterDialogue = _monster.GetComponent<MonsterDialogue>();
    _monsterInteraction = _monster.GetComponent<MonsterInteraction>();
    _gameMode = GameMode.sceneMode;
}

   

public void ChangeGameMode()
{

    if (Vector3.Distance(_player.transform.position, _monster.transform.position) <= 3)
    {  
         switch (_gameMode)
        {
            case GameMode.sceneMode:
                _playerMove.enabled = false;
                _playerCamera.enabled = false;
                Cursor.lockState = CursorLockMode.None;
                _gameMode = GameMode.DialogueMode;
                _monsterDialogue.StartDialogue();
                break;
            case GameMode.DialogueMode:
                _playerMove.enabled = true;
                _playerCamera.enabled = true;
                _gameMode = GameMode.sceneMode;
                _monsterDialogue.Skip();
                break;
            default:
                break;
        }
    }
}
}

