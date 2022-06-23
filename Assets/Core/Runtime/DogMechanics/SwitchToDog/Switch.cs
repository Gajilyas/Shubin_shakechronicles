using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    [SerializeField] 
    private GameObject replacementCamera;

    [SerializeField]
    private GameObject replaceableCamera;

    [SerializeField]
    private bool isStudy;

    [SerializeField]
    private StudyOfTheSubjectByTheDog currentStudyObject;

    private Vector3 fwd;



    private void Start()
    {
         
    }
    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 100f, Color.red);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider.GetComponent<DesiredObject>() != null)
            {
                if(hit.collider.GetComponent<DesiredObject>().IsFirst() == true)
                {
                    if(Input.GetKeyDown(KeyCode.E))
                    {
                        isStudy = true;
                        currentStudyObject.CurrentObject = hit.collider.GetComponent<DesiredObject>();
                    }
                }
            }
        }
       
           
        
        if(Input.GetKeyDown(KeyCode.T) && isStudy == true)
        {
            Debug.Log("lol");
            replacementCamera.SetActive(true);
            // сюда ещё метод затемнения
            replaceableCamera.SetActive(false);
        }
    }

   
    
   
}
