using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPirateCreator : MonoBehaviour
{
    // PirateScriptableObject �ablonunu atamak i�in kullan�l�r
    public PirateScriptableObject pirateTemplate;
    public GameObject pirateshowfield; // Panele eklenecek yeni korsan�n parent'�
    public GameObject korsanPrefab; // Korsan prefab'i

    public void PirateCreator()
    {
        // Rastgele bir isim olu�tur
        string[] isimler = { "Ahmet", "Mehmet", "Edward", "Ronin", "Chupi" };
        string rastgeleIsim = isimler[Random.Range(0, isimler.Length)];

        // Rastgele hasar ve can de�erleri olu�tur
        int rastgeleHasar = Random.Range(1, 11);
        int rastgeleCan = Random.Range(50, 101);

        // Yeni bir korsan olu�tur
        PirateScriptableObject yeniKorsan = CreatePirate(rastgeleIsim, rastgeleHasar, rastgeleCan);
        GameObject yeniKorsanObjesi = Instantiate(korsanPrefab);
        TextManager yeniKorsanUI = yeniKorsanObjesi.GetComponent<TextManager>(); // Korsan bilgilerini g�steren UI bile�eni
                                                                                 // Korsan bilgilerini prefab'e ata
        Debug.Log("Yeni Korsan Olu�turuldu: �sim: " + yeniKorsan.PirateName + ", Hasar: " + yeniKorsan.PirateHitChance + ", Can: " + yeniKorsan.PirateRepairAbility);
    }

    // Yeni bir PirateScriptableObject olu�turur ve d�nd�r�r
    private PirateScriptableObject CreatePirate(string isim, int hasar, int onarimYetene�i)
    {
        PirateScriptableObject yeniKorsan = ScriptableObject.CreateInstance<PirateScriptableObject>();
        yeniKorsan.PirateName = isim;
        yeniKorsan.PirateHitChance = hasar;
        yeniKorsan.PirateRepairAbility = onarimYetene�i;
        return yeniKorsan;
    }
}
