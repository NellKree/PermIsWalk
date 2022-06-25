using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnapScrolling : MonoBehaviour
{
    [Range (1,50)]
    [Header("Controlers")]
    public int panCount;
    [Range(0, 500)]
    public int panOffset;
    [Range(0f,20f)]
    public float snapSpeed;
    [Range(0.1f, 20f)]
    public float scaleOffset;
    [Range(1f, 20f)]
    public float Scalespeed;
    public bool ScaleChange;
    [Header("Other Objects")]
    [SerializeField]
    public GameObject[] Prefabs;
    public ScrollRect scrollRect;


    private GameObject[] instsPans;
    private Vector2[] panPos;
    private Vector2[] panScale;
   
    private RectTransform contentRect;
    private Vector2 contentVector;

    private int selectedPanID;
    public bool isScrolling;
   
    private void Start()
    {
        contentRect = GetComponent<RectTransform>();
        instsPans = new GameObject[panCount];
        panPos = new Vector2[panCount];
        panScale = new Vector2[panCount];
        for (int i =0;i< panCount; i++)
        {
            instsPans[i] = Instantiate(Prefabs[i], transform, false);
            if (i == 0) continue;
            instsPans[i].transform.localPosition = new Vector2(instsPans[i].transform.localPosition.x ,instsPans[i-1].transform.localPosition.y -
                Prefabs[i].GetComponent<RectTransform>().sizeDelta.y - panOffset);
            panPos[i] = -instsPans[i].transform.localPosition;
        }
    }

    private void FixedUpdate()
    {
        if (contentRect.anchoredPosition.y <= panPos[0].y && !isScrolling || contentRect.anchoredPosition.y >= panPos[panPos.Length-1].y && !isScrolling)
        {
            scrollRect.inertia = false;
        }
        float nearestPos = float.MaxValue;
        for (int i = 0; i < panCount; i++)
        {
            float distance = Mathf.Abs(contentRect.anchoredPosition.y - panPos[i].y);
            if (distance < nearestPos)
            {
                nearestPos = distance;
                selectedPanID = i;
            }
            float scale = 1;
            if (ScaleChange == true) scale = Mathf.Clamp(1 / (distance / panOffset) * scaleOffset, 0.5f, 1f);

                
            panScale[i].x = Mathf.SmoothStep(instsPans[i].transform.localScale.x, scale, 6 * Time.fixedDeltaTime);
            panScale[i].y = Mathf.SmoothStep(instsPans[i].transform.localScale.y, scale, 6 * Time.fixedDeltaTime);
            instsPans[i].transform.localScale = panScale[i];
        }
        float scrollVelocity = Mathf.Abs(scrollRect.velocity.y);
        if (scrollVelocity < 400 && !isScrolling) scrollRect.inertia = false;
        if (isScrolling || scrollVelocity > 400) return;
        contentVector.y = Mathf.SmoothStep(contentRect.anchoredPosition.y, panPos[selectedPanID].y, snapSpeed * Time.fixedDeltaTime);
        contentRect.anchoredPosition3D = contentVector;
    }

    public void Scrolling(bool scroll)
    {
        isScrolling = scroll;
        if (scroll) scrollRect.inertia = true;
    }


}
