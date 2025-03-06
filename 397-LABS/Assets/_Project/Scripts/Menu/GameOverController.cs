using UnityEngine;
using UnityEngine.UI;

namespace Platformer397
{
    public class GameOverController : MonoBehaviour
    {
        [SerializeField] private Button mainMenuBtn;
        [SerializeField] private Button restartGameBtn;
        [SerializeField] private Button quitBtn;

        void Start()
        {
            mainMenuBtn.onClick.AddListener(() => SceneController.Instance.ChangeScene("Menu"));
            restartGameBtn.onClick.AddListener(() => SceneController.Instance.ChangeScene("GamePlay"));
        }
    }
}
