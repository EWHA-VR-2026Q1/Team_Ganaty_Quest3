using UnityEngine;

public class ThemeManager : MonoBehaviour
{
    [Header("Target Objects")]
    public Renderer planeRenderer;
    public Transform roadParent;
    public Transform decoParent;

    [Header("Spring/Summer")]
    public Material ssPlaneMat;
    public Material ssRoadMat;
    public Material ssDecoMat;
    public Material ssSkybox;

    [Header("Fall")]
    public Material fallPlaneMat;
    public Material fallRoadMat;
    public Material fallDecoMat;
    public Material fallSkybox;

    [Header("Winter")]
    public Material winterPlaneMat;
    public Material winterRoadMat;
    public Material winterDecoMat;
    public Material winterSkybox;

    [Header("Time Setting")]
    public int monthsPerClick = 4;

    public void SetSpringSummerTheme()
    {
        CityData.totalMonths += monthsPerClick;
        if (planeRenderer != null) planeRenderer.material = ssPlaneMat;
        ChangeRoadMaterial(roadParent, ssRoadMat);
        ChangeDecoMaterials(decoParent, ssDecoMat);
        RenderSettings.skybox = ssSkybox;
    }

    public void SetFallTheme()
    {
        CityData.totalMonths += monthsPerClick;
        if (planeRenderer != null) planeRenderer.material = fallPlaneMat;
        ChangeRoadMaterial(roadParent, fallRoadMat);
        ChangeDecoMaterials(decoParent, fallDecoMat);
        RenderSettings.skybox = fallSkybox;
    }

    public void SetWinterTheme()
    {
        CityData.totalMonths += monthsPerClick;
        if (planeRenderer != null) planeRenderer.material = winterPlaneMat;
        ChangeRoadMaterial(roadParent, winterRoadMat);
        ChangeDecoMaterials(decoParent, winterDecoMat);
        RenderSettings.skybox = winterSkybox;
    }

    private void ChangeRoadMaterial(Transform parentObj, Material newMat)
    {
        if (parentObj == null) return;

        Renderer[] allRenderers = parentObj.GetComponentsInChildren<Renderer>();
        for (int i = 0; i < allRenderers.Length; i++)
        {
            allRenderers[i].material = newMat;
        }
    }

    private void ChangeDecoMaterials(Transform parentObj, Material newLeafMat)
    {
        if (parentObj == null) return;

        Renderer[] allRenderers = parentObj.GetComponentsInChildren<Renderer>();

        for (int i = 0; i < allRenderers.Length; i++)
        {
            Renderer rend = allRenderers[i];
            Material[] mats = rend.materials;

            for (int j = 0; j < mats.Length; j++)
            {
                if (mats[j].name.ToLower().Contains("bakery"))
                {
                    continue;
                }
                else
                {
                    mats[j] = newLeafMat;
                }
            }

            rend.materials = mats;
        }
    }
}