using Unity.Mathematics;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
    }

    private void Update()
    {
        //Input.GetAxis("Horizontal");
        _playerTransform.Translate(new Vector2(Input.GetAxis("Horizontal") * Time.deltaTime * _speed, Input.GetAxis("Vertical") * Time.deltaTime * _speed));
        if(Input.GetKeyDown("space")){
            Debug.Log("space pressed");
            if(_numSeedsLeft > 0){
                PlantSeed();
                Debug.Log("seed planted");
            }
        }
    }

    public void PlantSeed ()
    {
        Instantiate(_plantPrefab, new Vector3(_playerTransform.position.x, _playerTransform.position.y, 0), new quaternion(0, 0, 0, 0));
        _numSeedsLeft -= 1;
        _numSeedsPlanted += 1;
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }
}
