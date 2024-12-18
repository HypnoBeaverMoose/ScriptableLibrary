using UnityEngine;

namespace HBM.Scriptable
{
    [CreateAssetMenu(menuName = "HBM/Variables/Vector3")]
    public class Vector3Variable : Variable<Vector3>
    {
        public void Change(Vector3 by)
        {
            value += by;
        }
    }
}