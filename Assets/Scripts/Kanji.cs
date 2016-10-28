using UnityEngine;
using System.Collections;

namespace KanjiImage.Game
{
    public class Kanji
    {
        public string main;
        public string complete;
        public string onyomi;
        public string kunyomi;


        public Kanji()
        {

        }

       public Kanji(string blankKanji, string completeKanji, string yomikatta)
        {
            this.main = blankKanji;
            this.complete = completeKanji;
            this.onyomi = yomikatta;
        }
    }
}

