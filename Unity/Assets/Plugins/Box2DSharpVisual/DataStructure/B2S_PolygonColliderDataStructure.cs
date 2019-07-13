//------------------------------------------------------------
// Author: 烟雨迷离半世殇
// Mail: 1778139321@qq.com
// Data: 2019年7月13日 21:31:25
//------------------------------------------------------------

using System.Collections.Generic;
using ETModel;
using Sirenix.OdinInspector;
using UnityEngine;

namespace DefaultNamespace
{
    public class B2S_PolygonColliderDataStructure:B2S_ColliderDataStructureBase
    {
        [LabelText("碰撞体所包含的顶点信息(顺时针)")]
        [DisableInEditorMode]
        public List<CostumVector2> points = new List<CostumVector2>();
        
        [HideInEditorMode]
        public int pointCount;
    }
}