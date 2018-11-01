using UnityEngine;
namespace AnchorGridUnity {
    public class AnchorGrid : MonoBehaviour {

        public int ColumnCount = 5;
    
        void OnValidate()
        {
            float enabledObjectCount = 0;
            for (int i = 0; i < this.transform.childCount; i++)
            {
                if (this.transform.GetChild(i).gameObject.GetActive())
                    enabledObjectCount++;
            }

            int rowCount = Mathf.CeilToInt(enabledObjectCount / ColumnCount);
            if (enabledObjectCount < ColumnCount)
                rowCount = 1;

            int posIndex = 0;

            for (int i = 0; i < this.transform.childCount; i++) {
                GameObject go = this.transform.GetChild(i).gameObject;

                if (go.GetActive()) {
                    RectTransform r = go.GetComponent<RectTransform>();                    
                    r.anchorMin = new Vector2(((float)posIndex) % ColumnCount / ColumnCount, (float)(rowCount - posIndex / ColumnCount - 1) / rowCount);
                    r.anchorMax = new Vector2((((float)posIndex) % ColumnCount + 1) / ColumnCount, (float)(rowCount - posIndex / ColumnCount) / rowCount);
                    posIndex++;
                }
            }
        }
    }
}
