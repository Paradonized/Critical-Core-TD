using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint missleLauncher;
    public TurretBlueprint laserBeamer;
    BuildManager buildManager;
    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectStandardTurret()
    {
        Debug.Log("Standard Turret Selected");
        BuildManager.instance.SelectTurretToBuild(standardTurret);
    }
    public void SelectMissleLauncher()
    {
        Debug.Log("Missle Launcher Selected");
        BuildManager.instance.SelectTurretToBuild(missleLauncher);
    }
    public void SelectLaserBeamer()
    {
        Debug.Log("Laser Beamer Selected");
        BuildManager.instance.SelectTurretToBuild(laserBeamer);
    }
    void Update()
    {
        /*if (Input.GetKeyDown("1"))
        {
            buildManager.SelectTurretToBuild(buildManager.standardTurretPrefab);
        }
        if (Input.GetKeyDown("2"))
        {
            BuildManager.instance.SelectTurretToBuild(buildManager.missleLauncherPrefab);
        }*/
    }
}
