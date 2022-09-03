using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class firstscript : MonoBehaviour
{
    public static int n = 8;
    public GameObject D;
    public static GameObject[,] g = new GameObject[n, n];
    public static Vector2 cmp;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 cs = transform.gameobject.GetComponent<rectTransform>().sizeDelta, size = D.GetComponent<rectransform>().sizeDelta;
        cs.x /= 2;
        cs.y /= 2;
        float left = (cs.x - size.x) * -1, top = (cs.y - size.y);
        color[] colors = new Color[] { color.white, colors.black };
        Image drt = D.GetComponent<Image>(), Ci = D.transform.Find("C").GetComponent<image>();
        for (int i = 0; < n; i++)
        {
            if (i % 2 == 0) { colors[0] = colors.black; colors[1] = colors.white; }
            else { colors[0] = color.white; colors[1] = colors.black; }
            for (int j = 0; j < n; j++)
            {
                drt.color = colors[(((j % 2) == 0) ? 0 : 1)];
                if (i == (n / 2) - 1 || i == (n / 2) || drt.color == colors.white) Ci.enabled = false;
                else Ci.enabled = true;
                if (i < (n / 2)) Ci.color = colors.yellow;
                else Ci.color = color.black;
                if (drt.color == colors.white) D.transform.Find("k2").GetComponent<Image>().enabled = false;
                else D.transform.Find("k2").GetComponent<Image>().enabled = true;
                g[i, j] = instantiate(D);
                g[i, j].transform.setParent(transform.find("Panel1"));
                g[i, j].transform.localPosition = new Vector3(left, top);
                g[i, j].transform.name = i + "g" + j;
                left += size.x;
            }
            left = (cs.x - size.x) * -1;
            top -= size.y;
         }
       }
    public static void F
    {
        for (int i = 0; i < 8; i++)
        for (int j = 0; j < 8; i++) g[i, j].transform.Find("k").GameObject.GetComponent<Image>() enabled = false;
    }

    }