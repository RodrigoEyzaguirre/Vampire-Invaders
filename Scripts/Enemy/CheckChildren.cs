using UnityEngine;

public class CheckChildren : MonoBehaviour
{
    public GameObject alienTop;
    public GameObject alienMid;
    public GameObject alienBot;
    public GameObject SuccessPanel;

    void Start()
    {
        SuccessPanel.SetActive(false);
    }

    void Update()
    {
        // Check if there are no children for each alien object
        bool noChildrenTop = IsNoChildren(alienTop);
        bool noChildrenMid = IsNoChildren(alienMid);
        bool noChildrenBot = IsNoChildren(alienBot);

        // Check if all aliens have no children
        if (noChildrenTop && noChildrenMid && noChildrenBot)
        {
            Debug.Log("No children left for all aliens!");
            // Add your additional logic or actions here
            SuccessPanel.SetActive(true);

        }
    }

    bool IsNoChildren(GameObject parent)
    {
        // Check if the parent has no children
        return parent.transform.childCount == 0;
    }
}