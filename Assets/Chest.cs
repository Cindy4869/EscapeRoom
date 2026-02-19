using UnityEngine;

public class Chest : MonoBehaviour
{

    public Transform lid;
    public GameObject skull;
    public GameObject axe;

    private Vector3 closedPos;
    private Quaternion closedRot;

    public Vector3 lidOpenLocalOffset = new Vector3(0f, 0.25f, -0.25f);
    public Vector3 lidOpenLocalEuler = new Vector3(-60f, 0f, 0f);
    private bool opened = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void Awake()
    {
        if (lid != null)
        {
            closedPos = lid.localPosition;
            closedRot = lid.localRotation;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OpenChest()
    {
        if (opened) return;

        lid.localPosition = closedPos + lidOpenLocalOffset;
        lid.localRotation = Quaternion.Euler(lidOpenLocalEuler);
        skull.SetActive(true);
        axe.SetActive(true);

        opened = true;
    }
}
