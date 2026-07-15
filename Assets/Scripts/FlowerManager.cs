using UnityEngine;

public class FlowerManager : MonoBehaviour
{
    public GameObject mawar;
    public GameObject daisy;
    public GameObject lotus;
    public GameObject lily;
    public GameObject sakura;
    public GameObject anggrek;

    void Start()
    {
        HideAllFlowers();
    }

    public void ShowFlower(string flowerName)
    {
        HideAllFlowers();

        switch (flowerName)
        {
            case "MAWAR":
                mawar.SetActive(true);
                break;

            case "DAISY":
                daisy.SetActive(true);
                break;

            case "LOTUS":
                lotus.SetActive(true);
                break;

            case "LILY":
                lily.SetActive(true);
                break;

            case "SAKURA":
                sakura.SetActive(true);
                break;

            case "ANGGREK":
                anggrek.SetActive(true);
                break;
        }
    }

    public void HideAllFlowers()
    {
        mawar.SetActive(false);
        daisy.SetActive(false);
        lotus.SetActive(false);
        lily.SetActive(false);
        sakura.SetActive(false);
        anggrek.SetActive(false);
    }
}