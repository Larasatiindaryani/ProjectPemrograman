using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdsManager : MonoBehaviour
{

    public Button btnAdd;
    public Button btnUse;
    public Text txCoin;
    int coin = 0;
    //durasi video 30 detik dan tidak dapat dilewati
    string placementId = "rewardedVideo";
    //video dapat dilewati setelah 5 detik
    //string placementId = "video";
    // Menggunakan Game ID berdasarkan Platform yang digunakan
    #if UNITY_IOS
    private string gameId = "1678494";
    #elif UNITY_ANDROID
    private string gameId = "1678493";
    #endif

    // Start is called before the first frame update
    void Start()
    {
        // menghandle button
        if (btnAdd) btnAdd.onClick.AddListener(ShowAd);
if (btnUse) btnUse.onClick.AddListener(UseCoin);
// inisialisasi Game ID ke Unity Ads
if (Advertisement.isSupported) {
    Advertisement.Initialize(gameId, true);
}
    }

    // Update is called once per frame
    void Update()
    {
        // menentukan tombol dapat interakasi atau tidak
        if (btnAdd) btnAdd.interactable = Advertisement.Is
Ready(placementId);
btnUse.interactable = (coin > 0);
    }
    void ShowAd() {
        // menampilkan iklan
        ShowOptions options = new ShowOptions();
        options.resultCallback = HandleShowResult;
        Advertisement.Show(placementId, options);
    }
    void HandleShowResult(ShowResult result) {
        // merespon feedback, jika berhasil maka coin akan dit
ambah 50
        if (result == ShowResult.Finished) {
            Debug.Log("Video selesai - tawarkan coin ke pemain");
coin += 50;
txCoin.text = "Coin: " + coin;
        }
        else if (result == ShowResult.Skipped) {
            Debug.LogWarning("Video dilewati - tidak menawarkan coin ke pemain");
        }
else if (result == ShowResult.Failed) {
    Debug.LogError("Video tidak ditampilkan");
    }
}
void UseCoin() {
    // koin dikurangi
    if (coin > 0) {
        coin -= 10;
        txCoin.text = "Coin: " + coin;
    }
}

