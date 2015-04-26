using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Helpers
{
    public class AssetBundleLoaderHelper : ScriptableObject {

        // Use this for initialization
        void Start () {
	
        }
	
        // Update is called once per frame
        void Update () {
	
        }

        public static IEnumerator LoadAssetBundleEnumerator(string url, string name, Action<GameObject> onResult)
        {
            WWW www = WWW.LoadFromCacheOrDownload(url, 1);

            // Wait for download to complete
            yield return www;

            // Load and retrieve the AssetBundle
            AssetBundle bundle = www.assetBundle;

            // Load the object asynchronously
            AssetBundleRequest request = bundle.LoadAssetAsync(name, typeof(GameObject));

            // Wait for completion
            yield return request;

            // Get the reference to the loaded object
            GameObject obj = request.asset as GameObject;

            onResult(obj);
        }
    }
}
