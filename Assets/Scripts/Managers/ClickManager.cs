using NDRSims.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
namespace NDRSims
{

    public class ClickManager : MonoBehaviour
    {

        #region Singleton
        public static ClickManager instance;
        void Awake()
        {
            if (!instance) instance = this;
        }
        #endregion

        [SerializeField]
        List<GameObject> allObjects = new List<GameObject>();

        void Update()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (EventSystem.current.IsPointerOverGameObject())
                        return;

                    OnMouseClickDown();
                }

            }
           
        }

        private void OnMouseClickDown()
        {
            Vector3 clickPosition = -Vector3.zero;
            SpawnObject(clickPosition);
        }

        private void SpawnObject(Vector3 clickPosition)
        {
            GameObject createdObject = Instantiate(UIManager.instance.CurrentSelectedObjectType,
                                    clickPosition, Quaternion.identity);
            allObjects.Add(createdObject);
        }
    }
}