using UnityEngine;

public class Data : MonoBehaviour
{
    #region variables

    [SerializeField] private StaticData staticData;
    [SerializeField] private DynamicData dynamicData;

    public StaticData StaticData => staticData;
    public DynamicData DynamicData => dynamicData;

    #endregion variables
    
    #region Singleton

    public static Data instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }
    }

    #endregion Singleton
    
    [ContextMenu("Rename Points")]
    public void Rename()
    {
        for (int i = 0; i < dynamicData.PointData.Points.Count; i++)
        {
            dynamicData.PointData.Points[i].name = i.ToString();
        }
    }
    
}
