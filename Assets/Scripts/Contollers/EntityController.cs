using System.Collections.Generic;
using UnityEngine;

public class EntityController : MonoBehaviour
{
    #region variables
    
    private List<GameObject> coins; //will be replaced on ObjectPool when it needed
    private List<GameObject> points;
    private List<GameObject> cubes;

    #endregion variables

    #region public functions

    public List<GameObject> GetCoins()
    {
        GetData();
        return coins;
    }
    
    #endregion public functions

    #region private functions

    // private void Start()
    // {
    //     GetData();
    // }

    public void SetCubesOnPoints()
    {
        GetData();

        int row = 3;
        var number = GetRandomNumber();
        var diff = row - number;
        for (int i = 0; i < points.Count; i++)
        {
            if (diff >0)
            {
                var newGameObject = Instantiate(cubes[GetRandomNumber() - 1], points[i].transform.position, Quaternion.identity);
                newGameObject.transform.parent = points[i].transform;
                diff--;
            }
            else
            {
                var newGameObject = Instantiate(cubes[2], points[i].transform.position, Quaternion.identity);
                newGameObject.transform.parent = points[i].transform;
                i = i + (row - number) + 1;
                number = GetRandomNumber();
                diff = row - number;
            }
        }
    }

    private int GetRandomNumber() => Random.Range(1, 3);

    private void GetData()
    {
        var data = Data.instance.DynamicData;
        
        coins = data.CoinData.Coins;
        points = data.PointData.Points;
        cubes = data.PointData.CubesOnPoints;
    }

    #endregion private functions
}
