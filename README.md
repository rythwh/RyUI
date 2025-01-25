RyUI is a simple UI-manager which provides types and methods for UI _screens_ and _elements_. These are two specific types which will be explained further below.

**INSTALLATION**

Add to **Unity** by:

Install URL: `https://github.com/rythwh/RyUI.git?path=Packages/RyUI`

`Window` > `Package Manager` > `+` (top-left) > `Install package from git URL...` > Paste `https://github.com/rythwh/RyUI.git?path=Packages/RyUI` and click `Install`.

**HOW TO USE**

The UIManager controls opening and closing of the Screens.

Screens are composed of 3 scripts: a UIConfig, UIPresenter, and UIView. The Config links the Presenter and View together.
The UIView is a MonoBehaviour which can be added to a GameObject in the Unity Inspector to then add UGUI components to be accessed by the UIView.
Whichever GameObject the UIView is attached to needs to be a Prefab and an Addressable with the address of `UI/<UIConfigName>`. For example, if making a loading screen called UILoadingScreen, the addressable prefab with the UIView would have the address `UI/UILoadingScreen`.

Elements are composed of 2 scripts: an Element and an ElementComponent. It is essentially the Presenter and View, without a Config.
The ElementComponent is also a MonoBehaviour, like the UIView.
It also has similar Addressable requirements to the UIConfig above, however it is `UI/Element/<UIElementName>`.

**Opening a Screen**

Once you have a Screen setup, you can open it with an instance of the UIManager.
Call the method `uiManager.OpenViewAsync<UIConfigName>()` to open the config with that name.
You can also optionally add a Parameters script (which has an associated UIParameters script) to send parameters to the Presenter. You would also need to add the associated Parameters script to the UIConfig for that screen.

You can close the screen similarly with `uiManager.CloseView<UIConfigName>()`.

**Opening an Element**

You can create an Element by simply creating a new instance like `new UIElementName(Transform parent)`. In the definition of the UIElement, you can also add any parameters you want to the constructor, to be able to send those to the UIElement.

You can close the Element with `element.Close()`.
