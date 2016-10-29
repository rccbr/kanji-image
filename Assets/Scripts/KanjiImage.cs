using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using KanjiImage.Game;

namespace KanjiImage.Game
{
    public class KanjiImage : MonoBehaviour
    {
        public static KanjiImage instance;

        public Dictionary<int, Kanji> kanjiIdeograms;

        void Awake()
        {
            instance = this;

            kanjiIdeograms = new Dictionary<int, Kanji>();

            kanjiIdeograms.Add(0, new Kanji("禁", "止", "きんし"));
            kanjiIdeograms.Add(1, new Kanji("禁", "煙", "きんえん"));
            kanjiIdeograms.Add(2, new Kanji("煙", "", "けむり"));
            kanjiIdeograms.Add(3, new Kanji("静", "か", "静か"));
            kanjiIdeograms.Add(4, new Kanji("危", "ない", "あぶない"));
            kanjiIdeograms.Add(5, new Kanji("危", "険", "きけん"));
            kanjiIdeograms.Add(6, new Kanji("関", "心", "かんしん"));
            kanjiIdeograms.Add(7, new Kanji("関", "係", "かんけい"));
            kanjiIdeograms.Add(8, new Kanji("落", "ちる", "おちる"));
            kanjiIdeograms.Add(9, new Kanji("石", "", "いし"));
        }

        void Start()
        {
            
        }

        void Update()
        {

        }

        public Kanji ChooseKanjiSet()
        {
            int idKey = Random.Range(0, kanjiIdeograms.Count);

            Kanji kanji = new Kanji();

            kanji = kanjiIdeograms[idKey];
            kanji.id = idKey;

            return kanji;
        }
    }

}

