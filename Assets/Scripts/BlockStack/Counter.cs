using UnityEngine;

namespace BlockStack
{
    public class Counter : MonoBehaviour
    {
        // Start is called before the first frame update
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Block") || SingletonBS.Instance.StackHeight == 0)
                SingletonBS.Instance.IncreaseStackHeight();
        }
    }
}