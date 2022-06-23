using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;
using static UnityEngine.PostProcessing.VignetteModel;

public class StudyOfTheSubjectByTheDog : MonoBehaviour
{
    [SerializeField]  
    private PostProcessingProfile profile;

    [SerializeField]
    private float distance;

    [SerializeField]
    private float distanceFactor;

    [SerializeField]
    private Settings settings;

    [SerializeField]
    private DesiredObject currentObject;


    private void Awake()
    {
        settings = Settings.defaultSettings;
        settings.color = Color.yellow;
    }

    void Update()
    {
        if(currentObject != null)
        {
            distance = Vector3.Distance(this.transform.position, currentObject.transform.position);
            settings.intensity = distanceFactor / distance;
            profile.vignette.settings = settings;
            if (Input.GetKeyDown(KeyCode.E) && distance < 1)
            {
                currentObject.SearchForANewObject();
            }
        }
        else
        {
            settings.intensity = 0;
            profile.vignette.settings = settings;
        }
        
        //if (Input.GetKeyDown(KeyCode.Mouse0))
        //{
        //    currentObject = nextObject;
        //}
    }

    public  DesiredObject CurrentObject
    {
        set
        {
            currentObject = value;
        }
    }
}
