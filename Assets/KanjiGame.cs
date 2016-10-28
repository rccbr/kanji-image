using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using KanjiImage.Game;

public class KanjiGame : MonoBehaviour
{
    public Text[] kanjiSet;

    public Kanji currentKanji;

    public AudioSource audioSource;

    void Awake()
    {
        currentKanji = new Kanji();

        audioSource = GetComponent<AudioSource>();
    }

	// Use this for initialization
	void Start ()
    {
        currentKanji = KanjiImage.Game.KanjiImage.instance.ChooseKanjiSet();

        kanjiSet[0].text = "_";
        kanjiSet[1].text = currentKanji.complete;
        kanjiSet[2].text = currentKanji.onyomi;
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void KanjiWa(string kanjiIdeogram)
    {
        if (kanjiIdeogram.Equals(currentKanji.main))
        {
            kanjiSet[0].text = currentKanji.main;

            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }
}
