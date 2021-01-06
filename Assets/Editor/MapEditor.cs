using UnityEditor;
using UnityEngine;

namespace NDRSims.TileMap
{
    [CustomEditor(typeof(MapGenerator))]
    public class MapEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            MapGenerator map = target as MapGenerator;
            map.GenerateMap();
        }
    }
}