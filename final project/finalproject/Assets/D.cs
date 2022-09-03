using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class D : MonoBehaviour
{
    static string k, k2 = "";
    static image c;
    static color color = color.white;
    public GameObject p;

    public void Cclick(RectTransform t)
    {
        S.F();
        C = t.transform.Find("C").GetComponent<Image>();
        if (color == C.color)
        {
            string name = t.name;
            int i, j;
            i = convert.ToInt32((name.Split('&'))[0]);
            j = convert.ToInt32((name.Split('&'))[1]);
            int co = -1;
            if (C.color == color.yellow) co = 1;
            try
            {
                if (!S.g[i + co, j - 1].transform.Find("C").GetComponent<Image>().enabled = true;
                {
                    S.g[i + co, j - 1].transform.Find("k").GetComponent<Image>().enabled = true;
                }

            else if (S.g[i + co, j - 1].transform.Find("C").GetComponent<Image>().color != C.color && !S.g(i + (co * 2), j - 2].transform.Find("C").GetComponent<Image>().enabled)
                {
                    S.g[i + (co * 2), j - 2].transform.Find("k").GetComponent<Image>().enabled = true;
                    k2 = (i = co) + " " + (j + 1);
                }

            }

            catch { }
            try
            {
                if (!S.g[i + co, j + 1].transform.Find("C").GetComponent<Image>().enabled)
                {
                    S.g[i + co, j + 1].transform.Find("k").GetComponent<Image>().enabled = true;
                }
                else if (S.g[i + co, j + i].transform.Find("C").GetComponent<Image>().color != C.color && !S.g[i + (co * 2), j + 2].transform.Find("C").GetComponent<Image>().enabled)
                {
                    S.g[i + (co * 2), j + 2].transform.Find("k").GetComponent<Image>().enabled = true;
                    k2 = (i + co) + " " + (j + 1);
                }
            }

            catch { }
            k = i + " " + j;
        }
    
    }
    public text r, w;

    public void A2(char c)
    {
        if (c == 'w') s.cmp.x++;
        else s.cmp.y++;
        if(s.cmp.x >= 12)
        {
            P.GameObject.SetActive(true);
            p.transform.Find("w").GetComponent<Text>().text = "You Won Black !!!";
        }
        if (s.cmp.y >= 12)
        {
            P.GameObject.SetActive(true);
            p.transform.Find("w").GetComponent<Text>().text = "You Won Yellow !!!";
        }

    }
    public void Kclick (RecTransform t)
    {
        S.F();
        string name = t.name;
        int i, j;
        i = convert.ToInt32((name.Split('&'))[0]);
        j = convert.ToInt32((name.Split('&'))[1]);
        S.g[i, j].transform.Find("C").GetComponent<Image>().color = color;
        S.g[i, j].transform.Find("C").GetComponent<Image>().enabled = true;
        i = convert.ToInt32((k.Split(''))[0]);
        j = convert.ToInt32((k.Split(''))[1]);
        S.g[i, j].transform.Find("C").GetComponent<Image>().enabled = false;
        if (k2 != "" && ((convert.ToInt32((name.Split('&'))[1]) - 1) == convert.ToInt32((k2.Split((' '))[1]) || (convert.ToInt32((name.Split('&'))[1]) + 1) == convert.ToInt32((k2.Split(' '))[1]))))
        {
            i = convert.ToInt32((k2.Split(' '))[0]);
            j = convert.ToInt32((k2.Split(' '))[0]);
            S.g[i, j].transform.Find("C").GetComponent<Image>().enabled = false;
            else A2('r');
            r.text = S.cmp.x + "";
            w.text = S.cmp.y + "";

            k2 = "";
        }
        if (color == color.white) color = color.yellow;
        else color = color.white;
    }
}
