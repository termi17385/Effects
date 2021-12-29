using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void FireWorks() => SceneManager.LoadScene("Fireworks");
    public void Smoke() => SceneManager.LoadScene("Smoke");
    public void FireEffect() => SceneManager.LoadScene("FireEffect");
    public void FireFlies() => SceneManager.LoadScene("FireFlies");
    public void MuzzleFlash() => SceneManager.LoadScene("MuzzleFlash");
    public void WaterSim() => SceneManager.LoadScene("WaterSim");
    public void ToMenu() => SceneManager.LoadScene("MainMenu");
}
