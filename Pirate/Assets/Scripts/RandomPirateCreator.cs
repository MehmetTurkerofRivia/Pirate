using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPirateCreator : MonoBehaviour
{
    // PirateScriptableObject þablonunu atamak için kullanýlýr
    public PirateScriptableObject pirateTemplate;
    public GameObject pirateshowfield; // Panele eklenecek yeni korsanýn parent'ý
    public GameObject korsanPrefab; // Korsan prefab'i

    public void PirateCreator()
    {
        // Rastgele bir isim oluþtur
        string[] isimler = { "Ahmet", "Mehmet", "Edward", "Ronin", "Chupi" };
        string rastgeleIsim = isimler[Random.Range(0, isimler.Length)];

        // Rastgele hasar ve can deðerleri oluþtur
        int rastgeleHasar = Random.Range(1, 11);
        int rastgeleCan = Random.Range(50, 101);

        // Yeni bir korsan oluþtur
        PirateScriptableObject yeniKorsan = CreatePirate(rastgeleIsim, rastgeleHasar, rastgeleCan);
        GameObject yeniKorsanObjesi = Instantiate(korsanPrefab);
        TextManager yeniKorsanUI = yeniKorsanObjesi.GetComponent<TextManager>(); // Korsan bilgilerini gösteren UI bileþeni
                                                                                 // Korsan bilgilerini prefab'e ata
        Debug.Log("Yeni Korsan Oluþturuldu: Ýsim: " + yeniKorsan.PirateName + ", Hasar: " + yeniKorsan.PirateHitChance + ", Can: " + yeniKorsan.PirateRepairAbility);
    }

    // Yeni bir PirateScriptableObject oluþturur ve döndürür
    private PirateScriptableObject CreatePirate(string isim, int hasar, int onarimYeteneði)
    {
        PirateScriptableObject yeniKorsan = ScriptableObject.CreateInstance<PirateScriptableObject>();
        yeniKorsan.PirateName = isim;
        yeniKorsan.PirateHitChance = hasar;
        yeniKorsan.PirateRepairAbility = onarimYeteneði;
        return yeniKorsan;
    }
}
