using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using KanjiImage.Game;

namespace KanjiImage.Game
{
    public enum KanjiGameStatus
    {
        準備する,
        漢字選ぶ,
        答えする,
    }

    public class KanjiGame : MonoBehaviour
    {
        public static KanjiGame instance;

        public KanjiGameStatus status;

        public Text[] kanjiSet;

        public Kanji currentKanji;

        public AudioSource audioSource;

        public AudioClip correct;
        public AudioClip notcorrect;

        public int kanjiID;

        void Awake()
        {
            instance = this;

            currentKanji = new Kanji();

            audioSource = GetComponent<AudioSource>();
        }

        // Use this for initialization
        void Start()
        {
            WarmUp();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void WarmUp()
        {
            Invoke("ChooseKanji", 3.0f);
        }

        public void ChooseKanji()
        {
            currentKanji = KanjiImage.instance.ChooseKanjiSet();

            kanjiID = currentKanji.id;

            kanjiSet[0].text = "";
            kanjiSet[1].text = currentKanji.complete;
            kanjiSet[2].text = currentKanji.onyomi;
        }

        public void KanjiWa(string kanjiIdeogram)
        {
            if (kanjiIdeogram.Equals(currentKanji.main))
            {
                kanjiSet[0].text = currentKanji.main;

                audioSource.clip = correct;
            } else
                audioSource.clip = notcorrect;

            if (!audioSource.isPlaying)
                audioSource.Play();

            WarmUp();
        }
    }
}

