using UnityEngine;
namespace AnchorGridUnity {
    public class AnchorGrid : MonoBehaviour {

        public int ColumnCount = 5;
    
        void OnValidate()
        {
            int rowCount = this.transform.childCount / ColumnCount;
            for (int i = 0; i < this.transform.childCount; i++) {
                RectTransform r = this.transform.GetChild(i).GetComponent<RectTransform>();
                r.anchorMin = new Vector2(((float)i) % ColumnCount / ColumnCount, (float)(i / ColumnCount) / rowCount);
                r.anchorMax = new Vector2((((float)i) % ColumnCount+1) / ColumnCount, (float)(i / ColumnCount+1) / rowCount);
            }
        }
    }
}
