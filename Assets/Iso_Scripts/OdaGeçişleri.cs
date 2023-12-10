using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OdaGeçişleri : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Çarpışan nesnenin etiketini kontrol et
        if (collision.gameObject.CompareTag("kapi"))
        {
            // Çarpışma gerçekleştiğinde sahne değiştir
            SahneDegistir();
        }

        if (collision.gameObject.CompareTag("kapi2"))
        {
            // Çarpışma gerçekleştiğinde sahne değiştir
            SahneDegistirİki();
        }

        if (collision.gameObject.CompareTag("kapi3"))
        {
            // Çarpışma gerçekleştiğinde sahne değiştir
            SahneDegistirUc();
        }

        if (collision.gameObject.CompareTag("kapidisari"))
        {
            // Çarpışma gerçekleştiğinde sahne değiştir
            SahneDegistirDisari();
            print("switching to outside");
        }
    }

    void SahneDegistir()
    {
        // Sahne adını belirtin, örneğin "YeniSahne"
        string yeniSahneAdi = "1";

        // Sahneyi değiştir
        SceneManager.LoadScene(yeniSahneAdi);
                

    }

    void SahneDegistirİki()
    {
        // Sahne adını belirtin, örneğin "YeniSahne"
        string yeniSahneAdi = "2";

        // Sahneyi değiştir
        SceneManager.LoadScene(yeniSahneAdi);
    }

    void SahneDegistirUc()
    {
        // Sahne adını belirtin, örneğin "YeniSahne"
        string yeniSahneAdi = "3";

        // Sahneyi değiştir
        SceneManager.LoadScene(yeniSahneAdi);
    }
    void SahneDegistirDisari()
    {
        // Sahne adını belirtin, örneğin "YeniSahne"
        string yeniSahneAdi = "OurTown";

        // Sahneyi değiştir
        SceneManager.LoadScene(yeniSahneAdi);
    }
}

