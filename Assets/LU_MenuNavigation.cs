using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LU_MenuNavigation : MonoBehaviour
{
    [SerializeField] 
    GameObject _menuToActivate;
    void Start()
    {
        _menuToActivate = null;
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void GetMenuToActivate()
    {
        //if (_menuToActivate == null)
        //{
        //    _menuToActivate = _menuList[0];
        //}
        //else 
        //{

        //}
    }
    public void Get0( GameObject menu)
    {

    }

}