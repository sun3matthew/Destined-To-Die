using UnityEngine;
using System.Collections;

public class Window : MonoBehaviour, Clickable
{
    protected virtual void Start() => WindowManager.add(this);
    public virtual void clickedOn(bool type) => WindowManager.focus(this);
    public virtual void turnOff() => gameObject.SetActive(false);
}
