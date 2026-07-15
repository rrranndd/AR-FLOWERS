using UnityEngine;
using System.Collections.Generic;

public class WordManager : MonoBehaviour
{
    private string lastWord = "";

    private FlowerManager flowerManager;

    void Start()
    {
        flowerManager = FindFirstObjectByType<FlowerManager>();
    }

    void Update()
    {
        LetterTracker[] letters =
            FindObjectsByType<LetterTracker>(FindObjectsInactive.Exclude);

        HashSet<string> activeLetters = new HashSet<string>();

        foreach (LetterTracker lt in letters)
        {
            if (lt.IsTracked())
            {
                activeLetters.Add(lt.letter);
            }
        }

        string detectedWord = CheckFlower(activeLetters);

        Debug.Log("Jumlah Huruf Aktif: " + activeLetters.Count);
        Debug.Log("Kata Saat Ini: " + detectedWord);

        if (detectedWord != lastWord)
        {
            lastWord = detectedWord;

            if (detectedWord != "")
            {
                Debug.Log("Kata Ditemukan: " + detectedWord);

                if (flowerManager != null)
                {
                    flowerManager.ShowFlower(detectedWord);
                }
            }
            else
            {
                if (flowerManager != null)
                {
                    flowerManager.HideAllFlowers();
                }
            }
        }
    }

    string CheckFlower(HashSet<string> letters)
    {
        // MAWAR
        if (letters.Contains("M") &&
            letters.Contains("A") &&
            letters.Contains("W") &&
            letters.Contains("R"))
        {
            return "MAWAR";
        }

        // DAISY
        if (letters.Contains("D") &&
            letters.Contains("A") &&
            letters.Contains("I") &&
            letters.Contains("S") &&
            letters.Contains("Y"))
        {
            return "DAISY";
        }

        // LOTUS
        if (letters.Contains("L") &&
            letters.Contains("O") &&
            letters.Contains("T") &&
            letters.Contains("U") &&
            letters.Contains("S"))
        {
            return "LOTUS";
        }

        // LILY
        if (letters.Contains("L") &&
            letters.Contains("I") &&
            letters.Contains("Y"))
        {
            return "LILY";
        }

        // SAKURA
        if (letters.Contains("S") &&
            letters.Contains("A") &&
            letters.Contains("K") &&
            letters.Contains("U") &&
            letters.Contains("R"))
        {
            return "SAKURA";
        }

        // ANGGREK
        if (letters.Contains("A") &&
            letters.Contains("N") &&
            letters.Contains("G") &&
            letters.Contains("R") &&
            letters.Contains("E") &&
            letters.Contains("K"))
        {
            return "ANGGREK";
        }

        return "";
    }
}