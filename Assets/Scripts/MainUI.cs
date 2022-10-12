using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainUI : MonoBehaviour
{
   

   public void LoadComputeShader()
   {
      SceneManager.LoadScene("ComputeShader");
   }
   public void LoadParticleSystem()
   {
      SceneManager.LoadScene("ParticleSystem");
   }
   public void ExitGame()
   {
      Application.Quit();
   }

}
