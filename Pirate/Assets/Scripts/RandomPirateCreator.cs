using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomPirateCreator : MonoBehaviour
{
    // PirateScriptableObject þablonunu atamak için kullanýlýr
    public PirateScriptableObject pirateTemplate;
    public GameObject korsanPrefab; // Korsan prefab'i
    public Canvas Canvas;
    public void Start()
    {
        
            // Rastgele bir isim oluþtur
            string[] isimler = { "Ahmet", "Mehmet", "Edward", "Ronin", "Chupi" };
            string rastgeleIsim = isimler[Random.Range(0, isimler.Length)];

            // Rastgele hasar ve can deðerleri oluþtur
            int rastgeleHasar = Random.Range(1, 11);
            int rastgeleCan = Random.Range(50, 101);

            // Yeni bir korsan oluþtur
            PirateScriptableObject yeniKorsan = CreatePirate(rastgeleIsim, rastgeleHasar, rastgeleCan);
          
            GameObject yeniKorsanObjesi = Instantiate(korsanPrefab, new Vector3(600,0,0), Quaternion.identity);
            GameObject yeniKorsanObjesi2 = Instantiate(korsanPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            GameObject yeniKorsanObjesi3 = Instantiate(korsanPrefab, new Vector3(-600, 0, 0), Quaternion.identity);
            yeniKorsanObjesi.transform.SetParent(Canvas.transform);
            yeniKorsanObjesi2.transform.SetParent(Canvas.transform);
            yeniKorsanObjesi3.transform.SetParent(Canvas.transform);
            TextManager.crewList.list.Add(yeniKorsan);
            TextManager.crewList.list.Add(yeniKorsan);
            TextManager.crewList.list.Add(yeniKorsan);

            TextManager Pirate = yeniKorsanObjesi.GetComponent<TextManager>();
            TextManager Pirate2 = yeniKorsanObjesi.GetComponent<TextManager>();
            TextManager Pirate3 = yeniKorsanObjesi.GetComponent<TextManager>();
        Debug.Log("Yeni Korsan Oluþturuldu: Ýsim: " + yeniKorsan.PirateName + ", Hasar: " + yeniKorsan.PirateHitChance + ", Can: " + yeniKorsan.PirateRepairAbility);
                
    }

    private PirateScriptableObject CreatePirate(string isim, int hasar, int onarimYeteneði)
    {
        PirateScriptableObject yeniKorsan = ScriptableObject.CreateInstance<PirateScriptableObject>();
        yeniKorsan.PirateName = isim;
        yeniKorsan.PirateHitChance = hasar;
        yeniKorsan.PirateRepairAbility = onarimYeteneði;
        return yeniKorsan;
    }
}
