using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    /* Scene Manager Function that manages all scene transitions.
     * On any desirable interaction game will load desired level or menu.
     */
    public void SceneLoader(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
