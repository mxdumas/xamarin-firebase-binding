using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Com.Firebase.Client.Collection
{
    public abstract partial class LLRBValueNode
    {
        ILLRBNode ILLRBNode.Copy(Java.Lang.Object p0, Java.Lang.Object p1, LLRBNodeColor p2, ILLRBNode p3, ILLRBNode p4)
        {
            return Copy(p0, p1, p2, p3, p4);
        }
    }
}