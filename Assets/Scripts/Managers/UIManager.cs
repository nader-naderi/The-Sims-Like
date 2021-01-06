using System.Collections;
using UnityEngine;

namespace NDRSims.UI
{
    public class UIManager : MonoBehaviour
    {

        #region Singleton
        public static UIManager instance;
        void Awake()
        {
            if (!instance) instance = this;
        }
        #endregion

        public GameObject CurrentSelectedObjectType { get; private set; }

        public void OnBtn_SelectObject(GameObject go)
        {
            CurrentSelectedObjectType = go;
        }

    }
}