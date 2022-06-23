using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesiredObject : MonoBehaviour
{
    [SerializeField]
    private DesiredObject nextObject;

    [SerializeField] 
    private bool isLast;

    [SerializeField]
    private bool isFirst;

    [SerializeField]
    private StudyOfTheSubjectByTheDog currentObject;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SearchForANewObject()
    {
        if (isLast == false)
        {
            nextObject.enabled = true;
            currentObject.CurrentObject = nextObject;
            this.enabled = false;
        }
        else
        {
            this.enabled = false;
            currentObject.CurrentObject = null;
        }
    }

    public bool IsFirst()
    {
        return isFirst;
    }
}
