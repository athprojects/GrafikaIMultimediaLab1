using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviourScript : MonoBehaviour {
    private int _count;
    private Rigidbody _playerObj;

    public float Speed;
    public Text PointCountText;
    public GameObject WinPanel;

    void Start()
    {
        _count = 0;
        _playerObj = GetComponent<Rigidbody>();
        UpdatePointCountUI();
    }

    // Update is called once per frame
    void Update()
    {
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");
        var movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        _playerObj.AddForce(movement * Speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUpType1"))
            IncreaseScoreAndHideCollider(other, 1);      
        else if (other.gameObject.CompareTag("PickUpType2"))
            IncreaseScoreAndHideCollider(other, 3);
    }

    private void ShowWinPanelIfNeeded()
    {
        if (_count >= 9)
            WinPanel.gameObject.SetActive(true);
    }

    private void IncreaseScoreAndHideCollider(Collider obj, int scoreIncrease)
    {
        obj.gameObject.SetActive(false);
        _count += scoreIncrease;
        UpdatePointCountUI();
        ShowWinPanelIfNeeded();
    }

    private void UpdatePointCountUI()
    {
        PointCountText.text = "Score: " + _count;
    }
}
