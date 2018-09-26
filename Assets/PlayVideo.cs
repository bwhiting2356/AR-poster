using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using Vuforia;

public class PlayVideo : MonoBehaviour {
    public VideoPlayer videoPlayer;
    public ImageTarget imageTarget;
    public bool playMe;

	// Use this for initialization
	void Start () {
        //StartCoroutine(PlayTheVideo());
	}
	
	// Update is called once per frame
	void Update () {
        if (playMe) {
            StartCoroutine(PlayTheVideo());
        } else {
            // stop the video
            videoPlayer.Stop();
        }
	}

   public IEnumerator PlayTheVideo() {
        videoPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while(!videoPlayer.isPrepared) {
            yield return waitForSeconds;
            break;
        }
        videoPlayer.Play();
    }
}
