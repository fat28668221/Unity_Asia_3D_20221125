using UnityEngine;
using TMPro;
namespace Just
{
    /// <summary>
    /// 對話系統
    /// </summary>
    public class DialogueSystem : MonoBehaviour
    {
        [SerializeField, Header("對話間隔"), Range(0, 0.5f)]
        private float dialogueIntervalTime = 0.1f;

        private WaitForEndOfFrame dialogueInterval;
        private CanvasGroup groupDialogue;
        private TextMeshProUGUI textName;
        private TextMeshProUGUI textContont;
        private GameObject goTriangle;
    }
}


