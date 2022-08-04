using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ShowWindow
{
    public static void Show(VisualElement element)
    {
        VisualElement label = new Label("Hello World! From C#");
        element.Add(label);
    }
}
