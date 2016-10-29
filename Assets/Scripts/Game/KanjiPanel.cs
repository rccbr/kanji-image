using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace KanjiImage.Game
{
    public class KanjiPanel : MonoBehaviour
    {
        public Button kanjiPanelBtn;
        public Text kanjiPanelText;

        void Awake()
        {
            kanjiPanelBtn = GetComponent<Button>();
            kanjiPanelText = kanjiPanelBtn.transform.GetChild(0).GetComponent<Text>();
        }

        void Start()
        {
            kanjiPanelBtn.onClick.AddListener(delegate { KanjiGame.instance.KanjiWa(kanjiPanelText.text); });
        }

        void Update()
        {

        }
    }
}


