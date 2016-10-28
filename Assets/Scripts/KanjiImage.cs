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
        }

        void Start()
        {
            
        }

        void Update()
        {

        }

        public Kanji ChooseKanjiSet()
        {
            return kanjiIdeograms[0];
        }
    }

}

