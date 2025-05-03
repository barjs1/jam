using UnityEngine;

public class WinZoneDetector : MonoBehaviour
{
    public GameObject winPanel; // Kazanma paneli

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Karakterin tag'ini "Player" olarak kontrol et
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Oyunu kazandınız!");

            // Kazanma panelini aktif et
            if (winPanel != null)
            {
                winPanel.SetActive(true);

                // İsterseniz oyunu durdurun
                Time.timeScale = 0f;
            }
        }
    }
}
