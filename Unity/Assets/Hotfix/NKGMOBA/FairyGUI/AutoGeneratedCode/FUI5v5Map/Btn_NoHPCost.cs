/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using ETModel;

namespace ETHotfix
{
    [ObjectSystem]
    public class Btn_NoHPCostAwakeSystem : AwakeSystem<Btn_NoHPCost, GObject>
    {
        public override void Awake(Btn_NoHPCost self, GObject go)
        {
            self.Awake(go);
        }
    }
        
    public sealed class Btn_NoHPCost : FUI
    {	
        public const string UIPackageName = "FUI5v5Map";
        public const string UIResName = "Btn_NoHPCost";
        
        /// <summary>
        /// {uiResName}的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
        public GButton self;
            
    public Controller button;
    public GImage n0;
    public GImage n1;
    public GImage n2;
    public GImage n3;
    public const string URL = "ui://9sdz56q4u6tf7t";

    private static GObject CreateGObject()
    {
        return UIPackage.CreateObject(UIPackageName, UIResName);
    }
    
    private static void CreateGObjectAsync(UIPackage.CreateObjectCallback result)
    {
        UIPackage.CreateObjectAsync(UIPackageName, UIResName, result);
    }
        
    public static Btn_NoHPCost CreateInstance()
    {			
        return ComponentFactory.Create<Btn_NoHPCost, GObject>(CreateGObject());
    }
        
    public static ETTask<Btn_NoHPCost> CreateInstanceAsync(Entity domain)
    {
        ETTaskCompletionSource<Btn_NoHPCost> tcs = new ETTaskCompletionSource<Btn_NoHPCost>();
        CreateGObjectAsync((go) =>
        {
            tcs.SetResult(ComponentFactory.Create<Btn_NoHPCost, GObject>(go));
        });
        return tcs.Task;
    }
        
    public static Btn_NoHPCost Create(GObject go)
    {
        return ComponentFactory.Create<Btn_NoHPCost, GObject>(go);
    }
        
    /// <summary>
    /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
    /// </summary>
    public static Btn_NoHPCost GetFormPool(GObject go)
    {
        var fui = go.Get<Btn_NoHPCost>();
        if(fui == null)
        {
            fui = Create(go);
        }
        fui.isFromFGUIPool = true;
        return fui;
    }
        
    public void Awake(GObject go)
    {
        if(go == null)
        {
            return;
        }
        
        GObject = go;	
        
        if (string.IsNullOrWhiteSpace(Name))
        {
            Name = Id.ToString();
        }
        
        self = (GButton)go;
        
        self.Add(this);
        
        var com = go.asCom;
            
        if(com != null)
        {	
            
    		button = com.GetControllerAt(0);
    		n0 = (GImage)com.GetChildAt(0);
    		n1 = (GImage)com.GetChildAt(1);
    		n2 = (GImage)com.GetChildAt(2);
    		n3 = (GImage)com.GetChildAt(3);
    	}
}
       public override void Dispose()
       {
            if(IsDisposed)
            {
                return;
            }
            
            base.Dispose();
            
            self.Remove();
            self = null;
            
			button = null;
			n0 = null;
			n1 = null;
			n2 = null;
			n3 = null;
		}
}
}